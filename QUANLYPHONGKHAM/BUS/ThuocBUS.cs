using QUANLYPHONGKHAM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.BUS
{
    public class ThuocBUS
    {
        public ThuocDAO thuocDAO=new ThuocDAO();

        public List<DTO.Thuoc> GetAllThuocs()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = thuocDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<DTO.Thuoc> list = new List<DTO.Thuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DTO.Thuoc thuoc = new DTO.Thuoc();

                    thuoc.Mathuoc = int.Parse(row["MaThuoc"].ToString());
                    thuoc.TenThuoc = row["tenThuoc"].ToString();
                    thuoc.cachDung = row["cachDung"].ToString();
                    thuoc.thanhPhan = row["thanhPhan"].ToString();
                    thuoc.donViTinh = row["donViTinh"].ToString();
                    thuoc.ghiChu = row["ghiChu"].ToString();
                    thuoc.MaLopthuoc = int.Parse(row["MaLopThuoc"].ToString());
                    thuoc.hamLuongNDo = row["hamLuongNDo"].ToString();
                    thuoc.dangBaoChe = row["dangBaoChe"].ToString();
                    thuoc.HinhAnh = row["hinhAnh"].ToString();

                    list.Add(thuoc);
                }
            }
            return list;
        }

        public string[] getAllImageName()
        {
            DataTable dt = new DataTable();
            string[] dsAnh = null;
            try
            {
                dt = thuocDAO.getAllImageName();
                if (dt != null && dt.Rows.Count > 0)
                {
                    dsAnh = new string[dt.Rows.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dsAnh[i] = dt.Rows[i]["hinhAnh"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dsAnh;
        }

        public string[] getImageNameBySearchName(string searchName, int maLoaiThuoc)
        {
            DataTable dt = new DataTable();
            string[] dsAnh = null;
            try
            {
                dt = thuocDAO.getImageNameWithTenThuoc(searchName, maLoaiThuoc);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dsAnh = new string[dt.Rows.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dsAnh[i] = dt.Rows[i]["hinhAnh"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dsAnh;
        }

        public List<DTO.Thuoc> TimTheoTenThuoc(string searchName, int MaLopThuoc)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = thuocDAO.TimTheotenThuoc(searchName, MaLopThuoc);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<DTO.Thuoc> list = new List<DTO.Thuoc>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    DTO.Thuoc thuoc = new DTO.Thuoc();

                    thuoc.Mathuoc = int.Parse(dr["MaThuoc"].ToString());
                    thuoc.TenThuoc = dr["tenThuoc"].ToString();
                    thuoc.cachDung = dr["cachDung"].ToString();
                    thuoc.thanhPhan = dr["thanhPhan"].ToString();
                    thuoc.HinhAnh = dr["hinhAnh"].ToString();
                    thuoc.donViTinh = dr["donViTinh"].ToString();
                    thuoc.ghiChu = dr["ghiChu"].ToString();
                    thuoc.MaLopthuoc = int.Parse(dr["MaLopThuoc"].ToString());
                    thuoc.hamLuongNDo = dr["hamLuongNDo"].ToString();
                    thuoc.dangBaoChe = dr["dangBaoChe"].ToString();
                    list.Add(thuoc);
                }
            }
            return list;
        }
        public bool AddNewThuoc(DTO.Thuoc thuoc)
        {
            return thuocDAO.AddNewThuoc(thuoc);
        }

        public bool UpdateThuoc(DTO.Thuoc thuoc)
        {
            return thuocDAO.UpdateThuoc(thuoc);
        }
        public bool DeleteThuoc(int id)
        {
            return thuocDAO.DeleteThuoc(id);
        }
    }
}
