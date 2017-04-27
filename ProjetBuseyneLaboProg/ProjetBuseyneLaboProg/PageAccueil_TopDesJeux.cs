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
    public partial class PageAccueil_TopDesJeux : Form
    {
        public PageAccueil_TopDesJeux()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PageAccueil_TopDesJeux_Load(object sender, EventArgs e)
        {
            groupBox1.Parent = pictureBox2;
            lb_Description.Parent = pictureBox2;
            lb_NomJeu.Parent = pictureBox2;
            //lb_Top1.Parent = pictureBox2;
            //lb_Top2.Parent = pictureBox2;
            //lb_Top3.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label1.Parent = pictureBox2;

            lb_Top1.Text = "League Of Legends";
            lb_Top2.Text = "Counter Strike GO";
            lb_Top3.Text = "Hearthstone";

            lb_NomJeu.Text = "League Of Legends";
            lb_Description.Text = "Jeu de stratégie de type MOBA";
            label1.Text = "League of Legends est un jeu vidéo de type arène de bataille en ligne gratuit développé et édité par Riot Games sur Windows, Linux et Mac OS X. Fin janvier 2013, un nouveau client bêta pour Mac a été distribué par Riot Games.";
         }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
