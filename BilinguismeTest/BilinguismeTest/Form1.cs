using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilinguismeTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Français");
            comboBox1.Items.Add("Nederlands");
            comboBox1.Items.Add("Deutsch");
            comboBox1.Items.Add("russkiy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "English")
            {
                label1.Text = "Language";
                Variable.langue = "Anglais";
            }
            if(comboBox1.Text == "Français")
            {
                label1.Text = "Langue";
                Variable.langue = "Français";
            }
            if(comboBox1.Text == "Nederlands")
            {
                label1.Text = "Taal";
                Variable.langue = "Neerlandais";
            }
            if (comboBox1.Text == "Deutsch")
            {
                label1.Text = "Sprache";
                Variable.langue = "Allemand";
            }
            if(comboBox1.Text == "russkiy")
            {
                label1.Text = "yazyk";
                Variable.langue = "Russe";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
