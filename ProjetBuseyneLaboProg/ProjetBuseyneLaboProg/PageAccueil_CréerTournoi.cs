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
            int nbm;

            if (Variable.conn.State == ConnectionState.Closed) { Variable.conn.Open(); }

            Variable.cmd.CommandText = "insert into Tournoi(NomTournoi,Type,Calendrier) values('" + tb_nomTournoi.Text + "','" + tb_typeTournoi.Text + "','" + cl_calendrierTournoi.SelectionEnd.Date.ToString() + "')";
            Variable.cmd.Connection = Variable.conn;
            try
            {
                nbm = Variable.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

            Variable.conn.Close();
            MessageBox.Show("Tournoi créée.");
            tb_nomTournoi.Clear();
            tb_typeTournoi.Clear();
            this.Close();
        }
    }
}
