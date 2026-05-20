using System;
using System.Windows.Forms;

namespace Quản_Lý_Sinh_Viên
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            lblTitle.ForeColor = System.Drawing.Color.Black;
            lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);

            btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailSinhVien = "dinhphuhung202@gmail.com"; // Thay bằng email của bạn
            string mssv = "0012768"; // Thay bằng MSSV của bạn

            if (txtUsername.Text.Trim() == emailSinhVien && txtPassword.Text == mssv)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form quản lý sinh viên
                FormSinhVien formMain = new FormSinhVien();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu FormLogin đóng thì đóng luôn application
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
