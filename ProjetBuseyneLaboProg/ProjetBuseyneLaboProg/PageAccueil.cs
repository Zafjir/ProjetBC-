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
            agrandirPage = 1;
        }

        private void retourBt_Click(object sender, EventArgs e)
        {
            agrandirPage = 2;
        }

        private void confirmBt_Click(object sender, EventArgs e)
        {
            int nbm;

            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "insert into Organisation(Nomorganisation,Description,Nomresponsable,Email) values('" + tb_NomOrganisation.Text + "','" + tb_description.Text + "','" + tb_NomGerant.Text + "','" + tb_Email.Text +"')";
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

            Variable.conn.Close();
            MessageBox.Show("Organisation créée.");
            tb_NomOrganisation.Clear();
            tb_NomGerant.Clear();
            tb_Email.Clear();
            tb_description.Clear();
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
                        tb_description.Visible = false;
                        lb_description.Visible = false;
                        tb_Email.Visible = false;
                        lb_Email.Visible = false;
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
                    lb_description.Location = new Point(250, 110);
                    tb_description.Location = new Point(350, 110);
                    tb_description.Size = new Size(200, 20);
                    lb_Email.Location = new Point(250, 140);
                    tb_Email.Location = new Point(350, 140);
                    tb_Email.Size = new Size(200, 20);
                    confirmBt.Location = new Point(250, 180);
                    confirmBt.Size = new Size(103, 23);


                    lb_NomOrgansation.Text = "Nom : ";
                    lb_NomGerant.Text = "Responsable : ";
                    lb_description.Text = "Description : ";
                    lb_Email.Text = "Email : ";
                    confirmBt.Text = "Confirmer";
                    confirmBt.Click += new EventHandler(confirmBt_Click);

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
                    this.Controls.Add(tb_description);
                    this.Controls.Add(lb_description);
                    this.Controls.Add(tb_Email);
                    this.Controls.Add(lb_Email);
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
                    tb_description.Visible = true;
                    lb_description.Visible = true;
                    tb_Email.Visible = true;
                    lb_Email.Visible = true;
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
            if (agrandirPage == 4)
            {
                if (itemCree3 == false)
                {
                    tournoi_bt_confirm.Location = new Point(250, 150);
                    tournoi_lb_nomTournoi.Location = new Point(250, 50);
                    tournoi_tb_nomTournoi.Location = new Point(350, 50);
                    tournoi_lb_type.Location = new Point(250, 80);
                    tournoi_tb_type.Location = new Point(350, 80);
                    tournoi_lb_calendrier.Location = new Point(250, 110);
                    tournoi_tb_calendrier.Location = new Point(350, 110);
                    tournoi_lb_nomTournoi.Text = "Nom du Tournoi";
                    tournoi_lb_type.Text = "Type de tournoi";
                    tournoi_lb_calendrier.Text = "Date du tournoi";
                    tournoi_bt_confirm.Text = "Confirmer";
                    if (itemCree == false && itemCree2)
                    {
                        retourBt.Size = new Size(23, 23);
                        retourBt.Location = new Point(157, 337);
                        retourBt.Text = "<";
                        this.Controls.Add(retourBt);
                    }
                    retourBt.Name = "retourBt";
                    retourBt.Click += new EventHandler(retourBt_Click);
                    this.Controls.Add(tournoi_bt_confirm);
                    this.Controls.Add(tournoi_lb_nomTournoi);
                    this.Controls.Add(tournoi_tb_nomTournoi);
                    this.Controls.Add(tournoi_lb_type);
                    this.Controls.Add(tournoi_tb_type);
                    this.Controls.Add(tournoi_lb_calendrier);
                    this.Controls.Add(tournoi_tb_calendrier);
                    itemCree3 = true;
                }
                    if (this.Size.Width < 610 && itemCree3 == true)
                    {
                        retourBt.Visible = true;
                        tournoi_bt_confirm.Visible = true;
                        tournoi_lb_nomTournoi.Visible = true;
                        tournoi_lb_type.Visible = true;
                        tournoi_tb_type.Visible = true;
                        tournoi_lb_calendrier.Visible = true;
                        tournoi_tb_calendrier.Visible = true;
                        int newWidth = this.Size.Width + 4;
                        this.Size = new Size(newWidth, this.Size.Height);
                        label1.Width = newWidth;
                        label1.Location = new Point(3, 9);
                    }
                    if (this.Size.Width >= 609)
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

        private void button4_Click(object sender, EventArgs e)
        {
            agrandirPage = 4;
        }
    }
}
