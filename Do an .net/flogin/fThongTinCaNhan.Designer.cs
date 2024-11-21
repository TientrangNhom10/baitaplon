namespace QuanLyQuanCafe
{
    partial class fThongTinCaNhan
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
            label1 = new Label();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            txtTenHienThi = new TextBox();
            label4 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtNhapPass = new TextBox();
            btnCapNhatThongTin = new Button();
            btnThoatCapNhat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 108);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 19);
            label2.Name = "label2";
            label2.Size = new Size(418, 30);
            label2.TabIndex = 0;
            label2.Text = "Thông tin tài khoản";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(191, 108);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = true;
            txtTenDangNhap.Size = new Size(282, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 163);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 0;
            label3.Text = "Tên hiển thị";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTenHienThi
            // 
            txtTenHienThi.Location = new Point(191, 163);
            txtTenHienThi.Name = "txtTenHienThi";
            txtTenHienThi.Size = new Size(282, 27);
            txtTenHienThi.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(162, 30);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(191, 219);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(282, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 275);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 0;
            label5.Text = "Mật khẩu mới";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNhapPass
            // 
            txtNhapPass.Location = new Point(191, 275);
            txtNhapPass.Name = "txtNhapPass";
            txtNhapPass.Size = new Size(282, 27);
            txtNhapPass.TabIndex = 3;
            // 
            // btnCapNhatThongTin
            // 
            btnCapNhatThongTin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhatThongTin.Location = new Point(12, 370);
            btnCapNhatThongTin.Name = "btnCapNhatThongTin";
            btnCapNhatThongTin.Size = new Size(461, 42);
            btnCapNhatThongTin.TabIndex = 5;
            btnCapNhatThongTin.Text = "Cập nhật";
            btnCapNhatThongTin.UseVisualStyleBackColor = true;
            btnCapNhatThongTin.Click += btnCapNhatThongTin_Click;
            // 
            // btnThoatCapNhat
            // 
            btnThoatCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoatCapNhat.Location = new Point(13, 428);
            btnThoatCapNhat.Name = "btnThoatCapNhat";
            btnThoatCapNhat.Size = new Size(461, 42);
            btnThoatCapNhat.TabIndex = 6;
            btnThoatCapNhat.Text = "Thoát";
            btnThoatCapNhat.UseVisualStyleBackColor = true;
            btnThoatCapNhat.Click += btnThoatCapNhat_Click;
            // 
            // fThongTinCaNhan
            // 
            AcceptButton = btnCapNhatThongTin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoatCapNhat;
            ClientSize = new Size(495, 482);
            Controls.Add(btnThoatCapNhat);
            Controls.Add(btnCapNhatThongTin);
            Controls.Add(txtNhapPass);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenHienThi);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "fThongTinCaNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongTinCaNhan";
            Load += fThongTinCaNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private Label label3;
        private TextBox txtTenHienThi;
        private Label label4;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtNhapPass;
        private Button btnCapNhatThongTin;
        private Button btnThoatCapNhat;
    }
}