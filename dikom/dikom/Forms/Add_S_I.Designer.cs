namespace dikom
{
    partial class Add_S_I
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_S_I));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStorekeeper = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.comboBoxStorekeeper = new System.Windows.Forms.ComboBox();
            this.comboBoxVAT = new System.Windows.Forms.ComboBox();
            this.comboBoxZ = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonBack.Location = new System.Drawing.Point(73, 108);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 42);
            this.buttonBack.TabIndex = 96;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonSave.Location = new System.Drawing.Point(189, 108);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 42);
            this.buttonSave.TabIndex = 95;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStorekeeper
            // 
            this.labelStorekeeper.AutoSize = true;
            this.labelStorekeeper.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelStorekeeper.Location = new System.Drawing.Point(9, 78);
            this.labelStorekeeper.Name = "labelStorekeeper";
            this.labelStorekeeper.Size = new System.Drawing.Size(92, 19);
            this.labelStorekeeper.TabIndex = 94;
            this.labelStorekeeper.Text = "Кладовщик";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelVAT.Location = new System.Drawing.Point(60, 45);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(41, 19);
            this.labelVAT.TabIndex = 93;
            this.labelVAT.Text = "НДС";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelZ.Location = new System.Drawing.Point(17, 12);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(84, 19);
            this.labelZ.TabIndex = 92;
            this.labelZ.Text = "Заказчики";
            // 
            // comboBoxStorekeeper
            // 
            this.comboBoxStorekeeper.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxStorekeeper.FormattingEnabled = true;
            this.comboBoxStorekeeper.Location = new System.Drawing.Point(107, 75);
            this.comboBoxStorekeeper.Name = "comboBoxStorekeeper";
            this.comboBoxStorekeeper.Size = new System.Drawing.Size(255, 27);
            this.comboBoxStorekeeper.TabIndex = 91;
            // 
            // comboBoxVAT
            // 
            this.comboBoxVAT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxVAT.FormattingEnabled = true;
            this.comboBoxVAT.Location = new System.Drawing.Point(107, 42);
            this.comboBoxVAT.Name = "comboBoxVAT";
            this.comboBoxVAT.Size = new System.Drawing.Size(255, 27);
            this.comboBoxVAT.TabIndex = 90;
            // 
            // comboBoxZ
            // 
            this.comboBoxZ.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxZ.FormattingEnabled = true;
            this.comboBoxZ.Location = new System.Drawing.Point(107, 9);
            this.comboBoxZ.Name = "comboBoxZ";
            this.comboBoxZ.Size = new System.Drawing.Size(255, 27);
            this.comboBoxZ.TabIndex = 89;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add_S_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(377, 162);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelStorekeeper);
            this.Controls.Add(this.labelVAT);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.comboBoxStorekeeper);
            this.Controls.Add(this.comboBoxVAT);
            this.Controls.Add(this.comboBoxZ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_S_I";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление накладной отправки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_S_I_FormClosing);
            this.Load += new System.EventHandler(this.Add_S_I_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStorekeeper;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.ComboBox comboBoxStorekeeper;
        private System.Windows.Forms.ComboBox comboBoxVAT;
        private System.Windows.Forms.ComboBox comboBoxZ;
        private System.Windows.Forms.Timer timer1;
    }
}