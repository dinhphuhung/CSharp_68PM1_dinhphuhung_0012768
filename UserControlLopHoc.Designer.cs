namespace Quản_Lý_Sinh_Viên
{
    partial class UserControlLopHoc
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
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemDanhSach = new System.Windows.Forms.Button();

            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();

            this.panelTrangTrai = new System.Windows.Forms.Panel();
            this.btnDauTrang = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.panelTrangPhai = new System.Windows.Forms.Panel();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoiTrang = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.panelTrangTrai.SuspendLayout();
            this.panelTrangPhai.SuspendLayout();
            this.SuspendLayout();

            // ===== PANEL TRÁI =====
            // Tiêu đề
            this.lblThongTin.Text = "Thông tin lớp học";
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(15, 15);
            this.lblThongTin.Size = new System.Drawing.Size(200, 20);
            this.lblThongTin.ForeColor = System.Drawing.Color.Black;

            // Mã lớp
            this.lblMaLop.Text = "Mã ID:";
            this.lblMaLop.Location = new System.Drawing.Point(15, 45);
            this.lblMaLop.Size = new System.Drawing.Size(110, 18);
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaLop.ForeColor = System.Drawing.Color.Black;

            this.txtMaLop.Location = new System.Drawing.Point(15, 65);
            this.txtMaLop.Size = new System.Drawing.Size(310, 24);
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Tên lớp
            this.lblTenLop.Text = "Mã lớp:";
            this.lblTenLop.Location = new System.Drawing.Point(15, 102);
            this.lblTenLop.Size = new System.Drawing.Size(110, 18);
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenLop.ForeColor = System.Drawing.Color.Black;

            this.txtTenLop.Location = new System.Drawing.Point(15, 122);
            this.txtTenLop.Size = new System.Drawing.Size(310, 24);
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Ghi chú
            this.lblGhiChu.Text = "Ghi chú:";
            this.lblGhiChu.Location = new System.Drawing.Point(15, 160);
            this.lblGhiChu.Size = new System.Drawing.Size(110, 18);
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.Black;

            this.txtGhiChu.Location = new System.Drawing.Point(15, 180);
            this.txtGhiChu.Size = new System.Drawing.Size(310, 24);
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ===== BUTTONS =====
            // Thêm
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(15, 340);
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // Sửa
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(175, 340);
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // Xóa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(15, 390);
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // Làm mới
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(175, 390);
            this.btnLamMoi.Size = new System.Drawing.Size(150, 40);
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // Xem danh sách sinh viên
            this.btnXemDanhSach.Text = "Xem danh sách sinh viên";
            this.btnXemDanhSach.Location = new System.Drawing.Point(15, 440);
            this.btnXemDanhSach.Size = new System.Drawing.Size(310, 40);
            this.btnXemDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemDanhSach.Click += new System.EventHandler(this.btnXemDanhSach_Click);

            // ===== PANEL PHẢI =====
            // Tìm kiếm
            this.lblTimKiem.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            this.lblTimKiem.Location = new System.Drawing.Point(355, 15);
            this.lblTimKiem.Size = new System.Drawing.Size(300, 18);
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.ForeColor = System.Drawing.Color.Black;

            this.txtTimKiem.Location = new System.Drawing.Point(355, 36);
            this.txtTimKiem.Size = new System.Drawing.Size(370, 24);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);

            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(730, 33);
            this.btnTim.Size = new System.Drawing.Size(80, 30);
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // DataGridView
            this.dgvLopHoc.Location = new System.Drawing.Point(355, 72);
            this.dgvLopHoc.Size = new System.Drawing.Size(455, 360);
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.AllowUserToDeleteRows = false;
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);

            // ===== PHÂN TRANG =====
            // Panel trái (<< <)
            this.panelTrangTrai.Location = new System.Drawing.Point(355, 440);
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
            this.lblTrang.Location = new System.Drawing.Point(473, 448);
            this.lblTrang.Size = new System.Drawing.Size(170, 20);
            this.lblTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrang.ForeColor = System.Drawing.Color.Black;

            // Panel phải (> >>)
            this.panelTrangPhai.Location = new System.Drawing.Point(650, 440);
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

            // ===== USERCONTROL =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "UserControlLopHoc";
            this.Size = new System.Drawing.Size(830, 520);
            this.Load += new System.EventHandler(this.UserControlLopHoc_Load);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThongTin,
                lblMaLop,     txtMaLop,
                lblTenLop,    txtTenLop,
                lblGhiChu,    txtGhiChu,
                btnThem,     btnSua,
                btnXoa,      btnLamMoi,
                btnXemDanhSach,
                lblTimKiem,  txtTimKiem,  btnTim,
                dgvLopHoc,
                panelTrangTrai,
                lblTrang,
                panelTrangPhai
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.panelTrangTrai.ResumeLayout(false);
            this.panelTrangPhai.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ===== FIELDS =====
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemDanhSach;

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvLopHoc;

        private System.Windows.Forms.Panel panelTrangTrai;
        private System.Windows.Forms.Button btnDauTrang;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Panel panelTrangPhai;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoiTrang;
    }
}
