using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjetBuseyneLaboProg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_passwordNewAccount.PasswordChar = '*';
            tb_passwordNewAccount.MaxLength = 14;
            tb_passwordNewAccountAgain.PasswordChar = '*';
            tb_passwordNewAccountAgain.MaxLength = 14;
        }

        private void bt_logConfirm_Click(object sender, EventArgs e)
        {

            int nbm;

            if (tb_passwordNewAccount.Text == tb_passwordNewAccountAgain.Text)
            {
                if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }                }
                Variable.cmd.CommandText = "insert into LogUtilisateur(UsName,Pwd) values('" + tb_UsernameNewAccount.Text + "','" + tb_passwordNewAccount.Text + "')";
                Variable.cmd.Connection = Variable.conn;
            try
            { 
                nbm = Variable.cmd.ExecuteNonQuery();
            }catch (Exception ex)
                {}
               
            Variable.conn.Close();
            this.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_languageSelect.Text == "Français")
            {
                label1.Text = "Gestion de tournois de jeux";
                label2.Text = "Créer un nouveau compte";
                label3.Text = "Nom de compte";
                label4.Text = "Mot de passe";
                label5.Text = "Mot de passe de nouveau";
                bt_back.Text = "Retour";
                button1.Text = "Confirmer langage";
                bt_logConfirm.Text = "Confirmer";
            }
            if (cb_languageSelect.Text == "English")
            {
                label1.Text = "Games championships managing";
                label2.Text = "Create a new account";
                label3.Text = "Username";
                label4.Text = "Password";
                label5.Text = "Password again";
                bt_back.Text = "Back";
                button1.Text = "Confirm language";
                bt_logConfirm.Text = "Confirm";
            }
        }
    }
}