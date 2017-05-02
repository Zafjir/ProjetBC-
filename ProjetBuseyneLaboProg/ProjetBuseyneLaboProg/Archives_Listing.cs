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
    public partial class Archives_Listing : Form
    {
        public Archives_Listing()
        {
            InitializeComponent();
        }

        private void Archives_Listing_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label4.Text = langage.ArchivesTournoiFR;
                label2.Text = langage.ArchivesScoresFR;
                label6.Text = langage.ArchivesVainqueurFR;
                button2.Text = langage.UniBoutonFermerFR;
            }
            if (Variable.langue == 1)
            {
                label4.Text = langage.ArchivesTournoiEN;
                label2.Text = langage.ArchivesScoresEN;
                label6.Text = langage.ArchivesVainqueurEN;
                button2.Text = langage.UniBoutonFermerEN;
            }

            label1.Parent = pictureBox1;
            label14.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            
            string sqlstr;
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select distinct NomTournoi from Résultats";
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    
            listBox2.Items.Clear();
            try
            {
                string sqlstr;
                string enr1, enr2;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Résultats where NomTournoi='" + listBox1.SelectedItem.ToString() + "'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["Equipe"].ToString();
                        enr2 = Variable.dtrd["Score"].ToString();
                        listBox2.Items.Add(enr1 + " -> " + enr2);
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

            try
            {
                string sqlstr;
                string enr1, enr2;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Résultats where NomTournoi='" + listBox1.SelectedItem.ToString() + "' order by Score asc";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["Score"].ToString();
                        enr2 = Variable.dtrd["Equipe"].ToString();
                        label14.Text = enr2 + " avec " + enr1 + "points";
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
            this.Close();
        }
    }
}
