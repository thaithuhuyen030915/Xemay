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
    public partial class FormDSSP : Form
    {
        bool home3;
        bool home2;
        bool home1;
        bool sliderExpand;
        public FormDSSP()
        {
            InitializeComponent();
        }

        private void DanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton19_Click(object sender, EventArgs e)
        {

        }

        private void OpenImg_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                    txtDuongDan.Text = imageLocation;


                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (home1)
            {
                HomeContainer1.Height += 10;
                HomeContainer1.Height += 10;
                if (HomeContainer1.Height == HomeContainer1.MaximumSize.Height && HomeContainer1.Height == HomeContainer1.MaximumSize.Height)
                {
                    home1 = false;
                    timer1.Stop();
                }
            }
            else
            {
                HomeContainer1.Height -= 10;
                HomeContainer1.Height -= 10;
                if (HomeContainer1.Height == HomeContainer1.MinimumSize.Height && HomeContainer1.Height == HomeContainer1.MinimumSize.Height)
                {
                    home1 = true;
                    timer1.Stop();
                }
            }
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
        private bool isFirstClick = true;
        private void DanhMuc_Click_1(object sender, EventArgs e)
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
        private bool isTwoClick = true;
        private void HoaDon_Click(object sender, EventArgs e)
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
        private bool isThreeClick = true;
        private void BaoCao_Click(object sender, EventArgs e)
        {
            if (isThreeClick)
            {
                next3.Visible = true;
                Down3.Visible = false;
            }
            else
            {
                next3.Visible = false;
                Down3.Visible = true;
            }
            isThreeClick = !isThreeClick;

            timer3.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (sliderExpand)
            {
                slidebar.Width -= 10;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    sliderExpand = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                slidebar.Width += 10;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    sliderExpand = true;
                    timerMenu.Stop();
                }
            }
        }

        
        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DanhSachKH();
            form.ShowDialog();
        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormDSSP();
            form.ShowDialog();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new NhaCungCap();
            form.ShowDialog();
        }

        private void guna2GradientButton49_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new HoaDonNhap();
            form.ShowDialog();
        }

        private void guna2GradientButton48_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new HoaDonBanHang();
            form.ShowDialog();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new NhanVien();
            form.ShowDialog();
        }

        private void grabtnnhaphang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BCNhaphang();
            form.ShowDialog();
        }

        private void grabtnbanhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BCBanHang();
            form.ShowDialog();
        }

        private void grabtndoanhthu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new BCDoanhThu();
            form.ShowDialog();
        }

        private void FormDSSP_Load(object sender, EventArgs e)
        {

        }

    }
}
