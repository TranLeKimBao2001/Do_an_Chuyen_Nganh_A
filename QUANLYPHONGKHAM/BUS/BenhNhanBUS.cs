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
    public class BenhNhanBUS
    {
        private BenhNhanDAO benhNhanDAO;

        public BenhNhanBUS()
        {
            benhNhanDAO = new BenhNhanDAO();
        }

        public List<BenhNhan> GetAllBenhNhans()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = benhNhanDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<BenhNhan> list = new List<BenhNhan>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BenhNhan bn = new BenhNhan();
                    bn.MaBN = Int32.Parse(dr["MaBN"].ToString());

                    bn.hoten = dr["hoTen"].ToString();

                    

                    bn.gioiTinh = dr["gioiTinh"].ToString();

                    bn.sdt = dr["sdt"].ToString();

                    bn.Ngaysinh = DateTime.Parse(dr["ngaySinh"].ToString());

                    bn.diaChi = dr["diaChi"].ToString();

                    bn.CCCD = dr["CCCD"].ToString();

                    

                    list.Add(bn);
                }
            }
            return list;
        }


        public List<BenhNhan> TimTheoTENBenhNhan(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = benhNhanDAO.TimTheoTenBenhNhan(keyword);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<BenhNhan> list = new List<BenhNhan>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BenhNhan bn = new BenhNhan();
                    bn.MaBN = Int32.Parse(dr["MaBN"].ToString());
                    bn.hoten = dr["hoTen"].ToString();
                    bn.gioiTinh = dr["gioiTinh"].ToString();
                    bn.sdt = dr["sdt"].ToString();
                    bn.Ngaysinh = DateTime.Parse(dr["ngaySinh"].ToString());
                    bn.diaChi = dr["diaChi"].ToString();
                    bn.sdt = dr["sdt"].ToString();
                    bn.CCCD = dr["CCCD"].ToString();

                    list.Add(bn);
                }
            }
            return list;
        }

       

        public List<BenhNhan> TimTheoDIACHIBenhNhan(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = benhNhanDAO.TimTheoDiaChiBenhNhan(keyword);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<BenhNhan> list = new List<BenhNhan>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BenhNhan bn = new BenhNhan();
                    bn.MaBN = Int32.Parse(dr["MaBN"].ToString());
                    bn.hoten = dr["hoTen"].ToString();
                    bn.gioiTinh = dr["gioiTinh"].ToString();
                    bn.sdt = dr["sdt"].ToString();
                    bn.Ngaysinh = DateTime.Parse(dr["ngaySinh"].ToString());
                    bn.diaChi = dr["diaChi"].ToString();
                    bn.sdt = dr["sdt"].ToString();
                    bn.CCCD = dr["CCCD"].ToString();

                    list.Add(bn);
                }
            }
            return list;
        }

        public bool AddNewBenhNhan(BenhNhan bn)
        {
            return benhNhanDAO.AddNewBenhNhan(bn);
        }
        public bool UpdateBenhNhan(BenhNhan bn)
        {
            return benhNhanDAO.UpdateBenhNhan(bn);
        }
        public bool DeleteUser(int id)
        {
            return benhNhanDAO.DeleteBenhNhan(id);
        }
    }
}
