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
using System.Runtime.Remoting.Contexts;

namespace dikom
{
    public partial class DB_CONNECTION : Form
    {
        public DB_CONNECTION()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxServer.Text) || String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Не все поля были заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string dataSource = "data source=" + textBoxServer.Text + ";";
                    string initialCatalog = "initial catalog=" + textBoxName.Text + ";";
                    string userId = null;
                    string password = null;

                    if (!String.IsNullOrEmpty(textBoxLogin.Text))
                        userId = "User ID=" + textBoxLogin.Text + ";";

                    if (!String.IsNullOrEmpty(textBoxPassword.Text))
                        password = "Password" + textBoxPassword + ";";

                    string connectionString = dataSource + initialCatalog +
                        "integrated security=True;MultipleActiveResultSets=True;" + userId + password;

                    var db = Context.DBContext;
                    db.Database.Connection.ConnectionString = connectionString;

                    MessageBox.Show("Подключение выполненно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Cancel;

                }
                catch(Exception ex)
                {
                    LogClass.WriteLine(ex.Message);
                    MessageBox.Show("Не верные дынные подключения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DB_CONNECTION_Load(object sender, EventArgs e)
        {

        }
    }
}
