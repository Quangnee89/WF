//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using System.IO;
//using Newtonsoft.Json.Linq;

//namespace _2212447_NguyenNgocTueQuang_Lab05_WF
//{
//    internal class JSON
//    {
//        private List<StudentInfo> LoadJSON(string Path)
//        {
//            // Khai báo danh sách lưu trữ
//            List<StudentInfo> List = new List<StudentInfo>();
//            // Đối tượng đọc tập tin
//            Path = "D:\\PhatTrienUngDung\\2212447_NguyenNgocTueQuang_Lab05_WF\\SinhVien.json";
//            StreamReader r = new StreamReader(Path);
//            string json = r.ReadToEnd(); // Đọc hết
//                                         // Chuyển về thành mảng các đối tượng
//            var array = (JObject)JsonConvert.DeserializeObject(json);
//            // Lấy đối tượng sinhvien
//            var students = array["sinhvien"].Children();
//            foreach (var item in students) // Duyệt mảng
//            {
//                // Lấy các thành phần
//                string mssv = item["MSSV"].Value<string>();
//                string hoten = item["hoten"].Value<string>();
//                int tuoi = item["tuoi"].Value<int>();
//                double diem = item["diem"].Value<double>();
//                bool tongiao = item["tongiao"].Value<bool>();
//                // Chuyển vào đối tượng StudentInfo
//                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem,tongiao);
//                List.Add(info);// Thêm vào danh sách
//            }
//            return List;
//        }
//    }
//}
