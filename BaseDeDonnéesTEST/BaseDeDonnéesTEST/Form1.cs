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

namespace BaseDeDonnéesTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1.conn = new OleDbConnection();
            Class1.cmd = new OleDbCommand(); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.conn.ConnectionString = Properties.Settings.Default.OledbConnectionString2010;
            try
            {
                Class1.conn.Open();
                if (Class1.conn.State==ConnectionState.Open)
                {
                    //MessageBox.Show("Connection established");
                    string sqlstr, enr;

                    sqlstr = "select Nom from TailleDeBite";
                    Class1.cmd.CommandType = CommandType.Text;
                    Class1.cmd.CommandText = sqlstr;
                    Class1.cmd.Connection = Class1.conn;
                    Class1.dtrd = Class1.cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (Class1.dtrd.Read())
                    {
                        enr = Class1.dtrd["Nom"].ToString();
                        listBox1.Items.Add(enr);
                    }
                    if (Class1.dtrd != null)
                    {
                        Class1.dtrd.Close();
                    }

                    sqlstr = "select Taille from TailleDeBite";
                    Class1.cmd.CommandType = CommandType.Text;
                    Class1.cmd.CommandText = sqlstr;
                    Class1.cmd.Connection = Class1.conn;
                    Class1.dtrd = Class1.cmd.ExecuteReader();
                    listBox2.Items.Clear();
                    while (Class1.dtrd.Read())
                    {
                        enr = Class1.dtrd["Taille"].ToString();
                        listBox2.Items.Add(enr);
                    }
                    if (Class1.dtrd != null)
                    {
                        Class1.dtrd.Close();
                    }

                    if (Class1.conn.State==ConnectionState.Open)
                    {
                        Class1.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Connection failed");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Class1.conn.ConnectionString = Properties.Settings.Default.OledbConnectionString2010;
            try
            {
                Class1.conn.Open();
                if (Class1.conn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Connection established");
                    string sqlstr, enr;

                    sqlstr = "select Nom from TailleDeBite";
                    Class1.cmd.CommandType = CommandType.Text;
                    Class1.cmd.CommandText = sqlstr;
                    Class1.cmd.Connection = Class1.conn;
                    Class1.dtrd = Class1.cmd.ExecuteReader();
                    listBox1.Items.Clear();
                    while (Class1.dtrd.Read())
                    {
                        enr = Class1.dtrd["Nom"].ToString();
                        listBox1.Items.Add(enr);
                    }
                    if (Class1.dtrd != null)
                    {
                        Class1.dtrd.Close();
                    }

                    sqlstr = "select Taille from TailleDeBite";
                    Class1.cmd.CommandType = CommandType.Text;
                    Class1.cmd.CommandText = sqlstr;
                    Class1.cmd.Connection = Class1.conn;
                    Class1.dtrd = Class1.cmd.ExecuteReader();
                    listBox2.Items.Clear();
                    while (Class1.dtrd.Read())
                    {
                        enr = Class1.dtrd["Taille"].ToString();
                        listBox2.Items.Add(enr);
                    }
                    if (Class1.dtrd != null)
                    {
                        Class1.dtrd.Close();
                    }

                    if (Class1.conn.State == ConnectionState.Open)
                    {
                        Class1.conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Connection failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
