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
using System.IO;
using System.Net;
using System.Net.Mail;
using dikom.Class;

namespace dikom
{
    public partial class Add_Reg : Form
    {
        Menu owner;
        public Add_Reg(Menu owner2)
        {
            InitializeComponent();
            owner = owner2;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Reg_FormClosing);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPassword.Text) || String.IsNullOrEmpty(textBoxOtcestvo.Text)
                || String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxSurname.Text) || String.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Не все поля были заполнены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBoxLogin.Text == textBoxPassword.Text)
                {
                    MessageBox.Show("Логин и пароль не могут быть одинаковыми", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (textBoxCapch.Text == ClassCaptcha.text)
                    {
                        byte[] profilePic = null;
                        if (pictureBoxImage.Tag != null)
                        {
                            string imageSource = pictureBoxImage.Tag.ToString();
                            FileStream fileStream = new FileStream(imageSource, FileMode.Open, FileAccess.Read);
                            BinaryReader binaryReader = new BinaryReader(fileStream);
                            profilePic = binaryReader.ReadBytes((int)fileStream.Length);
                        }
                        var db = Context.DBContext;
                        try
                        {
                            MailAddress toAddres = new MailAddress(textBoxAddres.Text, textBoxSurname.Text + " " + textBoxName.Text + " " + textBoxOtcestvo.Text);

                            try
                            {
                                Random rand = new Random();
                                int ran = rand.Next(1000, 9999);

                                db.AddStorekeeper(textBoxLogin.Text, textBoxPassword.Text,
                                           textBoxSurname.Text, textBoxName.Text, textBoxOtcestvo.Text, textBoxAddres.Text, profilePic, (int)comboBoxRole.SelectedValue);

                                MailAddress fromAddres = new MailAddress("testmails1rbi@gmail.com", "ООО «ДиКом»");
                                MailMessage massage = new MailMessage(fromAddres, toAddres);
                                massage.Subject = "Данные для входа сотрудника: " + textBoxSurname.Text + " " + textBoxName.Text + " " + textBoxOtcestvo.Text;
                                massage.Body = "Ваш Логин: " + textBoxLogin.Text + Environment.NewLine +
                                    "Ваш Пароль: " + textBoxPassword.Text + Environment.NewLine +
                                    "Ваш PIN-КОД: " + ran;

                                SmtpClient smtpClient = new SmtpClient();
                                smtpClient.Host = "smtp.gmail.com";
                                smtpClient.Port = 587;
                                smtpClient.EnableSsl = true;
                                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtpClient.UseDefaultCredentials = false;
                                smtpClient.Credentials = new NetworkCredential(fromAddres.Address, "QWEsdf_2001");
                                smtpClient.Send(massage);

                                db.SaveChanges();

                                MessageBox.Show("Запись добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DialogResult = DialogResult.Cancel;
                            }
                            catch(Exception ex)
                            {
                                LogClass.WriteLine(ex.Message);
                                MessageBox.Show("Такой Логин и/или Электронная почта уже есть в базе", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch(Exception ex)
                        {
                            LogClass.WriteLine(ex.Message);
                            MessageBox.Show("Не верно введен адрес электронной почты", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CAPTCHA была введена неверно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void Add_Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.Storekeeper();
            owner.timer1.Start();
            timer1.Stop();
        }

        private void Add_Reg_Load(object sender, EventArgs e)
        {
            var db = Context.DBContext;
            var role = db.VIEWRoles.ToArray();
            comboBoxRole.DataSource = role;
            comboBoxRole.ValueMember = "ID";
            comboBoxRole.DisplayMember = "Наименование";
            comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            pictureBoxCapch.Image = ClassCaptcha.CreateImage(pictureBoxCapch.Width, pictureBoxCapch.Height);

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxCapch.Image = ClassCaptcha.CreateImage(pictureBoxCapch.Width, pictureBoxCapch.Height);
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String sFileName = openFileDialog1.FileName;
                    pictureBoxImage.Image = Image.FromFile(sFileName);
                    pictureBoxImage.Tag = sFileName;//запоминаем путь к файлу картинки
                }
                catch(Exception ex)
                {
                    LogClass.WriteLine(ex.Message);
                    MessageBox.Show("Фото такого разрешения не может быть загружено.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage.Image != null)
            {
                pictureBoxImage.Image.Dispose();
                pictureBoxImage.Image = null;
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
