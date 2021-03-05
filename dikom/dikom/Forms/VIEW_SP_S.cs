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
    public partial class VIEW_SP_S : Form
    {
        Menu owner;
        string cap;
        string mass;
        DialogResult result;
        public VIEW_SP_S(Menu owner2)
        {
            InitializeComponent();
            Load_date();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIEW_SP_S_FormClosing);
        }

        private void VIEW_SP_S_Load(object sender, EventArgs e)
        {
            comboBoxEdiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dataGridViewShippingItem.ReadOnly = true;
            dataGridViewShippingItem.Columns["IDP"].Visible = false;
            dataGridViewShippingItem.Columns["ID"].Visible = false;
            dataGridViewShippingItem.Columns["ед_из"].Width = 45;
            dataGridViewShippingItem.Columns["Наименование"].Width = 170;
            dataGridViewShippingItem.Columns["Сумма"].Width = 50;
            dataGridViewShippingItem.Columns["Скидка"].Width = 50;
            timer1.Interval = 1000;
            timer1.Start();
        }

        public void Load_date()
        {
            var db = Context.DBContext;

            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var varused = db.VIEWShipping_Specification(Program.name, Program.age).ToArray();
            dataGridViewShippingItem.DataSource = varused;

            var positionMeasurement = db.VIEWMeasurement.ToArray();

            comboBoxEdiz.DataSource = positionMeasurement;
            comboBoxEdiz.ValueMember = "ID";
            comboBoxEdiz.DisplayMember = "Наименование";
        }

        private void VIEW_SP_S_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.timer1.Start();
            owner.Load_date();
            timer1.Stop();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add_SP_S f2 = new Add_SP_S(this);
            f2.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cap = "Удаление товара № " + dataGridViewShippingItem.CurrentRow.Cells["IDP"].Value.ToString() + " из накладной отправки";
            mass = "Вы уверены что хотите удалить товар из накладной?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.DeleteShipping_Specification((int)dataGridViewShippingItem.CurrentRow.Cells["ID"].Value, dataGridViewShippingItem.CurrentRow.Cells["IDP"].Value.ToString(), Program.name, Program.age);
                db.SaveChanges();
                MessageBox.Show("Товар № " + dataGridViewShippingItem.CurrentRow.Cells["IDP"].Value.ToString() + " был удален из накладной", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_date();
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            numericUpDownColvo.Text = dataGridViewShippingItem.CurrentRow.Cells["Количество"].Value.ToString();
            comboBoxEdiz.SelectedIndex = comboBoxEdiz.FindString(dataGridViewShippingItem.CurrentRow.Cells["ед_из"].Value.ToString());
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            cap = "Изменение количества товара № " + dataGridViewShippingItem.CurrentRow.Cells["IDP"].Value.ToString();
            mass = "Вы уверены что хотите изменить товар в накладной?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.UpdateShipping_Specification(dataGridViewShippingItem.CurrentRow.Cells["IDP"].Value.ToString(), Program.name, Program.age, (int)numericUpDownColvo.Value);


                db.SaveChanges();
                MessageBox.Show("Количество товар № " + dataGridViewShippingItem.CurrentRow.Cells["IDP"].Value.ToString() + " было изменено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_date();
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassClose.GetIdleTime() >= 30000)
            {
                end();
            }
        }

        public void end()
        {
            DialogResult = DialogResult.Cancel;
            owner.Close();
        }
    }
}
