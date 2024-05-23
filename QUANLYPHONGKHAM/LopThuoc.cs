using QUANLYPHONGKHAM.BUS;
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
    public partial class LopThuoc : Form
    {
        public LopThuoc()
        {
            InitializeComponent();
            LoadDSLopThuoc();
        }


        public void LoadDSLopThuoc()
        {

            List<DTO.LopThuoc> lopThuocs = new LopThuocBUS().GetAllLopThuocs();
            dgvDSLopTHuoc.DataSource = lopThuocs;

            dgvDSLopTHuoc.Columns["MaLopThuoc"].Width = (int)(0.2 * dgvDSLopTHuoc.Width);
            dgvDSLopTHuoc.Columns["tenLopThuoc"].Width = (int)(0.3 * dgvDSLopTHuoc.Width);
            dgvDSLopTHuoc.Columns["ghiChu"].Width = (int)(0.6 * dgvDSLopTHuoc.Width);

            dgvDSLopTHuoc.Columns[0].HeaderText = "Mã Lớp thuốc";
            dgvDSLopTHuoc.Columns[1].HeaderText = "Tên Lớp thuốc";
            dgvDSLopTHuoc.Columns[2].HeaderText = "Ghi chú";

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void ClearData()
        {
            txtMaLopThuoc.Text = "";
            txtTenLopThuoc.Text = "";
            rtbGhiChu.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtTenLopThuoc.Text.Length == 0)
            {
                MessageBox.Show("Nhap tên lớp thuốc!");
                return;
            }
            if (rtbGhiChu.Text.Length == 0)
            {
                MessageBox.Show("nhap ghi chu!");
                return;
            }
            if (txtMaLopThuoc.Text == "")
            {
                DTO.LopThuoc lopThuoc = new DTO.LopThuoc()
                {
                    MaLopThuoc = 0,
                    tenLopThuoc = txtTenLopThuoc.Text,
                    Ghichu = rtbGhiChu.Text,



                };
                bool result2 = new LopThuocBUS().AddNewLopThuoc(lopThuoc);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Thêm Xong.");
                        LopThuoc_Load(sender, e);
                        ClearData();
                    }
                    catch
                    {
                        MessageBox.Show("Them that bai");
                        LopThuoc_Load(sender, e);
                    }
                }
            }
        }

        private void LopThuoc_Load(object sender, EventArgs e)
        {
            LoadDSLopThuoc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvDSLopTHuoc.SelectedRows.Count > 0)
            {
                DTO.LopThuoc lopThuoc = new DTO.LopThuoc()
                {
                    MaLopThuoc = Int32.Parse(txtMaLopThuoc.Text.ToString()),
                    tenLopThuoc = txtTenLopThuoc.Text,
                    Ghichu = rtbGhiChu.Text,



                };
                bool result2 = new LopThuocBUS().UpdateLopThuoc(lopThuoc);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Cập Nhật Xong.");
                        LopThuoc_Load(sender, e);
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
            int i = dgvDSLopTHuoc.CurrentRow.Index;

            if (dgvDSLopTHuoc.SelectedRows.Count > 0)
            {
                string message = "Are you sure Delete this item?";
                string title = "Xóa Lớp Thuốc!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    bool result2 = new LopThuocBUS().DeleteLopThuoc(Int32.Parse(dgvDSLopTHuoc.Rows[i].Cells[0].Value.ToString()));
                    if (result2)
                    {
                        LopThuoc_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để XÓA");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadDSLopThuoc();
        }

        private void dgvDSLopTHuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSLopTHuoc.CurrentRow.Selected = true;

            txtMaLopThuoc.Text = dgvDSLopTHuoc.Rows[e.RowIndex].Cells["MaLopThuoc"].Value.ToString();
            txtTenLopThuoc.Text = dgvDSLopTHuoc.Rows[e.RowIndex].Cells["tenLopThuoc"].Value.ToString();
            rtbGhiChu.Text = dgvDSLopTHuoc.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();
        }
    }
}
