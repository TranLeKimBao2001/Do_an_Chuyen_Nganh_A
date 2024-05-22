using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class BenhNhanDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;

        public BenhNhanDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from BenhNhan";
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

        public DataTable TimTheoTenBenhNhan(string keyword)
        {
            DataTable dt = new DataTable();
            string query = "Select * from BenhNhan Where hoTen like N'%" + keyword + "%'";
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

       

        public DataTable TimTheoDiaChiBenhNhan(string keyword)
        {
            DataTable dt = new DataTable();
            string query = "Select * from BenhNhan Where diaChi like '%" + keyword + "%'";
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

        public bool AddNewBenhNhan(BenhNhan benhNhan)
        {

            try
            {
                string query = "INSERT INTO BenhNhan (hoTen, gioiTinh, sdt, diaChi, CCCD, ngaySinh) values (N'" + benhNhan.hoten + "', N'" + benhNhan.gioiTinh + "', '" + benhNhan.sdt + "', N'" +  benhNhan.diaChi + "', '" + benhNhan.CCCD + "', '"+benhNhan.Ngaysinh + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }
        public bool UpdateBenhNhan(BenhNhan benhNhan)
        {
            try
            {
                string query = "Update BenhNhan Set hoTen = N'" + benhNhan.hoten + "' , gioiTinh = N'" + benhNhan.gioiTinh + "', sdt = '" + benhNhan.sdt +  "', diaChi = N'" + benhNhan.diaChi + "',CCCD= '" + benhNhan.CCCD  + "',ngaySinh= '" +benhNhan.Ngaysinh +"' WHERE MaBN='" + benhNhan.MaBN + "'";

                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public bool DeleteBenhNhan(int id)
        {
            try
            {
                string query = "Delete from BenhNhan where MaBN = " + id;
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
    }
}
