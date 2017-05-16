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
    public partial class PageAdmin : Form
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label1.Text = "User name";
            label2.Text = "Password";
            label3.Text = "Grade";
            label4.Text = "Nbre Co";
            string log;
            string sqlstr;
            string enr1, enr2, enr3, enr4;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {

                    sqlstr = "select * from LogUtilisateur";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["UsName"].ToString();
                        enr2 = Variable.dtrd["Pwd"].ToString();
                        enr3 = Variable.dtrd["Grade"].ToString();
                        enr4 = Variable.dtrd["NbreCo"].ToString();
                        listBox1.Items.Add(enr1);
                        listBox2.Items.Add(enr2);
                        listBox3.Items.Add(enr3);
                        listBox4.Items.Add(enr4);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            label1.Text = "User name";
            label2.Text = "Password";
            label3.Text = " ";
            label4.Text = " ";
            string log;
            string sqlstr;
            string enr1, enr2;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {

                    sqlstr = "select * from LogAdmin";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["UsName"].ToString();
                        enr2 = Variable.dtrd["Pwd"].ToString();
                        listBox1.Items.Add(enr1);
                        listBox2.Items.Add(enr2);
                    }
                    if (Variable.dtrd == null)
                    {
                        Variable.dtrd.Close();
                    }
                    if (Variable.conn.State == ConnectionState.Open)
                    {
                        Variable.conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            label1.Text = "Name";
            label2.Text = "Description";
            label3.Text = "Responsable name";
            label4.Text = "Email";
            string log;
            string sqlstr;
            string enr1, enr2, enr3, enr4;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {

                    sqlstr = "select * from Organisation";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["Nomorganisation"].ToString();
                        enr2 = Variable.dtrd["Description"].ToString();
                        enr3 = Variable.dtrd["Nomresponsable"].ToString();
                        enr4 = Variable.dtrd["Email"].ToString();
                        listBox1.Items.Add(enr1);
                        listBox2.Items.Add(enr2);
                        listBox3.Items.Add(enr3);
                        listBox4.Items.Add(enr4);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string promote = listBox1.SelectedItem.ToString();

            //MessageBox.Show(promote + listBox1.SelectedItem.ToString());

            int nbm;

            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "update LogUtilisateur set Grade = 'organisateur' where UsName = '" + promote + "'";
            //MessageBox.Show(Variable.cmd.CommandText);
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

            Variable.conn.Close();
            //MessageBox.Show("Compte promote.");

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            label1.Text = "User name";
            label2.Text = "Password";
            label3.Text = "Grade";
            label4.Text = "Nbre Co";
            string log;
            string sqlstr;
            string enr1, enr2, enr3, enr4;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {

                    sqlstr = "select * from LogUtilisateur";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["UsName"].ToString();
                        enr2 = Variable.dtrd["Pwd"].ToString();
                        enr3 = Variable.dtrd["Grade"].ToString();
                        enr4 = Variable.dtrd["NbreCo"].ToString();
                        listBox1.Items.Add(enr1);
                        listBox2.Items.Add(enr2);
                        listBox3.Items.Add(enr3);
                        listBox4.Items.Add(enr4);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string depromote = listBox1.SelectedItem.ToString();

            //MessageBox.Show(promote + listBox1.SelectedItem.ToString());

            int nbm;

            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "update LogUtilisateur set Grade = 'utilisateur' where UsName = '" + depromote + "'";
            //MessageBox.Show(Variable.cmd.CommandText);
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

            Variable.conn.Close();
            //MessageBox.Show("Compte depromote.");

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label1.Text = "User name";
            label2.Text = "Password";
            label3.Text = " ";
            label4.Text = " ";
            string log;
            string sqlstr;
            string enr1, enr2, enr3;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {

                    sqlstr = "select * from LogUtilisateur";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["UsName"].ToString();
                        enr2 = Variable.dtrd["Pwd"].ToString();
                        enr3 = Variable.dtrd["Grade"].ToString();
                        listBox1.Items.Add(enr1);
                        listBox2.Items.Add(enr2);
                        listBox3.Items.Add(enr3);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
