using QUANLYPHONGKHAM;
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
    public partial class ManHinhChinh : Form
    {
        NhanVien nhanVienLocal = new NhanVien();
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        public ManHinhChinh(NhanVien nhanVien) //:this()
        {
            InitializeComponent();
            nhanVienLocal = nhanVien;
            quảnLýThuốcToolStripMenuItem.Text = nhanVien.Hoten.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien nhanVienForm = new QuanLyNhanVien();
            nhanVienForm.ShowDialog();
            nhanVienForm = null;
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            BienLaiThuTien danhMucDichVu = new BienLaiThuTien();
            danhMucDichVu.ShowDialog();
            danhMucDichVu = null;
            this.Show();
        }

       


        private void btnThuTien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
            thongKe = null;
            this.Show();
        }

        private void btnQLPhieuKham_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSKhamChuaBenh phieuKham = new DSKhamChuaBenh();
            phieuKham.ShowDialog();
            phieuKham = null;
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void tiếpNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DANHSACHBENHNHAN dANHSACHBENHNHAN = new DANHSACHBENHNHAN(nhanVienLocal);
            dANHSACHBENHNHAN.ShowDialog();
            dANHSACHBENHNHAN = null;
            this.Show();



        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.ShowDialog();
            quanLyNhanVien = null;
            this.Show();
        }

        private void lớpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LopThuoc lopThuoc = new LopThuoc();
            lopThuoc.ShowDialog();
            lopThuoc = null;
            this.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thuoc thuoc = new Thuoc();
            thuoc.ShowDialog();
            thuoc = null;
        }

        private void loạiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiDichVu loaiDichVu = new LoaiDichVu();
            loaiDichVu.ShowDialog();
            loaiDichVu = null;
            this.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DichVu dichVu = new DichVu();
            dichVu.ShowDialog();
            dichVu = null;
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
            thongKe = null;
            this.Show();

        }

        private void khámChửaBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSKhamChuaBenh dSKhamChuaBenh = new DSKhamChuaBenh();
            dSKhamChuaBenh.ShowDialog();
            
            
             dSKhamChuaBenh = null;
            this.Show();



        }

       

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(nhanVienLocal);
            thongTinCaNhan.ShowDialog();
            //thongTinCaNhan = null;
            this.Show();
        }
    }
}
