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
    public partial class ThongTinCaNhan : Form
    {
        NhanVien nhanVienLocal = new NhanVien();
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        public ThongTinCaNhan(NhanVien nv)
        {
            InitializeComponent();
            nhanVienLocal = nv;

            txtMaNV.Text = nv.MaNV.ToString();
            lblTenNV.Text= nv.Hoten.ToString();
            txthoten.Text = nv.Hoten.ToString();
            dtpNgaySinh.Text = nv.Ngaysinh.ToString();
            cbbgioiTinh.Text = nv.Gioitinh.ToString();
            txtdiaChi.Text = nv.Diachi.ToString();
            txttaikhoan.Text = nv.Taikhoan.ToString();
            txtmatkhau.Text = nv.Matkhau.ToString();
            txtcccd.Text = nv.CCCD.ToString();
            cbbchucVu.Text = nv.Chucvu.ToString();
            dtpngayLam.Text = nv.Ngayvaolam.ToString();
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\HinhAnhNVien\";
            string tenAnh = nv.HinhAnh;
            string pathImage = Path.Combine(appPath, tenAnh);
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            if (File.Exists(pathImage))
            {
                try
                {
                    pbHinhAnhNV.Image = new Bitmap(pathImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Đường dẫn ảnh: " + pathImage + " này không tìm được");
            }

        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
