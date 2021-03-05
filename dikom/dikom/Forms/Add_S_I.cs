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

namespace dikom
{
    public partial class Add_S_I : Form
    {
        Menu owner;
        public Add_S_I(Menu owner2)
        {
            InitializeComponent();
            Load_date();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_S_I_FormClosing);
        }

        public void Load_date()
        {
            var db = Context.DBContext;

            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var position = db.VIEWDelivery_Contract_Z.ToArray();
            var positionVAT = db.VIEWVAT.ToArray();
            var positionStorekeeper = db.VIEWStorekeeper2.ToArray();

            comboBoxZ.DataSource = position;
            comboBoxZ.ValueMember = "ID";
            comboBoxZ.DisplayMember = "Наименование_организации";

            comboBoxVAT.DataSource = positionVAT;
            comboBoxVAT.ValueMember = "ID";
            comboBoxVAT.DisplayMember = "Наименование";

            comboBoxStorekeeper.DataSource = positionStorekeeper;
            comboBoxStorekeeper.ValueMember = "Логин";
            comboBoxStorekeeper.DisplayMember = "Принял_накладную";
        }

        private void Add_S_I_Load(object sender, EventArgs e)
        {
            comboBoxStorekeeper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Add_S_I_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.Load_date();
            owner.timer1.Start();
            owner.buttonEdit2.Enabled = false;
            owner.buttonDelete2.Enabled = false;
            timer1.Stop();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxZ.Text == "" || comboBoxVAT.Text == "" || comboBoxStorekeeper.Text == "")
            {
                MessageBox.Show("Не все поля были заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var db = Context.DBContext;

                db.AddShipping_Invoice((int)comboBoxVAT.SelectedValue, (int)comboBoxZ.SelectedValue,
                                comboBoxStorekeeper.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Cancel;
            }
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
