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
        static LogPage pg = new LogPage();
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

            label3.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            bt_login.Parent = pictureBox1;
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
        { }

        private void button3_Click(object sender, EventArgs e)
        {

            PageAdmin form3 = new PageAdmin();
            form3.ShowDialog();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string log;
            DBAccess db = new DBAccess();
            DataTable ds = db.qry("select * from logAdmin");
            bool authentification = false;
            String auth = "";
            Variable.username = textBox1.Text;
            Variable.password = tb_password.Text;
            log = Variable.username + Variable.password;
            foreach (DataRow row in ds.Rows)
            {
                foreach (DataColumn column in ds.Columns)
                {
                    //Console.WriteLine(row[column]);
                    auth = auth + row[column].ToString();
                }
                Console.WriteLine(auth);
                Console.WriteLine(log);
                if (auth == log)
                {
                    authentification = true;
                }
                auth = "";
            }
            Console.WriteLine(auth);
            if (authentification)
            {
                PageAdmin form3 = new PageAdmin();
                form3.ShowDialog();
            }
            else
            {
                ds = db.qry("select * from LogUtilisateur");
                foreach (DataRow row in ds.Rows)
                {
                    foreach (DataColumn column in ds.Columns)
                    {
                       // Console.WriteLine(row[column]);
                        auth = auth + row[column].ToString();
                    }
                    Console.WriteLine(auth);
                    Console.WriteLine(log);
                    if (auth == log)
                    {
                        authentification = true;
                    }
                    auth = "";
                }
            }
            if (authentification)
            { 
                PageAccueil pageAccueil = new PageAccueil();
                pageAccueil.ShowDialog();
            }
        }
        /*

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
                    //MessageBox.Show("authAdmin");
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
                        // MessageBox.Show("Arrivée dans le auth utilisateur");
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
                                // MessageBox.Show("auth User");
                                enr = Variable.dtrd["UsName"].ToString() + "" + Variable.dtrd["Pwd"].ToString();
                                log = Variable.username + Variable.password;
                                if (log == enr)
                                {
                                    Variable.pseudoConnection = Variable.username;
                                    Variable.conn.Close();
                                    PageAccueil pageAccueil = new PageAccueil();
                                    pageAccueil.ShowDialog();
                                }
                            }
                            if (log != enr)
                            {
                                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion");
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
        catch (Exception ex) {}
         }*/

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.LogPageTitreFR;
                label3.Text = langage.LogPageUserFR;
                label4.Text = langage.LogPagePasswordFR;
                bt_createAccount.Text = langage.LogPageSignUpFR;
                bt_login.Text = langage.LogPageSeConnecterFR;
                button1.Text = langage.UniBoutonFermerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.LogPageTitreEN;
                label3.Text = langage.LogPageUserEN;
                label4.Text = langage.LogPagePasswordEN;
                bt_createAccount.Text = langage.LogPageSignUpEN;
                bt_login.Text = langage.LogPageSeConnecterEN;
                button1.Text = langage.UniBoutonFermerEN;
            }
        }
    }
}