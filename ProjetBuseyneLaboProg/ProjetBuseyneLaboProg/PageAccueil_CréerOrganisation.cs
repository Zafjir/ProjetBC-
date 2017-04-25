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
            int nbm;

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
            MessageBox.Show("Organisation créée.");
            tb_nomOrganisation.Clear();
            tb_nomResponsable.Clear();
            tb_email.Clear();
            tb_description.Clear();
            this.Close();
        }
    }
}
