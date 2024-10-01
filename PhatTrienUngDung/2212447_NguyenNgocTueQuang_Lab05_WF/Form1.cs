using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace _2212447_NguyenNgocTueQuang_Lab05_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<StudentInfo> LoadJSON(string Path)
        {
            // Khai báo danh sách lưu trữ
            List<StudentInfo> List = new List<StudentInfo>();
            // Đối tượng đọc tập tin
            Path = "D:\\PhatTrienUngDung\\2212447_NguyenNgocTueQuang_Lab05_WF\\SinhVien.json";
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd(); // Đọc hết
                                         // Chuyển về thành mảng các đối tượng
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // Lấy đối tượng sinhvien
            var students = array["sinhvien"].Children();
            foreach (var item in students) // Duyệt mảng
            {
                // Lấy các thành phần
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();
                // Chuyển vào đối tượng StudentInfo
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                List.Add(info);// Thêm vào danh sách
            }
            return List;
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            string Str = ""; // chuỗi lưu trữ
            string Path = "string Str = \"\"; // chuỗi lưu trữ\r\n string Path = \"../../JSONExample.json\"; // Đường dẫn tập tin\r\n List<StudentInfo> List = LoadJSON(Path); // Gọi phương thức\r\n for (int i = 0; i < List.Count; i++) // Đọc danh sách\r\n {\r\n StudentInfo info = List[i];\r\n Str += string.Format(\"Sinh viên {0} có MSSV: {1}, họ tên: {2},\r\nđiểm TB: {3}\\r\\n\", (i + 1), info.MSSV, info.Hoten, info.Diem);\r\n }\r\n MessageBox.Show(Str);"; // Đường dẫn tập tin
            List<StudentInfo> List = LoadJSON(Path); // Gọi phương thức
            for (int i = 0; i < List.Count; i++) // Đọc danh sách
            {
                StudentInfo info = List[i];
                Str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2},điểm TB: {3}\r\n", (i + 1), info.MSSV, info.Hoten, info.Diem);
            }
            MessageBox.Show(Str);
        }
    }
}
