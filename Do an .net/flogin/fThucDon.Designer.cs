namespace QuanLyQuanCafe
{
    partial class fThucDon
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
            flpThucDon = new FlowLayoutPanel();
            label2 = new Label();
            txtChonMon = new TextBox();
            grthaoTac = new GroupBox();
            cbDanhMuc = new ComboBox();
            btnHoantatthem = new Button();
            btnThemht = new Button();
            txtGia = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtTenmonan = new TextBox();
            label4 = new Label();
            txtidTD = new TextBox();
            label3 = new Label();
            btnThemTD = new Button();
            btnSuaTD = new Button();
            btnXoaTD = new Button();
            txtIDDM = new TextBox();
            label7 = new Label();
            grthaoTac.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 23);
            label1.Name = "label1";
            label1.Size = new Size(382, 56);
            label1.TabIndex = 0;
            label1.Text = "Danh sách thực đơn";
            // 
            // flpThucDon
            // 
            flpThucDon.AutoScroll = true;
            flpThucDon.BackColor = Color.White;
            flpThucDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpThucDon.Location = new Point(27, 82);
            flpThucDon.Name = "flpThucDon";
            flpThucDon.Size = new Size(711, 544);
            flpThucDon.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 663);
            label2.Name = "label2";
            label2.Size = new Size(135, 44);
            label2.TabIndex = 2;
            label2.Text = "Chọn món";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtChonMon
            // 
            txtChonMon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChonMon.Location = new Point(187, 663);
            txtChonMon.Multiline = true;
            txtChonMon.Name = "txtChonMon";
            txtChonMon.ReadOnly = true;
            txtChonMon.Size = new Size(384, 44);
            txtChonMon.TabIndex = 3;
            txtChonMon.TextChanged += txtChonMon_TextChanged;
            // 
            // grthaoTac
            // 
            grthaoTac.BackColor = Color.FromArgb(192, 255, 255);
            grthaoTac.Controls.Add(cbDanhMuc);
            grthaoTac.Controls.Add(btnHoantatthem);
            grthaoTac.Controls.Add(btnThemht);
            grthaoTac.Controls.Add(txtGia);
            grthaoTac.Controls.Add(label6);
            grthaoTac.Controls.Add(label5);
            grthaoTac.Controls.Add(txtTenmonan);
            grthaoTac.Controls.Add(label4);
            grthaoTac.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grthaoTac.Location = new Point(778, 82);
            grthaoTac.Name = "grthaoTac";
            grthaoTac.Size = new Size(321, 544);
            grthaoTac.TabIndex = 4;
            grthaoTac.TabStop = false;
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Location = new Point(26, 299);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(255, 39);
            cbDanhMuc.TabIndex = 3;
            cbDanhMuc.SelectedIndexChanged += cbDanhMuc_SelectedIndexChanged;
            // 
            // btnHoantatthem
            // 
            btnHoantatthem.Location = new Point(76, 468);
            btnHoantatthem.Name = "btnHoantatthem";
            btnHoantatthem.Size = new Size(170, 40);
            btnHoantatthem.TabIndex = 2;
            btnHoantatthem.Text = "Hoàn tất";
            btnHoantatthem.UseVisualStyleBackColor = true;
            btnHoantatthem.Click += btnHoantatthem_Click;
            // 
            // btnThemht
            // 
            btnThemht.Location = new Point(76, 468);
            btnThemht.Name = "btnThemht";
            btnThemht.Size = new Size(170, 40);
            btnThemht.TabIndex = 2;
            btnThemht.Text = "Thêm";
            btnThemht.UseVisualStyleBackColor = true;
            btnThemht.Click += btnThemht_Click;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGia.Location = new Point(26, 387);
            txtGia.Multiline = true;
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(255, 34);
            txtGia.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 344);
            label6.Name = "label6";
            label6.Size = new Size(41, 28);
            label6.TabIndex = 0;
            label6.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 251);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 0;
            label5.Text = "Danh mục";
            // 
            // txtTenmonan
            // 
            txtTenmonan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenmonan.Location = new Point(26, 191);
            txtTenmonan.Multiline = true;
            txtTenmonan.Name = "txtTenmonan";
            txtTenmonan.Size = new Size(255, 34);
            txtTenmonan.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 148);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên món ăn";
            // 
            // txtidTD
            // 
            txtidTD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtidTD.Location = new Point(844, 45);
            txtidTD.Multiline = true;
            txtidTD.Name = "txtidTD";
            txtidTD.ReadOnly = true;
            txtidTD.Size = new Size(255, 34);
            txtidTD.TabIndex = 1;
            txtidTD.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(804, 48);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 0;
            label3.Text = "ID";
            label3.Visible = false;
            // 
            // btnThemTD
            // 
            btnThemTD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemTD.Image = Properties.Resources._4115237_add_plus_114047;
            btnThemTD.Location = new Point(667, 32);
            btnThemTD.Name = "btnThemTD";
            btnThemTD.Size = new Size(71, 44);
            btnThemTD.TabIndex = 5;
            btnThemTD.UseVisualStyleBackColor = true;
            btnThemTD.Click += btnThemTD_Click;
            // 
            // btnSuaTD
            // 
            btnSuaTD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaTD.Image = Properties.Resources.edit_icon_128873;
            btnSuaTD.Location = new Point(590, 663);
            btnSuaTD.Name = "btnSuaTD";
            btnSuaTD.Size = new Size(71, 44);
            btnSuaTD.TabIndex = 5;
            btnSuaTD.UseVisualStyleBackColor = true;
            btnSuaTD.Click += btnSuaTD_Click;
            // 
            // btnXoaTD
            // 
            btnXoaTD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaTD.Image = Properties.Resources._4115230_cancel_close_cross_delete_114048;
            btnXoaTD.Location = new Point(667, 663);
            btnXoaTD.Name = "btnXoaTD";
            btnXoaTD.Size = new Size(71, 44);
            btnXoaTD.TabIndex = 5;
            btnXoaTD.UseVisualStyleBackColor = true;
            btnXoaTD.Click += btnXoaTD_Click;
            // 
            // txtIDDM
            // 
            txtIDDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDDM.Location = new Point(903, 663);
            txtIDDM.Name = "txtIDDM";
            txtIDDM.Size = new Size(233, 34);
            txtIDDM.TabIndex = 6;
            txtIDDM.Visible = false;
            txtIDDM.TextChanged += txtIDDM_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(779, 666);
            label7.Name = "label7";
            label7.Size = new Size(122, 28);
            label7.TabIndex = 7;
            label7.Text = "ID danh mục";
            label7.Visible = false;
            // 
            // fThucDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1148, 763);
            Controls.Add(label7);
            Controls.Add(txtIDDM);
            Controls.Add(btnXoaTD);
            Controls.Add(btnSuaTD);
            Controls.Add(btnThemTD);
            Controls.Add(grthaoTac);
            Controls.Add(txtChonMon);
            Controls.Add(label2);
            Controls.Add(flpThucDon);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtidTD);
            Name = "fThucDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thực đơn";
            Load += fThucDon_Load;
            grthaoTac.ResumeLayout(false);
            grthaoTac.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpThucDon;
        private Label label2;
        private TextBox txtChonMon;
        private GroupBox grthaoTac;
        private Label label3;
        private TextBox txtidTD;
        private Button btnThemTD;
        private Button btnSuaTD;
        private Button btnXoaTD;
        private Button btnHoantatthem;
        private Button btnThemht;
        private TextBox txtGia;
        private Label label6;
        private Label label5;
        private TextBox txtTenmonan;
        private Label label4;
        private ComboBox cbDanhMuc;
        private TextBox txtIDDM;
        private Label label7;
    }
}