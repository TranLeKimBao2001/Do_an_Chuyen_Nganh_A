using Microsoft.VisualBasic.ApplicationServices;
using QUANLYPHONGKHAM.DAO;
using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nhanVienDAO;

       
        public NhanVienBUS()
        {
            nhanVienDAO = new NhanVienDAO();
        }

        public List<NhanVien> getAllNhanViens()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = nhanVienDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<NhanVien> list = new List<NhanVien>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = Int32.Parse(dr["MaNV"].ToString());

                    nv.Hoten = dr["hoten"].ToString();

                    nv.Ngaysinh = DateTime.Parse(dr["ngaySinh"].ToString());

                    nv.Gioitinh = dr["gioiTinh"].ToString();

                    nv.Diachi = dr["diaChi"].ToString();

                    nv.Taikhoan = dr["taiKhoan"].ToString();

                    nv.Matkhau = dr["matKhau"].ToString();

                    nv.CCCD = dr["CCCD"].ToString();

                    nv.Chucvu = dr["chucVu"].ToString();

                    nv.HinhAnh = dr["hinhAnh"].ToString();

                    nv.Ngayvaolam = DateTime.Parse(dr["ngayVaoLam"].ToString());

                    list.Add(nv);
                }
            }
            return list;
        }

        public List<NhanVien> getInfoByAccount(string taiKhoan, string matKhau)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = nhanVienDAO.getInfoByAccount(taiKhoan, matKhau);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<NhanVien> list = new List<NhanVien>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = Int32.Parse(dr["MaNV"].ToString());

                    nv.Hoten = dr["hoten"].ToString();

                    nv.Ngaysinh = DateTime.Parse(dr["ngaySinh"].ToString());

                    nv.Gioitinh = dr["gioiTinh"].ToString();

                    nv.Diachi = dr["diaChi"].ToString();

                    nv.Taikhoan = dr["taiKhoan"].ToString();

                    nv.Matkhau = dr["matKhau"].ToString();

                    nv.CCCD = dr["CCCD"].ToString();

                    nv.Chucvu = dr["chucVu"].ToString();

                    nv.HinhAnh = dr["hinhAnh"].ToString();

                    nv.Ngayvaolam = DateTime.Parse(dr["ngayVaoLam"].ToString());
                    list.Add(nv);
                }
            }
            return list;
        }
        public bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            return nhanVienDAO.KiemTraDangNhap(taiKhoan, matKhau);
        }

        public string[] getAllImageName()
        {
            DataTable dt = new DataTable();
            string[] dsAnh = null;
            try
            {
                dt = nhanVienDAO.getAllImageName();
                if (dt != null && dt.Rows.Count > 0)
                {
                    dsAnh = new string[dt.Rows.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dsAnh[i] = dt.Rows[i]["hinhAnh"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dsAnh;
        }
        public bool AddNewUser(NhanVien nv)
        {
            return nhanVienDAO.AddNewNhanVien(nv);
        }
        public bool UpdateUser(NhanVien nv)
        {
            return nhanVienDAO.UpdateNhanVien(nv);
        }
        public bool DeleteUser(int id)
        {
            return nhanVienDAO.DeleteNhanVien(id);
        }


    }
}
