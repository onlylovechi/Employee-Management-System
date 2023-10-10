using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANQUYENADMIN.DTO
{
    /*NHANVIEN (MANV, TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP,
VAITRO, MANQL, PHG)*/
    internal class NhanVienDTO
    {
        private string MaNV;
        private string TenNV;
        private string Phai;
        private string NgaySinh;
        private string DiaChi;
        private string SoDT;
        private string Luong;
        private string PhuCap;
        private string VaiTro;
        private string MaNQL;
        private string PHG;
        
        public NhanVienDTO(string maNV, string tenNV, string phai, string ngaySinh, string diaChi, string soDT, string luong, string phuCap, string vaiTro, string maNQL, string pHG)
        {
            MaNV = maNV;
            TenNV = tenNV;
            Phai = phai;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDT = soDT;
            Luong = luong;
            PhuCap = phuCap;
            VaiTro = vaiTro;
            MaNQL = maNQL;
            PHG = pHG;
        }
    }
}
