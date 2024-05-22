using QUANLYPHONGKHAM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.BUS
{
    public class LopThuocBUS
    {
        public LopThuocDAO lopThuocDAO=new LopThuocDAO();

        public List<DTO.LopThuoc> GetAllLopThuocs()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = lopThuocDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<DTO.LopThuoc> list = new List<DTO.LopThuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO.LopThuoc lopThuoc = new DTO.LopThuoc();

                    lopThuoc.MaLopThuoc = int.Parse(row["MaLopThuoc"].ToString());
                    lopThuoc.tenLopThuoc = row["tenLopThuoc"].ToString();
                    lopThuoc.Ghichu = row["ghiChu"].ToString();



                    list.Add(lopThuoc);
                }
            }
            return list;
        }

        public bool AddNewLopThuoc(DTO.LopThuoc lopThuoc)
        {
            return lopThuocDAO.AddNewLopThuoc(lopThuoc);
        }

        public bool UpdateLopThuoc(DTO.LopThuoc lopThuoc)
        {
            return lopThuocDAO.UpdateLopThuoc(lopThuoc);
        }
        public bool DeleteLopThuoc(int id)
        {
            return lopThuocDAO.DeleteLopThuoc(id);
        }

    }
}
