using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYPHONGKHAM.DTO
{
    public class NhanVien
    {
        public NhanVien()
        {

        }
        public int MaNV { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Hoten { get; set; }
        public string HinhAnh { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string CCCD { get; set; }
        public string Chucvu { get; set; }
        public DateTime Ngayvaolam { get; set; }

        public NhanVien(int MaNV, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Taikhoan, string Matkhau, string CCCD, string Chucvu, string HinhAnh, DateTime Ngayvaolam)
        {
            this.MaNV = MaNV;
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
            this.Diachi = Diachi;
            this.Taikhoan=Taikhoan;
            this.Matkhau = Matkhau;
            this.CCCD = CCCD;
            this.Chucvu = Chucvu;
            this.HinhAnh = HinhAnh;
            this.Ngayvaolam = Ngayvaolam;
        }
    }
}
