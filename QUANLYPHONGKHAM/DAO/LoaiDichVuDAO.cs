using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class LoaiDichVuDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;
        public LoaiDichVuDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from LoaiDichVu";
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

        public DataTable getLoaiDichVuById(int id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from LoaiDichVu where MaLoaiDichVu =" + id;
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

        public bool AddNewLoaiDichVu(DTO.LoaiDichVu loaiDichVu)
        {

            try
            {
                string query = "INSERT INTO LoaiDichVu (tenLoaiDichVu, ghiChu) values ('" + loaiDichVu.TenLoaiDichVu + "', '" + loaiDichVu.ghiChu + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }

        public bool UpdateLoaiDichVu(DTO.LoaiDichVu loaidichVu)
        {
            try
            {
                string query = "Update LoaiDichVu Set tenLoaiDichVu = '" + loaidichVu.TenLoaiDichVu + "' , ghiChu = '" + loaidichVu.ghiChu  + "' WHERE MaLoaiDichVu='" + loaidichVu.MaLoaiDichVu + "'";

                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public bool DeleteLoaiDichVu(int MaLoaidichVu)
        {
            try
            {
                string query = "Delete from LoaiDichVu where MaLoaiDichVu = " + MaLoaidichVu;
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
