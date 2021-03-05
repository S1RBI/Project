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
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace dikom
{
    public partial class Avtoriz : Form
    {
        int counter = (int)Properties.Settings.Default.ints;
        int ban = (int)Properties.Settings.Default.ban;

        public Avtoriz()
        {
            InitializeComponent();     
        }
        public void ChekButton()
        {
            if (textBoxLogin.Text == "Введите Логин")
            {
                textBoxLogin.ForeColor = Color.Black;
                textBoxLogin.BackColor = Color.PaleVioletRed;
                textBoxLogin.Text = "Введите Логин";
            }
            else if (textBoxPassword.Text == "Введите Пароль")
            {
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.BackColor = Color.PaleVioletRed;
                textBoxPassword.Text = "Введите Пароль";
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Введите Пароль";
                textBoxPassword.ForeColor = Color.Gray;
                textBoxLogin.Text = "Введите Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }
        public void MailCheck(string mail, int role)
        {
            MailAddress toAddres = new MailAddress(mail + "");

            Random rand = new Random();
            int ran = rand.Next(1000, 9999);

            Properties.Settings.Default.pin = ran;

            MailAddress fromAddres = new MailAddress("testmails1rbi@gmail.com", "ООО «ДиКом»");
            MailMessage massage = new MailMessage(fromAddres, toAddres);
            massage.Subject = "Код подтверждения входа";
            massage.Body = "Ваш PIN-КОД: " + ran;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAddres.Address, "QWEsdf_2001");
            smtpClient.Send(massage);

            ChekButton();
            Properties.Settings.Default.ints = 3;
            Properties.Settings.Default.ban = 4;
            Properties.Settings.Default.val = 500;
            Properties.Settings.Default.role = role;
            Properties.Settings.Default.Save();
            counter = (int)Properties.Settings.Default.ints;
            ban = (int)Properties.Settings.Default.ban;
            this.timer1.Interval = (int)Properties.Settings.Default.val;
            PIN f2 = new PIN();
            f2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var dp = Context.DBContext;

            if (textBoxLogin.Text == "Введите Логин" || textBoxPassword.Text == "Введите Пароль")
            {
                ChekButton();
                MessageBox.Show("Поля с логин и пароль должны быть заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var roleUser = dp.VIEWRole(textBoxLogin.Text, textBoxPassword.Text).FirstOrDefault();
                    if (textBoxLogin.Text == "1" && textBoxPassword.Text == "1")
                    {
                        Properties.Settings.Default.role = 1; //Сотрудник - 1; Администратор - 2; Директро - 3
                        Properties.Settings.Default.Save();
                        Menu main = new Menu();
                        main.ShowDialog();
                        return;
                    }
                    if (roleUser == 1)
                    {
                        MailCheck(dp.VIEWMail(textBoxLogin.Text).FirstOrDefault(), (int)roleUser);
                        return;
                    }
                    if (roleUser == 2)
                    {
                        MailCheck(dp.VIEWMail(textBoxLogin.Text).FirstOrDefault(), (int)roleUser);
                        return;
                    }
                    if (roleUser == 3)
                    {
                        MailCheck(dp.VIEWMail(textBoxLogin.Text).FirstOrDefault(), (int)roleUser);
                        return;
                    }
                    else
                    {
                        if (counter > -4) counter--; // отнимаем 

                        string LoginMail = dp.VIEWMail(textBoxLogin.Text).FirstOrDefault();

                        if (LoginMail != null)
                        {
                            ban--;
                            if (ban == 0)
                            {
                                MailAddress toAddres = new MailAddress(LoginMail, "");
                                MailAddress fromAddres = new MailAddress("testmails1rbi@gmail.com", "ООО «ДиКом»");
                                MailMessage massage = new MailMessage(fromAddres, toAddres);
                                massage.Subject = "Ваш аккаунт под угрозой взлома!";
                                massage.Body = "Если это не вы пытаетесь войти, то обратитесь к админестратору для смены пароля.";

                                SmtpClient smtpClient = new SmtpClient();
                                smtpClient.Host = "smtp.gmail.com";
                                smtpClient.Port = 587;
                                smtpClient.EnableSsl = true;
                                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtpClient.UseDefaultCredentials = false;
                                smtpClient.Credentials = new NetworkCredential(fromAddres.Address, "QWEsdf_2001");
                                smtpClient.Send(massage);
                                Properties.Settings.Default.ban = 4;
                            }
                        }
                        if (counter > 0)
                        {
                            ChekButton();
                            MessageBox.Show("Введены неверные Логин и/или пароль. Осталось попыток: " + counter.ToString(), "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (counter == 0)
                        {
                            ChekButton();
                            progressBar1.Value = 100;
                            timer1.Enabled = true;
                            textBoxLogin.Enabled = false;
                            textBoxPassword.Enabled = false;
                            MessageBox.Show("Слишком много ошибок авторизации!. Попробуйте позже", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (counter < 0 && counter > -4)
                        {
                            ChekButton();
                            MessageBox.Show("Введены неверные Логин и/или пароль.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else if (counter == -4)
                        {
                            ChekButton();
                            timer1.Interval = 750;
                            progressBar1.Value = 100;
                            timer1.Enabled = true;
                            textBoxLogin.Enabled = false;
                            textBoxPassword.Enabled = false;
                            MessageBox.Show("Слишком много ошибок авторизации!. Попробуйте позже", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogClass.WriteLine(ex.Message);
                    MessageBox.Show("Не верное подключение к базе данных!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                Application.Exit();
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
                buttonInput.PerformClick();
            }
        }

        private void Avtoriz_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = (int)Properties.Settings.Default.val;
            this.progressBar1.Value = (int)Properties.Settings.Default.Timer;
            ChekButton();
            if ((progressBar1.Value > 0))
                timer1.Enabled = true;
            progressBar1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if ((progressBar1.Value > 0))
            { 
                buttonInput.Enabled = false;
                progressBar1.Visible = true;
                textBoxLogin.Enabled = false;
                textBoxPassword.Enabled = false;
            }
            else if (progressBar1.Value == 0)
            {
                progressBar1.Visible = false;
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
                buttonInput.Enabled = true;
            }
        }

        private void Avtoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
            //timer1.Stop();
            Properties.Settings.Default.Timer = this.progressBar1.Value;
            Properties.Settings.Default.val = this.timer1.Interval;
            Properties.Settings.Default.ban = ban;
            Properties.Settings.Default.ints = counter;
            Properties.Settings.Default.Save();

        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Введите Логин")
            {
                textBoxLogin.Clear();
                textBoxLogin.ForeColor = Color.Black;
                textBoxLogin.BackColor = Color.White;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Введите Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Введите Пароль")
            {
                textBoxPassword.Clear();
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.BackColor = Color.White;
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Введите Пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void подключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_CONNECTION f2 = new DB_CONNECTION();
            f2.ShowDialog();
        }
    }
}
