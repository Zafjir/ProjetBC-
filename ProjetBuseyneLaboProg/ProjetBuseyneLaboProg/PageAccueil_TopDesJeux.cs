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
            if (Variable.langue == 0)
            {
                label2.Text = langage.TopDesJeuxTitreFR;
                button1.Text = langage.UniBoutonFermerFR; 
            }
            if (Variable.langue == 1)
            {
                label2.Text = langage.TopDesJeuxTitreEN;
                button1.Text = langage.UniBoutonFermerEN;
            }

            groupBox1.Parent = pictureBox2;
            lb_Description.Parent = pictureBox2;
            lb_NomJeu.Parent = pictureBox2;
            //lb_Top1.Parent = pictureBox2;
            //lb_Top2.Parent = pictureBox2;
            //lb_Top3.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            lb_RésuméJeu.Parent = pictureBox2;

            lb_Top1.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Bold);
            lb_Top2.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            lb_Top3.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);

            string sqlstr, enr1, enr2, enr3, enr4;

            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from TopDesJeux where Range='1'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomJeu"].ToString();
                        enr2 = Variable.dtrd["Description"].ToString();
                        enr3 = Variable.dtrd["RésuméJeu"].ToString();

                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }
                        lb_NomJeu.Text = enr1;
                        lb_Description.Text = enr2;
                        lb_RésuméJeu.Text = enr3;
                    }
                }
            }
            catch (Exception ex) { }

            lb_Top1.Text = "League Of Legends";
            lb_Top2.Text = "Counter Strike GO";
            lb_Top3.Text = "Hearthstone";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_Top1_Click(object sender, EventArgs e)
        {
            lb_Top1.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Bold);
            lb_Top2.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            lb_Top3.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            string sqlstr, enr1, enr2, enr3, enr4;
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from TopDesJeux where Range='1'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomJeu"].ToString();
                        enr2 = Variable.dtrd["Description"].ToString();
                        enr3 = Variable.dtrd["RésuméJeu"].ToString();

                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }
                        lb_NomJeu.Text = enr1;
                        lb_Description.Text = enr2;
                        lb_RésuméJeu.Text = enr3;
                        pictureBox1.Image = Properties.Resources.maxresdefault;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void lb_Top2_Click(object sender, EventArgs e)
        {
            lb_Top1.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            lb_Top2.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Bold);
            lb_Top3.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            string sqlstr, enr1, enr2, enr3, enr4;
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from TopDesJeux where Range='2'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomJeu"].ToString();
                        enr2 = Variable.dtrd["Description"].ToString();
                        enr3 = Variable.dtrd["RésuméJeu"].ToString();

                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }
                        lb_NomJeu.Text = enr1;
                        lb_Description.Text = enr2;
                        lb_RésuméJeu.Text = enr3;
                        pictureBox1.Image = Properties.Resources._78eb7dcb0b15_counter_strike_global_offensive_4__2;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void lb_Top3_Click(object sender, EventArgs e)
        {
            lb_Top1.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            lb_Top2.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Regular);
            lb_Top3.Font = new Font("MS Reference Sans Serif", 11, FontStyle.Bold);
            string sqlstr, enr1, enr2, enr3, enr4;
            try
            {
                Variable.conn.Open();
                if (Variable.conn.State == ConnectionState.Open)
                {
                    sqlstr = "select * from TopDesJeux where Range='3'";
                    Variable.cmd.CommandType = CommandType.Text;
                    Variable.cmd.CommandText = sqlstr;
                    Variable.cmd.Connection = Variable.conn;
                    Variable.dtrd = Variable.cmd.ExecuteReader();
                    while (Variable.dtrd.Read())
                    {
                        enr1 = Variable.dtrd["NomJeu"].ToString();
                        enr2 = Variable.dtrd["Description"].ToString();
                        enr3 = Variable.dtrd["RésuméJeu"].ToString();

                        if (Variable.dtrd == null)
                        {
                            Variable.dtrd.Close();
                        }

                        if (Variable.conn.State == ConnectionState.Open)
                        {
                            Variable.conn.Close();
                        }
                        lb_NomJeu.Text = enr1;
                        lb_Description.Text = enr2;
                        lb_RésuméJeu.Text = enr3;
                        pictureBox1.Image = Properties.Resources.facebook_share;
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
