using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quản_Lý_Sinh_Viên
{
    public partial class UserControlLopHoc : UserControl
    {
        private List<LopHoc> dsLop = new List<LopHoc>();
        private List<LopHoc> dsHienThi = new List<LopHoc>();
        private int soDoiTuongMoiTrang = 10;
        private int trangHienTai = 1;
        private int tongSoTrang = 1;

        public UserControlLopHoc()
        {
            InitializeComponent();
        }

        private void UserControlLopHoc_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            panelTrangTrai.BackColor = System.Drawing.Color.White;
            panelTrangPhai.BackColor = System.Drawing.Color.White;
            lblTrang.BackColor = System.Drawing.Color.White;

            dgvLopHoc.EnableHeadersVisualStyles = false;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvLopHoc.GridColor = System.Drawing.Color.LightGray;
            dgvLopHoc.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvLopHoc.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvLopHoc.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

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

            btnXemDanhSach.BackColor = System.Drawing.Color.FromArgb(23, 120, 200);
            btnXemDanhSach.ForeColor = System.Drawing.Color.White;
            btnXemDanhSach.FlatStyle = FlatStyle.Flat;
            btnXemDanhSach.FlatAppearance.BorderSize = 0;

            CaiDatDataGridView();
            LoadDuLieuTuSQL();
            HienThiDuLieu();
            LamMoiForm();
        }

        private void LoadDuLieuTuSQL()
        {
            dsLop = DatabaseConnection.GetAllLopHoc();
            dsHienThi = new List<LopHoc>(dsLop);
        }

        private void CaiDatDataGridView()
        {
            dgvLopHoc.AutoGenerateColumns = false;
            dgvLopHoc.Columns.Clear();
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã lớp", DataPropertyName = "MaLop", Width = 150 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên lớp", DataPropertyName = "TenLop", Width = 250 });
            dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.MultiSelect = false;
            dgvLopHoc.ReadOnly = true;
        }

        private void HienThiDuLieu()
        {
            tongSoTrang = (int)Math.Ceiling((double)dsHienThi.Count / soDoiTuongMoiTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;
            if (trangHienTai > tongSoTrang) trangHienTai = tongSoTrang;
            var ds = dsHienThi.Skip((trangHienTai - 1) * soDoiTuongMoiTrang).Take(soDoiTuongMoiTrang).ToList();
            dgvLopHoc.DataSource = ds;
            lblTrang.Text = $"Trang {trangHienTai}/{tongSoTrang}  |  {dsHienThi.Count} bản ghi";
        }

        private void LamMoiForm()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaLop.ReadOnly = false;
            txtMaLop.Focus();
        }

        private void HienThiThongTinLenForm(LopHoc lh)
        {
            txtMaLop.Text = lh.MaLop;
            txtTenLop.Text = lh.TenLop;
            txtMaLop.ReadOnly = true;
        }

        // ========== CELL CLICK ==========
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var ds = dgvLopHoc.DataSource as List<LopHoc>;
            if (ds != null && e.RowIndex < ds.Count)
                HienThiThongTinLenForm(ds[e.RowIndex]);
        }

        private void btnThem_Click(object sender, EventArgs e) { }
        private void btnSua_Click(object sender, EventArgs e) { }
        private void btnXoa_Click(object sender, EventArgs e) { }
        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoiForm();
        private void btnTim_Click(object sender, EventArgs e) { }
        private void btnXemDanhSach_Click(object sender, EventArgs e) { }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e) { }
        private void btnDauTrang_Click(object sender, EventArgs e) { trangHienTai = 1; HienThiDuLieu(); }
        private void btnTruoc_Click(object sender, EventArgs e) { if (trangHienTai > 1) { trangHienTai--; HienThiDuLieu(); } }
        private void btnSau_Click(object sender, EventArgs e) { if (trangHienTai < tongSoTrang) { trangHienTai++; HienThiDuLieu(); } }
        private void btnCuoiTrang_Click(object sender, EventArgs e) { trangHienTai = tongSoTrang; HienThiDuLieu(); }
    }
}