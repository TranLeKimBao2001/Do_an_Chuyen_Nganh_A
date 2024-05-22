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
    public partial class Thuoc : Form
    {
        string anhCu = "";
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            Loaddata();
            ckbTimKiem_CheckedChanged(sender, e);


        }


        public Thuoc(DTO.Thuoc thuoc) : this()
        {
            List<DTO.LopThuoc> lopThuocs = new LopThuocBUS().GetAllLopThuocs();

            cbbTenLopThuoc.DataSource = lopThuocs;
            cbbTenLopThuoc.DisplayMember = "tenLopThuoc";
            cbbTenLopThuoc.ValueMember = "tenLopThuoc";
            cbbTenLopThuoc.SelectedValue = thuoc.Mathuoc;
        }
        public void Loaddata()
        {
            List<DTO.Thuoc> thuocs = new ThuocBUS().GetAllThuocs();
            dgvDSThuoc.DataSource = thuocs;

            List<DTO.LopThuoc> lopThuocs = new LopThuocBUS().GetAllLopThuocs();
            cbbLoaiThuoc.DataSource = lopThuocs;
            cbbLoaiThuoc.DisplayMember = "tenLopThuoc";
            cbbLoaiThuoc.ValueMember = "MaLopThuoc";

            Loaddata2();
            CauHinhData();
        }

        public void CauHinhData()
        {
            dgvDSThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvDSThuoc.Columns[1].HeaderText = "Mã Lớp Thuốc";
            dgvDSThuoc.Columns[2].HeaderText = "Tên Thuốc";
            dgvDSThuoc.Columns[3].HeaderText = "Hàm Lượng/Nồng độ";
            dgvDSThuoc.Columns[4].HeaderText = "Bào chế";
            dgvDSThuoc.Columns[5].HeaderText = "Thành phần";
            dgvDSThuoc.Columns[6].HeaderText = "Đơn vị tính";

            dgvDSThuoc.Columns[7].HeaderText = "Ghi chú";
            dgvDSThuoc.Columns[8].HeaderText = "Cách dùng";

            dgvDSThuoc.Columns["MaThuoc"].Width = (int)(0.12 * dgvDSThuoc.Width);
            dgvDSThuoc.Columns["MaLopThuoc"].Width = (int)(0.14 * dgvDSThuoc.Width);

            dgvDSThuoc.Columns["tenThuoc"].Width = (int)(0.2 * dgvDSThuoc.Width);
            dgvDSThuoc.Columns["cachDung"].Width = (int)(0.15 * dgvDSThuoc.Width);

            dgvDSThuoc.Columns["donViTinh"].Width = (int)(0.15 * dgvDSThuoc.Width);
            dgvDSThuoc.Columns["ghiChu"].Width = (int)(0.2 * dgvDSThuoc.Width);

            dgvDSThuoc.Columns["hamLuongNDo"].Width = (int)(0.2 * dgvDSThuoc.Width);
            dgvDSThuoc.Columns["dangBaoChe"].Width = (int)(0.1 * dgvDSThuoc.Width);

            dgvDSThuoc.Columns["thanhPhan"].Width = (int)(0.3 * dgvDSThuoc.Width);

        }

        public void ClearData()
        {
            txtMaThuoc.Text = null;
            txtTenThuoc.Text = null;
            txthamLuongNDo.Text = null;
            txtThanhPhan.Text = null;
            txtGhiChu.Text = null;
            txtHinhAnhThuoc.Text = null;
            pbHinhAnhThuoc.Image = null;
            cbbTenLopThuoc.SelectedIndex = 0;
            cbbdonViTinh.SelectedIndex = 0;
            cbbdangBaoChe.SelectedIndex = 0;
            cbbCachDung.SelectedIndex = 0;
            ckbTimTheoLoaithuoc.Checked = false;
            ckbTimTheoTenThuoc.Checked = false;

        }
        public void Loaddata2()
        {
            List<DTO.LopThuoc> lopThuocs = new LopThuocBUS().GetAllLopThuocs();
            cbbTenLopThuoc.DataSource = lopThuocs;
            cbbTenLopThuoc.DisplayMember = "tenLopThuoc";
            cbbTenLopThuoc.ValueMember = "MaLopThuoc";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtTenThuoc.Text.Length == 0)
            {
                MessageBox.Show("Nhập ten thuoc");
                return;
            }
            
            if (txthamLuongNDo.Text.Length == 0)
            {
                MessageBox.Show("Nhập ham luong");
                return;
            }
            
            
            if (txtHinhAnhThuoc.Text.Length == 0)
            {
                MessageBox.Show("Chon hinh ảnh tượng trưng");
                return;
            }
            if (txtThanhPhan.Text.Length == 0)
            {
                MessageBox.Show("Nhập tphan");
                return;
            }
            if (txtMaThuoc.Text == "")
            {
                string tenThuoc = txtTenThuoc.Text;
                string cachDung = cbbCachDung.Text;
                string hamLuongND = txthamLuongNDo.Text;
                string donViTinh = cbbdonViTinh.Text;
                string dangBaoChe = cbbdangBaoChe.Text;
                string hinhAnh = txtHinhAnhThuoc.Text;
                string thanhPhan = txtThanhPhan.Text;
                string ghiChu = txtGhiChu.Text;
                string tenLopThuoc = cbbTenLopThuoc.SelectedValue.ToString();
                DTO.Thuoc thuoc = new DTO.Thuoc()
                {
                    
                    Mathuoc = 0,
                    MaLopthuoc = Int32.Parse(tenLopThuoc) - 1,
                    TenThuoc = tenThuoc,
                    cachDung = cachDung,
                    hamLuongNDo = hamLuongND,
                    donViTinh = donViTinh,
                    dangBaoChe = dangBaoChe,
                    HinhAnh = hinhAnh,
                    thanhPhan = thanhPhan,
                    ghiChu = ghiChu,

                };
                bool result2 = new ThuocBUS().AddNewThuoc(thuoc);
                if (result2)
                {
                    try
                    {
                        ClearData();
                        MessageBox.Show("Đã Thêm.");
                        Thuoc_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm không thành công do "+ex);
                    }
                }
            }
        }
        // Hello
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvDSThuoc.CurrentRow.Index;

            if (dgvDSThuoc.SelectedRows.Count > 0)
            {
                string message = "Bạn có chắc muốn xóa thuốc hay không?";
                string title = "Xóa Thuoc!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string nameImgSP = dgvDSThuoc.Rows[i].Cells[9].Value.ToString();


                    bool result2 = new ThuocBUS().DeleteThuoc(Int32.Parse(dgvDSThuoc.Rows[i].Cells[0].Value.ToString()));
                    if (result2)
                    {
                        XoaHinhAnhThuoc(nameImgSP);
                        Thuoc_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 dòng để XÓA");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string TenThuoc = txtTenThuoc.Text;
            string CachDung = cbbCachDung.Text;
            string HamLuongNDo = txthamLuongNDo.Text;
            string DonViTinh = cbbdonViTinh.Text;
            string DangBaoChe = cbbdangBaoChe.Text;
            string HinhAnh;
            if (dgvDSThuoc.SelectedRows.Count > 0)
            {
                DTO.Thuoc thuoc = new DTO.Thuoc()
                {

                    Mathuoc = Int32.Parse(txtMaThuoc.Text.ToString()),
                    MaLopthuoc = Int32.Parse(cbbTenLopThuoc.SelectedValue.ToString()) - 1,
                    TenThuoc = txtTenThuoc.Text,
                    cachDung = cbbCachDung.Text,
                    hamLuongNDo = txthamLuongNDo.Text,
                    donViTinh = cbbdonViTinh.Text,
                    dangBaoChe = cbbdangBaoChe.Text,
                    HinhAnh=txtHinhAnhThuoc.Text,
                    thanhPhan = txtThanhPhan.Text,
                    ghiChu = txtGhiChu.Text,

                };
                bool result2 = new ThuocBUS().UpdateThuoc(thuoc);
                if (result2)
                {
                    try
                    {
                        MessageBox.Show("Đã Cập Nhật Xong.");
                        Thuoc_Load(sender, e);
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

        private void dgvDSThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSThuoc.CurrentRow.Selected = true;

            txtMaThuoc.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["MaThuoc"].Value.ToString();
            cbbTenLopThuoc.SelectedIndex = Int32.Parse(dgvDSThuoc.Rows[e.RowIndex].Cells["MaLopThuoc"].Value.ToString());
            txtTenThuoc.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["tenThuoc"].Value.ToString();
            txthamLuongNDo.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["hamLuongNDo"].Value.ToString();

            cbbdonViTinh.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["donViTinh"].Value.ToString();
            cbbdangBaoChe.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["dangBaoChe"].Value.ToString();
            cbbCachDung.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["cachDung"].Value.ToString();
            txtHinhAnhThuoc.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["hinhAnh"].Value.ToString();
            txtGhiChu.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();
            txtThanhPhan.Text = dgvDSThuoc.Rows[e.RowIndex].Cells["thanhPhan"].Value.ToString();
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\ProImages\";
            string tenAnh = txtHinhAnhThuoc.Text;
            string pathImage = Path.Combine(appPath, tenAnh);
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            if (File.Exists(pathImage))
            {
                try
                {
                    pbHinhAnhThuoc.Image = new Bitmap(pathImage);
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
            pbHinhAnhThuoc.Image = Image.FromFile(pathImage);
        }

        public void LoadDataBySearchName(string keyword, int id)
        {
            List<DTO.Thuoc> thuocs = new ThuocBUS().TimTheoTenThuoc(keyword, id);
            dgvDSThuoc.DataSource = thuocs;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            Loaddata();
            

        }



        private void ckbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTimKiem.Checked == true)
            {
                ckbTimTheoLoaithuoc.Visible = true;
                cbbLoaiThuoc.Visible = true;
                ckbTimTheoTenThuoc.Visible = true;
                txtTimKiem.Visible = true;
            }
            else
            {
                ckbTimTheoLoaithuoc.Visible = false;
                cbbLoaiThuoc.Visible = false;
                ckbTimTheoTenThuoc.Visible = false;
                txtTimKiem.Visible = false;
            }
        }

        private void dgvDSThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int StaTenLoaiThuoc = 0;
            if (ckbTimTheoLoaithuoc.Checked == true )
            {
                StaTenLoaiThuoc = Int32.Parse(cbbLoaiThuoc.SelectedValue.ToString());

                if (txtTimKiem.Text == "")
                {
                    LoadDataBySearchName(txtTimKiem.Text, StaTenLoaiThuoc);
                }
            }
            else if(ckbTimTheoTenThuoc.Checked == true)
            {
                if (txtTimKiem.Text.Length > 0)
                {
                    LoadDataBySearchName(txtTimKiem.Text, StaTenLoaiThuoc);
                }
            }


        }


        public void UploadAnhChoThuoc()
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\ProImages\";  // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;
                    txtHinhAnhThuoc.Text = opFile.SafeFileName;// <---
                    string filepath = opFile.FileName;    // <---
                    pbHinhAnhThuoc.Image = null;
                    pbHinhAnhThuoc.Image = new Bitmap(opFile.OpenFile());
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
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\ProImages\";
            string duongDanHinhAnh = Path.Combine(appPath, tenAnh);
            if (File.Exists(duongDanHinhAnh))
            {
                try
                {
                    pbHinhAnhThuoc.Image.Dispose();
                    File.Delete(duongDanHinhAnh);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa hình ảnh: " + ex);
                }
            }
        }

        private void XoaHinhAnhThuoc(string tenAnh)
        {
            string appPath = Path.GetDirectoryName(Application.LocalUserAppDataPath) + @"\ProImages\";
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
        private void btnChonHInh_Click(object sender, EventArgs e)
        {
            if (txtHinhAnhThuoc.Text == "")
            {
                UploadAnhChoThuoc();
            }
            else
            {
                anhCu = txtHinhAnhThuoc.Text;
                UploadAnhChoThuoc();
            }
        }
    }
}
