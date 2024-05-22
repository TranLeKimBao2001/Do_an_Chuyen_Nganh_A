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

namespace QUANLYPHONGKHAM
{
    public partial class DANHSACHBENHNHAN : Form
    {
        NhanVien nv = new NhanVien();
        public DANHSACHBENHNHAN()
        {
            InitializeComponent();
        }

        public DANHSACHBENHNHAN(NhanVien nhanVien)
        {
            nv = nhanVien;
            InitializeComponent();
            txtTenNV.Text = nhanVien.Hoten;
            txtMaNVPKham.Text = nhanVien.MaNV.ToString();

        }
        public void LoadDataUser()
        {
            List<BenhNhan> bn = new BenhNhanBUS().GetAllBenhNhans();
            dgvDSBenhNhan.DataSource = bn;
            CauHinnhData();

        }

        public void LoadDataPhieuKham()
        {
            List<PhieuKham> pk = new PhieuKhamBUS().getAllPhieuKhamByYtas();
            dgvDSPhieuKham.DataSource = pk;

        }
        public void CauHinnhData()
        {
            dgvDSBenhNhan.Columns["hoTen"].Width = (int)(0.22 * dgvDSBenhNhan.Width);
            // dgvDSBenhNhan.Columns["tuoi"].Width = (int)(0.1 * dgvDSBenhNhan.Width);
            dgvDSBenhNhan.Columns["sdt"].Width = (int)(0.2 * dgvDSBenhNhan.Width);
            dgvDSBenhNhan.Columns["diaChi"].Width = (int)(0.3 * dgvDSBenhNhan.Width);


            dgvDSBenhNhan.Columns[0].HeaderText = "Mã Bệnh Nhân";
            dgvDSBenhNhan.Columns[1].HeaderText = "Họ tên";
            dgvDSBenhNhan.Columns[2].HeaderText = "Giới tính";

            dgvDSBenhNhan.Columns[3].HeaderText = "Điện thoại";
            //dgvDSBenhNhan.Columns[4].HeaderText = "Tuổi";

            dgvDSBenhNhan.Columns[5].HeaderText = "Địa chỉ";

            dgvDSBenhNhan.Columns[6].HeaderText = "CCCD/CMND";



        }

        public void ClearData()
        {
            txtMaBN.Text = "";
            txthoten.Text = "";
            txtdiaChi.Text = "";
            mtbdienThoai.Text = "";
            txtCCCD.Text = "";

            cbbgioiTinh.SelectedIndex = 0;
            errorPro.Clear();
        }

        public void ClearData2()
        {
            txtMaBNPKham.Text = "";
            rtbLyDoKham.Text = "";
            nbrCanNang.Value = 0;

            errorPro.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgaySinh.Value;
            if (txthoten.Text.Length == 0)
            {
                MessageBox.Show("Nhap ten BENH NHAN!");
                return;
            }


            if (txtdiaChi.Text.Length == 0)
            {
                MessageBox.Show("Nhap DC!");
                return;
            }

            /*  if (mtbdienThoai.Text.Length == 0)
              {

                  MessageBox.Show("Nhap sdt!");
                  return;

              }
              if (txtCCCD.Text.Length == 0)
              {
                  MessageBox.Show("Nhap CCCD!");
                  return;

              }*/
            if (txtMaBN.Text == "")
            {
                BenhNhan bn = new BenhNhan()
                {
                    MaBN = 0,
                    hoten = txthoten.Text,

                    Ngaysinh = DateTime.Parse(selectedDate.ToString()),
                    gioiTinh = cbbgioiTinh.Text,
                    diaChi = txtdiaChi.Text,
                    sdt = mtbdienThoai.Text,
                    CCCD = txtCCCD.Text,



                };
                bool result2 = new BenhNhanBUS().AddNewBenhNhan(bn);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Thêm Xong.");
                        DANHSACHBENHNHAN_Load(sender, e);
                        ClearData();
                    }
                    catch
                    {
                        MessageBox.Show("Them that bai");
                        DANHSACHBENHNHAN_Load(sender, e);
                    }
                }
            }

        }

        private void DANHSACHBENHNHAN_Load(object sender, EventArgs e)
        {
            LoadDataUser();
            LoadDataPhieuKham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgaySinh.Value;
            if (dgvDSBenhNhan.SelectedRows.Count > 0)
            {
                BenhNhan bn = new BenhNhan()
                {
                    MaBN = Int32.Parse(txtMaBN.Text.ToString()),
                    hoten = txthoten.Text,
                    gioiTinh = cbbgioiTinh.Text,
                    diaChi = txtdiaChi.Text,

                    CCCD = txtCCCD.Text,
                    Ngaysinh = DateTime.Parse(selectedDate.ToString()),

                    sdt = mtbdienThoai.Text,
                };
                bool result2 = new BenhNhanBUS().UpdateBenhNhan(bn);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Cập Nhật Xong.");
                        DANHSACHBENHNHAN_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để thao tác");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvDSBenhNhan.CurrentRow.Index;
            string message = "BẠN CÓ CHẮC MUỐN XÓA BỆNH NHÂN NÀY KHÔNG?";
            string title = "XÓA BỆNH NHÂN!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //string nameImgSP = dgvDSBenhNhan.Rows[i].Cells[9].Value.ToString();

                bool result2 = new NhanVienBUS().DeleteUser(Int32.Parse(dgvDSBenhNhan.Rows[i].Cells[0].Value.ToString()));
                if (result2)
                {
                    // XoaHinhAnhNhanVien(nameImgSP);
                    DANHSACHBENHNHAN_Load(sender, e);
                }
            }
        }

        private void dgvDSBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSBenhNhan.CurrentRow.Selected = true;
            txtMaBNPKham.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();
            txtMaBN.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();
            txthoten.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
            cbbgioiTinh.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["gioiTinh"].Value.ToString();
            txtdiaChi.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["diaChi"].Value.ToString();
            txtCCCD.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();

            mtbdienThoai.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["sdt"].Value.ToString();
            dtpNgaySinh.Text = dgvDSBenhNhan.Rows[e.RowIndex].Cells["ngaySinh"].Value.ToString();



        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadDataUser();
            LoadDataPhieuKham();
        }

        private bool IsValidTuoi(string input)
        {
            // Kiểm tra xem chuỗi chỉ chứa số hoặc số kèm theo chữ "tháng"
            return Regex.IsMatch(input, @"^(?!1$|2$)\d+(\s*tháng)?$");
        }


        // private bool handlingTextChanged = false;


        private void dgvDSBenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiembyHoten.Text.Length == 0  && txtTimKiemByDiaChi.Text.Length == 0)
            {

                MessageBox.Show("Nhập thông tin tìm kiếm");
            }
            else
            {
                if (txtTimKiembyHoten.Text.Length > 0)
                {
                    List<BenhNhan> benhNhans = new BenhNhanBUS().TimTheoTENBenhNhan(txtTimKiembyHoten.Text);
                    dgvDSBenhNhan.DataSource = benhNhans;
                }

                if (txtTimKiemByDiaChi.Text.Length > 0)
                {
                    List<BenhNhan> benhNhans = new BenhNhanBUS().TimTheoDIACHIBenhNhan(txtTimKiemByDiaChi.Text);
                    dgvDSBenhNhan.DataSource = benhNhans;
                }
            }

        }

        private void btnTaoPK_Click(object sender, EventArgs e)
        {
            DateTime ngayKham = dtpNgayLap.Value;
            if (nbrCanNang.Value == 0)
            {
                MessageBox.Show("Nhap can nang");
                return;
            }
            if (rtbLyDoKham.Text.Length == 0)
            {
                MessageBox.Show("Nhap li do kham");
                return;
            }
            if (txtMaPK.Text == "")
            {
                PhieuKham pk = new PhieuKham()
                {
                    MaPK = 0,
                    Ngaylap = DateTime.Parse(ngayKham.ToString()),
                    Cannang = Int32.Parse(nbrCanNang.Value.ToString()),
                    LydoKham = rtbLyDoKham.Text,
                    MaNV = Int32.Parse(txtMaNVPKham.Text.ToString()),
                    MaBN = Int32.Parse(txtMaBNPKham.Text.ToString()),



                };
                bool result2 = new PhieuKhamBUS().AddNewPKham(pk);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Thêm Xong.");
                        DANHSACHBENHNHAN_Load(sender, e);
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Them that bai do " + ex);
                        DANHSACHBENHNHAN_Load(sender, e);
                    }
                }
            }
        }

        private void dgvDSPhieuKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSPhieuKham.CurrentRow.Selected = true;

            txtMaPK.Text = dgvDSPhieuKham.Rows[e.RowIndex].Cells["MaPK"].Value.ToString();
            dtpNgayLap.Text = dgvDSPhieuKham.Rows[e.RowIndex].Cells["ngayLap"].Value.ToString();
            nbrCanNang.Value = Int32.Parse(dgvDSPhieuKham.Rows[e.RowIndex].Cells["canNang"].Value.ToString());
            
            rtbLyDoKham.Text = dgvDSPhieuKham.Rows[e.RowIndex].Cells["lyDoKham"].Value.ToString();
            txtMaNVPKham.Text = dgvDSPhieuKham.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtMaBNPKham.Text = dgvDSPhieuKham.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();

        }
    }
}
