namespace ProjetBuseyneLaboProg
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_languageSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_createAccount = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de tournois de jeux";
            // 
            // cb_languageSelect
            // 
            this.cb_languageSelect.FormattingEnabled = true;
            this.cb_languageSelect.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.cb_languageSelect.Location = new System.Drawing.Point(147, 116);
            this.cb_languageSelect.Name = "cb_languageSelect";
            this.cb_languageSelect.Size = new System.Drawing.Size(121, 21);
            this.cb_languageSelect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select language";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(147, 78);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(121, 20);
            this.tb_password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(316, 157);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(95, 21);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_createAccount
            // 
            this.bt_createAccount.Location = new System.Drawing.Point(136, 157);
            this.bt_createAccount.Name = "bt_createAccount";
            this.bt_createAccount.Size = new System.Drawing.Size(143, 21);
            this.bt_createAccount.TabIndex = 9;
            this.bt_createAccount.Text = "Create account";
            this.bt_createAccount.UseVisualStyleBackColor = true;
            this.bt_createAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(274, 114);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(68, 23);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "Confirm";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 190);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.bt_createAccount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_languageSelect);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projet en laboratoire de programmation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_languageSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_createAccount;
        private System.Windows.Forms.Button button_ok;
    }
}

