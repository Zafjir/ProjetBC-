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
    public partial class PageAccueil : Form
    {
        bool agrandirPage = false;
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agrandirPage = true;
        }

        private void PageAccueil_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (agrandirPage==true)
            {
                int h = 254;
                int x = 3;
                while (h < 710)
                {
                    h++;
                    this.Width = h;
                }
                agrandirPage = false;

                
                ListBox list = new ListBox();
                list.Size = new Size(300, 300);
                list.Location = new Point(250, 50);

                this.Controls.Add(list);
            }
        }
    }
}
