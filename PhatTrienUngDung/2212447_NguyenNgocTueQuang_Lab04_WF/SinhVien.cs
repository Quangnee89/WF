using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212447_NguyenNgocTueQuang_Lab04_WF
{
    internal class SinhVien

    {

        public string MaSoSV { get; set; }

        public string HoTen { get; set; }

        public string Phai { get; set; }

        public DateTime NgaySinh { get; set; }

        public string Lop { get; set; }

        public string

        SoDienThoai

        { get; set; }

        public string Email { get; set; }

        public string DiaChi { get; set; }

        public string HinhAnh { get; set; }

        public SinhVien(string maSo, string hoTen, string phai, DateTime ngaySinh, string lop, string soDienThoai, string email, string diaChi, string hinhAnh)

        {

            MaSoSV = maSo;

            HoTen = hoTen;

            Phai = phai;

            NgaySinh = ngaySinh;

            Lop = lop;

            SoDienThoai = soDienThoai;

            Email = email;

            DiaChi = diaChi;

            HinhAnh = hinhAnh;

        }

        public SinhVien()
        {
        }
    }

}