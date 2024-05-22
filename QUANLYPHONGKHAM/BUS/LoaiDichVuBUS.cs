using QUANLYPHONGKHAM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.BUS
{
    public class LoaiDichVuBUS
    {
        public LoaiDichVuDAO loaiDichVuDAO=new LoaiDichVuDAO();
        public List<DTO.LoaiDichVu> getAllLoaiDichVus()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = loaiDichVuDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<DTO.LoaiDichVu> list = new List<DTO.LoaiDichVu>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO.LoaiDichVu loaidichVu = new DTO.LoaiDichVu();
                    loaidichVu.MaLoaiDichVu= int.Parse(row["MaLoaiDichVu"].ToString());
                    loaidichVu.TenLoaiDichVu= row["tenLoaiDichVu"].ToString();
                    loaidichVu.ghiChu= row["ghiChu"].ToString();

                    

                    list.Add(loaidichVu);
                }
            }
            return list;
        }

        public bool AddNewLoaiDichVu(DTO.LoaiDichVu loaiDichVu)
        {
            return loaiDichVuDAO.AddNewLoaiDichVu(loaiDichVu);
        }

        public bool UpdateLoaiDichVu(DTO.LoaiDichVu loaiDichVu)
        {
            return loaiDichVuDAO.UpdateLoaiDichVu(loaiDichVu);
        }
        public bool DeleteLoaiDichVu(int id)
        {
            return loaiDichVuDAO.DeleteLoaiDichVu(id);
        }
    }


}
