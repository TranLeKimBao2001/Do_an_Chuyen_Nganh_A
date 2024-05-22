using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DTO
{
    public class DichVu
    {
        public DichVu() { }

        public int MaDV { get; set; }

        public string tenDV { get; set; }
        public int MaLoaiDichVU { get; set; }

        public int gia { get; set; }

        public string donViTinh { get; set; }

        public string ghiChu { get; set; }


    }
}
