namespace flogin
{
    partial class fQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLy));
            MenuQuanLy = new MenuStrip();
            menuTaiKhoan = new ToolStripMenuItem();
            ThongTinCaNhanMenu = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            menuQLy = new ToolStripMenuItem();
            DoanhThuMenu = new ToolStripMenuItem();
            DanhmucMenu = new ToolStripMenuItem();
            ThucDonMenu = new ToolStripMenuItem();
            BanAnMenu = new ToolStripMenuItem();
            menuTKNV = new ToolStripMenuItem();
            pnThaoTac = new Panel();
            flpMonAnShow = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            txtTimKiem = new TextBox();
            grbDanhMuc = new GroupBox();
            cbDanhMuc = new ComboBox();
            flpTable = new FlowLayoutPanel();
            grbThongTinThanhToan = new GroupBox();
            txtTienThua = new TextBox();
            txtKhachTra = new TextBox();
            txtTongTien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtHienThiKhuVuc = new TextBox();
            cbKhuVuc = new ComboBox();
            gpbBanDangChon = new GroupBox();
            btnHoanThanhThucDon = new Button();
            txtBanDangChon = new TextBox();
            grbThucDon = new GroupBox();
            dtgvThucDon = new DataGridView();
            pnHoaDon = new Panel();
            btnThanhToan = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            MenuQuanLy.SuspendLayout();
            pnThaoTac.SuspendLayout();
            groupBox1.SuspendLayout();
            grbDanhMuc.SuspendLayout();
            grbThongTinThanhToan.SuspendLayout();
            groupBox2.SuspendLayout();
            gpbBanDangChon.SuspendLayout();
            grbThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvThucDon).BeginInit();
            pnHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MenuQuanLy
            // 
            MenuQuanLy.AutoSize = false;
            MenuQuanLy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuQuanLy.ImageScalingSize = new Size(20, 20);
            MenuQuanLy.Items.AddRange(new ToolStripItem[] { menuTaiKhoan, menuQLy });
            MenuQuanLy.Location = new Point(0, 0);
            MenuQuanLy.Name = "MenuQuanLy";
            MenuQuanLy.Size = new Size(1920, 37);
            MenuQuanLy.TabIndex = 0;
            MenuQuanLy.Text = "menuStrip1";
            // 
            // menuTaiKhoan
            // 
            menuTaiKhoan.DropDownItems.AddRange(new ToolStripItem[] { ThongTinCaNhanMenu, menuDangXuat });
            menuTaiKhoan.Image = (Image)resources.GetObject("menuTaiKhoan.Image");
            menuTaiKhoan.Name = "menuTaiKhoan";
            menuTaiKhoan.Size = new Size(129, 33);
            menuTaiKhoan.Text = "<nameUser>";
            // 
            // ThongTinCaNhanMenu
            // 
            ThongTinCaNhanMenu.Name = "ThongTinCaNhanMenu";
            ThongTinCaNhanMenu.Size = new Size(270, 26);
            ThongTinCaNhanMenu.Text = "Cập nhật thông tin cá nhân";
            ThongTinCaNhanMenu.Click += ThongTinCaNhanMenu_Click;
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(270, 26);
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // menuQLy
            // 
            menuQLy.DropDownItems.AddRange(new ToolStripItem[] { DoanhThuMenu, DanhmucMenu, ThucDonMenu, BanAnMenu, menuTKNV });
            menuQLy.Name = "menuQLy";
            menuQLy.Size = new Size(75, 33);
            menuQLy.Text = "Quản Lý";
            // 
            // DoanhThuMenu
            // 
            DoanhThuMenu.Name = "DoanhThuMenu";
            DoanhThuMenu.Size = new Size(222, 26);
            DoanhThuMenu.Text = "Doanh thu";
            DoanhThuMenu.Click += DoanhThuMenu_Click;
            // 
            // DanhmucMenu
            // 
            DanhmucMenu.Name = "DanhmucMenu";
            DanhmucMenu.Size = new Size(222, 26);
            DanhmucMenu.Text = "Danh mục thực đơn";
            DanhmucMenu.Click += DanhmucMenu_Click;
            // 
            // ThucDonMenu
            // 
            ThucDonMenu.Name = "ThucDonMenu";
            ThucDonMenu.Size = new Size(222, 26);
            ThucDonMenu.Text = "Thực đơn";
            ThucDonMenu.Click += ThucDonMenu_Click;
            // 
            // BanAnMenu
            // 
            BanAnMenu.Name = "BanAnMenu";
            BanAnMenu.Size = new Size(222, 26);
            BanAnMenu.Text = "Quản lý bàn";
            BanAnMenu.Click += BanAnMenu_Click;
            // 
            // menuTKNV
            // 
            menuTKNV.Name = "menuTKNV";
            menuTKNV.Size = new Size(222, 26);
            menuTKNV.Text = "Tài khoản nhân viên";
            menuTKNV.Click += menuTKNV_Click;
            // 
            // pnThaoTac
            // 
            pnThaoTac.Controls.Add(flpMonAnShow);
            pnThaoTac.Controls.Add(groupBox1);
            pnThaoTac.Controls.Add(grbDanhMuc);
            pnThaoTac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnThaoTac.Location = new Point(1356, 43);
            pnThaoTac.Name = "pnThaoTac";
            pnThaoTac.Size = new Size(552, 996);
            pnThaoTac.TabIndex = 2;
            // 
            // flpMonAnShow
            // 
            flpMonAnShow.BackColor = Color.White;
            flpMonAnShow.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpMonAnShow.Location = new Point(3, 151);
            flpMonAnShow.Name = "flpMonAnShow";
            flpMonAnShow.Size = new Size(546, 761);
            flpMonAnShow.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Location = new Point(13, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(515, 34);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // grbDanhMuc
            // 
            grbDanhMuc.Controls.Add(cbDanhMuc);
            grbDanhMuc.Location = new Point(13, 3);
            grbDanhMuc.Name = "grbDanhMuc";
            grbDanhMuc.Size = new Size(527, 68);
            grbDanhMuc.TabIndex = 0;
            grbDanhMuc.TabStop = false;
            grbDanhMuc.Text = "Danh mục thực đơn";
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.DisplayMember = "Đồ uống";
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Location = new Point(6, 26);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(515, 36);
            cbDanhMuc.TabIndex = 0;
            cbDanhMuc.ValueMember = "Đồ uống";
            cbDanhMuc.SelectedIndexChanged += cbDanhMuc_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.BackColor = Color.White;
            flpTable.Location = new Point(3, 104);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(540, 717);
            flpTable.TabIndex = 3;
            // 
            // grbThongTinThanhToan
            // 
            grbThongTinThanhToan.Controls.Add(txtTienThua);
            grbThongTinThanhToan.Controls.Add(txtKhachTra);
            grbThongTinThanhToan.Controls.Add(txtTongTien);
            grbThongTinThanhToan.Controls.Add(label3);
            grbThongTinThanhToan.Controls.Add(label2);
            grbThongTinThanhToan.Controls.Add(label1);
            grbThongTinThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongTinThanhToan.Location = new Point(6, 626);
            grbThongTinThanhToan.Name = "grbThongTinThanhToan";
            grbThongTinThanhToan.Size = new Size(756, 234);
            grbThongTinThanhToan.TabIndex = 0;
            grbThongTinThanhToan.TabStop = false;
            grbThongTinThanhToan.Text = "Thông tin thanh toán";
            // 
            // txtTienThua
            // 
            txtTienThua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienThua.Location = new Point(157, 181);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.ReadOnly = true;
            txtTienThua.Size = new Size(561, 43);
            txtTienThua.TabIndex = 1;
            // 
            // txtKhachTra
            // 
            txtKhachTra.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhachTra.Location = new Point(157, 113);
            txtKhachTra.Name = "txtKhachTra";
            txtKhachTra.Size = new Size(561, 43);
            txtKhachTra.TabIndex = 1;
            txtKhachTra.TextChanged += txtKhachTra_TextChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(157, 49);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(561, 43);
            txtTongTien.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 193);
            label3.Name = "label3";
            label3.Size = new Size(115, 31);
            label3.TabIndex = 0;
            label3.Text = "Tiền thừa";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 0;
            label2.Text = "Khách trả";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 0;
            label1.Text = "Tổng tiền";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtHienThiKhuVuc);
            groupBox2.Controls.Add(cbKhuVuc);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(7, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(536, 95);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khu Vực";
            // 
            // txtHienThiKhuVuc
            // 
            txtHienThiKhuVuc.Location = new Point(26, 43);
            txtHienThiKhuVuc.Name = "txtHienThiKhuVuc";
            txtHienThiKhuVuc.ReadOnly = true;
            txtHienThiKhuVuc.Size = new Size(114, 34);
            txtHienThiKhuVuc.TabIndex = 1;
            txtHienThiKhuVuc.TextChanged += txtHienThiKhuVuc_TextChanged;
            // 
            // cbKhuVuc
            // 
            cbKhuVuc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbKhuVuc.FormattingEnabled = true;
            cbKhuVuc.Location = new Point(157, 41);
            cbKhuVuc.Name = "cbKhuVuc";
            cbKhuVuc.Size = new Size(265, 36);
            cbKhuVuc.TabIndex = 0;
            cbKhuVuc.Text = "Chọn khu vực quản lý";
            cbKhuVuc.SelectedIndexChanged += cbKhuVuc_SelectedIndexChanged;
            // 
            // gpbBanDangChon
            // 
            gpbBanDangChon.Controls.Add(btnHoanThanhThucDon);
            gpbBanDangChon.Controls.Add(txtBanDangChon);
            gpbBanDangChon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbBanDangChon.Location = new Point(6, 6);
            gpbBanDangChon.Name = "gpbBanDangChon";
            gpbBanDangChon.Size = new Size(756, 74);
            gpbBanDangChon.TabIndex = 0;
            gpbBanDangChon.TabStop = false;
            gpbBanDangChon.Text = "Bàn đang chọn";
            // 
            // btnHoanThanhThucDon
            // 
            btnHoanThanhThucDon.Location = new Point(559, 24);
            btnHoanThanhThucDon.Name = "btnHoanThanhThucDon";
            btnHoanThanhThucDon.Size = new Size(191, 41);
            btnHoanThanhThucDon.TabIndex = 1;
            btnHoanThanhThucDon.Text = "Đã xong";
            btnHoanThanhThucDon.UseVisualStyleBackColor = true;
            btnHoanThanhThucDon.Click += btnHoanThanhThucDon_Click;
            // 
            // txtBanDangChon
            // 
            txtBanDangChon.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBanDangChon.Location = new Point(157, 24);
            txtBanDangChon.Multiline = true;
            txtBanDangChon.Name = "txtBanDangChon";
            txtBanDangChon.ReadOnly = true;
            txtBanDangChon.Size = new Size(361, 38);
            txtBanDangChon.TabIndex = 0;
            txtBanDangChon.TextAlign = HorizontalAlignment.Center;
            // 
            // grbThucDon
            // 
            grbThucDon.Controls.Add(dtgvThucDon);
            grbThucDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThucDon.Location = new Point(3, 86);
            grbThucDon.Name = "grbThucDon";
            grbThucDon.Size = new Size(762, 534);
            grbThucDon.TabIndex = 0;
            grbThucDon.TabStop = false;
            grbThucDon.Text = "Thực đơn";
            // 
            // dtgvThucDon
            // 
            dtgvThucDon.BackgroundColor = SystemColors.ControlLightLight;
            dtgvThucDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThucDon.Dock = DockStyle.Fill;
            dtgvThucDon.Location = new Point(3, 34);
            dtgvThucDon.Name = "dtgvThucDon";
            dtgvThucDon.RowHeadersVisible = false;
            dtgvThucDon.RowHeadersWidth = 51;
            dtgvThucDon.Size = new Size(756, 497);
            dtgvThucDon.TabIndex = 0;
            dtgvThucDon.CellClick += dtgvThucDon_CellClick;
            // 
            // pnHoaDon
            // 
            pnHoaDon.Controls.Add(btnThanhToan);
            pnHoaDon.Controls.Add(grbThucDon);
            pnHoaDon.Controls.Add(grbThongTinThanhToan);
            pnHoaDon.Controls.Add(gpbBanDangChon);
            pnHoaDon.Location = new Point(573, 40);
            pnHoaDon.Name = "pnHoaDon";
            pnHoaDon.Size = new Size(768, 999);
            pnHoaDon.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(6, 869);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(268, 58);
            btnThanhToan.TabIndex = 1;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(flpTable);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(6, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 999);
            panel2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(100, 836);
            label8.Name = "label8";
            label8.Size = new Size(123, 23);
            label8.TabIndex = 6;
            label8.Text = ":  Đang chờ đồ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(100, 902);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 6;
            label9.Text = ":  Đã có khách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(100, 869);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = ":  Bàn trống";
            // 
            // label6
            // 
            label6.BackColor = Color.LightGreen;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(6, 902);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.Tomato;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(6, 868);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.Gold;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(6, 835);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 5;
            // 
            // fQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1920, 1051);
            Controls.Add(panel2);
            Controls.Add(pnThaoTac);
            Controls.Add(pnHoaDon);
            Controls.Add(MenuQuanLy);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = MenuQuanLy;
            Name = "fQuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phầm mềm quản lý quán cafe";
            WindowState = FormWindowState.Maximized;
            Load += fQuanLy_Load;
            MenuQuanLy.ResumeLayout(false);
            MenuQuanLy.PerformLayout();
            pnThaoTac.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbDanhMuc.ResumeLayout(false);
            grbThongTinThanhToan.ResumeLayout(false);
            grbThongTinThanhToan.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gpbBanDangChon.ResumeLayout(false);
            gpbBanDangChon.PerformLayout();
            grbThucDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvThucDon).EndInit();
            pnHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip MenuQuanLy;
        private ToolStripMenuItem menuQLy;
        private ToolStripMenuItem menuTaiKhoan;
        private ToolStripMenuItem ThongTinCaNhanMenu;
        private Panel pnThaoTac;
        private FlowLayoutPanel flpTable;
        private GroupBox grbDanhMuc;
        private ComboBox cbDanhMuc;
        private GroupBox groupBox1;
        private TextBox txtTimKiem;
        private GroupBox grbThongTinThanhToan;
        private GroupBox groupBox2;
        private GroupBox gpbBanDangChon;
        private GroupBox grbThucDon;
        private Panel pnHoaDon;
        private TextBox txtHienThiKhuVuc;
        private ComboBox cbKhuVuc;
        private Button btnThanhToan;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTienThua;
        private TextBox txtKhachTra;
        private TextBox txtTongTien;
        private ToolStripMenuItem DoanhThuMenu;
        private ToolStripMenuItem DanhmucMenu;
        private ToolStripMenuItem ThucDonMenu;
        private ToolStripMenuItem BanAnMenu;
        private FileSystemWatcher fileSystemWatcher1;
        private DataGridView dtgvThucDon;
        private TextBox txtBanDangChon;
        private FlowLayoutPanel flpMonAnShow;
        private Panel panel2;
        private Button btnHoanThanhThucDon;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuTKNV;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label7;
    }
}