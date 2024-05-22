using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class HoaDonDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;

        public HoaDonDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from HoaDon";
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

        public bool AddNewHoaDon(HoaDon hoaDon)
        {
            try
            {
                string query = "INSERT INTO HoaDon (ngayLap, tongTien, MaPK) values ('" + hoaDon.Ngaylap + "', '" + hoaDon.tongTien + "', '" + hoaDon.MaPK + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {

            }
            return false;
        }

        
    }
}
