using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Quản_Lý_Sinh_Viên
{
    public class DatabaseConnection
    {
        private static readonly string _connectionString =
    "Server=ADMIN-PC\\SQLEXPRESS01;Database=qlsv;User Id=sa;Password=123456;TrustServerCertificate=True;Encrypt=False;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // ========== LẤY DANH SÁCH SINH VIÊN ==========
        public static List<SinhVien> GetAllSinhVien()
        {
            List<SinhVien> list = new List<SinhVien>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [id],[hoten],[gioitinh],[ngaysinh],[malop] FROM [dbo].[tbl_sinhviens]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SinhVien
                    {
                        MaSV = Convert.ToInt32(reader["id"]),
                        HoTen = reader["hoten"].ToString()!,
                        GioiTinh = reader["gioitinh"].ToString()!,
                        NgaySinh = Convert.ToDateTime(reader["ngaysinh"]),
                        Lop = reader["malop"].ToString()!
                    });
                }
                reader.Close();
            }
            return list;
        }

        // ========== THÊM SINH VIÊN ==========
        public static bool AddSinhVien(SinhVien sv)
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                string query = "INSERT INTO [dbo].[tbl_sinhviens] ([id],[hoten],[gioitinh],[ngaysinh],[malop]) " +
                               "VALUES (@id,@hoten,@gioitinh,@ngaysinh,@malop)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", sv.MaSV);
                cmd.Parameters.AddWithValue("@hoten", sv.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@malop", sv.Lop);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // ========== CẬP NHẬT SINH VIÊN ==========
        public static bool UpdateSinhVien(SinhVien sv)
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                string query = "UPDATE [dbo].[tbl_sinhviens] " +
                               "SET [hoten]=@hoten,[gioitinh]=@gioitinh,[ngaysinh]=@ngaysinh,[malop]=@malop " +
                               "WHERE [id]=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", sv.MaSV);
                cmd.Parameters.AddWithValue("@hoten", sv.HoTen);
                cmd.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@malop", sv.Lop);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // ========== XÓA SINH VIÊN ==========
        public static bool DeleteSinhVien(int maSV)
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                string query = "DELETE FROM [dbo].[tbl_sinhviens] WHERE [id]=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", maSV);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // ========== LẤY DANH SÁCH LỚP HỌC ==========
        public static List<LopHoc> GetAllLopHoc()
        {
            List<LopHoc> list = new List<LopHoc>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [malop],[tenlop] FROM [dbo].[tbl_lophoc]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new LopHoc
                    {
                        MaLop = reader["malop"].ToString()!,
                        TenLop = reader["tenlop"].ToString()!
                    });
                }
                reader.Close();
            }
            return list;
        }

        // ========== THÊM LỚP HỌC ==========
        public static bool AddLopHoc(LopHoc lh)
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                string query = "INSERT INTO [dbo].[tbl_lophoc] ([malop],[tenlop]) VALUES (@malop,@tenlop)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@malop", lh.MaLop);
                cmd.Parameters.AddWithValue("@tenlop", lh.TenLop);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // ========== CẬP NHẬT LỚP HỌC ==========
        public static bool UpdateLopHoc(LopHoc lh)
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                string query = "UPDATE [dbo].[tbl_lophoc] SET [tenlop]=@tenlop WHERE [malop]=@malop";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@malop", lh.MaLop);
                cmd.Parameters.AddWithValue("@tenlop", lh.TenLop);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // ========== XÓA LỚP HỌC ==========
        public static bool DeleteLopHoc(string maLop)
        {
            try
            {
                using SqlConnection conn = GetConnection();
                conn.Open();
                string query = "DELETE FROM [dbo].[tbl_lophoc] WHERE [malop]=@malop";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@malop", maLop);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // ========== TÌM SINH VIÊN ==========
        public static List<SinhVien> SearchSinhVien(string keyword)
        {
            List<SinhVien> list = new List<SinhVien>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [id],[hoten],[gioitinh],[ngaysinh],[malop] FROM [dbo].[tbl_sinhviens] " +
                               "WHERE [hoten] LIKE @kw OR [malop] LIKE @kw OR CAST([id] AS NVARCHAR) LIKE @kw";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new SinhVien
                    {
                        MaSV = Convert.ToInt32(reader["id"]),
                        HoTen = reader["hoten"].ToString()!,
                        GioiTinh = reader["gioitinh"].ToString()!,
                        NgaySinh = Convert.ToDateTime(reader["ngaysinh"]),
                        Lop = reader["malop"].ToString()!
                    });
                }
                reader.Close();
            }
            return list;
        }

        // ========== TÌM LỚP HỌC ==========
        public static List<LopHoc> SearchLopHoc(string keyword)
        {
            List<LopHoc> list = new List<LopHoc>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT [malop],[tenlop] FROM [dbo].[tbl_lophoc] " +
                               "WHERE [malop] LIKE @kw OR [tenlop] LIKE @kw";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new LopHoc
                    {
                        MaLop = reader["malop"].ToString()!,
                        TenLop = reader["tenlop"].ToString()!
                    });
                }
                reader.Close();
            }
            return list;
        }
    }
}