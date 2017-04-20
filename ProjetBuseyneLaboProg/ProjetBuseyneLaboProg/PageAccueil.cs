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

        Button retourBt = new Button();
        ListBox list = new ListBox();

        TextBox tb_NomOrganisation = new TextBox();
        Label lb_NomGerant = new Label();
        TextBox tb_NomGerant = new TextBox();
        Label lb_nbJoueurs = new Label();
        TextBox tb_nbJoueurs = new TextBox();
        Label lb_NomOrgansation = new Label();
        Button confirmBt = new Button();


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
            agrandirPage = 1;
        }

        private void retourBt_Click(object sender, EventArgs e)
        {
            agrandirPage = 2;
        }

        private void PageAccueil_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (agrandirPage == 1)
            {
                if (itemCree==false)
                {
                    list.Size = new Size(420, 300);
                    list.Location = new Point(250, 50);
                    retourBt.Size = new Size(23, 23);
                    retourBt.Location = new Point(157, 337);
                    retourBt.Text = "<";
                    retourBt.Name = "retourBt";
                    retourBt.Click += new EventHandler(retourBt_Click);
                    this.Controls.Add(retourBt);
                    this.Controls.Add(list);
                    itemCree = true;
                }
                if (this.Size.Width < 710&&itemCree==true)
                {
                    retourBt.Visible = true;
                    list.Visible = true;
                    int newWidth = this.Size.Width + 4;
                    this.Size = new Size(newWidth, this.Size.Height);
                    label1.Width = newWidth;
                    label1.Location = new Point(3, 9);
                }
                if (this.Size.Width==709)
                {
                    agrandirPage = 0;
                }
            }

            if (agrandirPage == 2)
            {
                if (this.Size.Width > 253)
                {
                    int newWidth = this.Size.Width - 4;
                    this.Size = new Size(newWidth, this.Size.Height);
                    label1.Width = newWidth;
                    label1.Location = new Point(3, 9);
                    if (this.Size.Width==254)
                    {
                        list.Visible = false;
                        retourBt.Visible = false;
                        lb_NomOrgansation.Visible = false;
                        tb_NomOrganisation.Visible = false;
                        tb_NomGerant.Visible = false;
                        lb_NomGerant.Visible = false;
                        tb_nbJoueurs.Visible = false;
                        lb_nbJoueurs.Visible = false;
                        confirmBt.Visible = false;
                        label1.Width = 229;
                        agrandirPage = 0;
                    }
                }
            }

            if (agrandirPage == 3)
            {
                if (itemCree2 == false)
                {
                    lb_NomOrgansation.Location = new Point(250, 50);
                    tb_NomOrganisation.Location = new Point(350, 50);
                    tb_NomOrganisation.Size = new Size(200, 20);
                    lb_NomGerant.Location = new Point(250, 80);
                    tb_NomGerant.Location = new Point(350, 80);
                    tb_NomGerant.Size = new Size(200, 20);
                    lb_nbJoueurs.Location = new Point(250, 110);
                    tb_nbJoueurs.Location = new Point(350, 110);
                    tb_nbJoueurs.Size = new Size(200, 20);
                    confirmBt.Location = new Point(250, 150);
                    confirmBt.Size = new Size(103, 23);

                    lb_NomOrgansation.Text = "Nom : ";
                    lb_NomGerant.Text = "Nom du gérant : ";
                    lb_nbJoueurs.Text = "Nbre de joueurs : ";
                    confirmBt.Text = "Confirmer";

                    if (itemCree == false)
                    {
                        retourBt.Size = new Size(23, 23);
                        retourBt.Location = new Point(157, 337);
                        retourBt.Text = "<";
                        this.Controls.Add(retourBt);
                    }
                    
                    retourBt.Name = "retourBt";
                    retourBt.Click += new EventHandler(retourBt_Click);
                    this.Controls.Add(retourBt);
                    this.Controls.Add(lb_NomOrgansation);
                    this.Controls.Add(tb_NomOrganisation);
                    this.Controls.Add(tb_NomGerant);
                    this.Controls.Add(lb_NomGerant);
                    this.Controls.Add(tb_nbJoueurs);
                    this.Controls.Add(lb_nbJoueurs);
                    this.Controls.Add(confirmBt);
                    itemCree2 = true;
                }
                if (this.Size.Width < 610 && itemCree2 == true)
                {
                    retourBt.Visible = true;
                    tb_NomOrganisation.Visible = true;
                    lb_NomOrgansation.Visible = true;
                    tb_NomGerant.Visible = true;
                    lb_NomGerant.Visible = true;
                    tb_nbJoueurs.Visible = true;
                    lb_nbJoueurs.Visible = true;
                    confirmBt.Visible = true;
                    int newWidth = this.Size.Width + 4;
                    this.Size = new Size(newWidth, this.Size.Height);
                    label1.Width = newWidth;
                    label1.Location = new Point(3, 9);
                }
                if (this.Size.Width == 609)
                {
                    agrandirPage = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agrandirPage = 3;
        }
    }
}
