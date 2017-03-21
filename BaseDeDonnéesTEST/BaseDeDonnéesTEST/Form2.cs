using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDonnéesTEST
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nbm;
            int taille;
            taille = Int32.Parse(textBox2.Text);
            Class1.cmd.CommandText = "insert into TailleDeBite(Nom,Taille) values('" + textBox1.Text + "'," + taille + ")";
            Class1.cmd.Connection = Class1.conn;
            if (Class1.conn.State == ConnectionState.Closed) Class1.conn.Open();
            nbm=Class1.cmd.ExecuteNonQuery();
            //MessageBox.Show(nbm.ToString());
            Class1.conn.Close();
            this.Close();
        }
    }
}
