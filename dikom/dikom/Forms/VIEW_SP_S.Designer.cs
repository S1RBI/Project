namespace dikom
{
    partial class VIEW_SP_S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_SP_S));
            this.buttonBack = new System.Windows.Forms.Button();
            this.numericUpDownColvo = new System.Windows.Forms.NumericUpDown();
            this.labelColvo = new System.Windows.Forms.Label();
            this.comboBoxEdiz = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewShippingItem = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingItem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonBack.Location = new System.Drawing.Point(437, 342);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 42);
            this.buttonBack.TabIndex = 129;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // numericUpDownColvo
            // 
            this.numericUpDownColvo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDownColvo.Location = new System.Drawing.Point(134, 321);
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
            this.numericUpDownColvo.TabIndex = 128;
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
            this.labelColvo.Location = new System.Drawing.Point(33, 324);
            this.labelColvo.Name = "labelColvo";
            this.labelColvo.Size = new System.Drawing.Size(95, 19);
            this.labelColvo.TabIndex = 127;
            this.labelColvo.Text = "Количество";
            // 
            // comboBoxEdiz
            // 
            this.comboBoxEdiz.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxEdiz.FormattingEnabled = true;
            this.comboBoxEdiz.Location = new System.Drawing.Point(236, 321);
            this.comboBoxEdiz.Name = "comboBoxEdiz";
            this.comboBoxEdiz.Size = new System.Drawing.Size(42, 27);
            this.comboBoxEdiz.TabIndex = 126;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(437, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 42);
            this.buttonAdd.TabIndex = 125;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(331, 294);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 42);
            this.buttonEdit.TabIndex = 124;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(331, 342);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 42);
            this.buttonDelete.TabIndex = 123;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewShippingItem
            // 
            this.dataGridViewShippingItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippingItem.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShippingItem.Name = "dataGridViewShippingItem";
            this.dataGridViewShippingItem.Size = new System.Drawing.Size(566, 268);
            this.dataGridViewShippingItem.TabIndex = 122;
            this.dataGridViewShippingItem.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VIEW_SP_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(590, 409);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.numericUpDownColvo);
            this.Controls.Add(this.labelColvo);
            this.Controls.Add(this.comboBoxEdiz);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewShippingItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VIEW_SP_S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар в накладной отправки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIEW_SP_S_FormClosing);
            this.Load += new System.EventHandler(this.VIEW_SP_S_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.NumericUpDown numericUpDownColvo;
        private System.Windows.Forms.Label labelColvo;
        private System.Windows.Forms.ComboBox comboBoxEdiz;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewShippingItem;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Timer timer1;
    }
}