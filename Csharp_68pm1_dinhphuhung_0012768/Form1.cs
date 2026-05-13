namespace Csharp_68pm1_dinhphuhung_0012768
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailSinhVien = "dinhphuhung202@gmail.com"; // đổi thành email của bạn
            string mssv = "0012768"; // đổi thành MSSV của bạn

            if (txtUsername.Text == emailSinhVien && txtPassword.Text == mssv)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}