using Microsoft.VisualBasic.ApplicationServices;
using QUANLYPHONGKHAM.BUS;
using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGKHAM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtTaiKhoan.Text = null;
            txtMatKhau.Text = null;
            ckbHienMatKhau.Checked = false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = new NhanVienBUS().getInfoByAccount(txtTaiKhoan.Text, txtMatKhau.Text);
            bool result = new NhanVienBUS().KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);

            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (taiKhoan.Trim() == "")
            {
                MessageBox.Show("Hay nhap tai khoan");
                return;
            }
            if (matKhau.Trim() == "")
            {
                MessageBox.Show("Hay nhap mat khau");
                return;
            }
            if (result == true)
            {
                this.Hide();
                MessageBox.Show("Xin Chào " + nhanViens[0].Hoten);
                ManHinhChinh manHinhChinh = new ManHinhChinh(nhanViens[0]);
                manHinhChinh.ShowDialog();
                manHinhChinh = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Lỗi Đăng Nhập, hãy xem lại bạn có sai sót ở đâu hay không?");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
