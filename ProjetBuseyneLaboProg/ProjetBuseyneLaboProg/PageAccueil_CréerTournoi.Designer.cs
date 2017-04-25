namespace ProjetBuseyneLaboProg
{
    partial class PageAccueil_CréerTournoi
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_typeTournoi = new System.Windows.Forms.TextBox();
            this.tb_nomTournoi = new System.Windows.Forms.TextBox();
            this.bt_confirmOrganisation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cl_calendrierTournoi = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Type de tournoi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nom du tournoi :";
            // 
            // tb_typeTournoi
            // 
            this.tb_typeTournoi.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_typeTournoi.Location = new System.Drawing.Point(30, 191);
            this.tb_typeTournoi.Name = "tb_typeTournoi";
            this.tb_typeTournoi.Size = new System.Drawing.Size(254, 27);
            this.tb_typeTournoi.TabIndex = 28;
            // 
            // tb_nomTournoi
            // 
            this.tb_nomTournoi.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomTournoi.Location = new System.Drawing.Point(30, 102);
            this.tb_nomTournoi.Name = "tb_nomTournoi";
            this.tb_nomTournoi.Size = new System.Drawing.Size(254, 27);
            this.tb_nomTournoi.TabIndex = 27;
            // 
            // bt_confirmOrganisation
            // 
            this.bt_confirmOrganisation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirmOrganisation.Location = new System.Drawing.Point(30, 467);
            this.bt_confirmOrganisation.Name = "bt_confirmOrganisation";
            this.bt_confirmOrganisation.Size = new System.Drawing.Size(92, 44);
            this.bt_confirmOrganisation.TabIndex = 26;
            this.bt_confirmOrganisation.Text = "Confirmer";
            this.bt_confirmOrganisation.UseVisualStyleBackColor = true;
            this.bt_confirmOrganisation.Click += new System.EventHandler(this.bt_confirmOrganisation_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "Création d\'un tournoi";
            // 
            // cl_calendrierTournoi
            // 
            this.cl_calendrierTournoi.Location = new System.Drawing.Point(122, 281);
            this.cl_calendrierTournoi.Name = "cl_calendrierTournoi";
            this.cl_calendrierTournoi.TabIndex = 34;
            // 
            // PageAccueil_CréerTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 539);
            this.Controls.Add(this.cl_calendrierTournoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_typeTournoi);
            this.Controls.Add(this.tb_nomTournoi);
            this.Controls.Add(this.bt_confirmOrganisation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "PageAccueil_CréerTournoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageAccueil_CréerTournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_typeTournoi;
        private System.Windows.Forms.TextBox tb_nomTournoi;
        private System.Windows.Forms.Button bt_confirmOrganisation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar cl_calendrierTournoi;
    }
}