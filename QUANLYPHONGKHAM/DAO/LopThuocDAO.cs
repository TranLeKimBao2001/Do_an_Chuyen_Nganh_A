using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class LopThuocDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;

        public LopThuocDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from LopThuoc";
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

        public DataTable getLoaiThuocById(int id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from LopThuoc where MaLopThuoc =" + id;
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

        public bool AddNewLopThuoc(DTO.LopThuoc lopThuoc)
        {

            try
            {
                string query = "INSERT INTO LopThuoc (tenLopThuoc, ghiChu) values ('" + lopThuoc.tenLopThuoc + "', '" + lopThuoc.Ghichu + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }

        public bool UpdateLopThuoc(DTO.LopThuoc lopThuoc)
        {
            try
            {
                string query = "Update LopThuoc Set tenLopThuoc = '" + lopThuoc.tenLopThuoc + "' , ghiChu = '" + lopThuoc.Ghichu + "' WHERE MaLopThuoc='" + lopThuoc.MaLopThuoc + "'";

                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public bool DeleteLopThuoc(int MaLopThuoc)
        {
            try
            {
                string query = "Delete from LopThuoc where MaLopThuoc = " + MaLopThuoc;
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
