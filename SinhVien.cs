using System;

namespace Quản_Lý_Sinh_Viên
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; } = "";
        public string GioiTinh { get; set; } = "";
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; } = "";
    }
}