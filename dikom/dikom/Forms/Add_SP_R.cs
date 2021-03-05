using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dikom.Entity;
using System.Runtime.InteropServices;

namespace dikom
{
    public partial class Add_SP_R : Form
    {
        VIEW_SP_R owner;
        int? id;
        public Add_SP_R(VIEW_SP_R owner2)
        {
            InitializeComponent();
            Load_date();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_SP_R_FormClosing);
        }

        public void Load_date()
        {
            var db = Context.DBContext;

            id = db.VIEWContractor_id(Program.name, Program.age).FirstOrDefault();

            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var Use = db.VIEWProduct2.ToArray();
            var positionMeasurement = db.VIEWMeasurement.ToArray();

            comboBoxEdiz.DataSource = positionMeasurement;
            comboBoxEdiz.ValueMember = "ID";
            comboBoxEdiz.DisplayMember = "Наименование";

            dataGridViewItemReceiptInvoice.DataSource = Use;
        }

        private void Add_SP_R_Load(object sender, EventArgs e)
        {
            comboBoxEdiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dataGridViewItemReceiptInvoice.ReadOnly = true;
            dataGridViewItemReceiptInvoice.Columns["ID"].Visible = false;
            dataGridViewItemReceiptInvoice.Columns["ед_из"].Visible = false;
            dataGridViewItemReceiptInvoice.Columns["Наименование"].Width = 160;
            dataGridViewItemReceiptInvoice.Columns["Материал"].Width = 70;
            dataGridViewItemReceiptInvoice.Columns["Тип"].Width = 75;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var db = Context.DBContext;

            textBoxId.Text = dataGridViewItemReceiptInvoice.CurrentRow.Cells["ID"].Value.ToString();
            comboBoxEdiz.SelectedIndex = comboBoxEdiz.FindString(dataGridViewItemReceiptInvoice.CurrentRow.Cells["ед_из"].Value.ToString());

            var data = db.CostPrice_Reception(id, textBoxId.Text).FirstOrDefault();
            if (data == null) numericUpDownPrice.Value = 0;
            else numericUpDownPrice.Value = Convert.ToInt32(data);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || numericUpDownPrice.Text == "0")
            {
                MessageBox.Show("Не все поля были заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var db = Context.DBContext;
                    db.AddReception_Specification(textBoxId.Text, Program.name, Program.age, (int)numericUpDownColvo.Value,
                                    numericUpDownPrice.Value, id);
                    db.SaveChanges();
                    MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Cancel;


                }
                catch(Exception ex)
                {
                    LogClass.WriteLine(ex.Message);
                    MessageBox.Show("Такой товар уже присутствует в накладной", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Add_SP_R_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.Load_date();
            owner.buttonEdit.Enabled = false;
            owner.buttonDelete.Enabled = false;
            owner.timer1.Start();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassClose.GetIdleTime() >= 30000)
            {
                DialogResult = DialogResult.Cancel;
                owner.end();
            }
        }
    }
}
