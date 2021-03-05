namespace dikom
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.labelCell = new System.Windows.Forms.Label();
            this.comboBoxCell = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelMaterials = new System.Windows.Forms.Label();
            this.labelTypes = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownColvo = new System.Windows.Forms.NumericUpDown();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.labelColvo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxEdiz = new System.Windows.Forms.ComboBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labeltextBoxCod = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelCell.Location = new System.Drawing.Point(23, 79);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(101, 19);
            this.labelCell.TabIndex = 106;
            this.labelCell.Text = "Секция/Ярус";
            // 
            // comboBoxCell
            // 
            this.comboBoxCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxCell.FormattingEnabled = true;
            this.comboBoxCell.Location = new System.Drawing.Point(130, 76);
            this.comboBoxCell.Name = "comboBoxCell";
            this.comboBoxCell.Size = new System.Drawing.Size(135, 27);
            this.comboBoxCell.TabIndex = 105;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelColor.Location = new System.Drawing.Point(80, 113);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(44, 19);
            this.labelColor.TabIndex = 104;
            this.labelColor.Text = "Цвет";
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelMaterials.Location = new System.Drawing.Point(44, 46);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(80, 19);
            this.labelMaterials.TabIndex = 103;
            this.labelMaterials.Text = "Материал";
            // 
            // labelTypes
            // 
            this.labelTypes.AutoSize = true;
            this.labelTypes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelTypes.Location = new System.Drawing.Point(87, 147);
            this.labelTypes.Name = "labelTypes";
            this.labelTypes.Size = new System.Drawing.Size(37, 19);
            this.labelTypes.TabIndex = 102;
            this.labelTypes.Text = "Тип";
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxName.Location = new System.Drawing.Point(130, 210);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(135, 79);
            this.textBoxName.TabIndex = 101;
            // 
            // numericUpDownColvo
            // 
            this.numericUpDownColvo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDownColvo.Location = new System.Drawing.Point(130, 177);
            this.numericUpDownColvo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownColvo.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownColvo.Name = "numericUpDownColvo";
            this.numericUpDownColvo.Size = new System.Drawing.Size(87, 27);
            this.numericUpDownColvo.TabIndex = 100;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(130, 110);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(135, 27);
            this.comboBoxColor.TabIndex = 99;
            // 
            // comboBoxMaterials
            // 
            this.comboBoxMaterials.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxMaterials.FormattingEnabled = true;
            this.comboBoxMaterials.Location = new System.Drawing.Point(130, 43);
            this.comboBoxMaterials.Name = "comboBoxMaterials";
            this.comboBoxMaterials.Size = new System.Drawing.Size(135, 27);
            this.comboBoxMaterials.TabIndex = 98;
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(130, 144);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(135, 27);
            this.comboBoxTypes.TabIndex = 97;
            // 
            // labelColvo
            // 
            this.labelColvo.AutoSize = true;
            this.labelColvo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelColvo.Location = new System.Drawing.Point(29, 179);
            this.labelColvo.Name = "labelColvo";
            this.labelColvo.Size = new System.Drawing.Size(95, 19);
            this.labelColvo.TabIndex = 96;
            this.labelColvo.Text = "Количество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelName.Location = new System.Drawing.Point(9, 213);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 19);
            this.labelName.TabIndex = 95;
            this.labelName.Text = "Наименование";
            // 
            // comboBoxEdiz
            // 
            this.comboBoxEdiz.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxEdiz.FormattingEnabled = true;
            this.comboBoxEdiz.Location = new System.Drawing.Point(223, 177);
            this.comboBoxEdiz.Name = "comboBoxEdiz";
            this.comboBoxEdiz.Size = new System.Drawing.Size(42, 27);
            this.comboBoxEdiz.TabIndex = 94;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxCod.Location = new System.Drawing.Point(130, 10);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(135, 27);
            this.textBoxCod.TabIndex = 107;
            // 
            // labeltextBoxCod
            // 
            this.labeltextBoxCod.AutoSize = true;
            this.labeltextBoxCod.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labeltextBoxCod.Location = new System.Drawing.Point(32, 13);
            this.labeltextBoxCod.Name = "labeltextBoxCod";
            this.labeltextBoxCod.Size = new System.Drawing.Size(92, 19);
            this.labeltextBoxCod.TabIndex = 108;
            this.labeltextBoxCod.Text = "Код товара";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonBack.Location = new System.Drawing.Point(29, 303);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 42);
            this.buttonBack.TabIndex = 110;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonSave.Location = new System.Drawing.Point(145, 303);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 42);
            this.buttonSave.TabIndex = 109;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(283, 357);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labeltextBoxCod);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelCell);
            this.Controls.Add(this.comboBoxCell);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelMaterials);
            this.Controls.Add(this.labelTypes);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownColvo);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxMaterials);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.labelColvo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxEdiz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.ComboBox comboBoxCell;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.Label labelTypes;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownColvo;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxMaterials;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Label labelColvo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxEdiz;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labeltextBoxCod;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Timer timer1;
    }
}