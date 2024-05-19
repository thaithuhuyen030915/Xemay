using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xemay.From
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

     

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DashBoard();
            form.ShowDialog();
        }

        

        private void dangnhap_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
            guna2PictureBox1.Visible = false;
            guna2PictureBox2.Visible = false;
            guna2PictureBox3.Visible = false;
            guna2PictureBox4.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2PictureBox1.Visible == true)
            {
                guna2PictureBox1.Visible = false;
                guna2PictureBox2.Visible = true;
            }
            else if (guna2PictureBox2.Visible == true)
            {
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = true;
            }
            else if (guna2PictureBox3.Visible == true)
            {
                guna2PictureBox3.Visible = false;
                guna2PictureBox4.Visible = true;
            }
            else
            {
                guna2PictureBox4.Visible = false;
                guna2PictureBox1.Visible = true;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
