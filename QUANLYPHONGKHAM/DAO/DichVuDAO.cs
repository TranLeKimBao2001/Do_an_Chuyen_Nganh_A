using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using QUANLYPHONGKHAM.DTO;
using System.Data;

namespace QUANLYPHONGKHAM.DAO
{
    public class DichVuDAO
    {
        private DatabaseSQLExecute databaseSQLExecute;

        public DichVuDAO()
        {
            databaseSQLExecute = new DatabaseSQLExecute();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string query = "Select * from DichVu";
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

        public DataTable getDichVuById(int id)
        {
            DataTable dt = new DataTable();
            string query = "Select * from DichVu where MaDV =" + id;
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

        public bool AddNewDichVu(DTO.DichVu dichVu)
        {

            try
            {
                string query = "INSERT INTO DichVu (tenDV, gia, donViTinh, ghiChu, MaLoaidichvu) values (N'" + dichVu.tenDV + "', '" + dichVu.gia + "', N'" + dichVu.donViTinh + "', N'" + dichVu.ghiChu + "', '" + dichVu.MaLoaiDichVU + "')";
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch
            {
            }
            return false;
        }

        public bool UpdateDichVu(DTO.DichVu dichVu)
        {
            try
            {
                string query = "Update DichVu Set tenDV = N'" + dichVu.tenDV + "' , gia = '" + dichVu.gia + "', donViTinh = N'" + dichVu.donViTinh + "', ghiChu = N'" + dichVu.ghiChu + "', MaLoaidichvu = '" + dichVu.MaLoaiDichVU + "' WHERE MaDV='" + dichVu.MaDV + "'";

                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public bool DeleteDichVu(int MadichVu)
        {
            try
            {
                string query = "Delete from DichVu where MaDV = " + MadichVu;
                return databaseSQLExecute.ExecuteCRUDQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }



       /* public List<DTO.DichVu> LayTatCaDichVu()
        {
            List<DTO.DichVu> dsDichVu = new List<DTO.DichVu>();

            DataTable dt = databaseSQLExecute.ExecuteSelectAllQuery("SELECT * FROM DichVu");

            foreach (DataRow row in dt.Rows)
            {
                DTO.DichVu dichVu = new DTO.DichVu();
                dichVu.MaDV = int.Parse(row["MaDV"].ToString());
                dichVu.tenDV = row["tenDV"].ToString();
                dichVu.MaLoaiDichVU = int.Parse(row["MaLoaiDichVU"].ToString());
                dichVu.gia = int.Parse(row["gia"].ToString());
                dichVu.donViTinh = row["donViTinh"].ToString();
                dichVu.ghiChu = row["ghiChu"].ToString();

                dsDichVu.Add(dichVu);
            }

            return dsDichVu;
        }*/

      /*  public List<DTO.DichVu> TimKiemDichVuTheoTen(string tenDV)
        {
            List<DTO.DichVu> dsDichVu = new List<DTO.DichVu>();

            DataTable dt = databaseSQLExecute.ExecuteSelectAllQuery("SELECT * FROM DichVu WHERE tenDV LIKE '%" + tenDV + "%'");

            foreach (DataRow row in dt.Rows)
            {
                DTO.DichVu dichVu = new DTO.DichVu();
                dichVu.MaDV = int.Parse(row["MaDV"].ToString());
                dichVu.tenDV = row["tenDV"].ToString();
                dichVu.gia = int.Parse(row["gia"].ToString());
                dichVu.donViTinh = row["donViTinh"].ToString();
                dichVu.ghiChu = row["ghiChu"].ToString();
                dichVu.MaLoaiDichVU = int.Parse(row["MaLoaiDichVU"].ToString());

                dsDichVu.Add(dichVu);
            }

            return dsDichVu;
        }*/

        

        /*public void CapNhatDichVu(DichVuDTO dichVuDTO)
        {
            string sqlUpdate = "UPDATE DichVu SET MaDV=@MaDV, tenDV = @tenDV, MaLoaiDichVU = @MaLoaiDichVU, gia = @gia, donViTinh = @donViTinh, ghiChu = @ghiChu WHERE MaDV = @MaDV";

            List<SqlParameter> parameters = new List<SqlParameter>()
  {
    new SqlParameter("@MaDV", dichVuDTO.MaDV),
    new SqlParameter("@tenDV", dichVuDTO.tenDV),
    new SqlParameter("@MaLoaiDichVU", dichVuDTO.MaLoaiDichVU),
    new SqlParameter("@gia", dichVuDTO.gia),
    new SqlParameter("@donViTinh", dichVuDTO.donViTinh),
    new SqlParameter("@ghiChu", dichVuDTO.ghiChu)
  };

            using (SqlCommand command = new SqlCommand(sqlUpdate, databaseSQLExecute.GetConnection()))
            {
               
                command.Parameters.AddRange(parameters.ToArray());

                command.ExecuteNonQuery();
            }
        }

        public void ThemDichVu(DichVuDTO dichVuDTO)
        {
            using (SqlConnection connection = databaseSQLExecute.GetConnection())
            {
                string sqlInsert = "INSERT INTO DichVu VALUES (@MaDV, @tenDV, @MaLoaiDichVU, @gia, @donViTinh, @ghiChu)";

                List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaDV", dichVuDTO.MaDV),
                new SqlParameter("@tenDV", dichVuDTO.tenDV),
                new SqlParameter("@MaLoaiDichVU", dichVuDTO.MaLoaiDichVU),
                new SqlParameter("@gia", dichVuDTO.gia),
                new SqlParameter("@donViTinh", dichVuDTO.donViTinh),
                new SqlParameter("@ghiChu", dichVuDTO.ghiChu)
            };

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    command.ExecuteNonQuery();
                }
            }
        }*/
    }
}
