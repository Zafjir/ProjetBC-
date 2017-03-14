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
        int agrandirPage = 0;
        bool itemCree = false;
        Button retourBt = new Button();
        ListBox list = new ListBox();
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
            agrandirPage = 1;
        }

        private void retourBt_Click(object sender, EventArgs e)
        {
            agrandirPage = 2;
        }

        private void PageAccueil_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (agrandirPage == 1)
            {
                if (itemCree==false)
                {
                    list.Size = new Size(420, 300);
                    list.Location = new Point(250, 50);
                    retourBt.Size = new Size(23, 23);
                    retourBt.Location = new Point(157, 337);
                    retourBt.Text = "<";
                    retourBt.Name = "retourBt";
                    retourBt.Click += new EventHandler(retourBt_Click);
                    this.Controls.Add(retourBt);
                    this.Controls.Add(list);
                    itemCree = true;
                }
                if (this.Size.Width < 710&&itemCree==true)
                {
                    retourBt.Visible = true;
                    list.Visible = true;
                    int newWidth = this.Size.Width + 3;
                    this.Size = new Size(newWidth, this.Size.Height);
                    label1.Width = newWidth;
                    label1.Location = new Point(3, 9);
                }
                if (this.Size.Width==709)
                {
                    agrandirPage = 0;
                }
            }

            if (agrandirPage == 2)
            {
                if (this.Size.Width > 253)
                {
                    int newWidth = this.Size.Width - 3;
                    this.Size = new Size(newWidth, this.Size.Height);
                    label1.Width = newWidth;
                    label1.Location = new Point(3, 9);
                    if (this.Size.Width==254)
                    {
                        list.Visible = false;
                        retourBt.Visible = false;
                        label1.Width = 229;
                        agrandirPage = 0;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
