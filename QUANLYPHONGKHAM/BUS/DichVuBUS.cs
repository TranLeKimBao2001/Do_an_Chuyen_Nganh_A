using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using QUANLYPHONGKHAM.DAO;
using QUANLYPHONGKHAM.DTO;
using System.Data;


namespace QUANLYPHONGKHAM.BUS
{
    public class DichVuBUS
    {
        public DichVuDAO dichVuDAO = new DichVuDAO();

        public List<DTO.DichVu> getAllDichVus()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dichVuDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<DTO.DichVu> list = new List<DTO.DichVu>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO.DichVu dichVu = new DTO.DichVu();
                    dichVu.MaDV = int.Parse(row["MaDV"].ToString());
                    dichVu.tenDV = row["tenDV"].ToString();
                    dichVu.MaLoaiDichVU = int.Parse(row["MaLoaiDichVU"].ToString());
                    dichVu.gia = int.Parse(row["gia"].ToString());
                    dichVu.donViTinh = row["donViTinh"].ToString();
                    dichVu.ghiChu = row["ghiChu"].ToString();

                    list.Add(dichVu);
                }
            }
            return list;
        }


        public bool AddNewDichVu(DTO.DichVu dv)
        {
            return dichVuDAO.AddNewDichVu(dv);
        }

        public bool UpdateDichVu(DTO.DichVu dv)
        {
            return dichVuDAO.UpdateDichVu(dv);
        }
        public bool DeleteDichVu(int id)
        {
            return dichVuDAO.DeleteDichVu(id);
        }

        /*  public List<DTO.DichVu> TimKiemDichVuTheoTen(string tenDV)
          {
              return dichVuDAO.TimKiemDichVuTheoTen(tenDV);
          }*/

        /* public List<DTO.DichVu> LayTatCaDichVu()
         {
             List<DTO.DichVu> dsDichVuDTO = dichVuDAO.LayTatCaDichVu();
             return dsDichVuDTO;
         }*/

        /* public void CapNhatDichVu(DichVuDTO dichVuDTO)
         {
             dichVuDAO.CapNhatDichVu(dichVuDTO);
         }
         public void ThemDichVu(DichVuDTO dichVuDTO)
         {


             dichVuDAO.ThemDichVu(dichVuDTO);
         }*/
    }

}
