namespace Quản_Lý_Sinh_Viên {
    partial class FormSinhVien {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.tabLopHoc = new System.Windows.Forms.TabPage();
            this.ucSinhVien = new UserControlSinhVien();
            this.ucLopHoc = new UserControlLopHoc();
            this.tabControl1.SuspendLayout();
            this.tabSinhVien.SuspendLayout();
            this.tabLopHoc.SuspendLayout();
            this.SuspendLayout();
            
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuSinhVien, this.mnuLopHoc, this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            
            this.mnuSinhVien.Text = "Quản lý Sinh Viên";
            this.mnuSinhVien.ForeColor = System.Drawing.Color.Black;
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            
            this.mnuLopHoc.Text = "Quản lý Lớp Học";
            this.mnuLopHoc.ForeColor = System.Drawing.Color.Black;
            this.mnuLopHoc.Click += new System.EventHandler(this.mnuLopHoc_Click);
            
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.ForeColor = System.Drawing.Color.Red;
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Size = new System.Drawing.Size(900, 570);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {this.tabSinhVien, this.tabLopHoc});
            
            this.tabSinhVien.Text = "Quản lý Sinh Viên";
            this.tabSinhVien.BackColor = System.Drawing.Color.White;
            this.tabSinhVien.Controls.Add(this.ucSinhVien);
            this.ucSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            
            this.tabLopHoc.Text = "Quản lý Lớp Học";
            this.tabLopHoc.BackColor = System.Drawing.Color.White;
            this.tabLopHoc.Controls.Add(this.ucLopHoc);
            this.ucLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 594);
            this.Text = "Quản lý Sinh Viên";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainMenuStrip = this.menuStrip1;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {this.menuStrip1, this.tabControl1});
            this.tabControl1.ResumeLayout(false);
            this.tabSinhVien.ResumeLayout(false);
            this.tabLopHoc.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien, mnuLopHoc, mnuDangXuat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSinhVien, tabLopHoc;
        private UserControlSinhVien ucSinhVien;
        private UserControlLopHoc ucLopHoc;
    }
}
