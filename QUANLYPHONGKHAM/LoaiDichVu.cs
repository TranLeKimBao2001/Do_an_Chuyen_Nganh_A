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
    public partial class LoaiDichVu : Form
    {
        public LoaiDichVu()
        {
            InitializeComponent();
            LoadLoaiDichVu();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.Show();
            this.Close();
        }

        private void dgvLoaiDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLoaiDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLoaiDichVu.CurrentRow.Selected = true;

            txtMaLoaiDichVu.Text = dgvLoaiDichVu.Rows[e.RowIndex].Cells["MaLoaiDichVu"].Value.ToString();
            txtTenLoaiDichVu.Text = dgvLoaiDichVu.Rows[e.RowIndex].Cells["tenLoaiDichVu"].Value.ToString();
            txtghiChu.Text = dgvLoaiDichVu.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();

        }

        public void ClearData()
        {
            txtMaLoaiDichVu.Text = "";
            txtTenLoaiDichVu.Text = "";
            txtghiChu.Text = "";
        }
        public void LoadLoaiDichVu()
        {
            List<DTO.LoaiDichVu> loaiDichVus = new LoaiDichVuBUS().getAllLoaiDichVus();
            dgvLoaiDichVu.DataSource = loaiDichVus;

            dgvLoaiDichVu.Columns["MaLoaiDichVu"].Width = (int)(0.2 * dgvLoaiDichVu.Width);
            dgvLoaiDichVu.Columns["tenLoaiDichVu"].Width = (int)(0.3 * dgvLoaiDichVu.Width);
            dgvLoaiDichVu.Columns["ghiChu"].Width = (int)(0.6 * dgvLoaiDichVu.Width);

            dgvLoaiDichVu.Columns[0].HeaderText = "Mã Loại dich vụ";
            dgvLoaiDichVu.Columns[1].HeaderText = "Tên Loại dich vụ";
            dgvLoaiDichVu.Columns[2].HeaderText = "Ghi chú";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDichVu.Text.Length == 0)
            {
                MessageBox.Show("Nhap ten loai dich vu!");
                return;
            }
            if (txtghiChu.Text.Length == null)
            {
                MessageBox.Show("nhap ghi chu!");
                return;
            }
            if (txtMaLoaiDichVu.Text == "")
            {
                DTO.LoaiDichVu loaiDichVu = new DTO.LoaiDichVu()
                {
                    MaLoaiDichVu = 0,
                    TenLoaiDichVu = txtTenLoaiDichVu.Text,
                    ghiChu = txtghiChu.Text,



                };
                bool result2 = new LoaiDichVuBUS().AddNewLoaiDichVu(loaiDichVu);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Thêm Xong.");
                        LoaiDichVu_Load(sender, e);
                        ClearData();
                    }
                    catch
                    {
                        MessageBox.Show("Them that bai");
                        LoaiDichVu_Load(sender, e);
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadLoaiDichVu();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDichVu.SelectedRows.Count > 0)
            {
                DTO.LoaiDichVu loaiDichVu = new DTO.LoaiDichVu()
                {
                    MaLoaiDichVu = Int32.Parse(txtMaLoaiDichVu.Text.ToString()),
                    TenLoaiDichVu = txtTenLoaiDichVu.Text,
                    ghiChu = txtghiChu.Text,



                };
                bool result2 = new LoaiDichVuBUS().UpdateLoaiDichVu(loaiDichVu);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Cập Nhật Xong.");
                        LoaiDichVu_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để CẬP NHẬT");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvLoaiDichVu.CurrentRow.Index;

            if (dgvLoaiDichVu.SelectedRows.Count > 0)
            {
                string message = "Are you sure Delete this item?";
                string title = "Delete Producer!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    bool result2 = new LoaiDichVuBUS().DeleteLoaiDichVu(Int32.Parse(dgvLoaiDichVu.Rows[i].Cells[0].Value.ToString()));
                    if (result2)
                    {
                        LoadLoaiDichVu();
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để XÓA");
            }

        }

        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            LoadLoaiDichVu();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
