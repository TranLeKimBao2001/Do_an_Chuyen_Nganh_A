using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DTO
{
    public class PhieuKham_Thuoc
    {
        public PhieuKham_Thuoc() 
        {

        }

        public int ID { get; set; }
        public int MaPK { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public int SoNgay { get; set; }
        public string LieuDung { get; set; }


    }
}
