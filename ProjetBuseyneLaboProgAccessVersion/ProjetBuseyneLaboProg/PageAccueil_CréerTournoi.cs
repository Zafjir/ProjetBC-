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
    public partial class PageAccueil_CréerTournoi : Form
    {
        public PageAccueil_CréerTournoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_confirmOrganisation_Click(object sender, EventArgs e)
        {
            if (tb_nomTournoi.Text == "" || tb_typeTournoi.Text == "" || cl_calendrierTournoi.SelectionEnd.Date.ToString() == "" || label2.Text == "")
            {
                MessageBox.Show("Manque d'informations", "Erreur");
            }
            else{
                /*
                int nbm;

                if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

                Variable.cmd.CommandText = "insert into Tournoi(NomTournoi,Type,Calendrier,OrgaResponsable) values('" + tb_nomTournoi.Text + "','" + tb_typeTournoi.Text + "','" + cl_calendrierTournoi.SelectionEnd.Date.ToString() + "','" + label2.Text + "')";
                Variable.cmd.Connection = Variable.conn;
                try
                {
                    nbm = Variable.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { }
                */
                DBAccess qry = new DBAccess();
                qry.qry("insert into Tournoi(NomTournoi,Type,Calendrier,OrgaResponsable) values('" + tb_nomTournoi.Text + "','" + tb_typeTournoi.Text + "','" + cl_calendrierTournoi.SelectionEnd.Date.ToString() + "','" + label2.Text + "')");
                Variable.conn.Close();
                MessageBox.Show("Tournoi créé.");
                tb_nomTournoi.Clear();
                tb_typeTournoi.Clear();
                this.Close();
            }
        }

        private void PageAccueil_CréerTournoi_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.CreerTournoiTitreFR;
                label3.Text = langage.CreerTournoiNomFR;
                label4.Text = langage.CreerTournoiTypeFR;
                button1.Text = langage.UniBoutonFermerFR;
                bt_confirmOrganisation.Text = langage.UniConfirmerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.CreerTournoiTitreEN;
                label3.Text = langage.CreerTournoiNomEN;
                label4.Text = langage.CreerTournoiTypeEN;
                button1.Text = langage.UniBoutonFermerEN;
                bt_confirmOrganisation.Text = langage.UniConfirmerEN;
            }

            label2.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;

            try
            {
                string sqlstr;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Organisation";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        listBox1.Items.Add(Variable.dtrd["Nomorganisation"].ToString());
                    }
                    if (Variable.dtrd == null)
                    {
                        Variable.dtrd.Close();
                    }

                    if (Variable.conn.State == ConnectionState.Open)
                    {
                        Variable.conn.Close();
                    }

                }
            }
            catch (Exception ex) { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.SelectedItem.ToString();
        }
    }
}
