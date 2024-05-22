using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DTO
{
    public class BenhNhan
    {
        public int MaBN { get; set; }
        public string hoten { get; set; }
        public string gioiTinh { get; set; }
        public string sdt { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string diaChi { get; set; }
        public string CCCD { get; set; }
        

        public BenhNhan() 
        {

        }
    }
}
