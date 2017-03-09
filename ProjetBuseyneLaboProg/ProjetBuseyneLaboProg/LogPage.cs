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
                        enr = Variable.dtrd["UserName"].ToString() + "" + Variable.dtrd["Password"].ToString();
                        log = Variable.username + Variable.password;
                        if (log == enr)
                        {
                            Form3 form3 = new Form3();
                            form3.ShowDialog();
                        }
                        if (Variable.dtrd != null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (log != enr)
                        {
                            if (Variable.conn.State == ConnectionState.Open)
                            {
                                Variable.username = textBox1.Text;
                                Variable.password = tb_password.Text;
                                sqlstr = "select * from LogUtilisateur";
                                Variable.cmd.CommandType = CommandType.Text;
                                Variable.cmd.CommandText = sqlstr;
                                Variable.cmd.Connection = Variable.conn;
                                Variable.dtrd = Variable.cmd.ExecuteReader();
                                while (Variable.dtrd.Read())
                                {
                                    enr = Variable.dtrd["UsName"].ToString() + "" + Variable.dtrd["Pwd"].ToString();
                                    log = Variable.username + Variable.password;
                                    if (log == enr)
                                    {
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
                }catch (Exception ex){}
        }
    }
}
