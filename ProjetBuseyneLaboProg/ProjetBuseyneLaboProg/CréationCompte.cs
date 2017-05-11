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
    public partial class CréationCompte : Form
    {
        public CréationCompte()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.CreerCompteTitreFR;
                label3.Text = langage.CreerCompteUserNameFR;
                label4.Text = langage.CreerCompteMDPFR;
                label5.Text = langage.CreerCompteMDPAFR;
                bt_back.Text = langage.CreerCompteBTRetourFR;
                bt_logConfirm.Text = langage.UniConfirmerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.CreerCompteTitreEN;
                label3.Text = langage.CreerCompteUserNameEN;
                label4.Text = langage.CreerCompteMDPEN;
                label5.Text = langage.CreerCompteMDPAEN;
                bt_back.Text = langage.CreerCompteBTRetourEN;
                bt_logConfirm.Text = langage.UniConfirmerEN;
            }

            label1.Parent = pictureBox1;
            label3.Parent = pictureBox1; 
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            tb_passwordNewAccount.PasswordChar = '*';
            tb_passwordNewAccount.MaxLength = 14;
            tb_passwordNewAccountAgain.PasswordChar = '*';
            tb_passwordNewAccountAgain.MaxLength = 14;
        }

        private void bt_logConfirm_Click(object sender, EventArgs e)
        {
            if (tb_passwordNewAccount.Text == "" && tb_UsernameNewAccount.Text == "")
            {
                MessageBox.Show("Manque d'informations");
            }

            else
            {
                //Variable.motCrypte = "";
                //Variable.motNonCrypte = "";
                //Variable.motNonCrypte = tb_passwordNewAccount.Text;
                string pass = tb_passwordNewAccount.Text;
                Variable.motNonCrypte = pass.ToCharArray(0,pass.Length);

                Cryptage.cryptage();
                int nbm;

                if (tb_passwordNewAccount.Text == tb_passwordNewAccountAgain.Text)
                {
                    if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }
                }
                string s = new string(Variable.motCrypte);
                Variable.cmd.CommandText = "insert into LogUtilisateur(UsName,Pwd,Grade) values('" + tb_UsernameNewAccount.Text + "','" + s + "','utilisateur')";
                Variable.cmd.Connection = Variable.conn;
                try
                {
                    nbm = Variable.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { }

                Variable.conn.Close();
                MessageBox.Show("Compte créé.");
                this.Close();
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {}
    }
}