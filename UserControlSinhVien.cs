using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quản_Lý_Sinh_Viên
{
    public partial class UserControlSinhVien : UserControl
    {
        private List<SinhVien> dsSinhVien = new List<SinhVien>();
        private List<SinhVien> dsHienThi = new List<SinhVien>();
        private List<LopHoc> dsLop = new List<LopHoc>();
        private int soDoiTuongMoiTrang = 10;
        private int trangHienTai = 1;
        private int tongSoTrang = 1;

        public UserControlSinhVien()
        {
            InitializeComponent();
        }

        private void UserControlSinhVien_Load(object sender, EventArgs e)
        {
            // ===== NỀN TRẮNG =====
            this.BackColor = System.Drawing.Color.White;
            dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            panelTrangTrai.BackColor = System.Drawing.Color.White;
            panelTrangPhai.BackColor = System.Drawing.Color.White;
            lblTrang.BackColor = System.Drawing.Color.White;

            // ===== DATAGRIDVIEW =====
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvSinhVien.GridColor = System.Drawing.Color.LightGray;
            dgvSinhVien.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSinhVien.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

            // ===== LABEL TÌM KIẾM =====
            lblTimKiem.ForeColor = System.Drawing.Color.Black;
            lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // ===== MÀU BUTTON =====
            btnThem.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            btnThem.ForeColor = System.Drawing.Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.FlatAppearance.BorderSize = 0;

            btnSua.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            btnSua.ForeColor = System.Drawing.Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.FlatAppearance.BorderSize = 0;

            btnXoa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnXoa.ForeColor = System.Drawing.Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.FlatAppearance.BorderSize = 0;

            btnLamMoi.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnLamMoi.ForeColor = System.Drawing.Color.White;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.FlatAppearance.BorderSize = 0;

            btnTim.BackColor = System.Drawing.Color.FromArgb(52, 58, 64);
            btnTim.ForeColor = System.Drawing.Color.White;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.FlatAppearance.BorderSize = 0;

            // ===== KHỞI TẠO =====
            CaiDatDataGridView();
            LoadDuLieuTuSQL();
            HienThiDuLieu();
            LamMoiForm();
        }

        // ========== LẤY DỮ LIỆU TỪ SQL ==========
        private void LoadDuLieuTuSQL()
        {
            try
            {
                dsLop = DatabaseConnection.GetAllLopHoc();
                dsSinhVien = DatabaseConnection.GetAllSinhVien();
                dsHienThi = new List<SinhVien>(dsSinhVien);

                cboLop.DataSource = new List<LopHoc>(dsLop);
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== CÀI ĐẶT DATAGRIDVIEW ==========
        private void CaiDatDataGridView()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.Columns.Clear();

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Mã SV", DataPropertyName = "MaSV", Width = 80 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Họ và Tên", DataPropertyName = "HoTen", Width = 200 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Giới Tính", DataPropertyName = "GioiTinh", Width = 100 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Ngày Sinh", DataPropertyName = "NgaySinh", Width = 120 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Lớp", DataPropertyName = "Lop", Width = 100 });

            dgvSinhVien.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
        }

        // ========== HIỂN THỊ DỮ LIỆU ==========
        private void HienThiDuLieu()
        {
            tongSoTrang = (int)Math.Ceiling((double)dsHienThi.Count / soDoiTuongMoiTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;
            if (trangHienTai > tongSoTrang) trangHienTai = tongSoTrang;

            var ds = dsHienThi
                .Skip((trangHienTai - 1) * soDoiTuongMoiTrang)
                .Take(soDoiTuongMoiTrang)
                .ToList();

            dgvSinhVien.DataSource = ds;
            lblTrang.Text = $"Trang {trangHienTai}/{tongSoTrang}  |  {dsHienThi.Count} bản ghi";
        }

        // ========== TÌM KIẾM ==========
        private void TimKiem()
        {
            string keyword = txtTimKiem.Text.Trim();
            dsHienThi = string.IsNullOrEmpty(keyword)
                ? new List<SinhVien>(dsSinhVien)
                : DatabaseConnection.SearchSinhVien(keyword);
            trangHienTai = 1;
            HienThiDuLieu();
        }

        // ========== LÀM MỚI FORM ==========
        private void LamMoiForm()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            txtMaSV.ReadOnly = false;
            txtMaSV.Focus();
        }

        // ========== HIỂN THỊ LÊN FORM ==========
        private void HienThiThongTinLenForm(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV.ToString();
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            cboGioiTinh.SelectedItem = sv.GioiTinh;
            cboLop.SelectedValue = sv.Lop;
            txtMaSV.ReadOnly = true;
        }

        // ========== SỰ KIỆN BUTTON ==========
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtMaSV.Text, out int maSV))
            {
                MessageBox.Show("Mã SV phải là số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dsSinhVien.Any(sv => sv.MaSV == maSV))
            {
                MessageBox.Show("Mã SV đã tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sv = new SinhVien
            {
                MaSV = maSV,
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Nam",
                NgaySinh = dtpNgaySinh.Value,
                Lop = cboLop.SelectedValue?.ToString() ?? ""
            };

            if (DatabaseConnection.AddSinhVien(sv))
            {
                dsSinhVien.Add(sv);
                TimKiem();
                LamMoiForm();
                MessageBox.Show("Thêm thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaSV.Text, out int maSV)) return;
            var sv = dsSinhVien.FirstOrDefault(s => s.MaSV == maSV);
            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sv.HoTen = txtHoTen.Text.Trim();
            sv.GioiTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Nam";
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Lop = cboLop.SelectedValue?.ToString() ?? "";

            if (DatabaseConnection.UpdateSinhVien(sv))
            {
                TimKiem();
                MessageBox.Show("Sửa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaSV.Text, out int maSV)) return;
            var sv = dsSinhVien.FirstOrDefault(s => s.MaSV == maSV);
            if (sv == null) return;

            if (MessageBox.Show($"Xóa sinh viên '{sv.HoTen}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DatabaseConnection.DeleteSinhVien(maSV))
                {
                    dsSinhVien.Remove(sv);
                    TimKiem();
                    LamMoiForm();
                    MessageBox.Show("Xóa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoiForm();
        private void btnTim_Click(object sender, EventArgs e) => TimKiem();

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) TimKiem();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvSinhVien.DataSource is List<SinhVien> ds && e.RowIndex < ds.Count)
                HienThiThongTinLenForm(ds[e.RowIndex]);
        }

        // ========== PHÂN TRANG ==========
        private void btnDauTrang_Click(object sender, EventArgs e)
        {
            trangHienTai = 1;
            HienThiDuLieu();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1) { trangHienTai--; HienThiDuLieu(); }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (trangHienTai < tongSoTrang) { trangHienTai++; HienThiDuLieu(); }
        }

        private void btnCuoiTrang_Click(object sender, EventArgs e)
        {
            trangHienTai = tongSoTrang;
            HienThiDuLieu();
        }
    }
}