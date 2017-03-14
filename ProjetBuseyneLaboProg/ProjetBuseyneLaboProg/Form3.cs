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
    public partial class Form3 : Form
    {
        public Form3()
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
            string log;
            string sqlstr;
            string enr1, enr2;

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
                        listBox1.Items.Add(enr1);
                        listBox2.Items.Add(enr2);
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
    }
}
