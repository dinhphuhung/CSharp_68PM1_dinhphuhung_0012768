namespace Quản_Lý_Sinh_Viên
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();

            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();

            this.panelTrangTrai = new System.Windows.Forms.Panel();
            this.btnDauTrang = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.panelTrangPhai = new System.Windows.Forms.Panel();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoiTrang = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panelTrangTrai.SuspendLayout();
            this.panelTrangPhai.SuspendLayout();
            this.SuspendLayout();

            // ===== MENU STRIP =====
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuSinhVien, this.mnuLopHoc, this.mnuDangXuat });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);

            this.mnuSinhVien.Text = "Quản lý Sinh Viên";
            this.mnuSinhVien.ForeColor = System.Drawing.Color.Black;

            this.mnuLopHoc.Text = "Quản lý Lớp Học";
            this.mnuLopHoc.ForeColor = System.Drawing.Color.Black;

            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.ForeColor = System.Drawing.Color.Red;
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);

            // ===== PANEL TRÁI =====
            // Tiêu đề
            this.lblThongTin.Text = "Thông tin sinh viên";
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(15, 36);
            this.lblThongTin.Size = new System.Drawing.Size(200, 20);
            this.lblThongTin.ForeColor = System.Drawing.Color.Black;

            // Mã sinh viên
            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Location = new System.Drawing.Point(15, 65);
            this.lblMaSV.Size = new System.Drawing.Size(110, 18);
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSV.ForeColor = System.Drawing.Color.Black;

            this.txtMaSV.Location = new System.Drawing.Point(15, 85);
            this.txtMaSV.Size = new System.Drawing.Size(310, 24);
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Họ và tên
            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.Location = new System.Drawing.Point(15, 122);
            this.lblHoTen.Size = new System.Drawing.Size(110, 18);
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.ForeColor = System.Drawing.Color.Black;

            this.txtHoTen.Location = new System.Drawing.Point(15, 142);
            this.txtHoTen.Size = new System.Drawing.Size(310, 24);
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Ngày sinh
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 180);
            this.lblNgaySinh.Size = new System.Drawing.Size(110, 18);
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;

            this.dtpNgaySinh.Location = new System.Drawing.Point(15, 200);
            this.dtpNgaySinh.Size = new System.Drawing.Size(310, 24);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Giới tính
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 238);
            this.lblGioiTinh.Size = new System.Drawing.Size(110, 18);
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;

            this.cboGioiTinh.Location = new System.Drawing.Point(15, 258);
            this.cboGioiTinh.Size = new System.Drawing.Size(310, 24);
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.SelectedIndex = 0;

            // Lớp
            this.lblLop.Text = "Lớp:";
            this.lblLop.Location = new System.Drawing.Point(15, 296);
            this.lblLop.Size = new System.Drawing.Size(110, 18);
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLop.ForeColor = System.Drawing.Color.Black;

            this.cboLop.Location = new System.Drawing.Point(15, 316);
            this.cboLop.Size = new System.Drawing.Size(310, 24);
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // ===== BUTTONS =====
            // Thêm
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(15, 530);
            this.btnThem.Size = new System.Drawing.Size(150, 45);
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // Sửa
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(175, 530);
            this.btnSua.Size = new System.Drawing.Size(150, 45);
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // Xóa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(15, 585);
            this.btnXoa.Size = new System.Drawing.Size(150, 45);
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // Làm mới
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(175, 585);
            this.btnLamMoi.Size = new System.Drawing.Size(150, 45);
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ===== PANEL PHẢI =====
            // Tìm kiếm
            this.lblTimKiem.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            this.lblTimKiem.Location = new System.Drawing.Point(355, 36);
            this.lblTimKiem.Size = new System.Drawing.Size(250, 18);
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.Black;

            this.txtTimKiem.Location = new System.Drawing.Point(355, 57);
            this.txtTimKiem.Size = new System.Drawing.Size(460, 24);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);

            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(825, 54);
            this.btnTim.Size = new System.Drawing.Size(80, 30);
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // DataGridView
            this.dgvSinhVien.Location = new System.Drawing.Point(355, 95);
            this.dgvSinhVien.Size = new System.Drawing.Size(555, 470);
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // ===== PHÂN TRANG =====
            // Panel trái (<< <)
            this.panelTrangTrai.Location = new System.Drawing.Point(355, 575);
            this.panelTrangTrai.Size = new System.Drawing.Size(110, 36);
            this.panelTrangTrai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnDauTrang.Text = "<<";
            this.btnDauTrang.Location = new System.Drawing.Point(0, 0);
            this.btnDauTrang.Size = new System.Drawing.Size(55, 34);
            this.btnDauTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDauTrang.FlatAppearance.BorderSize = 0;
            this.btnDauTrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDauTrang.BackColor = System.Drawing.Color.White;
            this.btnDauTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDauTrang.Click += new System.EventHandler(this.btnDauTrang_Click);

            this.btnTruoc.Text = "<";
            this.btnTruoc.Location = new System.Drawing.Point(55, 0);
            this.btnTruoc.Size = new System.Drawing.Size(55, 34);
            this.btnTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruoc.FlatAppearance.BorderSize = 0;
            this.btnTruoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTruoc.BackColor = System.Drawing.Color.White;
            this.btnTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);

            this.panelTrangTrai.Controls.Add(this.btnDauTrang);
            this.panelTrangTrai.Controls.Add(this.btnTruoc);

            // Label trang (giữa)
            this.lblTrang.Text = "Trang 1/1  |  0 bản ghi";
            this.lblTrang.Location = new System.Drawing.Point(473, 583);
            this.lblTrang.Size = new System.Drawing.Size(220, 20);
            this.lblTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrang.ForeColor = System.Drawing.Color.Black;

            // Panel phải (> >>)
            this.panelTrangPhai.Location = new System.Drawing.Point(700, 575);
            this.panelTrangPhai.Size = new System.Drawing.Size(110, 36);
            this.panelTrangPhai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnSau.Text = ">";
            this.btnSau.Location = new System.Drawing.Point(0, 0);
            this.btnSau.Size = new System.Drawing.Size(55, 34);
            this.btnSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSau.FlatAppearance.BorderSize = 0;
            this.btnSau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSau.BackColor = System.Drawing.Color.White;
            this.btnSau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);

            this.btnCuoiTrang.Text = ">>";
            this.btnCuoiTrang.Location = new System.Drawing.Point(55, 0);
            this.btnCuoiTrang.Size = new System.Drawing.Size(55, 34);
            this.btnCuoiTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuoiTrang.FlatAppearance.BorderSize = 0;
            this.btnCuoiTrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCuoiTrang.BackColor = System.Drawing.Color.White;
            this.btnCuoiTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuoiTrang.Click += new System.EventHandler(this.btnCuoiTrang_Click);

            this.panelTrangPhai.Controls.Add(this.btnSau);
            this.panelTrangPhai.Controls.Add(this.btnCuoiTrang);

            // ===== FORM =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 645);   // NHỎ HƠN: 930 x 645
            this.Text = "Quản lý Sinh Viên";
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Load += new System.EventHandler(this.Form1_Load);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                menuStrip1,
                lblThongTin,
                lblMaSV,     txtMaSV,
                lblHoTen,    txtHoTen,
                lblNgaySinh, dtpNgaySinh,
                lblGioiTinh, cboGioiTinh,
                lblLop,      cboLop,
                btnThem,     btnSua,
                btnXoa,      btnLamMoi,
                lblTimKiem,  txtTimKiem,  btnTim,
                dgvSinhVien,
                panelTrangTrai,
                lblTrang,
                panelTrangPhai
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panelTrangTrai.ResumeLayout(false);
            this.panelTrangPhai.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ===== FIELDS =====
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvSinhVien;

        private System.Windows.Forms.Panel panelTrangTrai;
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Panel panelTrangPhai;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoiTrang;
    }
}