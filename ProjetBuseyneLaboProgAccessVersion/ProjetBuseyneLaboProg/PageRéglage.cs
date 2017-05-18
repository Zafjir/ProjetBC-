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
    public partial class PageRéglage : Form
    {
        public PageRéglage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PageRéglage_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
        }

        private void bt_createAccount_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Français")
            {
                Variable.langue = 0;
            }
            if (comboBox1.Text == "Anglais")
            {
                Variable.langue = 1;
            }
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Variable.langue == 0)
            {
                label1.Text = langage.ReglageTitreFR;
                label2.Text = langage.ReglageLangueFR;
                button1.Text = langage.UniBoutonFermerFR;
                bt_createAccount.Text = langage.UniConfirmerFR;
            }
            if (Variable.langue == 1)
            {
                label1.Text = langage.ReglageTitreEN;
                label2.Text = langage.ReglageLangueEN;
                button1.Text = langage.UniBoutonFermerEN;
                bt_createAccount.Text = langage.UniConfirmerEN;
            }
        }
    }
}
