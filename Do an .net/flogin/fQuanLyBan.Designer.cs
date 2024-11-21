namespace QuanLyQuanCafe
{
    partial class fQuanLyBan
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
            flpBanAn = new FlowLayoutPanel();
            label2 = new Label();
            txtBanDangChon = new TextBox();
            grthaotac = new GroupBox();
            btnHoanTatThem = new Button();
            btnThemHT = new Button();
            txtKhuvuc = new TextBox();
            label5 = new Label();
            txtTenBan = new TextBox();
            label4 = new Label();
            btnThemBan = new Button();
            btnSưaBan = new Button();
            btnXoaBan = new Button();
            txtIDBDC = new TextBox();
            grthaotac.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 20);
            label1.Name = "label1";
            label1.Size = new Size(296, 56);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bàn ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpBanAn
            // 
            flpBanAn.AutoScroll = true;
            flpBanAn.BackColor = Color.White;
            flpBanAn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpBanAn.Location = new Point(31, 82);
            flpBanAn.Name = "flpBanAn";
            flpBanAn.Size = new Size(711, 544);
            flpBanAn.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 666);
            label2.Name = "label2";
            label2.Size = new Size(182, 44);
            label2.TabIndex = 2;
            label2.Text = "Bàn đang chọn";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBanDangChon
            // 
            txtBanDangChon.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBanDangChon.Location = new Point(216, 666);
            txtBanDangChon.Multiline = true;
            txtBanDangChon.Name = "txtBanDangChon";
            txtBanDangChon.ReadOnly = true;
            txtBanDangChon.Size = new Size(361, 44);
            txtBanDangChon.TabIndex = 3;
            txtBanDangChon.TextChanged += txtBanDangChon_TextChanged;
            // 
            // grthaotac
            // 
            grthaotac.BackColor = Color.FromArgb(192, 255, 255);
            grthaotac.Controls.Add(btnHoanTatThem);
            grthaotac.Controls.Add(btnThemHT);
            grthaotac.Controls.Add(txtKhuvuc);
            grthaotac.Controls.Add(label5);
            grthaotac.Controls.Add(txtTenBan);
            grthaotac.Controls.Add(label4);
            grthaotac.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grthaotac.Location = new Point(777, 82);
            grthaotac.Name = "grthaotac";
            grthaotac.Size = new Size(321, 544);
            grthaotac.TabIndex = 4;
            grthaotac.TabStop = false;
            // 
            // btnHoanTatThem
            // 
            btnHoanTatThem.Location = new Point(75, 452);
            btnHoanTatThem.Name = "btnHoanTatThem";
            btnHoanTatThem.Size = new Size(170, 40);
            btnHoanTatThem.TabIndex = 3;
            btnHoanTatThem.Text = "Hoàn tất";
            btnHoanTatThem.UseVisualStyleBackColor = true;
            btnHoanTatThem.Click += btnHoanTatThem_Click;
            // 
            // btnThemHT
            // 
            btnThemHT.Location = new Point(75, 452);
            btnThemHT.Name = "btnThemHT";
            btnThemHT.Size = new Size(170, 40);
            btnThemHT.TabIndex = 2;
            btnThemHT.Text = "Thêm";
            btnThemHT.UseVisualStyleBackColor = true;
            btnThemHT.Click += btnThemHT_Click;
            // 
            // txtKhuvuc
            // 
            txtKhuvuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhuvuc.Location = new Point(23, 287);
            txtKhuvuc.Multiline = true;
            txtKhuvuc.Name = "txtKhuvuc";
            txtKhuvuc.Size = new Size(269, 34);
            txtKhuvuc.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 245);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 0;
            label5.Text = "Khu vực";
            // 
            // txtTenBan
            // 
            txtTenBan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenBan.Location = new Point(23, 141);
            txtTenBan.Multiline = true;
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(269, 34);
            txtTenBan.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 99);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên bàn";
            // 
            // btnThemBan
            // 
            btnThemBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemBan.Image = Properties.Resources._4115237_add_plus_114047;
            btnThemBan.Location = new Point(671, 32);
            btnThemBan.Name = "btnThemBan";
            btnThemBan.Size = new Size(71, 44);
            btnThemBan.TabIndex = 5;
            btnThemBan.UseVisualStyleBackColor = true;
            btnThemBan.Click += btnThemBan_Click;
            // 
            // btnSưaBan
            // 
            btnSưaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSưaBan.Image = Properties.Resources.edit_icon_128873;
            btnSưaBan.Location = new Point(593, 666);
            btnSưaBan.Name = "btnSưaBan";
            btnSưaBan.Size = new Size(71, 44);
            btnSưaBan.TabIndex = 6;
            btnSưaBan.UseVisualStyleBackColor = true;
            btnSưaBan.Click += btnSưaBan_Click;
            // 
            // btnXoaBan
            // 
            btnXoaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaBan.Image = Properties.Resources._4115230_cancel_close_cross_delete_114048;
            btnXoaBan.Location = new Point(671, 666);
            btnXoaBan.Name = "btnXoaBan";
            btnXoaBan.Size = new Size(71, 44);
            btnXoaBan.TabIndex = 7;
            btnXoaBan.UseVisualStyleBackColor = true;
            btnXoaBan.Click += btnXoaBan_Click;
            // 
            // txtIDBDC
            // 
            txtIDBDC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDBDC.Location = new Point(800, 35);
            txtIDBDC.Name = "txtIDBDC";
            txtIDBDC.Size = new Size(125, 38);
            txtIDBDC.TabIndex = 8;
            txtIDBDC.Visible = false;
            // 
            // fQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1148, 763);
            Controls.Add(txtIDBDC);
            Controls.Add(btnXoaBan);
            Controls.Add(btnSưaBan);
            Controls.Add(btnThemBan);
            Controls.Add(grthaotac);
            Controls.Add(txtBanDangChon);
            Controls.Add(label2);
            Controls.Add(flpBanAn);
            Controls.Add(label1);
            Name = "fQuanLyBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fQuanLyBan";
            Load += fQuanLyBan_Load;
            grthaotac.ResumeLayout(false);
            grthaotac.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpBanAn;
        private Label label2;
        private TextBox txtBanDangChon;
        private GroupBox grthaotac;
        private Button btnHoanTatThem;
        private Button btnThemHT;
        private Button btnThemBan;
        private Button btnSưaBan;
        private Button btnXoaBan;
        private TextBox txtKhuvuc;
        private Label label5;
        private TextBox txtTenBan;
        private Label label4;
        private TextBox txtIDBDC;
    }
}