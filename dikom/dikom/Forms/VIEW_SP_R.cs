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
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace dikom
{
    public partial class VIEW_SP_R : Form
    {
        Menu owner;

        string cap;
        string mass;
        DialogResult result;
        public VIEW_SP_R(Menu owner2)
        {
            InitializeComponent();
            Load_date();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_SP_R_FormClosing);
        }

        private void Add_SP_R_Load(object sender, EventArgs e)
        {
            comboBoxEdiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dataGridViewProductAcceptance.ReadOnly = true;
            dataGridViewProductAcceptance.Columns["IDP"].Visible = false;
            dataGridViewProductAcceptance.Columns["ID"].Visible = false;
            dataGridViewProductAcceptance.Columns["ед_из"].Width = 45;
            dataGridViewProductAcceptance.Columns["Наименование"].Width = 170;
            dataGridViewProductAcceptance.Columns["Сумма"].Width = 50;
            timer1.Interval = 1000;
            timer1.Start();
        }

        public void Load_date()
        {
            var db = Context.DBContext;

            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var varused = db.VIEWReception_Specification(Program.name, Program.age).ToArray();
            dataGridViewProductAcceptance.DataSource = varused;

            var positionMeasurement = db.VIEWMeasurement.ToArray();

            comboBoxEdiz.DataSource = positionMeasurement;
            comboBoxEdiz.ValueMember = "ID";
            comboBoxEdiz.DisplayMember = "Наименование";
        }

        private void Add_SP_R_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.timer1.Start();
            owner.Load_date();
            timer1.Stop();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add_SP_R f2 = new Add_SP_R(this);
            f2.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cap = "Удаление товара № " + dataGridViewProductAcceptance.CurrentRow.Cells["IDP"].Value.ToString() + " из накладной приема";
            mass = "Вы уверены что хотите удалить товар из накладной?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.DeleteReception_Specification((int)dataGridViewProductAcceptance.CurrentRow.Cells["ID"].Value, dataGridViewProductAcceptance.CurrentRow.Cells["IDP"].Value.ToString(), Program.name, Program.age);
                db.SaveChanges();
                MessageBox.Show("Товар № " + dataGridViewProductAcceptance.CurrentRow.Cells["IDP"].Value.ToString() + " был удален из накладной", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            numericUpDownColvo.Text = dataGridViewProductAcceptance.CurrentRow.Cells["Количество"].Value.ToString();
            comboBoxEdiz.SelectedIndex = comboBoxEdiz.FindString(dataGridViewProductAcceptance.CurrentRow.Cells["ед_из"].Value.ToString());
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            cap = "Изменение количества товара № " + dataGridViewProductAcceptance.CurrentRow.Cells["IDP"].Value.ToString();
            mass = "Вы уверены что хотите изменить товар в накладной?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.UpdateReception_Specification(dataGridViewProductAcceptance.CurrentRow.Cells["IDP"].Value.ToString(), Program.name, Program.age, (int)numericUpDownColvo.Value);


                db.SaveChanges();
                MessageBox.Show("Количество товар № " + dataGridViewProductAcceptance.CurrentRow.Cells["IDP"].Value.ToString() + " было изменено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
