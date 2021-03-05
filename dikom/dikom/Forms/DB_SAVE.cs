using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dikom.Entity;

namespace dikom
{
    public partial class DB_SAVE : Form
    {
        Menu owner;
        public DB_SAVE(Menu owner2)
        {
            InitializeComponent();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DB_SAVE_FormClosing);
        }
        private void DB_SAVE_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxLocation.Text = dlg.SelectedPath;
                buttonBackup.Enabled = true;
            }
        }
        private void buttonBackup_Click(object sender, EventArgs e)
        {
            var db = Context.DBContext;

            string dbname = db.Database.Connection.Database;
            try
            {

                if (textBoxLocation.Text == string.Empty)
                {
                    MessageBox.Show("Выберите расположение файла с резервной копией", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sqlCommand = @"BACKUP DATABASE [Sklad_dikom] TO  DISK = '" + textBoxLocation.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'MyAir-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, "Sklad_dikom"));
                    MessageBox.Show("База данных была успешно сохранена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                LogClass.WriteLine(ex.Message);
                MessageBox.Show("Не является допустимым целевым файлом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DB_SAVE_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.timer1.Start();
            timer1.Stop();
        }
    }
}
