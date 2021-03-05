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
    public partial class AddProduct : Form
    {
        Menu owner;
        public AddProduct(Menu owner2)
        {
            InitializeComponent();
            Load_date();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
        }

        public void Load_date()
        {
            var db = Context.DBContext;

            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var positionMeasurement = db.VIEWMeasurement.ToArray();
            var positionCell = db.VIEWProduct_Location_Cell.ToArray();
            var positionColor = db.VIEWColor_object.ToArray();
            var positionMaterials = db.VIEWMaterials.ToArray();
            var positiontype = db.VIEWProduct_type.ToArray();

            comboBoxEdiz.DataSource = positionMeasurement;
            comboBoxEdiz.ValueMember = "ID";
            comboBoxEdiz.DisplayMember = "Наименование";

            comboBoxCell.DataSource = positionCell;
            comboBoxCell.ValueMember = "ID";
            comboBoxCell.DisplayMember = "Секция_Ярус";

            comboBoxColor.DataSource = positionColor;
            comboBoxColor.ValueMember = "ID";
            comboBoxColor.DisplayMember = "Наименование";

            comboBoxMaterials.DataSource = positionMaterials;
            comboBoxMaterials.ValueMember = "ID";
            comboBoxMaterials.DisplayMember = "Наименование";

            comboBoxTypes.DataSource = positiontype;
            comboBoxTypes.ValueMember = "ID";
            comboBoxTypes.DisplayMember = "Наименование";
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            comboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEdiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.Load_date();
            owner.timer1.Start();
            owner.buttonEdit3.Enabled = false;
            owner.buttonDelete3.Enabled = false;
            timer1.Stop();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCod.Text == "" || comboBoxMaterials.Text == "" || comboBoxCell.Text == "" || comboBoxColor.Text == "" ||
                comboBoxTypes.Text == "" || numericUpDownColvo.Text == "" || comboBoxEdiz.Text == "" || textBoxName.Text == "")
            {
                MessageBox.Show("Не все поля были заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var db = Context.DBContext;

                    db.AddProduct(textBoxCod.Text, (int)comboBoxEdiz.SelectedValue, (int)comboBoxTypes.SelectedValue, (int)comboBoxCell.SelectedValue,
                                    (int)comboBoxMaterials.SelectedValue, comboBoxColor.SelectedValue.ToString(), textBoxName.Text, (int)numericUpDownColvo.Value);
                    db.SaveChanges();
                    MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Cancel;

                }
                catch
                {
                    LogClass.WriteLine("Ошибка в строке 94 AddProduct: Такая запись уже есть в базе данных.");
                    MessageBox.Show("Такой товар уже присутствует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
