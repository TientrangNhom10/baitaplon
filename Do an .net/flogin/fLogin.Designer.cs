namespace flogin
{
    partial class flogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lbMatKhau = new Label();
            lbTenDangNhap = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(lbMatKhau);
            panel1.Controls.Add(lbTenDangNhap);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(42, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 164);
            panel1.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(221, 101);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(421, 34);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Text = "123";
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(222, 21);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(421, 34);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.Text = "admin";
            // 
            // lbMatKhau
            // 
            lbMatKhau.Location = new Point(26, 102);
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
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(414, 230);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(124, 40);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(597, 230);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // flogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(765, 361);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += flogin_FormClosing;
            Load += flogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTenDangNhap;
        private Label lbTenDangNhap;
        private TextBox txtMatKhau;
        private Label lbMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}
