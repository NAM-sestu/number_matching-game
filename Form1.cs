using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzel
{
    public partial class Mainframe : Form
    {
        public Mainframe()
        {
            InitializeComponent();
            btn50_1.Location = new Point(new Random().Next(300, 1000)+5, new Random().Next(0, 400)+5);
            btn50_2.Location = new Point(new Random().Next(300,500)+10, new Random().Next(0, 345)+10);
            btn64_1.Location = new Point(new Random().Next(200, 1000)+15, new Random().Next(50, 400)+15);
            btn64_2.Location = new Point(new Random().Next(300, 1000)+20, new Random().Next(200, 440)+20);
            btn79_1.Location = new Point(new Random().Next(600, 1000)+25, new Random().Next(0, 200)+25);
            btn79_2.Location = new Point(new Random().Next(200, 1000)+24, new Random().Next(90, 400)+4);
            btn82_1.Location = new Point(new Random().Next(305, 750)+44, new Random().Next(0,400)+5);
            btn82_2.Location = new Point(new Random().Next(350, 500)+21, new Random().Next(0,200)+12);
            btn99_1.Location = new Point(new Random().Next(380, 1000)+12, new Random().Next(0, 200));
            btn99_2.Location = new Point(new Random().Next(340, 800)+20, new Random().Next(200, 250));
            btn13_1.Location = new Point(new Random().Next(360, 400)+32, new Random().Next(10, 300));
            btn13_2.Location = new Point(new Random().Next(310, 780)+12, new Random().Next(200, 300));
            btn21_1.Location = new Point(new Random().Next(370, 600)+18, new Random().Next(100, 300));
            btn21_2.Location = new Point(new Random().Next(390, 400)+10, new Random().Next(27, 50));
            btn27_1.Location = new Point(new Random().Next(250, 700), new Random().Next(39, 200));
            btn27_2.Location = new Point(new Random().Next(270, 788)+9, new Random().Next(82, 260));
            btn35_1.Location = new Point(new Random().Next(296, 900), new Random().Next(100, 450));
            btn35_2.Location = new Point(new Random().Next(245, 800)+4, new Random().Next(400,420));
            btn43_1.Location = new Point(new Random().Next(194, 450)+7, new Random().Next(59, 380));
            btn43_2.Location = new Point(new Random().Next(300, 575)+8, new Random().Next(50, 100));
            

        }
        string s = "";
        
        private void Btn50_1_Click(object sender, EventArgs e)
        {
            btn50_1.BackColor = Color.Yellow;
            btn50_1.Text = "50";
            int sc = Convert.ToInt32(label1.Text);
            if (s!=btn50_1.Text)
            {
                s = btn50_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = false;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;

                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                
                btn13_1.BackColor= Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn50_1.Visible = false;
                btn50_2.Visible = false;
               
            }
        }

        private void Btn50_2_Click(object sender, EventArgs e)
        {
            btn50_2.BackColor = Color.Yellow;
            btn50_2.Text = "50";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn50_2.Text)
            {
                s = btn50_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = false;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_1.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn50_1.Visible = false;
                btn50_2.Visible = false;

            }
        }

        private void Btn82_1_Click(object sender, EventArgs e)
        {
            btn82_1.BackColor = Color.Yellow;
            btn82_1.Text = "82";
            int sc = Convert.ToInt32(label1.Text);
            
            if (s != btn82_1.Text)
            {
                s = btn82_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = false;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn50_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn82_1.Visible = false;
                btn82_2.Visible = false;

            }
        }

        private void Btn21_1_Click(object sender, EventArgs e)
        {
            btn21_1.BackColor = Color.Yellow;
            btn21_1.Text = "21";
            int sc = Convert.ToInt32(label1.Text);
           
            if (s != btn21_1.Text)
            {
                s = btn21_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = false;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn50_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn21_1.Visible = false;
                btn21_2.Visible = false;

            }
        }

        private void Btn21_2_Click(object sender, EventArgs e)
        {
            btn21_2.BackColor = Color.Yellow;
            btn21_2.Text = "21";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn21_2.Text)
            {
                s = btn21_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = false;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn50_1.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn21_1.Visible = false;
                btn21_2.Visible = false;

            }
        }

        private void Btn82_2_Click(object sender, EventArgs e)
        {
            btn82_2.BackColor = Color.Yellow;
            btn82_2.Text = "82";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn82_2.Text)
            {
                s = btn82_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = false;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn50_1.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn82_2.Visible = false;
                btn82_1.Visible = false;

            }
        }

        private void Btn79_1_Click(object sender, EventArgs e)
        {
            btn79_1.BackColor = Color.Yellow;
            btn79_1.Text = "79";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn79_1.Text)
            {
                s = btn79_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = false;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn50_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn79_1.Visible = false;
                btn79_2.Visible = false;

            }

        }

        private void Btn79_2_Click(object sender, EventArgs e)
        {
            btn79_2.BackColor = Color.Yellow;
            btn79_2.Text = "79";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn79_2.Text)
            {
                s = btn79_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = false;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn50_1.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn13_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn79_1.Visible = false;
                btn79_2.Visible = false;

            }

        }

        private void Btn13_1_Click(object sender, EventArgs e)
        {
            btn13_1.BackColor = Color.Yellow;
            btn13_1.Text = "13";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn13_1.Text)
            {
                s = btn13_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = false;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn13_1.Visible = false;
                btn13_2.Visible = false;

            }
        }

        private void Btn13_2_Click(object sender, EventArgs e)
        {
            btn13_2.BackColor = Color.Yellow;
            btn13_2.Text = "13";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn13_2.Text)
            {
                s = btn13_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = false;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_1.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn13_1.Visible = false;
                btn13_2.Visible = false;

            }
        }

        private void Btn35_1_Click(object sender, EventArgs e)
        {
            btn35_1.BackColor = Color.Yellow;
            btn35_1.Text = "35";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn35_1.Text)
            {
                s = btn35_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = false;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn13_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn35_1.Visible = false;
                btn35_2.Visible = false;

            }
        }

        private void Btn35_2_Click(object sender, EventArgs e)
        {
            btn35_2.BackColor = Color.Yellow;
            btn35_2.Text = "35";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn35_2.Text)
            {
                s = btn35_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = false;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn13_1.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn35_1.Visible = false;
                btn35_2.Visible = false;

            }
        }

        private void Btn99_1_Click(object sender, EventArgs e)
        {
            btn99_1.BackColor = Color.Yellow;
            btn99_1.Text = "99";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn99_1.Text)
            {
                s = btn99_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = false;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn13_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn99_1.Visible = false;
                btn99_2.Visible = false;

            }
        }

        private void Btn99_2_Click(object sender, EventArgs e)
        {
            btn99_2.BackColor = Color.Yellow;
            btn99_2.Text = "99";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn99_2.Text)
            {
                s = btn99_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = false;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn13_1.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn99_1.Visible = false;
                btn99_2.Visible = false;

            }
        }

        private void Btn27_1_Click(object sender, EventArgs e)
        {
            btn27_1.BackColor = Color.Yellow;
            btn27_1.Text = "27";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn27_1.Text)
            {
                s = btn27_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = false;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn13_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn27_1.Visible = false;
                btn27_2.Visible = false;

            }
        }

        private void Btn27_2_Click(object sender, EventArgs e)
        {
            btn27_2.BackColor = Color.Yellow;
            btn27_2.Text = "27";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn27_2.Text)
            {
                s = btn27_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = false;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn13_1.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn27_1.Visible = false;
                btn27_2.Visible = false;

            }
        }

        private void Btn64_1_Click(object sender, EventArgs e)
        {
            btn64_1.BackColor = Color.Yellow;
            btn64_1.Text = "64";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn64_1.Text)
            {
                s = btn64_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = false;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn13_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn64_1.Visible = false;
                btn64_2.Visible = false;
              

            }
        }

        private void Btn64_2_Click(object sender, EventArgs e)
        {
            btn64_2.BackColor = Color.Yellow;
            btn64_2.Text = "64";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn64_2.Text)
            {
                s = btn64_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = false;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn13_1.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn64_1.Visible = false;
                btn64_2.Visible = false;

            }
        }

        private void Btn43_1_Click(object sender, EventArgs e)
        {
            btn43_1.BackColor = Color.Yellow;
            btn43_1.Text = "43";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn43_1.Text)
            {
                s = btn43_1.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = false;
                btn43_2.Enabled = true;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn13_1.Text = "";
                btn43_2.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn43_1.Visible = false;
                btn43_2.Visible = false;

            }
        }

        private void Btn43_2_Click(object sender, EventArgs e)
        {
            btn43_2.BackColor = Color.Yellow;
            btn43_2.Text = "43";
            int sc = Convert.ToInt32(label1.Text);
            if (s != btn43_2.Text)
            {
                s = btn43_2.Text;
                sc = sc - 10;
                label1.Text = sc.ToString();
                btn13_1.Enabled = true;
                btn13_2.Enabled = true;
                btn21_1.Enabled = true;
                btn21_2.Enabled = true;
                btn27_1.Enabled = true;
                btn27_2.Enabled = true;
                btn35_1.Enabled = true;
                btn35_2.Enabled = true;
                btn43_1.Enabled = true;
                btn43_2.Enabled = false;
                btn50_1.Enabled = true;
                btn50_2.Enabled = true;
                btn64_1.Enabled = true;
                btn64_2.Enabled = true;
                btn79_1.Enabled = true;
                btn79_2.Enabled = true;
                btn82_1.Enabled = true;
                btn82_2.Enabled = true;
                btn99_1.Enabled = true;
                btn99_2.Enabled = true;
                btn50_2.Text = "";
                btn64_1.Text = "";
                btn64_2.Text = "";
                btn79_1.Text = "";
                btn79_2.Text = "";
                btn82_1.Text = "";
                btn82_2.Text = "";
                btn99_1.Text = "";
                btn99_2.Text = "";
                btn50_1.Text = "";
                btn13_2.Text = "";
                btn21_1.Text = "";
                btn21_2.Text = "";
                btn27_1.Text = "";
                btn27_2.Text = "";
                btn35_1.Text = "";
                btn35_2.Text = "";
                btn43_1.Text = "";
                btn13_1.Text = "";
                btn79_1.BackColor = Color.FromArgb(0, 0, 64);
                btn13_2.BackColor = Color.FromArgb(0, 0, 64);
                btn21_1.BackColor = Color.FromArgb(0, 0, 64);
                btn21_2.BackColor = Color.FromArgb(0, 0, 64);
                btn27_1.BackColor = Color.FromArgb(0, 0, 64);
                btn27_2.BackColor = Color.FromArgb(0, 0, 64);
                btn13_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_2.BackColor = Color.FromArgb(0, 0, 64);
                btn43_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_2.BackColor = Color.FromArgb(0, 0, 64);
                btn50_2.BackColor = Color.FromArgb(0, 0, 64);
                btn64_1.BackColor = Color.FromArgb(0, 0, 64);
                btn64_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_2.BackColor = Color.FromArgb(0, 0, 64);
                btn79_2.BackColor = Color.FromArgb(0, 0, 64);
                btn82_1.BackColor = Color.FromArgb(0, 0, 64);
                btn50_1.BackColor = Color.FromArgb(0, 0, 64);
                btn35_1.BackColor = Color.FromArgb(0, 0, 64);
                btn99_1.BackColor = Color.FromArgb(0, 0, 64);
            }
            else
            {
                btn43_1.Visible = false;
                btn43_2.Visible = false;

            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Mainframe nw = new Mainframe();
            nw.Visible = true;
            this.Visible = false;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
