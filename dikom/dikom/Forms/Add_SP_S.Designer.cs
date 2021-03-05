namespace dikom
{
    partial class Add_SP_S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_SP_S));
            this.labelrub = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownColvo = new System.Windows.Forms.NumericUpDown();
            this.labelColvo = new System.Windows.Forms.Label();
            this.comboBoxEdiz = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewItemShippingInvoice = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemShippingInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelrub
            // 
            this.labelrub.AutoSize = true;
            this.labelrub.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelrub.Location = new System.Drawing.Point(225, 284);
            this.labelrub.Name = "labelrub";
            this.labelrub.Size = new System.Drawing.Size(40, 19);
            this.labelrub.TabIndex = 130;
            this.labelrub.Text = "руб.";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDownPrice.Location = new System.Drawing.Point(121, 276);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(98, 27);
            this.numericUpDownPrice.TabIndex = 129;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPrice.Location = new System.Drawing.Point(70, 278);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 19);
            this.labelPrice.TabIndex = 128;
            this.labelPrice.Text = "Цена";
            // 
            // numericUpDownColvo
            // 
            this.numericUpDownColvo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDownColvo.Location = new System.Drawing.Point(121, 243);
            this.numericUpDownColvo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownColvo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColvo.Name = "numericUpDownColvo";
            this.numericUpDownColvo.Size = new System.Drawing.Size(98, 27);
            this.numericUpDownColvo.TabIndex = 127;
            this.numericUpDownColvo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelColvo
            // 
            this.labelColvo.AutoSize = true;
            this.labelColvo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelColvo.Location = new System.Drawing.Point(20, 246);
            this.labelColvo.Name = "labelColvo";
            this.labelColvo.Size = new System.Drawing.Size(95, 19);
            this.labelColvo.TabIndex = 126;
            this.labelColvo.Text = "Количество";
            // 
            // comboBoxEdiz
            // 
            this.comboBoxEdiz.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxEdiz.FormattingEnabled = true;
            this.comboBoxEdiz.Location = new System.Drawing.Point(223, 243);
            this.comboBoxEdiz.Name = "comboBoxEdiz";
            this.comboBoxEdiz.Size = new System.Drawing.Size(42, 27);
            this.comboBoxEdiz.TabIndex = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.dataGridViewItemShippingInvoice);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 211);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelId.Location = new System.Drawing.Point(96, 179);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(111, 19);
            this.labelId.TabIndex = 121;
            this.labelId.Text = "Номер товара";
            // 
            // dataGridViewItemShippingInvoice
            // 
            this.dataGridViewItemShippingInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemShippingInvoice.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewItemShippingInvoice.Name = "dataGridViewItemShippingInvoice";
            this.dataGridViewItemShippingInvoice.Size = new System.Drawing.Size(473, 150);
            this.dataGridViewItemShippingInvoice.TabIndex = 113;
            this.dataGridViewItemShippingInvoice.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxId.Location = new System.Drawing.Point(213, 176);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(135, 27);
            this.textBoxId.TabIndex = 120;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonBack.Location = new System.Drawing.Point(340, 276);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 42);
            this.buttonBack.TabIndex = 123;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonSave.Location = new System.Drawing.Point(340, 228);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 42);
            this.buttonSave.TabIndex = 122;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add_SP_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(513, 332);
            this.Controls.Add(this.labelrub);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownColvo);
            this.Controls.Add(this.labelColvo);
            this.Controls.Add(this.comboBoxEdiz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_SP_S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара в накладную отправки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_SP_S_FormClosing);
            this.Load += new System.EventHandler(this.Add_SP_S_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemShippingInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelrub;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownColvo;
        private System.Windows.Forms.Label labelColvo;
        private System.Windows.Forms.ComboBox comboBoxEdiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DataGridView dataGridViewItemShippingInvoice;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Timer timer1;
    }
}