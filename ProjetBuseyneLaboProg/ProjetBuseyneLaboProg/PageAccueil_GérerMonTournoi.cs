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
    public partial class PageAccueil_GérerMonTournoi : Form
    {
        public PageAccueil_GérerMonTournoi()
        {
            InitializeComponent();
        }

        private void PageAccueil_GérerMonTournoi_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.GestionTournoiTitreFR;
                label4.Text = langage.GestionTournoiListeFR;
                label2.Text = langage.GestionTournoiRechercherFR;
                label6.Text = langage.GestionTournoiNomTFR;
                label8.Text = langage.GestionTournoiCalendrierFR;
                button2.Text = langage.GestionTournoiRechercherFR;
                bt_RechercheJoueur.Text = langage.GestionTournoiRechercherFR;
                label3.Text = langage.GestionTournoiRechercheTFR;
                label9.Text = langage.GestionTournoiNomTFR;
                label15.Text = langage.GestionTournoiPrenomFR;
                label10.Text = langage.GestionTournoiRangFR;
                label11.Text = langage.GestionTournoiEquipeFR;
                button1.Text = langage.GestionTournoiRajouterFR;
                button3.Text = langage.UniBoutonFermerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.GestionTournoiTitreEN;
                label4.Text = langage.GestionTournoiListeEN;
                label2.Text = langage.GestionTournoiRechercherEN;
                label6.Text = langage.GestionTournoiNomTEN;
                label8.Text = langage.GestionTournoiCalendrierEN;
                button2.Text = langage.GestionTournoiRechercherEN;
                bt_RechercheJoueur.Text = langage.GestionTournoiRechercherEN;
                label3.Text = langage.GestionTournoiRechercheTEN;
                label9.Text = langage.GestionTournoiNomTEN;
                label15.Text = langage.GestionTournoiPrenomEN;
                label10.Text = langage.GestionTournoiRangEN;
                label11.Text = langage.GestionTournoiEquipeEN;
                button1.Text = langage.GestionTournoiRajouterEN;
                button3.Text = langage.UniBoutonFermerEN;
            }

            button1.Enabled = false;
            bt_RechercheJoueur.Enabled = false;

            label1.Parent = pictureBox1;
            label10.Parent = pictureBox1;
            label11.Parent = pictureBox1;
            label12.Parent = pictureBox1;
            label13.Parent = pictureBox1;
            label14.Parent = pictureBox1;
            label15.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;

            string sqlstr;
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Tournoi";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        listBox1.Items.Add(Variable.dtrd["NomTournoi"].ToString());
                        //listBox1.Items.Add(enr4);
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

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            bt_RechercheJoueur.Enabled = true;
            string sqlstr, enr1, enr2, enr3, enr4;
            listBox2.Items.Clear();
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Tournoi where NomTournoi='"+textBox1.Text+"'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomTournoi"].ToString();
                        enr2 = Variable.dtrd["Type"].ToString();
                        enr3 = Variable.dtrd["Calendrier"].ToString();
                        Variable.RangeID = Variable.dtrd["N°"].ToString();

                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }
                        label14.Text = enr1;
                        label13.Text = enr2;
                        label12.Text = enr3;
                    }
                }
            }
            catch (Exception ex) {}

            
            try
            {
                string sqlstr2, enr11, enr22, enr33, enr44;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr2 = "select * from Participants where Flag =" + Convert.ToInt32(Variable.RangeID);
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr2;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr11 = Variable.dtrd["Nom"].ToString();
                        enr22 = Variable.dtrd["Prénom"].ToString();
                        enr33 = Variable.dtrd["Rang"].ToString();
                        enr44 = Variable.dtrd["Equipe"].ToString();
                        listBox2.Items.Add(enr22);
                        tb_Nom.Text = enr11;
                        tb_Prénom.Text = enr22;
                        tb_Rang.Text = enr33;
                        tb_Equipe.Text = enr44;
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

        private void tb_Nom_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Nom_Click(object sender, EventArgs e)
        {
            tb_Equipe.Clear();
            tb_Nom.Clear();
            tb_Prénom.Clear();
            tb_Rang.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nbm;

            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "insert into Participants(Nom,Prénom,Rang,Flag,Equipe) values('" + tb_Nom.Text + "','" + tb_Prénom.Text + "','" + tb_Rang.Text + "'," + Convert.ToInt32(Variable.RangeID) + ",'" + tb_Equipe.Text + "')";
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {}
            tb_Equipe.Clear();
            tb_Nom.Clear();
            tb_Prénom.Clear();
            tb_Rang.Clear();

            Variable.conn.Close();

            try
            {
                listBox2.Items.Clear();
                string enr1, sqlstr;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select* from Participants where Flag = " + Convert.ToInt32(Variable.RangeID);
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        listBox2.Items.Add(Variable.dtrd["Prénom"].ToString());                        
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
            catch (Exception ex) {}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void bt_RechercheJoueur_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstr2, enr11, enr22, enr33, enr44;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr2 = "select * from Participants where Prénom ='" + textBox2.Text+"'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr2;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr11 = Variable.dtrd["Nom"].ToString();
                        enr22 = Variable.dtrd["Prénom"].ToString();
                        enr33 = Variable.dtrd["Rang"].ToString();
                        enr44 = Variable.dtrd["Equipe"].ToString();
                        tb_Nom.Text = enr11;
                        tb_Prénom.Text = enr22;
                        tb_Rang.Text = enr33;
                        tb_Equipe.Text = enr44;
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
            catch (Exception ex) {}
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = listBox2.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
