namespace ProjetBuseyneLaboProg
{
    partial class CréationCompte
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_UsernameNewAccount = new System.Windows.Forms.TextBox();
            this.tb_passwordNewAccountAgain = new System.Windows.Forms.TextBox();
            this.tb_passwordNewAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_logConfirm = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Création du compte";
            // 
            // tb_UsernameNewAccount
            // 
            this.tb_UsernameNewAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UsernameNewAccount.Location = new System.Drawing.Point(20, 91);
            this.tb_UsernameNewAccount.Name = "tb_UsernameNewAccount";
            this.tb_UsernameNewAccount.Size = new System.Drawing.Size(234, 27);
            this.tb_UsernameNewAccount.TabIndex = 3;
            // 
            // tb_passwordNewAccountAgain
            // 
            this.tb_passwordNewAccountAgain.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordNewAccountAgain.Location = new System.Drawing.Point(20, 231);
            this.tb_passwordNewAccountAgain.Name = "tb_passwordNewAccountAgain";
            this.tb_passwordNewAccountAgain.Size = new System.Drawing.Size(234, 27);
            this.tb_passwordNewAccountAgain.TabIndex = 4;
            // 
            // tb_passwordNewAccount
            // 
            this.tb_passwordNewAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordNewAccount.Location = new System.Drawing.Point(19, 158);
            this.tb_passwordNewAccount.Name = "tb_passwordNewAccount";
            this.tb_passwordNewAccount.Size = new System.Drawing.Size(235, 27);
            this.tb_passwordNewAccount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(16, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retaper le mot de passe";
            // 
            // bt_logConfirm
            // 
            this.bt_logConfirm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logConfirm.Location = new System.Drawing.Point(240, 295);
            this.bt_logConfirm.Name = "bt_logConfirm";
            this.bt_logConfirm.Size = new System.Drawing.Size(92, 44);
            this.bt_logConfirm.TabIndex = 9;
            this.bt_logConfirm.Text = "Confirmer";
            this.bt_logConfirm.UseVisualStyleBackColor = true;
            this.bt_logConfirm.Click += new System.EventHandler(this.bt_logConfirm_Click);
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(12, 295);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(92, 44);
            this.bt_back.TabIndex = 10;
            this.bt_back.Text = "Retour";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetBuseyneLaboProg.Properties.Resources.sgdfsdfg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 353);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // CréationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 351);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_logConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_passwordNewAccount);
            this.Controls.Add(this.tb_passwordNewAccountAgain);
            this.Controls.Add(this.tb_UsernameNewAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CréationCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création du compte";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_UsernameNewAccount;
        private System.Windows.Forms.TextBox tb_passwordNewAccountAgain;
        private System.Windows.Forms.TextBox tb_passwordNewAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_logConfirm;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}