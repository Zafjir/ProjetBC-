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
            Console.Write("\nOuverture : " + Variable.conn.ConnectionString.ToString());
        }

        private void bt_logConfirm_Click(object sender, EventArgs e)
        {

            int nbm;

            if (tb_passwordNewAccount.Text == tb_passwordNewAccountAgain.Text)
            {
                /*Variable.cmd.CommandText = "insert into LogUtilisateur(Username,Password) values('" + tb_UsernameNewAccount.Text + "','" + tb_passwordNewAccount.Text + "')";
                Variable.cmd.Connection = Variable.conn;
                nbm = Variable.cmd.ExecuteNonQuery();
                Variable.conn.Close();*/

                if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }                }
                Variable.cmd.CommandText = "insert into LogUtilisateur(UsName,Pwd) values('" + tb_UsernameNewAccount.Text + "','" + tb_passwordNewAccount.Text + "')";
                Variable.cmd.Connection = Variable.conn;
            try
            { 
                    nbm = Variable.cmd.ExecuteNonQuery();
                    MessageBox.Show(nbm.ToString());
            }catch (Exception ex)
                {
                    MessageBox.Show("Compte créé avec succès");
                }
               
                Variable.conn.Close();
            this.Close();
        }
    }
}