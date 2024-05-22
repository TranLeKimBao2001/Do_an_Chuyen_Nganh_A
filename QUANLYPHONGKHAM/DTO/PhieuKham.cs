using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DTO
{
    public class PhieuKham
    {
        public PhieuKham() 
        {
            
        }

        public int MaPK { get; set; }
        public int MaBN { get; set; }
        public int MaNV { get; set; }
        public DateTime Ngaylap { get; set; }
        public DateTime NgayTaikham { get; set; }
        public int Cannang { get; set; }
        public string ghiChu { get; set; }
        public string LydoKham { get; set; }
        public string ChuanDoan{ get; set; }
        public string Ketluan { get; set; }

    }
}
