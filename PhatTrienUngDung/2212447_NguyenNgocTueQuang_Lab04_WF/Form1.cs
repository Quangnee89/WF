using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212447_NguyenNgocTueQuang_Lab04_WF
{
    public partial class Form1 : Form
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();

            SinhVien sv1 = new SinhVien("2212447", "Nguyễn Ngọc Tuệ Quang", "Nam", new DateTime(8 / 9 / 2004), "CTK46", "098.999.8888", "2212447@dlu.edu.vn", "DALAT", "");

            danhSachSinhVien.Add(sv1);

            foreach (SinhVien sv in danhSachSinhVien)

            {

                ListViewItem item = new ListViewItem(sv.MaSoSV);

                item.SubItems.Add(sv.HoTen);

                item.SubItems.Add(sv.Phai);

                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));

                item.SubItems.Add(sv.Lop);

                item.SubItems.Add(sv.SoDienThoai);

                item.SubItems.Add(sv.Email);

                item.SubItems.Add(sv.DiaChi);

                item.SubItems.Add(sv.HinhAnh);

                listView1.Items.Add(item);

            }

        }
         private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSoSV = txtMaSo.Text;
            sv.HoTen = txtHoTen.Text;
            sv.Phai = rdNam.Checked ? "Nam" : "Nữ";
            sv.NgaySinh = dtpNgaySinh.Value;
            // ... các thuộc tính khác
            //sv.HinhAnh = pictureBox1.Image;

            danhSachSinhVien.Add(sv);
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            listView1.Items.Clear();
            foreach (SinhVien sv in danhSachSinhVien)
            {
                ListViewItem item = new ListViewItem(sv.MaSoSV);
                item.SubItems.Add(sv.HoTen);
                // ... thêm các subitem tương ứng với các thuộc tính khác
                item.ImageKey = "student"; // Nếu bạn sử dụng ImageList
                listView1.Items.Add(item);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
