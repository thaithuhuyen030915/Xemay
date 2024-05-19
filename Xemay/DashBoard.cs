using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xemay
{
    public partial class DashBoard : Form
    {
        bool home3;
        bool home2;
        bool home1;
        public DashBoard()
        {
            InitializeComponent();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (home3)
            {
                HomeContainer3.Height += 10;
                HomeContainer3.Height += 10;
                if (HomeContainer3.Height == HomeContainer3.MaximumSize.Height && HomeContainer3.Height == HomeContainer3.MaximumSize.Height)
                {
                    home3 = false;
                    timer3.Stop();
                }
            }
            else
            {
                HomeContainer3.Height -= 10;
                HomeContainer3.Height -= 10;
                if (HomeContainer3.Height == HomeContainer3.MinimumSize.Height && HomeContainer3.Height == HomeContainer3.MinimumSize.Height)
                {
                    home3 = true;
                    timer3.Stop();
                }
            }
        }

        private void DanhMuc_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (home2)
            {
                HomeContainer2.Height += 10;
                HomeContainer2.Height += 10;
                if (HomeContainer2.Height == HomeContainer2.MaximumSize.Height && HomeContainer2.Height == HomeContainer2.MaximumSize.Height)
                {
                    home2 = false;
                    timer2.Stop();
                }
            }
            else
            {
                HomeContainer2.Height -= 10;
                HomeContainer2.Height -= 10;
                if (HomeContainer2.Height == HomeContainer2.MinimumSize.Height && HomeContainer2.Height == HomeContainer2.MinimumSize.Height)
                {
                    home2 = true;
                    timer2.Stop();
                }
            }
        }
        private bool isFirstClick = true;
        private void admin_Click(object sender, EventArgs e)
        {

            if (isFirstClick)
            {
                next1.Visible = true;
                Down1.Visible = false;
            }
            else
            {
                next1.Visible = false;
                Down1.Visible = true;
            }

            // Đảo ngược trạng thái của isFirstClick
            isFirstClick = !isFirstClick;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (home1)
            {
                HomeContainner1.Height += 10;
                HomeContainner1.Height += 10;
                if (HomeContainner1.Height == HomeContainner1.MaximumSize.Height && HomeContainner1.Height == HomeContainner1.MaximumSize.Height)
                {
                    home1 = false;
                    timer1.Stop();
                }
            }
            else
            {
                HomeContainner1.Height -= 10;
                HomeContainner1.Height -= 10;
                if (HomeContainner1.Height == HomeContainner1.MinimumSize.Height && HomeContainner1.Height == HomeContainner1.MinimumSize.Height)
                {
                    home1 = true;
                    timer1.Stop();
                }
            }
        }
        private bool isTwoClick = true;
        private void QuanLy_Click(object sender, EventArgs e)
        {
            if (isTwoClick)
            {
                next2.Visible = true;
                down2.Visible = false;
            }
            else
            {
                next2.Visible = false;
                down2.Visible = true;
            }

            // Đảo ngược trạng thái của isFirstClick
            isTwoClick = !isTwoClick;

            timer2.Start();
        }
    }
}
