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

            if (Variable.grade == 1)
            {
                button3.Enabled = false;
                button8.Enabled = false;
                button4.Enabled = false;
                button6.Text = "Participer à un tournoi";
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            PageAccueil_GérerMonTournoi PageAccueil_GérerMonTournoi = new PageAccueil_GérerMonTournoi();
            PageAccueil_GérerMonTournoi.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PageAccueil_Archives PageAccueil_Archives = new PageAccueil_Archives();
            PageAccueil_Archives.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.PageAccueilTitreFR;
                button3.Text = langage.PageAccueilCréerOrgaFR;
                button4.Text = langage.PageAccueilCréerTournoiFR;
                button5.Text = langage.PageAccueilVoirTournoiFR;
                button2.Text = langage.PageAccueilTopDesJeuxFR;
                button6.Text = langage.PageAccueilGestionFR;
                button8.Text = langage.PageAccueilCloreFR;
                button1.Text = langage.UniBoutonFermerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Location = new Point(15, 9);
                label1.Text = langage.PageAccueilTitreEN;
                button3.Text = langage.PageAccueilCréerOrgaEN;
                button4.Text = langage.PageAccueilCréerTournoiEN;
                button5.Text = langage.PageAccueilVoirTournoiEN;
                button2.Text = langage.PageAccueilTopDesJeuxEN;
                button6.Text = langage.PageAccueilGestionEN;
                button8.Text = langage.PageAccueilCloreEN;
                button1.Text = langage.UniBoutonFermerEN;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Créer une organisation -> Crée une organisation\n_________________________________________\n\nCréer un tournoi -> Crée un tournoi\n_________________________________________\n\nVoir les tournois -> Voir les tournois en cours ainsi que l'organisation responsable\n_________________________________________\n\nTop des jeux -> Affiche le top des jeux-vidéos\n_________________________________________\n\nGérer mon tournoi -> Permet d'ajouter des participants à un tournoi\n_________________________________________\n\nClore un tournoi -> Permet de clore un tournoi en attribuant des points aux équipes d'un tournoi en particulier","Aide");
        }
    }
}
