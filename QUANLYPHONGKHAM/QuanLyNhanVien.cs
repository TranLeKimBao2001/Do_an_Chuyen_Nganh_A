﻿using Microsoft.VisualBasic.ApplicationServices;
using QUANLYPHONGKHAM.BUS;
using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLYPHONGKHAM
{
    public partial class QuanLyNhanVien : Form
    {
        string anhCu = "";
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadDataUser();
        }


        public void CauHinnhData()
        {
            //dgvDSNhanVien.Columns[4].Visible = false;

            dgvDSNhanVien.Columns[0].HeaderText = "Mã Nhân viên";
            dgvDSNhanVien.Columns[1].HeaderText = "Tài khoản";
            dgvDSNhanVien.Columns[2].HeaderText = "Mật khẩu";

            dgvDSNhanVien.Columns[3].HeaderText = "Họ tên";
            dgvDSNhanVien.Columns[4].HeaderText = "Hình ảnh";

            dgvDSNhanVien.Columns[5].HeaderText = "Giói tính";

            dgvDSNhanVien.Columns[6].HeaderText = "Địa chỉ";
            dgvDSNhanVien.Columns[7].HeaderText = "Ngày vào làm";
            dgvDSNhanVien.Columns[8].HeaderText = "CCCD";

            dgvDSNhanVien.Columns[9].HeaderText = "Chức vụ";
            dgvDSNhanVien.Columns[10].HeaderText = "Ngày sinh";


        }
        public void LoadDataUser()
        {
            List<NhanVien> nv = new NhanVienBUS().getAllNhanViens();
            dgvDSNhanVien.DataSource = nv;
            CauHinnhData();

        }


        public void UploadAnhChoNhanVien()
        {

            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\HinhAnhNVien\";  // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;
                    txthinhanh.Text = opFile.SafeFileName;// <---
                    string filepath = opFile.FileName;    // <---
                    pbhinhAnhNV.Image = null;
                    pbhinhAnhNV.Image = new Bitmap(opFile.OpenFile());
                    File.Copy(filepath, appPath + iName);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error: {e.Message}");
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
        public void XoaAnhCu(string tenAnh)
        {
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\HinhAnhNVien\";
            string duongDanHinhAnh = Path.Combine(appPath, tenAnh);
            if (File.Exists(duongDanHinhAnh))
            {
                try
                {
                    pbhinhAnhNV.Image.Dispose();
                    File.Delete(duongDanHinhAnh);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa hình ảnh: " + ex);
                }
            }
        }
        public void ClearData()
        {
            txtMaNV.Text = "";
            txthoten.Text = "";
            txtdiaChi.Text = "";
            txttaiKhoan.Text = "";
            txtmatKhau.Text = "";
            txtCCCD.Text = "";
            txthinhanh.Text = "";
            pbhinhAnhNV.Image = null;
            cbbchucVu.SelectedIndex = 0;
            cbbgioiTinh.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoaiDichVu loaiDichVu = new LoaiDichVu();
            loaiDichVu.Show();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        private void btnQLLichLam_Click(object sender, EventArgs e)
        {
            LoaiDichVu lichLamViec = new LoaiDichVu();
            lichLamViec.Show();
            this.Close();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            ManHinhChinh mainFrom = new ManHinhChinh();
            mainFrom.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            if (txthinhanh.Text == "")
            {
                UploadAnhChoNhanVien();
            }
            else
            {
                anhCu = txthinhanh.Text;
                UploadAnhChoNhanVien();
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvDSNhanVien.CurrentRow.Selected = true;

            txtMaNV.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txthoten.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
            dtpngaySinh.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["ngaySinh"].Value.ToString();
            cbbgioiTinh.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["gioiTinh"].Value.ToString();
            txtdiaChi.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["diaChi"].Value.ToString();
            txttaiKhoan.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["taiKhoan"].Value.ToString();
            txtmatKhau.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["matKhau"].Value.ToString();
            txtCCCD.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
            cbbchucVu.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["chucVu"].Value.ToString();
            txthinhanh.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["hinhAnh"].Value.ToString();
            dtpNgayvaolam.Text = dgvDSNhanVien.Rows[e.RowIndex].Cells["ngayVaoLam"].Value.ToString();
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\HinhAnhNVien\";
            string tenAnh = txthinhanh.Text;
            string pathImage = Path.Combine(appPath, tenAnh);
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            if (File.Exists(pathImage))
            {
                try
                {
                    pbhinhAnhNV.Image = new Bitmap(pathImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Đường dẫn ảnh: " + pathImage + " này không tìm thấy");
            }
            pbhinhAnhNV.Image = Image.FromFile(pathImage);

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            DateTime selectedDate = dtpngaySinh.Value;
            DateTime ngayVaoLam = dtpNgayvaolam.Value;
            if (txthoten.Text.Length == 0)
            {
                MessageBox.Show("Nhap ten nguoi dung!");
                return;
            }
            if (txtdiaChi.Text.Length == 0)
            {
                MessageBox.Show("Nhap DC!");
                return;
            }
            if (txttaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Nhap tai khoan !");
                return;
            }
            if (txtmatKhau.Text.Length == 0)
            {
                MessageBox.Show("Nhap nat khau!");
                return;
            }
            if (txtCCCD.Text.Length == 0)
            {
                MessageBox.Show("Nhap CCCD!");
                return;

            }
            if (pbhinhAnhNV.Image == null)
            {
                MessageBox.Show("Chon hinh anh !");
                return;

            }

            if (txtMaNV.Text == "")
            {
                NhanVien nv = new NhanVien()
                {
                    MaNV = 0,
                    Hoten = txthoten.Text,
                    Ngaysinh = DateTime.Parse(selectedDate.ToString()),
                    Gioitinh = cbbgioiTinh.Text,
                    Diachi = txtdiaChi.Text,
                    Taikhoan = txttaiKhoan.Text,
                    Matkhau = txtmatKhau.Text,
                    CCCD = txtCCCD.Text,
                    Chucvu = cbbchucVu.Text,
                    HinhAnh = txthinhanh.Text,
                    Ngayvaolam = DateTime.Parse(ngayVaoLam.ToString()),
                };
                bool result2 = new NhanVienBUS().AddNewUser(nv);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Thêm Xong.");
                        QuanLyNhanVien_Load(sender, e);
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Them that bai do " + ex);
                        QuanLyNhanVien_Load(sender, e);
                    }
                }
            }
        }
        private void XoaHinhAnhNhanVien(string tenAnh)
        {
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\HinhAnhNVien\";
            string duongDanHinhAnh = Path.Combine(appPath, tenAnh);
            if (File.Exists(duongDanHinhAnh))
            {
                try
                {
                    File.Delete(duongDanHinhAnh);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa hình ảnh: " + ex.Message);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvDSNhanVien.CurrentRow.Index;
            string message = "Are you sure Delete this item?";
            string title = "Delete Producer!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string nameImgSP = dgvDSNhanVien.Rows[i].Cells[9].Value.ToString();

                bool result2 = new NhanVienBUS().DeleteUser(Int32.Parse(dgvDSNhanVien.Rows[i].Cells[0].Value.ToString()));
                if (result2)
                {
                    XoaHinhAnhNhanVien(nameImgSP);
                    LoadDataUser();
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadDataUser();
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpngaySinh.Value;
            DateTime ngayVaoLam = dtpNgayvaolam.Value;

            if (dgvDSNhanVien.SelectedRows.Count > 0)
            {
                NhanVien nv = new NhanVien()
                {
                    MaNV = Int32.Parse(txtMaNV.Text.ToString()),
                    Hoten = txthoten.Text,
                    Ngaysinh = DateTime.Parse(selectedDate.ToString()),
                    Gioitinh = cbbgioiTinh.Text,
                    Diachi = txtdiaChi.Text,
                    Taikhoan = txttaiKhoan.Text,
                    Matkhau = txtmatKhau.Text,
                    CCCD = txtCCCD.Text,
                    Chucvu = cbbchucVu.Text,
                    HinhAnh = txthinhanh.Text,
                    Ngayvaolam = DateTime.Parse(ngayVaoLam.ToString()),
                };
                bool result2 = new NhanVienBUS().UpdateUser(nv);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Cập Nhật Xong.");
                        QuanLyNhanVien_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật không thành công do " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để thao tác");
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpngaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthoten.Text))
            {
                errorProvider1.SetError(txthoten, "Họ tên không được để trống!");
            }
            else if (txthoten.Text.Length < 3)
            {
                errorProvider1.SetError(txthoten, "Họ tên phải có ít nhất 3 ký tự!");
            }
            else if (Regex.IsMatch(txthoten.Text, @"\d"))
            {
                errorProvider1.SetError(txthoten, "Họ tên không được chứa số!");
            }
            else
            {
                errorProvider1.SetError(txthoten, "");
            }
        }

        private void txttaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttaiKhoan.Text))
            {
                errorProvider1.SetError(txttaiKhoan, "Tài khoản không được để trống!");
            }
            else if (txttaiKhoan.Text.Length < 6 || txttaiKhoan.Text.Length > 24)
            {
                errorProvider1.SetError(txttaiKhoan, "Tài khoản phải có từ 6 đến 24 ký tự!");
            }
            else if (!Regex.IsMatch(txttaiKhoan.Text, @"^[a-zA-Z0-9]+$"))
            {
                errorProvider1.SetError(txttaiKhoan, "Tài khoản chỉ được chứa chữ cái và số!");
            }
            else
            {
                errorProvider1.SetError(txttaiKhoan, "");
            }
        }

        private void txtmatKhau_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmatKhau.Text))
            {
                errorProvider1.SetError(txtmatKhau, "Mật khẩu không được để trống!");
            }
            else if (txtmatKhau.Text.Length < 6 || txtmatKhau.Text.Length > 24)
            {
                errorProvider1.SetError(txtmatKhau, "Mật khẩu phải có từ 6 đến 24 ký tự!");
            }
            else if (!Regex.IsMatch(txtmatKhau.Text, @"^[a-zA-Z0-9]+$"))
            {
                errorProvider1.SetError(txtmatKhau, "Mật khẩu chỉ được chứa chữ cái và số!");
            }
            else if (txtmatKhau.Text.Any(char.IsWhiteSpace))
            {
                errorProvider1.SetError(txtmatKhau, "Mật khẩu không được chứa khoảng trắng!");
            }
            else
            {
                errorProvider1.SetError(txtmatKhau, "");
            }
        }


    }
}
