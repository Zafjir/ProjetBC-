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
        int agrandirPage = 0;
        bool itemCree = false;
        bool itemCree2 = false;
        bool itemCree3 = false;
        bool itemCree4 = false;

        Button retourBt = new Button();
        ListBox list = new ListBox();

        TextBox tb_NomOrganisation = new TextBox();
        Label lb_NomGerant = new Label();
        TextBox tb_NomGerant = new TextBox();
        Label lb_description = new Label();
        TextBox tb_description = new TextBox();
        Label lb_NomOrgansation = new Label();
        Button confirmBt = new Button();
        //Choses pour le menu tournoi
        Button tournoi_bt_confirm = new Button();
        Label tournoi_lb_nomTournoi = new Label();
        TextBox tournoi_tb_nomTournoi = new TextBox();
        Label tournoi_lb_type = new Label();
        TextBox tournoi_tb_type = new TextBox();
        Label tournoi_lb_calendrier = new Label();
        TextBox tournoi_tb_calendrier = new TextBox();
        //Nom type calendrier
        TextBox tb_Email = new TextBox();
        Label lb_Email = new Label();


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
        {
            agrandirPage = 2;
        }

        private void confirmBt_Click(object sender, EventArgs e)
        {}

        private void PageAccueil_Load(object sender, EventArgs e)
        {
            lb_Pseudo.Text = Variable.pseudoConnection;
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
