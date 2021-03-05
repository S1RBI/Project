using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikom
{
    public partial class ExportData : Form
    {
        Menu owner;
        public ExportData(Menu owner2)
        {
            InitializeComponent();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportData_FormClosing);
        }

        private void ExportData_Load(object sender, EventArgs e)
        {
            comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTable.Items.AddRange(new string[] { "Product", "Reception_Invoice", "Shipping_Invoice"});
            timer1.Interval = 1000;
            timer1.Start();

            comboBoxTable.Text = "Выберите таблицу";
            comboBoxTable.ForeColor = Color.Gray;
        }

        private void exportToCsv(string FilePath, string tableName)
        {
            //try
            //{
            //    var db = Context.DBContext;
            //    string[] formattedString = db.ProcExportData(tableName).ToArray();
            //    using (FileStream fileStream = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Write))
            //    {
            //        StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);

            //        foreach (string row in formattedString)
            //            streamWriter.WriteLine(row);

            //        streamWriter.Close();
            //    }
            //    MessageBox.Show("Экспорт таблицы " + comboBoxTable.Text + " прошел успешно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    LogClass.WriteLine(ex.Message);
            //    MessageBox.Show("Не верный путь к файлу", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv"; //-- фильтр по выбираемым файлам
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxLocation.Text = openFileDialog.FileName;
                buttonBackup.Enabled = true;
            }
        }
        private void buttonBackup_Click(object sender, EventArgs e)
        {
            if (comboBoxTable.Text == "")
            {
                MessageBox.Show("Выберите таблицу.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                exportToCsv(textBoxLocation.Text, comboBoxTable.Text);
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

        private void ExportData_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.timer1.Start();
            timer1.Stop();
        }
    }
}
