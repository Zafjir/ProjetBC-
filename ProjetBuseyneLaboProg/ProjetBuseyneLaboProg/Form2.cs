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
            MessageBox.Show("Compte créé.");
            this.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {}
    }
}