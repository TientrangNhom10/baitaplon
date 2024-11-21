namespace QuanLyQuanCafe
{
    partial class fNhanVien
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
            flpNhanVien = new FlowLayoutPanel();
            label2 = new Label();
            btnSuanv = new Button();
            btnXoanv = new Button();
            btnThemnv = new Button();
            btnThemHoanTat = new Button();
            btnHoanTat = new Button();
            txtMK = new TextBox();
            label5 = new Label();
            txtTHT = new TextBox();
            label4 = new Label();
            txtTDN = new TextBox();
            label3 = new Label();
            txtTenNhanVien = new TextBox();
            grThaoTac = new GroupBox();
            grThaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 24);
            label1.Name = "label1";
            label1.Size = new Size(381, 56);
            label1.TabIndex = 0;
            label1.Text = "Danh sách nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // flpNhanVien
            // 
            flpNhanVien.AutoScroll = true;
            flpNhanVien.BackColor = Color.White;
            flpNhanVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpNhanVien.Location = new Point(34, 88);
            flpNhanVien.Name = "flpNhanVien";
            flpNhanVien.Size = new Size(711, 544);
            flpNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 669);
            label2.Name = "label2";
            label2.Size = new Size(135, 44);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label1_Click;
            // 
            // btnSuanv
            // 
            btnSuanv.Image = Properties.Resources.edit_icon_128873;
            btnSuanv.Location = new Point(584, 669);
            btnSuanv.Name = "btnSuanv";
            btnSuanv.Size = new Size(71, 44);
            btnSuanv.TabIndex = 3;
            btnSuanv.TextAlign = ContentAlignment.MiddleRight;
            btnSuanv.UseVisualStyleBackColor = true;
            btnSuanv.Click += btnSuanv_Click;
            // 
            // btnXoanv
            // 
            btnXoanv.Image = Properties.Resources._4115230_cancel_close_cross_delete_114048;
            btnXoanv.Location = new Point(674, 669);
            btnXoanv.Name = "btnXoanv";
            btnXoanv.Size = new Size(71, 44);
            btnXoanv.TabIndex = 4;
            btnXoanv.TextAlign = ContentAlignment.MiddleRight;
            btnXoanv.UseVisualStyleBackColor = true;
            btnXoanv.Click += btnXoanv_Click;
            // 
            // btnThemnv
            // 
            btnThemnv.Image = Properties.Resources._4115237_add_plus_114047;
            btnThemnv.Location = new Point(674, 38);
            btnThemnv.Name = "btnThemnv";
            btnThemnv.Size = new Size(71, 44);
            btnThemnv.TabIndex = 4;
            btnThemnv.UseVisualStyleBackColor = true;
            btnThemnv.Click += btnThemnv_Click;
            // 
            // btnThemHoanTat
            // 
            btnThemHoanTat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemHoanTat.Location = new Point(77, 443);
            btnThemHoanTat.Name = "btnThemHoanTat";
            btnThemHoanTat.Size = new Size(170, 40);
            btnThemHoanTat.TabIndex = 3;
            btnThemHoanTat.Text = "Thêm";
            btnThemHoanTat.UseVisualStyleBackColor = true;
            btnThemHoanTat.Click += btnThemHoanTat_Click;
            // 
            // btnHoanTat
            // 
            btnHoanTat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoanTat.Location = new Point(77, 443);
            btnHoanTat.Name = "btnHoanTat";
            btnHoanTat.Size = new Size(170, 40);
            btnHoanTat.TabIndex = 2;
            btnHoanTat.Text = "Hoàn tất sửa";
            btnHoanTat.UseVisualStyleBackColor = true;
            btnHoanTat.Click += btnHoanTat_Click;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(23, 335);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(292, 38);
            txtMK.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 295);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 0;
            label5.Text = "Mật khẩu";
            // 
            // txtTHT
            // 
            txtTHT.Location = new Point(23, 219);
            txtTHT.Name = "txtTHT";
            txtTHT.Size = new Size(292, 38);
            txtTHT.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 188);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên hiển thị";
            // 
            // txtTDN
            // 
            txtTDN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTDN.Location = new Point(23, 117);
            txtTDN.Multiline = true;
            txtTDN.Name = "txtTDN";
            txtTDN.Size = new Size(292, 27);
            txtTDN.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 77);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNhanVien.Location = new Point(175, 669);
            txtTenNhanVien.Multiline = true;
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(384, 44);
            txtTenNhanVien.TabIndex = 6;
            txtTenNhanVien.TextChanged += txtTenNhanVien_TextChanged;
            // 
            // grThaoTac
            // 
            grThaoTac.BackColor = Color.FromArgb(192, 255, 255);
            grThaoTac.Controls.Add(btnThemHoanTat);
            grThaoTac.Controls.Add(txtTHT);
            grThaoTac.Controls.Add(btnHoanTat);
            grThaoTac.Controls.Add(label3);
            grThaoTac.Controls.Add(txtMK);
            grThaoTac.Controls.Add(txtTDN);
            grThaoTac.Controls.Add(label5);
            grThaoTac.Controls.Add(label4);
            grThaoTac.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grThaoTac.Location = new Point(781, 88);
            grThaoTac.Name = "grThaoTac";
            grThaoTac.Size = new Size(321, 544);
            grThaoTac.TabIndex = 7;
            grThaoTac.TabStop = false;
            // 
            // fNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1148, 763);
            Controls.Add(grThaoTac);
            Controls.Add(txtTenNhanVien);
            Controls.Add(btnThemnv);
            Controls.Add(btnXoanv);
            Controls.Add(btnSuanv);
            Controls.Add(flpNhanVien);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += fNhanVien_Load;
            grThaoTac.ResumeLayout(false);
            grThaoTac.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpNhanVien;
        private Label label2;
        private Button btnSuanv;
        private Button btnXoanv;
        private Button btnThemnv;
        private Label label3;
        private TextBox txtMK;
        private Label label5;
        private TextBox txtTHT;
        private Label label4;
        private TextBox txtTDN;
        private Button btnHoanTat;
        private Button btnThemHoanTat;
        private TextBox txtTenNhanVien;
        private GroupBox grThaoTac;
    }
}