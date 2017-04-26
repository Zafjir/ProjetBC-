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
            string sqlstr, enr1, enr2, enr3;
            Variable.listing++;

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
                        enr1 = Variable.dtrd["N°"].ToString();
                        Variable.nbreDeTournoi = enr1;
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


            if (Variable.listing > Convert.ToInt32(Variable.nbreDeTournoi))
            {
                MessageBox.Show("Impossible de monter de nouveau dans la liste de tournois, il n'existe pas plus de tournois.");
                Variable.listing--;
            }
            else
            {
                try
                {
                    Variable.conn.Open();
                    if (Variable.conn.State == ConnectionState.Open)
                    {
                        sqlstr = "select * from Tournoi where N°=" + Variable.listing + "";
                        Variable.cmd.CommandType = CommandType.Text;
                        Variable.cmd.CommandText = sqlstr;
                        Variable.cmd.Connection = Variable.conn;
                        Variable.dtrd = Variable.cmd.ExecuteReader();
                        while (Variable.dtrd.Read())
                        {
                            enr1 = Variable.dtrd["NomTournoi"].ToString();
                            enr2 = Variable.dtrd["Type"].ToString();
                            enr3 = Variable.dtrd["Calendrier"].ToString();
                            lb_NomTournoi.Text = enr1;
                            lb_TypeTournoi.Text = enr2;
                            lb_Date.Text = enr3;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlstr, enr1, enr2, enr3;
            Variable.listing--;
            if (Variable.listing < 4)
            {
                MessageBox.Show("Impossible de descendre de nouveau dans la liste de tournois.");
                Variable.listing++;
            }

            else
            {
                try
                {
                    Variable.conn.Open();
                    if (Variable.conn.State == ConnectionState.Open)
                    {
                        sqlstr = "select * from Tournoi where N°=" + Variable.listing + "";
                        Variable.cmd.CommandType = CommandType.Text;
                        Variable.cmd.CommandText = sqlstr;
                        Variable.cmd.Connection = Variable.conn;
                        Variable.dtrd = Variable.cmd.ExecuteReader();
                        while (Variable.dtrd.Read())
                        {
                            enr1 = Variable.dtrd["NomTournoi"].ToString();
                            enr2 = Variable.dtrd["Type"].ToString();
                            enr3 = Variable.dtrd["Calendrier"].ToString();

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
                        }
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
