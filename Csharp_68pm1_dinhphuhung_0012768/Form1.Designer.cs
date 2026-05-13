namespace Csharp_68pm1_dinhphuhung_0012768
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();

            // ===== TIÊU ĐỀ =====
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.Location = new Point(220, 50);
            lblTitle.Size = new Size(350, 50);
            lblTitle.Name = "lblTitle";

            // ===== LABEL TÊN ĐĂNG NHẬP =====
            lblUsername.Text = "Tên đăng nhập:";
            lblUsername.Location = new Point(150, 140);
            lblUsername.Size = new Size(150, 30);
            lblUsername.Name = "lblUsername";

            // ===== TEXTBOX TÊN ĐĂNG NHẬP =====
            txtUsername.Location = new Point(320, 137);
            txtUsername.Size = new Size(220, 31);
            txtUsername.Name = "txtUsername";

            // ===== LABEL MẬT KHẨU =====
            lblPassword.Text = "Mật khẩu:";
            lblPassword.Location = new Point(150, 210);
            lblPassword.Size = new Size(150, 30);
            lblPassword.Name = "lblPassword";

            // ===== TEXTBOX MẬT KHẨU =====
            txtPassword.Location = new Point(320, 207);
            txtPassword.Size = new Size(220, 31);
            txtPassword.PasswordChar = '*';
            txtPassword.Name = "txtPassword";

            // ===== NÚT ĐĂNG NHẬP =====
            btnLogin.Text = "Đăng nhập";
            btnLogin.Location = new Point(285, 280);
            btnLogin.Size = new Size(150, 45);
            btnLogin.Name = "btnLogin";
            btnLogin.Click += new EventHandler(btnLogin_Click);

            // ===== FORM =====
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Màn hình đăng nhập";
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}