using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class NhanVienDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;

        public NhanVienDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from NhanVien";
            try
            {
                dt = databaseSQLExecute.ExecuteSelectAllQuery(query);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

       
        public DataTable getNhanVienByAccount(string taiKhoan)
        {
            DataTable dt = new DataTable();
            string query = "Select * from NhanVien where MaNV =" + taiKhoan;
            try
            {
                dt = databaseSQLExecute.ExecuteSelectAllQuery(query);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public bool AddNewNhanVien(NhanVien nhanVien)
        {
          
            try
            {
                string query = "INSERT INTO NhanVien (hoten, ngaySinh, gioiTinh, diaChi, taiKhoan, matKhau, CCCD, chucVu, hinhAnh, ngayVaoLam) values (N'" + nhanVien.Hoten + "', '" + nhanVien.Ngaysinh + "', N'" + nhanVien.Gioitinh + "', N'" + nhanVien.Diachi + "', '" + nhanVien.Taikhoan + "', '" + nhanVien.Matkhau + "', '" + nhanVien.CCCD + "', N'" + nhanVien.Chucvu + "', '" + nhanVien.HinhAnh+ "', '" + nhanVien.Ngayvaolam + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                string query = "Update NhanVien Set hoten = N'" + nhanVien.Hoten + "' , ngaySinh = '" + nhanVien.Ngaysinh + "', gioiTinh = N'" + nhanVien.Gioitinh + "', diaChi = N'" + nhanVien.Diachi + "', taiKhoan = '" + nhanVien.Taikhoan + "',matKhau= '" + nhanVien.Matkhau + "',CCCD= '" + nhanVien.CCCD + "',chucVu= N'" + nhanVien.Chucvu + "', hinhAnh = '" + nhanVien.HinhAnh+ "',ngayVaoLam= '" + nhanVien.Ngayvaolam + "' WHERE MaNV='" +nhanVien.MaNV + "'";

                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public bool DeleteNhanVien(int cccd)
        {
            try
            {
                string query = "Delete from NhanVien where MaNV = " + cccd;
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public DataTable getInfoByAccount(string taiKhoan, string matKhau)
        {
            DataTable dt = new DataTable();
            string query = "Select * from NhanVien where taiKhoan = '" + taiKhoan + "' and matKhau = '" + matKhau + "'";
            try
            {
                dt = databaseSQLExecute.ExecuteSelectAllQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        public bool KiemTraDangNhap(string username, string password)
        {
            DataTable dt = new DataTable();
            string query = "Select * from NhanVien where taiKhoan = '" + username + "' and matKhau = '" + password + "'";
            try
            {
                dt = databaseSQLExecute.ExecuteSelectAllQuery(query);
                if (dt != null) { return true; }
                else { return false; }
            }
            catch
            {
            }
            return false;
        }
        public DataTable getAllImageName()
        {
            DataTable dt = new DataTable();
            string query = "Select hinhAnh from NhanVien";
            try
            {
                dt = databaseSQLExecute.ExecuteSelectAllQuery(query);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
    }
}
