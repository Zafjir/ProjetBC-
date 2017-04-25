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
    public partial class LogPage : Form
    { 
        public LogPage()
        {
            InitializeComponent();
            Variable.conn = new OleDbConnection();
            Variable.cmd = new OleDbCommand();

            Console.Write("Load : " + Variable.conn.ConnectionString.ToString() + "\n");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            tb_password.Clear();
            tb_password.PasswordChar = '*';
            tb_password.MaxLength = 14;
            Variable.conn.ConnectionString = Properties.Settings.Default.OledbConnectionString2010;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CréationCompte form2 = new CréationCompte();
            form2.ShowDialog();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {

            PageAdmin form3 = new PageAdmin();
            form3.ShowDialog();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string log;
            string sqlstr, enr;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    Variable.username = textBox1.Text;
                    Variable.password = tb_password.Text;
                    sqlstr = "select * from LogAdmin";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr = Variable.dtrd["UsName"].ToString() + "" + Variable.dtrd["Pwd"].ToString();
                        log = Variable.username + Variable.password;
                        //MessageBox.Show("testAdmin");
                        if (log == enr)
                        {
                            Variable.conn.Close();
                            PageAdmin form3 = new PageAdmin();
                            form3.ShowDialog();
                        }
                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }

                        Variable.conn.Open();
                        if (log != enr)
                        {
                            // MessageBox.Show("Arrivée dans le test utilisateur");
                            if (Variable.conn.State == ConnectionState.Open)
                            {
                                // MessageBox.Show("Arrivée dans le if");
                                Variable.username = textBox1.Text;
                                Variable.password = tb_password.Text;
                                sqlstr = "select * from LogUtilisateur";
                                Variable.cmd.CommandType = CommandType.Text;
                                Variable.cmd.CommandText = sqlstr;
                                Variable.cmd.Connection = Variable.conn;
                                Variable.dtrd = Variable.cmd.ExecuteReader();
                                //MessageBox.Show("Enovoie de la commande");
                                while (Variable.dtrd.Read())
                                {
                                    // MessageBox.Show("Test User");
                                    enr = Variable.dtrd["UsName"].ToString() + "" + Variable.dtrd["Pwd"].ToString();
                                    log = Variable.username + Variable.password;
                                    if (log == enr)
                                    {
                                        Variable.conn.Close();
                                        PageAccueil pageAccueil = new PageAccueil();
                                        pageAccueil.ShowDialog();
                                    }
                                }
                            }
                        }
                        if (Variable.dtrd != null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void cb_languageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PageRéglage PageRéglage = new PageRéglage();
            PageRéglage.ShowDialog();
        }
    }
}