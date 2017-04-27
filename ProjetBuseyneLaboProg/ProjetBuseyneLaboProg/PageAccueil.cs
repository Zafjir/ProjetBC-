using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBuseyneLaboProg
{
    public partial class PageAccueil : Form
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageAccueil_TopDesJeux PageAccueil_TopDesJeux = new PageAccueil_TopDesJeux();
            PageAccueil_TopDesJeux.Show();
        }

        private void retourBt_Click(object sender, EventArgs e)
        {}

        private void confirmBt_Click(object sender, EventArgs e)
        {}

        private void PageAccueil_Load(object sender, EventArgs e)
        {
            lb_Pseudo.Text = Variable.pseudoConnection;
            lb_Pseudo.Parent = pictureBox1;
            groupBox1.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            lb_Pseudo.Parent = pictureBox1;
            lb_Pseudo.BackColor = Color.Transparent;
            lb_Pseudo.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageAccueil_CréerOrganisation PageAccueil_CréerOrganisation = new PageAccueil_CréerOrganisation();
            PageAccueil_CréerOrganisation.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageAccueil_CréerTournoi PageAccueil_CréerTournoi = new PageAccueil_CréerTournoi();
            PageAccueil_CréerTournoi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PageRéglage PageRéglage = new PageRéglage();
            PageRéglage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PageAccueil_VoirTournoi PageAccueil_VoirTournoi = new PageAccueil_VoirTournoi();
            PageAccueil_VoirTournoi.Show();
        }
    }
}
