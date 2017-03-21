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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Variable.langue == "Français")
            {
                label1.Text = "La langue que vous avez choisie est le français";
            }
            if (Variable.langue == "Anglais")
            {
                label1.Text = "The language you have chosen is English";
            }
            if(Variable.langue == "Neerlandais")
            {
                label1.Text = "Bon je sais pas écrire en Néerlandais donc faites comme si c'était écris dans cette langue merci :)";
            }
            if (Variable.langue == "Allemand")
            {
                label1.Text = "ÜberFallen Poland";
            }
            if (Variable.langue == "Russe")
            {
                label1.Text = "Cyka blyat";
            }
        }
    }
}
