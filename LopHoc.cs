namespace Quản_Lý_Sinh_Viên
{
    public class LopHoc
    {
        public string MaLop { get; set; } = "";
        public string TenLop { get; set; } = "";

        public override string ToString()
        {
            return $"{MaLop} – Lớp {MaLop}";
        }
    }
}