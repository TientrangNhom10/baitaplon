namespace QuanLyQuanCafe
{
    partial class fDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtTenHienThiDK = new TextBox();
            txtMatKhauDkLai = new TextBox();
            txtMatKhauDk = new TextBox();
            txtTenDangNhapDk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbMatKhau = new Label();
            lbTenDangNhap = new Label();
            btnDangKy = new Button();
            btnThoatDangKy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenHienThiDK);
            panel1.Controls.Add(txtMatKhauDkLai);
            panel1.Controls.Add(txtMatKhauDk);
            panel1.Controls.Add(txtTenDangNhapDk);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbMatKhau);
            panel1.Controls.Add(lbTenDangNhap);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(34, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 325);
            panel1.TabIndex = 1;
            // 
            // txtTenHienThiDK
            // 
            txtTenHienThiDK.Location = new Point(251, 101);
            txtTenHienThiDK.Name = "txtTenHienThiDK";
            txtTenHienThiDK.Size = new Size(391, 34);
            txtTenHienThiDK.TabIndex = 2;
            // 
            // txtMatKhauDkLai
            // 
            txtMatKhauDkLai.Location = new Point(252, 253);
            txtMatKhauDkLai.Name = "txtMatKhauDkLai";
            txtMatKhauDkLai.Size = new Size(391, 34);
            txtMatKhauDkLai.TabIndex = 2;
            txtMatKhauDkLai.UseSystemPasswordChar = true;
            // 
            // txtMatKhauDk
            // 
            txtMatKhauDk.Location = new Point(252, 180);
            txtMatKhauDk.Name = "txtMatKhauDk";
            txtMatKhauDk.Size = new Size(391, 34);
            txtMatKhauDk.TabIndex = 2;
            txtMatKhauDk.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhapDk
            // 
            txtTenDangNhapDk.Location = new Point(251, 21);
            txtTenDangNhapDk.Name = "txtTenDangNhapDk";
            txtTenDangNhapDk.Size = new Size(392, 34);
            txtTenDangNhapDk.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(27, 254);
            label1.Name = "label1";
            label1.Size = new Size(208, 34);
            label1.TabIndex = 0;
            label1.Text = "Nhập lại mật khẩu:";
            // 
            // label2
            // 
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(208, 34);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Location = new Point(27, 181);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(164, 34);
            lbMatKhau.TabIndex = 0;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // lbTenDangNhap
            // 
            lbTenDangNhap.Location = new Point(26, 22);
            lbTenDangNhap.Name = "lbTenDangNhap";
            lbTenDangNhap.Size = new Size(164, 34);
            lbTenDangNhap.TabIndex = 0;
            lbTenDangNhap.Text = "Tên đăng nhâp:";
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(285, 376);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(124, 40);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnThoatDangKy
            // 
            btnThoatDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoatDangKy.Location = new Point(464, 376);
            btnThoatDangKy.Name = "btnThoatDangKy";
            btnThoatDangKy.Size = new Size(124, 40);
            btnThoatDangKy.TabIndex = 4;
            btnThoatDangKy.Text = "Thoát";
            btnThoatDangKy.UseVisualStyleBackColor = true;
            btnThoatDangKy.Click += btnThoatDangKy_Click;
            // 
            // fDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 475);
            Controls.Add(btnThoatDangKy);
            Controls.Add(btnDangKy);
            Controls.Add(panel1);
            Name = "fDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký";
            Load += fDangKy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtMatKhauDkLai;
        private TextBox txtMatKhauDk;
        private TextBox txtTenDangNhapDk;
        private Label label1;
        private Label lbMatKhau;
        private Label lbTenDangNhap;
        private Button btnDangKy;
        private Button btnThoatDangKy;
        private TextBox txtTenHienThiDK;
        private Label label2;
    }
}