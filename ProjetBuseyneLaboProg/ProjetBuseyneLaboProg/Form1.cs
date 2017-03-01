using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBuseyneLaboProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
            tb_password.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (cb_languageSelect.Text == "Français")
            {
                label1.Text = "Gestion de tournois de jeux";
                label3.Text = "Nom de compte";
                label4.Text = "Mot de passe";
                label2.Text = "Sélectionner langue";
                button1.Text = "Fermer";
                bt_createAccount.Text = "Créer un compte";
                bt_login.Text = "Se connecter";
                button_ok.Text = "Confirmer";
            }
            if (cb_languageSelect.Text == "English")
            {
                label1.Text = "Games championships managing";
                label3.Text = "Username";
                label4.Text = "Password";
                label2.Text = "Select language";
                button1.Text = "Close";
                bt_createAccount.Text = "Create account";
                bt_login.Text = "Login";
                button_ok.Text = "Confirm";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
