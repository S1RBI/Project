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
    public partial class PIN : Form
    {
        int invalidPin = 4;
        public PIN()
        {
            InitializeComponent();
        }

        private void PIN_Load(object sender, EventArgs e)
        {
            textBoxPIN.MaxLength = 3;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var dp = Context.DBContext;

            try
            {
                if (Properties.Settings.Default.pin == Convert.ToInt32(textBoxPIN.Text))
                {
                    this.Hide();
                    Menu main = new Menu();
                    main.ShowDialog();
                    this.Show();
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    --invalidPin;
                    if (invalidPin == 0)
                    {
                        MessageBox.Show("Слишком много не верных попыток входа!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        MessageBox.Show("Не верный PIN-КОД", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                LogClass.WriteLine(ex.Message);
                MessageBox.Show("Не верное подключение к базе данных!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
