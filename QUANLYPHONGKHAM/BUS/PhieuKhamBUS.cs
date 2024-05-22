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
    public class PhieuKhamBUS
    {
        private PhieuKhamDAO phieuKhamDAO;
        public PhieuKhamBUS()
        {
            phieuKhamDAO=new PhieuKhamDAO();
        }

        public List<PhieuKham> getAllPhieuKhamByYtas()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = phieuKhamDAO.getAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<PhieuKham> list = new List<PhieuKham>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    PhieuKham pk = new PhieuKham();
                    pk.MaPK = Int32.Parse(dr["MaPK"].ToString());
                    pk.Ngaylap = DateTime.Parse(dr["ngayLap"].ToString());
                    pk.Cannang = Int32.Parse(dr["canNang"].ToString());
                    pk.LydoKham = dr["lyDoKham"].ToString();
                    
                    pk.MaNV = Int32.Parse(dr["MaNV"].ToString());
                    pk.MaBN = Int32.Parse(dr["MaBN"].ToString());
                  


                    list.Add(pk);
                }
            }
            return list;
        }

        public bool AddNewPKham(PhieuKham pk)
        {
            return phieuKhamDAO.AddNewPhieuKhamByYTa(pk);
        }
    }
}
