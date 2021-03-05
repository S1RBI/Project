using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace dikom
{
    
    public partial class Add_R_I : Form
    {
        Menu owner;
        public Add_R_I(Menu owner2)
        {
            InitializeComponent();
            Load_date();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_R_I_FormClosing);
        }

        private void Add_R_I_Load(object sender, EventArgs e)
        {
            comboBoxStorekeeper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            timer1.Interval = 1000;
            timer1.Start();
        }

        public void Load_date()
        {
            var db = Context.DBContext;

            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var position = db.VIEWDelivery_Contract_P.ToArray();
            var positionVAT = db.VIEWVAT.ToArray();
            var positionStorekeeper = db.VIEWStorekeeper2.ToArray();

            comboBoxP.DataSource = position;
            comboBoxP.ValueMember = "ID";
            comboBoxP.DisplayMember = "Наименование_организации";

            comboBoxVAT.DataSource = positionVAT;
            comboBoxVAT.ValueMember = "ID";
            comboBoxVAT.DisplayMember = "Наименование";

            comboBoxStorekeeper.DataSource = positionStorekeeper;
            comboBoxStorekeeper.ValueMember = "Логин";
            comboBoxStorekeeper.DisplayMember = "Принял_накладную";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxP.Text == "" || comboBoxVAT.Text == "" || comboBoxStorekeeper.Text == "")
            {
                MessageBox.Show("Не все поля были заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var db = Context.DBContext;

                db.AddReception_Invoice((int)comboBoxVAT.SelectedValue, (int)comboBoxP.SelectedValue,
                                    comboBoxStorekeeper.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Add_R_I_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.Load_date();
            owner.timer1.Start();
            owner.buttonEdit.Enabled = false;
            owner.buttonDelete.Enabled = false;
            timer1.Stop();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (ClassClose.GetIdleTime() >= 30000)
            {
                DialogResult = DialogResult.Cancel;
                owner.Close();
            }
        }
    }
}
