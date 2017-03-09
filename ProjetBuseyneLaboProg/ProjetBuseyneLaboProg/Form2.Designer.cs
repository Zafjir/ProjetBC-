namespace ProjetBuseyneLaboProg
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UsernameNewAccount = new System.Windows.Forms.TextBox();
            this.tb_passwordNewAccountAgain = new System.Windows.Forms.TextBox();
            this.tb_passwordNewAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_logConfirm = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion de tournois de jeux";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create a new account";
            // 
            // tb_UsernameNewAccount
            // 
            this.tb_UsernameNewAccount.Location = new System.Drawing.Point(114, 82);
            this.tb_UsernameNewAccount.Name = "tb_UsernameNewAccount";
            this.tb_UsernameNewAccount.Size = new System.Drawing.Size(143, 20);
            this.tb_UsernameNewAccount.TabIndex = 3;
            // 
            // tb_passwordNewAccountAgain
            // 
            this.tb_passwordNewAccountAgain.Location = new System.Drawing.Point(114, 134);
            this.tb_passwordNewAccountAgain.Name = "tb_passwordNewAccountAgain";
            this.tb_passwordNewAccountAgain.Size = new System.Drawing.Size(143, 20);
            this.tb_passwordNewAccountAgain.TabIndex = 4;
            // 
            // tb_passwordNewAccount
            // 
            this.tb_passwordNewAccount.Location = new System.Drawing.Point(114, 108);
            this.tb_passwordNewAccount.Name = "tb_passwordNewAccount";
            this.tb_passwordNewAccount.Size = new System.Drawing.Size(143, 20);
            this.tb_passwordNewAccount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password again";
            // 
            // bt_logConfirm
            // 
            this.bt_logConfirm.Location = new System.Drawing.Point(197, 230);
            this.bt_logConfirm.Name = "bt_logConfirm";
            this.bt_logConfirm.Size = new System.Drawing.Size(75, 23);
            this.bt_logConfirm.TabIndex = 9;
            this.bt_logConfirm.Text = "Confirm";
            this.bt_logConfirm.UseVisualStyleBackColor = true;
            this.bt_logConfirm.Click += new System.EventHandler(this.bt_logConfirm_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(13, 230);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 23);
            this.bt_back.TabIndex = 10;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_logConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_passwordNewAccount);
            this.Controls.Add(this.tb_passwordNewAccountAgain);
            this.Controls.Add(this.tb_UsernameNewAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UsernameNewAccount;
        private System.Windows.Forms.TextBox tb_passwordNewAccountAgain;
        private System.Windows.Forms.TextBox tb_passwordNewAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_logConfirm;
        private System.Windows.Forms.Button bt_back;
    }
}