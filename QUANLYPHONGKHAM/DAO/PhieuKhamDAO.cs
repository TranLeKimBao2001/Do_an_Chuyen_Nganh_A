using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DAO
{
    public class PhieuKhamDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;
        public PhieuKhamDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select MaPK,ngayLap,canNang,lyDoKham,MaNV,MaBN from PhieuKham";
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

        public DataTable getPhieuKhamById(int id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from PhieuKham where MaPK =" + id;
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

        public bool AddNewPhieuKhamByYTa(PhieuKham phieuKham)
        {
            try
            {
                string query = "INSERT INTO PhieuKham (ngayLap, canNang, lyDoKham, MaNV, MaBN) values ('" + phieuKham.Ngaylap + "', '" + phieuKham.Cannang + "', N'" + phieuKham.LydoKham  + "', '" + phieuKham.MaNV + "', '" + phieuKham.MaBN/*+ "', N'"+phieuKham.ghiChu +*/+ "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }


    }
}
