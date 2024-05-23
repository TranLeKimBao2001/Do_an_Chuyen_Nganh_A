using QUANLYPHONGKHAM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGKHAM
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
            Loaddata();
        }
        public DichVu(DTO.DichVu dichVu) : this()
        {
            List<DTO.LoaiDichVu> loaiDichVus = new LoaiDichVuBUS().getAllLoaiDichVus();

            cbbTenDichVu.DataSource = loaiDichVus;
            cbbTenDichVu.DisplayMember = "tenLoaiDichVu";
            cbbTenDichVu.ValueMember = "MaLoaiDichVu";
            cbbTenDichVu.SelectedValue = dichVu.MaLoaiDichVU;
        }
        public void Loaddata2()
        {
            List<DTO.LoaiDichVu> loaiDichVus = new LoaiDichVuBUS().getAllLoaiDichVus();
            cbbTenDichVu.DataSource = loaiDichVus;
            cbbTenDichVu.DisplayMember = "tenLoaiDichVu";
            cbbTenDichVu.ValueMember = "MaLoaiDichVu";
        }
        public void ClearData2()
        {
            txtMaDV.Text = null;
            txtTenDichVu.Text = null;
            txtGhichu.Text = null;
            nbrGia.Value = 0;
            cbbdonViDo.SelectedItem = null;
            cbbTenDichVu.SelectedItem = null;
        }

        public void CauHinhData()
        {
            dgvDichVu.Columns[0].HeaderText = "Mã Dịch vụ";
            dgvDichVu.Columns[1].HeaderText = "Tên Dịch vụ";
            dgvDichVu.Columns[2].HeaderText = "Mã Loại Dịch vụ";

            dgvDichVu.Columns[3].HeaderText = "Giá tiền";
            dgvDichVu.Columns[4].HeaderText = "Đơn vị tính";

            dgvDichVu.Columns[5].HeaderText = "Ghi Chú";
            dgvDichVu.Columns["MaDV"].Width = (int)(0.12 * dgvDichVu.Width);
            dgvDichVu.Columns["MaLoaidichvu"].Width = (int)(0.14 * dgvDichVu.Width);
            dgvDichVu.Columns["tenDV"].Width = (int)(0.3 * dgvDichVu.Width);
            dgvDichVu.Columns["gia"].Width = (int)(0.1 * dgvDichVu.Width);
            dgvDichVu.Columns["donViTinh"].Width = (int)(0.1 * dgvDichVu.Width);
            dgvDichVu.Columns["ghiChu"].Width = (int)(0.2 * dgvDichVu.Width);
        }
        public void Loaddata()
        {
            List<DTO.DichVu> dichVus = new DichVuBUS().getAllDichVus();
            dgvDichVu.DataSource = dichVus;
            Loaddata2();
            CauHinhData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDichVu.Text.Length == 0)
            {
                MessageBox.Show("Nhan ten DV");
                return;
            }
            if (nbrGia.Value == 0)
            {
                MessageBox.Show("Nhập gia DV");
                return;
            }
           
            if (txtGhichu.Text.Length == 0)
            {
                MessageBox.Show("Nhập ghi chu");
                return;
            }
           
            if (txtMaDV.Text == "")
            {
                DTO.DichVu dv = new DTO.DichVu()
                {
                    MaDV = 0,
                    tenDV = txtTenDichVu.Text,
                    gia = Int32.Parse(nbrGia.Value.ToString()),
                    donViTinh = cbbdonViDo.Text,
                    ghiChu = txtGhichu.Text,
                    MaLoaiDichVU = Int32.Parse(cbbTenDichVu.SelectedValue.ToString()) - 1
                };
                bool result2 = new DichVuBUS().AddNewDichVu(dv);
                if (result2)
                {
                    try
                    {
                        ClearData2();
                        MessageBox.Show("Đã Thêm.");
                        DichVu_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData2();
        }
        private void DichVu_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDichVu.CurrentRow.Selected = true;
            txtMaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
            txtTenDichVu.Text = dgvDichVu.Rows[e.RowIndex].Cells["tenDV"].Value.ToString();
            txtGhichu.Text = dgvDichVu.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();
            nbrGia.Value = Int32.Parse(dgvDichVu.Rows[e.RowIndex].Cells["gia"].Value.ToString());
            cbbdonViDo.Text = dgvDichVu.Rows[e.RowIndex].Cells["donViTinh"].Value.ToString();
            cbbTenDichVu.SelectedIndex = Int32.Parse(dgvDichVu.Rows[e.RowIndex].Cells["MaLoaidichvu"].Value.ToString());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                DTO.DichVu dichVu = new DTO.DichVu()
                {
                    MaDV = Int32.Parse(txtMaDV.Text.ToString()),
                    gia = Int32.Parse(nbrGia.Value.ToString()),
                    MaLoaiDichVU = Int32.Parse(cbbTenDichVu.SelectedIndex.ToString()),
                    tenDV = txtTenDichVu.Text,
                    ghiChu = txtGhichu.Text,
                    donViTinh = cbbdonViDo.Text,
                };
                bool result2 = new DichVuBUS().UpdateDichVu(dichVu);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Cập Nhật Xong.");
                        DichVu_Load(sender, e);
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
            int i = dgvDichVu.CurrentRow.Index;

            if (dgvDichVu.SelectedRows.Count > 0)
            {
                string message = "Are you sure Delete this item?";
                string title = "Delete Producer!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    bool result2 = new DichVuBUS().DeleteDichVu(Int32.Parse(dgvDichVu.Rows[i].Cells[0].Value.ToString()));
                    if (result2)
                    {
                        DichVu_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để XÓA");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
