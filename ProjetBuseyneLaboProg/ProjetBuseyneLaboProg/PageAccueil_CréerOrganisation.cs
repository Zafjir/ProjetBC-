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
    public partial class PageAccueil_CréerOrganisation : Form
    {
        public PageAccueil_CréerOrganisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_createAccount_Click(object sender, EventArgs e)
        {
            if (tb_nomOrganisation.Text == "" || tb_nomResponsable.Text == "" || tb_email.Text == "" || tb_description.Text == "")
            {
                MessageBox.Show("Manque d'informations", "Erreur");
            }
            else {
                /* int nbm;

                 if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

                 Variable.cmd.CommandText = "insert into Organisation(Nomorganisation,Description,Nomresponsable,Email) values('" + tb_nomOrganisation.Text + "','" + tb_description.Text + "','" + tb_nomResponsable.Text + "','" + tb_email.Text + "')";
                 Variable.cmd.Connection = Variable.conn;
                 try
                 {
                     nbm = Variable.cmd.ExecuteNonQuery();
                 }
                 catch (Exception ex)
                 { }

                 Variable.conn.Close();
                 */
                DBAccess qry = new DBAccess();
                qry.qry("insert into Organisation(Nomorganisation,Description,Nomresponsable,Email) values('" + tb_nomOrganisation.Text + "','" + tb_description.Text + "','" + tb_nomResponsable.Text + "','" + tb_email.Text + "')");
                MessageBox.Show("Organisation créée.");
                tb_nomOrganisation.Clear();
                tb_nomResponsable.Clear();
                tb_email.Clear();
                tb_description.Clear();
                this.Close();
            }
        }

        private void PageAccueil_CréerOrganisation_Load(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.CreerOrgaTitreFR;
                label3.Text = langage.CreerOrgaNomFR;
                label5.Text = langage.CreerOrgaNomRespFR;
                bt_confirmOrganisation.Text = langage.UniConfirmerFR;
                button1.Text = langage.UniBoutonFermerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.CreerOrgaTitreEN;
                label3.Text = langage.CreerOrgaNomEN;
                label5.Text = langage.CreerOrgaNomRespEN;
                bt_confirmOrganisation.Text = langage.UniConfirmerEN;
                button1.Text = langage.UniBoutonFermerEN;
            }
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
