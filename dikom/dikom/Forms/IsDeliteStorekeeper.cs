using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikom
{
    public partial class IsDeliteStorekeeper : Form
    {
        Menu owner;
        string cap;
        string mass;
        DialogResult result;
        public IsDeliteStorekeeper(Menu owner2)
        {
            InitializeComponent();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IsDeliteStorekeeper_FormClosing);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDelite.Text) || !string.IsNullOrWhiteSpace(textBoxDelite.Text))
            {
                cap = "Удаление сотрудника!";
                mass = "Вы уверены что хотите удалить сотрудника?";
                result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var db = Context.DBContext;

                    try
                    {
                        db.DeleteStorekeeper(owner.dataGridViewEmployee.CurrentRow.Cells["Логин"].Value.ToString(), textBoxDelite.Text);
                        db.SaveChanges();
                        MessageBox.Show("Сотрудник был удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Cancel;
                    }
                    catch (Exception ex)
                    {
                        LogClass.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните поле!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void IsDeliteStorekeeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.btnRemove.Enabled = false;
            owner.btnEdit.Enabled = false;
            owner.Storekeeper();
            owner.timer1.Start();
            timer1.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void IsDeliteStorekeeper_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassClose.GetIdleTime() >= 30000)
            {
                DialogResult = DialogResult.Cancel;
                owner.Close();
            }
        }
    }
}
