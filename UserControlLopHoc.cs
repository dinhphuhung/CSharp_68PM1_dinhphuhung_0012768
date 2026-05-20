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
        private Dictionary<string, string> dsGhiChu = new Dictionary<string, string>();
        private int soDoiTuongMoiTrang = 10;
        private int trangHienTai = 1;
        private int tongSoTrang = 1;

        public UserControlLopHoc()
        {
            InitializeComponent();
        }

        private void UserControlLopHoc_Load(object sender, EventArgs e)
        {
            // ===== NỀN TRẮNG =====
            this.BackColor = System.Drawing.Color.White;
            dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            panelTrangTrai.BackColor = System.Drawing.Color.White;
            panelTrangPhai.BackColor = System.Drawing.Color.White;
            lblTrang.BackColor = System.Drawing.Color.White;

            // ===== DATAGRIDVIEW =====
            dgvLopHoc.EnableHeadersVisualStyles = false;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvLopHoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvLopHoc.GridColor = System.Drawing.Color.LightGray;
            dgvLopHoc.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvLopHoc.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvLopHoc.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

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

            btnXemDanhSach.BackColor = System.Drawing.Color.FromArgb(23, 120, 200);
            btnXemDanhSach.ForeColor = System.Drawing.Color.White;
            btnXemDanhSach.FlatStyle = FlatStyle.Flat;
            btnXemDanhSach.FlatAppearance.BorderSize = 0;

            // ===== KHỞI TẠO DỮ LIỆU =====
            KhoiTaoDuLieuMau();
            CaiDatDataGridView();
            dsHienThi = new List<LopHoc>(dsLop);
            HienThiDuLieu();
            LamMoiForm();
        }

        // ========== DỮ LIỆU MẪU ==========
        private void KhoiTaoDuLieuMau()
        {
            dsLop.Add(new LopHoc { MaLop = "68PM1", TenLop = "Lớp 68PM1" });
            dsLop.Add(new LopHoc { MaLop = "68PM2", TenLop = "Lớp 68PM2" });

            dsGhiChu["68PM1"] = "abc";
            dsGhiChu["68PM2"] = "xyz";
        }

        // ========== CÀI ĐẶT DATAGRIDVIEW ==========
        private void CaiDatDataGridView()
        {
            dgvLopHoc.AutoGenerateColumns = false;
            dgvLopHoc.Columns.Clear();

            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Mã ID", DataPropertyName = "MaLop", Width = 100 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Mã lớp", DataPropertyName = "MaLop", Width = 100 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Tên lớp", DataPropertyName = "TenLop", Width = 150 });
            dgvLopHoc.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Ghi chú", Width = 200 });

            dgvLopHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopHoc.MultiSelect = false;
            dgvLopHoc.ReadOnly = true;
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

            // Tạo binding source để thêm cột Ghi chú
            var result = ds.Select(lh => new
            {
                MaLop = lh.MaLop,
                TenLop = lh.TenLop,
                GhiChu = dsGhiChu.ContainsKey(lh.MaLop) ? dsGhiChu[lh.MaLop] : ""
            }).ToList();

            dgvLopHoc.DataSource = result;
            lblTrang.Text = $"Trang {trangHienTai}/{tongSoTrang}  |  {dsHienThi.Count} bản ghi";
        }

        // ========== TÌM KIẾM ==========
        private void TimKiem()
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            dsHienThi = string.IsNullOrEmpty(keyword)
                ? new List<LopHoc>(dsLop)
                : dsLop.Where(lh =>
                    lh.MaLop.ToLower().Contains(keyword) ||
                    lh.TenLop.ToLower().Contains(keyword)).ToList();

            trangHienTai = 1;
            HienThiDuLieu();
        }

        // ========== LÀM MỚI FORM ==========
        private void LamMoiForm()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtGhiChu.Text = "";
            txtMaLop.ReadOnly = false;
            txtMaLop.Focus();
        }

        // ========== HIỂN THỊ LÊN FORM ==========
        private void HienThiThongTinLenForm(LopHoc lh)
        {
            txtMaLop.Text = lh.MaLop;
            txtTenLop.Text = lh.TenLop;
            txtGhiChu.Text = dsGhiChu.ContainsKey(lh.MaLop) ? dsGhiChu[lh.MaLop] : "";
            txtMaLop.ReadOnly = true;
        }

        // ========== SỰ KIỆN BUTTON ==========
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dsLop.Any(lh => lh.MaLop == txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = txtMaLop.Text.Trim();
            dsLop.Add(new LopHoc { MaLop = maLop, TenLop = txtTenLop.Text.Trim() });
            dsGhiChu[maLop] = txtGhiChu.Text.Trim();

            TimKiem();
            LamMoiForm();
            MessageBox.Show("Thêm thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            var lh = dsLop.FirstOrDefault(l => l.MaLop == maLop);
            if (lh == null)
            {
                MessageBox.Show("Không tìm thấy lớp học!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lh.TenLop = txtTenLop.Text.Trim();
            dsGhiChu[maLop] = txtGhiChu.Text.Trim();

            TimKiem();
            MessageBox.Show("Sửa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            var lh = dsLop.FirstOrDefault(l => l.MaLop == maLop);
            if (lh == null) return;

            if (MessageBox.Show($"Xóa lớp '{lh.TenLop}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dsLop.Remove(lh);
                if (dsGhiChu.ContainsKey(maLop)) dsGhiChu.Remove(maLop);
                TimKiem();
                LamMoiForm();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoiForm();
        private void btnTim_Click(object sender, EventArgs e) => TimKiem();

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn một lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show($"Xem danh sách sinh viên của lớp {maLop}", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) TimKiem();
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex < dsHienThi.Count)
                HienThiThongTinLenForm(dsHienThi
                    .Skip((trangHienTai - 1) * soDoiTuongMoiTrang)
                    .ToList()[e.RowIndex]);
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
