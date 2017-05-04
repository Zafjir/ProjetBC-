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
    public partial class PageAccueil_Archives : Form
    {
        public PageAccueil_Archives()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PageAccueil_Archives_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.CloreTournoiTitreFR;
                label4.Text = langage.CloreTournoiTournoiListeFR;
                label2.Text = langage.CloreTournoiRechercheFR;
                label6.Text = langage.CloreTournoiNomTFR;
                label8.Text = langage.CloreTournoiCalendrierFR;
                button2.Text = langage.UniBoutonFermerFR;
                button3.Text = langage.CloreTournoiBTArchivesFR;
                button4.Text = langage.CloreTournoiBTCloreFR;
                label3.Text = langage.CloreTournoiPointsFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.CloreTournoiTitreEN;
                label4.Text = langage.CloreTournoiTournoiListeEN;
                label2.Text = langage.CloreTournoiRechercheEN;
                label6.Text = langage.CloreTournoiNomTEN;
                label8.Text = langage.CloreTournoiCalendrierEN;
                button2.Text = langage.UniBoutonFermerEN;
                button3.Text = langage.CloreTournoiBTArchivesEN;
                button4.Text = langage.CloreTournoiBTCloreEN;
                label3.Text = langage.CloreTournoiPointsEN;
            }

            label1.Parent = pictureBox1;
            label12.Parent = pictureBox1;
            label13.Parent = pictureBox1;
            label14.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            try
            {
                string sqlstr;
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
            textBox1.Text = listBox1.SelectedItem.ToString();
            string sqlstr, enr1, enr2, enr3;
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Tournoi where NomTournoi='" + textBox1.Text + "'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomTournoi"].ToString();
                        enr2 = Variable.dtrd["Type"].ToString();
                        enr3 = Variable.dtrd["Calendrier"].ToString();
                        Variable.RangeID2 = Variable.dtrd["N°"].ToString();

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
            catch (Exception ex) { }

            listBox3.Items.Clear();
            try
            {
                string sqlstr2, enr11, enr22, enr33, enr44;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr2 = "select distinct Equipe from Participants where Flag =" + Convert.ToInt32(Variable.RangeID2);
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr2;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr44 = Variable.dtrd["Equipe"].ToString();
                        listBox3.Items.Add(enr44);
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

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = listBox3.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(label9.Text + " -> " + textBox2.Text);

            int nbm;
            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "insert into Résultats(Equipe,Score,NumType,NomTournoi) values('" + label9.Text + "','" + textBox2.Text + "','" + Convert.ToInt32(Variable.RangeID2) + "','" + textBox1.Text +"')";
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            Variable.conn.Close();
            textBox2.Clear();
            if (listBox2.Items.Count == listBox3.Items.Count)
            {
                button1.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variable.listing++;
            int nbm;
            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "delete * from Tournoi where N°=" + Convert.ToInt32(Variable.RangeID2);
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            Variable.conn.Close();

            int nbm2;
            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "delete * from Participants where Flag =" + Convert.ToInt32(Variable.RangeID2);
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm2 = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            Variable.conn.Close();

            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label5.Text = null;
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Archives_Listing Archives_Listing = new Archives_Listing();
            Archives_Listing.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
