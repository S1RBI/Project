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
using dikom.Entity;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using dikom.Class;

namespace dikom
{
    public partial class Menu : Form
    {
        string cap;
        string mass;
        DialogResult result;
        public Menu()
        {
            InitializeComponent();
            if (Properties.Settings.Default.role == 1)
            {
                tabPageEmploye.Parent = null;
                tabPageGraph.Parent = null;
                Load_date();
            }
            if (Properties.Settings.Default.role == 2)
            {
                tabPageSklad.Parent = null;
                tabPageReceiptInvoice.Parent = null;
                tabPageShippingInvoice.Parent = null;
                tabPageGraph.Parent = null;
                Storekeeper();
            }
            if (Properties.Settings.Default.role == 3)
            {
                tabPageSklad.Parent = null;
                tabPageReceiptInvoice.Parent = null;
                tabPageShippingInvoice.Parent = null;
                tabPageEmploye.Parent = null;
            }
            O_Prog();
        }

        public void RefreshAll()
        {
            foreach (var entity in Context.DBContext.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public void Load_date()
        {
            RefreshAll();
            var db = Context.DBContext;
            db.UPDATE_Discount();
            db.UPDATE_Delivery_Contract();

            var Use = db.VIEWReception_Invoice.ToArray();
            var Use2 = db.VIEWShipping_Invoice.ToArray();
            var position = db.VIEWDelivery_Contract_P.ToArray();
            var position2 = db.VIEWDelivery_Contract_Z.ToArray();
            var positionVAT = db.VIEWVAT.ToArray();
            var positionStorekeeper = db.VIEWStorekeeper2.ToArray();
            var product = db.VIEWProduct.ToArray();
            var positionMeasurement = db.VIEWMeasurement.ToArray();
            var positionCell = db.VIEWProduct_Location_Cell.ToArray();
            var positionColor = db.VIEWColor_object.ToArray();
            var positionMaterials = db.VIEWMaterials.ToArray();
            var positiontype = db.VIEWProduct_type.ToArray();
            
            comboBoxP.DataSource = position;
            comboBoxP.ValueMember = "ID";
            comboBoxP.DisplayMember = "Наименование_организации";

            comboBoxZ.DataSource = position2;
            comboBoxZ.ValueMember = "ID";
            comboBoxZ.DisplayMember = "Наименование_организации";

            comboBoxVAT.DataSource = positionVAT;
            comboBoxVAT.ValueMember = "ID";
            comboBoxVAT.DisplayMember = "Наименование";

            comboBoxVAT2.DataSource = positionVAT;
            comboBoxVAT2.ValueMember = "ID";
            comboBoxVAT2.DisplayMember = "Наименование";

            comboBoxStorekeeper.DataSource = positionStorekeeper;
            comboBoxStorekeeper.ValueMember = "Логин";
            comboBoxStorekeeper.DisplayMember = "Принял_накладную";

            comboBoxStorekeeper2.DataSource = positionStorekeeper;
            comboBoxStorekeeper2.ValueMember = "Логин";
            comboBoxStorekeeper2.DisplayMember = "Принял_накладную";

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

            dataGridViewReception.DataSource = Use;
            dataGridViewShipment.DataSource = Use2;
            dataGridViewProduct.DataSource = product;

            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEdit2.Enabled = false;
            buttonDelete2.Enabled = false;
            buttonEdit3.Enabled = false;
            buttonDelete3.Enabled = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.role == 1)
            {
                comboBoxStorekeeper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxVAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxStorekeeper2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxVAT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxEdiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                dataGridViewReception.ReadOnly = true;
                dataGridViewShipment.ReadOnly = true;
                dataGridViewProduct.ReadOnly = true;

                dataGridViewReception.Columns["Принял_накладную"].Width = 200;
                dataGridViewShipment.Columns["Принял_накладную"].Width = 200;
                dataGridViewProduct.Columns["ед_из"].Width = 45;
                dataGridViewProduct.Columns["Наименование"].Width = 200;

                dataGridViewReception.Columns["Номер_накладной"].Visible = false;
                dataGridViewShipment.Columns["Номер_накладной"].Visible = false;
                dataGridViewProduct.Columns["ID"].Visible = false;
            }
            if (Properties.Settings.Default.role == 2)
            {
                comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                dataGridViewEmployee.ReadOnly = true;

                dataGridViewEmployee.Columns["Фото"].Visible = false;
            }
            if (Properties.Settings.Default.role == 3)
            {
                comboBoxGraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                comboBoxGraph.Items.AddRange(new string[] { "Гисторгамма", "Линейная", "Круговая" });

                int dataYear = DateTime.Now.Year;
                for (int i = dataYear; i >= 2019; i--)
                {
                    comboBoxYear.Items.Add(i);
                }
                checkedListBoxGraph.SelectedIndex = 0;
                comboBoxYear.SelectedIndex = 0;
                comboBoxGraph.SelectedIndex = 0;
            }
            timer1.Interval = 1000;
            timer1.Start();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassClose.GetIdleTime() >= 30000)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Add_R_I f2 = new Add_R_I(this);
            f2.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cap = "Удаление накладной приема №" + (int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value;
            mass = "Вы уверены что хотите удалить накладную?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.DeleteReception_Invoice((int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value,
                            (DateTime)dataGridViewReception.CurrentRow.Cells["Дата_накладной"].Value);
                db.SaveChanges();
                MessageBox.Show("Накладная №" + (int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value + " была удалена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_date();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxP.Text == "" || comboBoxVAT.Text == "" || comboBoxStorekeeper.Text == "")
            {
                MessageBox.Show("Заполните поля до конца", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cap = "Изменение накладной приема №" + (int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value;
                mass = "Вы уверены что хотите изменить накладную?";
                result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var db = Context.DBContext;

                    db.UpdateReception_Invoice((int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value, (int)comboBoxVAT.SelectedValue, (int)comboBoxP.SelectedValue,
                                comboBoxStorekeeper.SelectedValue.ToString(), (DateTime)dataGridViewReception.CurrentRow.Cells["Дата_накладной"].Value);

                    db.SaveChanges();
                    MessageBox.Show("Накладная №" + (int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value + " была изменена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_date();
                }
            }
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Add_S_I f2 = new Add_S_I(this);
            f2.ShowDialog();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxZ.SelectedIndex = comboBoxZ.FindString(dataGridViewShipment.CurrentRow.Cells["Наименование_организации"].Value.ToString());
            comboBoxVAT2.SelectedIndex = comboBoxVAT2.FindString(dataGridViewShipment.CurrentRow.Cells["НДС_на_товар"].Value.ToString());
            comboBoxStorekeeper2.SelectedIndex = comboBoxStorekeeper2.FindString(dataGridViewShipment.CurrentRow.Cells["Принял_накладную"].Value.ToString());
            buttonPrint2.Enabled = true;
            buttonEdit2.Enabled = true;
            buttonDelete2.Enabled = true;
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            cap = "Удаление накладной отправки №" + (int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value;
            mass = "Вы уверены что хотите удалить накладную?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.DeleteShipping_Invoice((int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value,
                        (DateTime)dataGridViewShipment.CurrentRow.Cells["Дата_накладной"].Value);
                db.SaveChanges();
                MessageBox.Show("Накладная №" + (int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value + " была удалена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_date();
            }
        }

        private void buttonEdit2_Click(object sender, EventArgs e)
        {
            if (comboBoxZ.Text == "" || comboBoxVAT2.Text == "" || comboBoxStorekeeper2.Text == "")
            {
                MessageBox.Show("Заполните поля до конца", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cap = "Изменение накладной отправки №" + (int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value;
                mass = "Вы уверены что хотите изменить накладную?";
                result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var db = Context.DBContext;

                    db.UpdateShipping_Invoice((int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value, (int)comboBoxVAT2.SelectedValue, (int)comboBoxZ.SelectedValue,
                                comboBoxStorekeeper2.SelectedValue.ToString(), (DateTime)dataGridViewShipment.CurrentRow.Cells["Дата_накладной"].Value);

                    db.SaveChanges();
                    MessageBox.Show("Накладная №" + (int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value + " была изменена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_date();
                }
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxName.Text = dataGridViewProduct.CurrentRow.Cells["Наименование"].Value.ToString();
            numericUpDownColvo.Text = dataGridViewProduct.CurrentRow.Cells["Количество"].Value.ToString();
            comboBoxMaterials.SelectedIndex = comboBoxMaterials.FindString(dataGridViewProduct.CurrentRow.Cells["Материал"].Value.ToString());
            comboBoxCell.SelectedIndex = comboBoxCell.FindString(dataGridViewProduct.CurrentRow.Cells["Секция_Ярус"].Value.ToString());
            comboBoxEdiz.SelectedIndex = comboBoxEdiz.FindString(dataGridViewProduct.CurrentRow.Cells["ед_из"].Value.ToString());
            comboBoxColor.SelectedIndex = comboBoxColor.FindString(dataGridViewProduct.CurrentRow.Cells["Цвет"].Value.ToString());
            comboBoxTypes.SelectedIndex = comboBoxTypes.FindString(dataGridViewProduct.CurrentRow.Cells["Тип"].Value.ToString());
            buttonEdit3.Enabled = true;
            buttonDelete3.Enabled = true;
        }

        private void buttonaAdd3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            AddProduct f2 = new AddProduct(this);
            f2.ShowDialog();
        }

        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            cap = "Удаление товара № " + dataGridViewProduct.CurrentRow.Cells["ID"].Value.ToString();
            mass = "Вы уверены что хотите удалить товар?";
            result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                var db = Context.DBContext;

                db.DeleteProduct(dataGridViewProduct.CurrentRow.Cells["ID"].Value.ToString());
                db.SaveChanges();
                MessageBox.Show("Товар № " + dataGridViewProduct.CurrentRow.Cells["ID"].Value.ToString() + " был удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_date();
            }
        }

        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.Text == "" || comboBoxCell.Text == "" || comboBoxColor.Text == "" ||
                comboBoxTypes.Text == "" || numericUpDownColvo.Text == "" || comboBoxEdiz.Text == "" || textBoxName.Text == "")
            {
                MessageBox.Show("Заполните поля до конца", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cap = "Изменение товара № " + dataGridViewProduct.CurrentRow.Cells["ID"].Value.ToString();
                mass = "Вы уверены что хотите изменить товар?";
                result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    var db = Context.DBContext;

                    db.UpdateProduct(dataGridViewProduct.CurrentRow.Cells["ID"].Value.ToString(), (int)comboBoxMaterials.SelectedValue, comboBoxColor.SelectedValue.ToString(),
                            (int)comboBoxEdiz.SelectedValue, (int)comboBoxTypes.SelectedValue, (int)comboBoxCell.SelectedValue, textBoxName.Text, (int)numericUpDownColvo.Value);

                    db.SaveChanges();
                    MessageBox.Show("Товар № " + dataGridViewProduct.CurrentRow.Cells["ID"].Value.ToString() + " был изменен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_date();
                }
            }
        }
        
        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.age = (DateTime)dataGridViewShipment.CurrentRow.Cells["Дата_накладной"].Value;
            Program.name = (int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value;

            timer1.Stop();
            VIEW_SP_S f2 = new VIEW_SP_S(this);
            f2.ShowDialog();
        }
    
        public void O_Prog()
        {
            this.labelNameOfProduce.Text = ClassProgram.AssemblyProduct;
            this.labelVersion.Text = String.Format("Версия {0}", ClassProgram.AssemblyVersion);
            this.labelProtection.Text = ClassProgram.AssemblyCopyright;
            this.labelCompanyName.Text = ClassProgram.AssemblyCompany;
            this.labelCompanyName.Text = ClassProgram.AssemblyDescription;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            var db = Context.DBContext;

            var varused = db.VIEWReception_Specification((int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value, (DateTime)dataGridViewReception.CurrentRow.Cells["Дата_накладной"].Value).ToArray();
            dataGridViewStorage.DataSource = varused;

            if (dataGridViewStorage.RowCount > 0)
            {
                WordDoc(dataGridViewReception.CurrentRow.Cells["Наименование_организации"].Value.ToString(),
                    dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value.ToString(),
                    Convert.ToString((DateTime)dataGridViewReception.CurrentRow.Cells["Дата_накладной"].Value),
                    dataGridViewReception.CurrentRow.Cells["Принял_накладную"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Без товара накладная не имеет смысла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void WordDoc(string name, string nums, string time, string stoker)
        {
            Word.Document doc = null;

            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            try
            {
                object missing = System.Reflection.Missing.Value;
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = $@"{Environment.CurrentDirectory}\\temples\\temple.docx";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();

                app.Visible = true;
                // Добавляем информацию
                // wBookmarks содержит все закладки
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                wBookmarks["name"].Range.Text = name.ToString();
                wBookmarks["nums"].Range.Text = nums.ToString();
                wBookmarks["time"].Range.Text = time.ToString();
                wBookmarks["stoker"].Range.Text = stoker.ToString();

                Word.Table newTable;
                Word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                newTable = doc.Tables.Add(wrdRng, 1, dataGridViewStorage.Columns.Count - 1, ref oMissing, ref oMissing);
                newTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                newTable.AllowAutoFit = true;
                foreach (DataGridViewCell cell in dataGridViewStorage.Rows[0].Cells)
                {
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = dataGridViewStorage.Columns[cell.ColumnIndex].Name;

                }
                newTable.Rows.Add();

                foreach (DataGridViewRow row in dataGridViewStorage.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex).Range.Text = cell.Value.ToString();
                    }
                    newTable.Rows.Add();
                }
                //varused.Length.ToString();
            }
            catch (Exception ex)
            {
                LogClass.WriteLine(ex.Message);
                MessageBox.Show("Закройте форму Word!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = Context.DBContext;

            var varused = db.VIEWShipping_Specification((int)dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value, (DateTime)dataGridViewShipment.CurrentRow.Cells["Дата_накладной"].Value).ToArray();
            dataGridViewStorage.DataSource = varused;

            if (dataGridViewStorage.RowCount > 0)
            {
                WordDoc(dataGridViewShipment.CurrentRow.Cells["Наименование_организации"].Value.ToString(),
                    dataGridViewShipment.CurrentRow.Cells["Номер_накладной"].Value.ToString(),
                    Convert.ToString((DateTime)dataGridViewShipment.CurrentRow.Cells["Дата_накладной"].Value),
                    dataGridViewShipment.CurrentRow.Cells["Принял_накладную"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Без товара накладная не имеет смысла", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBoxP.SelectedIndex = comboBoxP.FindString(dataGridViewReception.CurrentRow.Cells["Наименование_организации"].Value.ToString());
            comboBoxVAT.SelectedIndex = comboBoxVAT.FindString(dataGridViewReception.CurrentRow.Cells["НДС_на_товар"].Value.ToString());
            comboBoxStorekeeper.SelectedIndex = comboBoxStorekeeper.FindString(dataGridViewReception.CurrentRow.Cells["Принял_накладную"].Value.ToString());
            buttonPrint.Enabled = true;
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Program.age = (DateTime)dataGridViewReception.CurrentRow.Cells["Дата_накладной"].Value;
            Program.name = (int)dataGridViewReception.CurrentRow.Cells["Номер_накладной"].Value;

            timer1.Stop();
            VIEW_SP_R f2 = new VIEW_SP_R(this);
            f2.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                importData();
                Load_date();
            }
            catch (Exception ex)
            {
                LogClass.WriteLine(ex.Message);
                MessageBox.Show("Не верный тип файла!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void importData()
        {
            /* Диалог выбора файла для открытия */
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv"; //-- фильтр по выбираемым файлам

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Product> importedProduct = new List<Product>(); //-- список импортированных товаров
                string[] fileData = File.ReadAllLines(openFileDialog.FileName, Encoding.GetEncoding(1251)); //-- данные, считанные из файла

                for (int i = 1; i < fileData.Length; i++)
                {
                    string[] fields = fileData[i].Split(';'); //-- поля, указанные в строке файла

                    /* Создание класса товар и передача ему данных из полей */
                    Product product = new Product()
                    {
                        product_id = fields[0],
                        measurement_unit_id = Convert.ToInt32(fields[1]),
                        product_type_id = Convert.ToInt32(fields[2]),
                        cell_id = Convert.ToInt32(fields[3]),
                        materials_id = Convert.ToInt32(fields[4]),
                        color_id = fields[5],
                        name_of_product = fields[6],
                        quantity_of_goods = Convert.ToInt32(fields[7])
                    };

                    importedProduct.Add(product);
                    
                }
                var db = Context.DBContext;
                db.Product.AddRange(importedProduct);
                db.SaveChanges();
                MessageBox.Show("Импорт завершен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxOtcestvo.Text == ""
                || textBoxNames.Text == "" || textBoxSurname.Text == "" || (string)dataGridViewEmployee.CurrentRow.Cells["Логин"].Value == "")
            {
                MessageBox.Show("Заполните поля до конца", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cap = "Изменение сотрудника";
                mass = "Вы уверены что хотите изменить сотрудника?";
                result = MessageBox.Show(mass, cap, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    byte[] profilePic = (byte[])dataGridViewEmployee.CurrentRow.Cells["Фото"].Value;
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
                        MailAddress toAddres = new MailAddress(textBoxAddres.Text, textBoxSurname.Text + " " + textBoxNames.Text + " " + textBoxOtcestvo.Text);

                        try
                        {

                            db.UpdateStorekeeper((string)dataGridViewEmployee.CurrentRow.Cells["Логин"].Value, textBoxPassword.Text, textBoxSurname.Text,
                                    textBoxNames.Text, textBoxOtcestvo.Text, textBoxAddres.Text, profilePic, (int)comboBoxRole.SelectedValue);

                            db.SaveChanges();
                            MessageBox.Show("Данные о сотруднике " + dataGridViewEmployee.CurrentRow.Cells["Логин"].Value.ToString() + " были изменены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Storekeeper();
                            textBoxPassword.Clear();
                            textBoxSurname.Clear();
                            textBoxNames.Clear();
                            textBoxOtcestvo.Clear();
                            textBoxAddres.Clear();
                            buttonEdit.Enabled = false;
                            buttonDelete.Enabled = false;

                            if (pictureBoxImage.Image != null)
                            {
                                pictureBoxImage.Image.Dispose();
                                pictureBoxImage.Image = null;
                            }

                        }
                        catch (Exception ex)
                        {
                            LogClass.WriteLine(ex.Message);
                            MessageBox.Show("Электронная почта уже используется другим сотрудником", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogClass.WriteLine(ex.Message);
                        MessageBox.Show("Не верно введен адрес электронной почты", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            IsDeliteStorekeeper f2 = new IsDeliteStorekeeper(this);
            f2.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Reg f2 = new Add_Reg(this);
            f2.ShowDialog();
        }

        private void dataGridViewEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxPassword.Text = dataGridViewEmployee.CurrentRow.Cells["Пароль"].Value.ToString();
            textBoxSurname.Text = dataGridViewEmployee.CurrentRow.Cells["Фамилия"].Value.ToString();
            textBoxNames.Text = dataGridViewEmployee.CurrentRow.Cells["Имя"].Value.ToString();
            textBoxOtcestvo.Text = dataGridViewEmployee.CurrentRow.Cells["Отчество"].Value.ToString();
            textBoxAddres.Text = dataGridViewEmployee.CurrentRow.Cells["Адрес_электронной_почты"].Value.ToString();
            comboBoxRole.SelectedIndex = comboBoxRole.FindString(dataGridViewEmployee.CurrentRow.Cells["Роль"].Value.ToString());

            if (pictureBoxImage.Image != null)
            {
                pictureBoxImage.Image.Dispose();
                pictureBoxImage.Image = null;
            }

            if (dataGridViewEmployee.CurrentRow.Cells["Фото"].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])dataGridViewEmployee.CurrentRow.Cells["Фото"].Value);
                pictureBoxImage.Image = Image.FromStream(ms);
            }
            btnRemove.Enabled = true;
            btnEdit.Enabled = true;
        }

        public void Storekeeper()
        {
            RefreshAll();
            var db = Context.DBContext;

            var role = db.VIEWRoles.ToArray();

            var Use = db.VIEWStorekeeper.ToArray();

            comboBoxRole.DataSource = role;
            comboBoxRole.ValueMember = "ID";
            comboBoxRole.DisplayMember = "Наименование";

            dataGridViewEmployee.DataSource = Use;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
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

        private void buttonDeleteImages_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage.Image != null)
            {
                pictureBoxImage.Image.Dispose();
                pictureBoxImage.Image = null;
            }
        }

        private void backupDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DB_SAVE f2 = new DB_SAVE(this);
            f2.ShowDialog();
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportData f2 = new ExportData(this);
            f2.ShowDialog();
        }
        private void Diagramm(string graph, string check = "", string year = "")
        {
            chart1.Series.Clear();
            chart1.Series.Add(check);
            if (graph == "Гисторгамма")
            {
                chart1.Series[check].ChartType = SeriesChartType.Column;
                chart1.DataBind();
            }
            if (graph == "Линейная")
            {
                chart1.Series[check].ChartType = SeriesChartType.Line;
                chart1.DataBind();
            }
            if (graph == "Круговая")
            {
                chart1.Series[check].ChartType = SeriesChartType.Pie;
                chart1.DataBind();
            }
            chart1.Series[check].Points.Clear();
            var db = Context.DBContext;
            if (check == "Количество тавара на складе")
            {
                var res = from tbl in db.Product select new { tbl.name_of_product, tbl.quantity_of_goods };
                foreach (var r in res)
                {
                    chart1.Series[check].Points.AddXY(r.name_of_product, r.quantity_of_goods);
                }
            }
            else if(check == "Закупки")
            {
                var date = db.GraphAnalytics(Convert.ToInt32(year)).ToArray();
                foreach (var r in date)
                {
                    chart1.Series[check].Points.AddXY(r.Название_месяца, r.Сумма);
                }
            }
            else if (check == "Продажи")
            {
                var date = db.GraphAnalytics2(Convert.ToInt32(year)).ToArray();
                foreach (var r in date)
                {
                    chart1.Series[check].Points.AddXY(r.Название_месяца, r.Сумма);
                }
            }
        }

        private void comboBoxGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYear.Text != null)
            {
                Diagramm(comboBoxGraph.SelectedItem.ToString(), checkedListBoxGraph.SelectedItem.ToString(), comboBoxYear.Text);
            }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGraph.Text != null)
            {
                Diagramm(comboBoxGraph.Text, checkedListBoxGraph.SelectedItem.ToString(), comboBoxYear.SelectedItem.ToString());
            }
        }

        private void checkedListBoxGraph_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (comboBoxGraph.Text != null || comboBoxYear.Text != null)
            {
                for (int ix = 0; ix < checkedListBoxGraph.Items.Count; ++ix)
                    if (ix != e.Index) checkedListBoxGraph.SetItemChecked(ix, false);
                Diagramm(comboBoxGraph.SelectedItem.ToString(), checkedListBoxGraph.SelectedItem.ToString(), comboBoxYear.Text);
            }
        }
    }
}
