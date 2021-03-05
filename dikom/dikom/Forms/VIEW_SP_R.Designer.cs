namespace dikom
{
    partial class VIEW_SP_R
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_SP_R));
            this.dataGridViewProductAcceptance = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.numericUpDownColvo = new System.Windows.Forms.NumericUpDown();
            this.labelColvo = new System.Windows.Forms.Label();
            this.comboBoxEdiz = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductAcceptance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductAcceptance
            // 
            this.dataGridViewProductAcceptance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductAcceptance.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProductAcceptance.Name = "dataGridViewProductAcceptance";
            this.dataGridViewProductAcceptance.Size = new System.Drawing.Size(510, 268);
            this.dataGridViewProductAcceptance.TabIndex = 0;
            this.dataGridViewProductAcceptance.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(406, 292);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 42);
            this.buttonAdd.TabIndex = 79;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(300, 292);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 42);
            this.buttonEdit.TabIndex = 78;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(300, 340);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 42);
            this.buttonDelete.TabIndex = 77;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // numericUpDownColvo
            // 
            this.numericUpDownColvo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDownColvo.Location = new System.Drawing.Point(125, 301);
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
            this.numericUpDownColvo.TabIndex = 120;
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
            this.labelColvo.Location = new System.Drawing.Point(24, 304);
            this.labelColvo.Name = "labelColvo";
            this.labelColvo.Size = new System.Drawing.Size(95, 19);
            this.labelColvo.TabIndex = 119;
            this.labelColvo.Text = "Количество";
            // 
            // comboBoxEdiz
            // 
            this.comboBoxEdiz.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxEdiz.FormattingEnabled = true;
            this.comboBoxEdiz.Location = new System.Drawing.Point(227, 301);
            this.comboBoxEdiz.Name = "comboBoxEdiz";
            this.comboBoxEdiz.Size = new System.Drawing.Size(42, 27);
            this.comboBoxEdiz.TabIndex = 118;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonBack.Location = new System.Drawing.Point(406, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 42);
            this.buttonBack.TabIndex = 121;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VIEW_SP_R
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(536, 394);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.numericUpDownColvo);
            this.Controls.Add(this.labelColvo);
            this.Controls.Add(this.comboBoxEdiz);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewProductAcceptance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VIEW_SP_R";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар в накладной приема";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_SP_R_FormClosing);
            this.Load += new System.EventHandler(this.Add_SP_R_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductAcceptance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductAcceptance;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownColvo;
        private System.Windows.Forms.Label labelColvo;
        private System.Windows.Forms.ComboBox comboBoxEdiz;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Timer timer1;
    }
}