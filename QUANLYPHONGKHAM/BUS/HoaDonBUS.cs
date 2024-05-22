using QUANLYPHONGKHAM.DAO;
using QUANLYPHONGKHAM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.BUS
{
    public class HoaDonBUS
    {
        

        private HoaDonDAO hoaDonDAO;

        public HoaDonBUS()
        {
            hoaDonDAO = new HoaDonDAO();
        }

        public List<HoaDon> getAllHoaDons()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = hoaDonDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<HoaDon> list = new List<HoaDon>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    HoaDon hd = new HoaDon();

                    hd.MaHD = Int32.Parse(dr["MaHD"].ToString());
                    hd.Ngaylap = DateTime.Parse(dr["ngayLap"].ToString());
                    hd.tongTien = Int32.Parse(dr["tongTien"].ToString());
                    hd.MaPK = Int32.Parse(dr["MaHD"].ToString());

                    
                    list.Add(hd);
                }
            }
            return list;
        }

        public bool AddNewHoaDon(HoaDon hd)
        {
            return hoaDonDAO.AddNewHoaDon(hd);
        }

    }
}
