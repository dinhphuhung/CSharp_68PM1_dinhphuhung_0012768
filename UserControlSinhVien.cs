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
            this.BackColor = System.Drawing.Color.White;
            dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            panelTrangTrai.BackColor = System.Drawing.Color.White;
            panelTrangPhai.BackColor = System.Drawing.Color.White;
            lblTrang.BackColor = System.Drawing.Color.White;

            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvSinhVien.GridColor = System.Drawing.Color.LightGray;
            dgvSinhVien.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvSinhVien.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

            lblTimKiem.ForeColor = System.Drawing.Color.Black;
            lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

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

            CaiDatDataGridView();
            LoadDuLieuTuSQL();
            HienThiDuLieu();
            LamMoiForm();
        }

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

        private void CaiDatDataGridView()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.Columns.Clear();
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã SV", DataPropertyName = "MaSV", Width = 80 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và Tên", DataPropertyName = "HoTen", Width = 200 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giới Tính", DataPropertyName = "GioiTinh", Width = 100 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày Sinh", DataPropertyName = "NgaySinh", Width = 120 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lớp", DataPropertyName = "Lop", Width = 100 });
            dgvSinhVien.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
        }

        private void HienThiDuLieu()
        {
            tongSoTrang = (int)Math.Ceiling((double)dsHienThi.Count / soDoiTuongMoiTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;
            if (trangHienTai > tongSoTrang) trangHienTai = tongSoTrang;
            var ds = dsHienThi.Skip((trangHienTai - 1) * soDoiTuongMoiTrang).Take(soDoiTuongMoiTrang).ToList();
            dgvSinhVien.DataSource = ds;
            lblTrang.Text = $"Trang {trangHienTai}/{tongSoTrang}  |  {dsHienThi.Count} bản ghi";
        }

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

        private void HienThiThongTinLenForm(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV.ToString();
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            cboGioiTinh.SelectedItem = sv.GioiTinh;
            cboLop.SelectedValue = sv.Lop;
            txtMaSV.ReadOnly = true;
        }

        // ========== CELL CLICK ==========
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvSinhVien.DataSource is List<SinhVien> ds && e.RowIndex < ds.Count)
                HienThiThongTinLenForm(ds[e.RowIndex]);
        }

        private void btnThem_Click(object sender, EventArgs e) { }
        private void btnSua_Click(object sender, EventArgs e) { }
        private void btnXoa_Click(object sender, EventArgs e) { }
        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoiForm();
        private void btnTim_Click(object sender, EventArgs e) { }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e) { }
        private void btnDauTrang_Click(object sender, EventArgs e) { trangHienTai = 1; HienThiDuLieu(); }
        private void btnTruoc_Click(object sender, EventArgs e) { if (trangHienTai > 1) { trangHienTai--; HienThiDuLieu(); } }
        private void btnSau_Click(object sender, EventArgs e) { if (trangHienTai < tongSoTrang) { trangHienTai++; HienThiDuLieu(); } }
        private void btnCuoiTrang_Click(object sender, EventArgs e) { trangHienTai = tongSoTrang; HienThiDuLieu(); }
    }
}