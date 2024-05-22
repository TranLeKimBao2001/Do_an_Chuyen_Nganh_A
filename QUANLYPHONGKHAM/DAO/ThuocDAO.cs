using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class ThuocDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;

        public ThuocDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Thuoc";
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

        public DataTable getThuocById(int id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from Thuoc where MaThuoc =" + id;
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

        public DataTable getAllImageName()
        {
            DataTable dt = new DataTable();
            string query = "Select hinhAnh from Thuoc";
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

        public DataTable getImageNameWithTenThuoc(string keySearch, int MaLoaiThuoc)
        {
            if (MaLoaiThuoc == 0)
            {
                DataTable dt = new DataTable();
                string query = "Select hinhAnh from Thuoc where tenThuoc like '%" + keySearch + "%'";
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
            else
            {
                DataTable dt = new DataTable();
                string query = "Select hinhAnh from Thuoc where tenThuoc like '%" + keySearch + "%' and MaLopThuoc = " + MaLoaiThuoc;
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
        public bool AddNewThuoc(DTO.Thuoc thuoc)
        {

            try
            {
                string query = "INSERT INTO Thuoc (tenThuoc, cachDung,thanhPhan,donViTinh,ghiChu, MaLopThuoc, hamLuongNDo, dangBaoChe,hinhAnh ) values (N'" + thuoc.TenThuoc + "', N'" + thuoc.cachDung + "', N'" + thuoc.thanhPhan+ "', N'"+ thuoc.donViTinh+ "', N'"+ thuoc.ghiChu + "', '"+ thuoc.MaLopthuoc+ "', N'"+ thuoc.hamLuongNDo + "', N'"+ thuoc.dangBaoChe+ "', '" + thuoc.HinhAnh + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }

        public bool UpdateThuoc(DTO.Thuoc thuoc)
        {
            try
            {
                string query = "Update Thuoc Set tenThuoc = N'" + thuoc.TenThuoc + "' , cachDung = N'" + thuoc.cachDung+ "' , thanhPhan = N'" + thuoc.thanhPhan+ "' , donViTinh = N'" + thuoc.donViTinh+ "' , ghiChu = N'" + thuoc.ghiChu+ "' , MaLopThuoc = '" + thuoc.MaLopthuoc+ "' , hamLuongNDo = '" + thuoc.hamLuongNDo + "' , dangBaoChe = N'" + thuoc.dangBaoChe+ "' , hinhAnh = '" + thuoc.HinhAnh + "' WHERE MaThuoc='" + thuoc.Mathuoc+ "'";

                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public bool DeleteThuoc(int MaThuoc)
        {
            try
            {
                string query = "Delete from Thuoc where MaThuoc = " + MaThuoc;
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }
        public DataTable TimTheotenThuoc(string keyword, int IdTenLopThuoc)
        {
            if(IdTenLopThuoc ==0)
            {
                DataTable dt = new DataTable();
                string query = "Select * from Thuoc Where tenThuoc like '%" + keyword + "%'";
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
            else 
            {
                DataTable dt = new DataTable();
                string query = "Select * from Thuoc Where tenThuoc like '%" + keyword + "%' and MaLopThuoc =" + IdTenLopThuoc;
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
}
