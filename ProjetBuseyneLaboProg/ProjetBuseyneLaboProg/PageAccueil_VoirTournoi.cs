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
    public partial class PageAccueil_VoirTournoi : Form
    {
        public PageAccueil_VoirTournoi()
        {
            InitializeComponent();
        }

        private void PageAccueil_VoirTournoi_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.VoirTournoiTitreFR;
                label2.Text = langage.VoirTournoiNomTFR;
                label3.Text = langage.VoirTournoiTypeTFR;
                label5.Text = langage.VoirTournoiListeFR;
                button3.Text = langage.UniBoutonFermerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.VoirTournoiTitreEN;
                label2.Text = langage.VoirTournoiNomTEN;
                label3.Text = langage.VoirTournoiTypeTEN;
                label5.Text = langage.VoirTournoiListeEN;
                button3.Text = langage.UniBoutonFermerEN;
            }

            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            lb_Date.Parent = pictureBox1;
            lb_NomTournoi.Parent = pictureBox1;
            lb_TypeTournoi.Parent = pictureBox1;
            lb_TypeTournoi.ForeColor = Color.White;
            lb_TypeTournoi.BackColor = Color.Transparent;
            lb_NomTournoi.ForeColor = Color.White;
            lb_NomTournoi.BackColor = Color.Transparent;
            lb_Date.ForeColor = Color.White;
            lb_Date.BackColor = Color.Transparent;

            string sqlstr, enr1, enr2, enr3, enr4;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Tournoi where N°="+Variable.listing+"";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomTournoi"].ToString();
                        enr2 = Variable.dtrd["Type"].ToString();
                        enr3 = Variable.dtrd["Calendrier"].ToString();
                        enr4 = Variable.dtrd["OrgaResponsable"].ToString();

                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }

                        lb_NomTournoi.Text = enr1;
                        lb_TypeTournoi.Text = enr2;
                        lb_Date.Text = enr3;
                        label7.Text = enr4;
                    }
                }
            }catch (Exception ex) { }

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlstr, enr1, enr2, enr3, enr4;
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from Tournoi where NomTournoi ='" + listBox1.SelectedItem.ToString() + "'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomTournoi"].ToString();
                        enr2 = Variable.dtrd["Type"].ToString();
                        enr3 = Variable.dtrd["Calendrier"].ToString();
                        enr4 = Variable.dtrd["OrgaResponsable"].ToString();
                        lb_NomTournoi.Text = enr1;
                        lb_TypeTournoi.Text = enr2;
                        lb_Date.Text = enr3;
                        label7.Text = enr4;
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
    }
}
