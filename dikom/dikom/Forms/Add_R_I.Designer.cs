namespace dikom
{
    partial class Add_R_I
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_R_I));
            this.labelStorekeeper = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.comboBoxStorekeeper = new System.Windows.Forms.ComboBox();
            this.comboBoxVAT = new System.Windows.Forms.ComboBox();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelStorekeeper
            // 
            this.labelStorekeeper.AutoSize = true;
            this.labelStorekeeper.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelStorekeeper.Location = new System.Drawing.Point(7, 79);
            this.labelStorekeeper.Name = "labelStorekeeper";
            this.labelStorekeeper.Size = new System.Drawing.Size(92, 19);
            this.labelStorekeeper.TabIndex = 12;
            this.labelStorekeeper.Text = "Кладовщик";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelVAT.Location = new System.Drawing.Point(58, 46);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(41, 19);
            this.labelVAT.TabIndex = 11;
            this.labelVAT.Text = "НДС";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelP.Location = new System.Drawing.Point(9, 13);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(90, 19);
            this.labelP.TabIndex = 10;
            this.labelP.Text = "Поставщик";
            // 
            // comboBoxStorekeeper
            // 
            this.comboBoxStorekeeper.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxStorekeeper.FormattingEnabled = true;
            this.comboBoxStorekeeper.Location = new System.Drawing.Point(105, 76);
            this.comboBoxStorekeeper.Name = "comboBoxStorekeeper";
            this.comboBoxStorekeeper.Size = new System.Drawing.Size(255, 27);
            this.comboBoxStorekeeper.TabIndex = 9;
            // 
            // comboBoxVAT
            // 
            this.comboBoxVAT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxVAT.FormattingEnabled = true;
            this.comboBoxVAT.Location = new System.Drawing.Point(105, 43);
            this.comboBoxVAT.Name = "comboBoxVAT";
            this.comboBoxVAT.Size = new System.Drawing.Size(255, 27);
            this.comboBoxVAT.TabIndex = 8;
            // 
            // comboBoxP
            // 
            this.comboBoxP.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Location = new System.Drawing.Point(105, 10);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(255, 27);
            this.comboBoxP.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonSave.Location = new System.Drawing.Point(187, 109);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 42);
            this.buttonSave.TabIndex = 87;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonBack.Location = new System.Drawing.Point(71, 109);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 42);
            this.buttonBack.TabIndex = 88;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Add_R_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(374, 160);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelStorekeeper);
            this.Controls.Add(this.labelVAT);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.comboBoxStorekeeper);
            this.Controls.Add(this.comboBoxVAT);
            this.Controls.Add(this.comboBoxP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_R_I";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление накладной приема";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_R_I_FormClosing);
            this.Load += new System.EventHandler(this.Add_R_I_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStorekeeper;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.ComboBox comboBoxStorekeeper;
        private System.Windows.Forms.ComboBox comboBoxVAT;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timer1;
    }
}