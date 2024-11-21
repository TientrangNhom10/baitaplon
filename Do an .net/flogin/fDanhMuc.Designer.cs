namespace QuanLyQuanCafe
{
    partial class fDanhMuc
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
            flpDanhMuc = new FlowLayoutPanel();
            label2 = new Label();
            txtDanhMucDC = new TextBox();
            grThaotac = new GroupBox();
            btnHoanTatthemDM = new Button();
            btnThemDMHT = new Button();
            txtTenDM = new TextBox();
            label4 = new Label();
            txtIDDM = new TextBox();
            label3 = new Label();
            btnThemDM = new Button();
            btnSuaDM = new Button();
            btnXoaDM = new Button();
            grThaotac.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 35);
            label1.Name = "label1";
            label1.Size = new Size(375, 56);
            label1.TabIndex = 0;
            label1.Text = "Danh sách danh mục";
            // 
            // flpDanhMuc
            // 
            flpDanhMuc.AutoScroll = true;
            flpDanhMuc.BackColor = Color.White;
            flpDanhMuc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpDanhMuc.Location = new Point(39, 97);
            flpDanhMuc.Name = "flpDanhMuc";
            flpDanhMuc.Size = new Size(711, 544);
            flpDanhMuc.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 667);
            label2.Name = "label2";
            label2.Size = new Size(135, 44);
            label2.TabIndex = 2;
            label2.Text = "Danh mục";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDanhMucDC
            // 
            txtDanhMucDC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDanhMucDC.Location = new Point(189, 667);
            txtDanhMucDC.Multiline = true;
            txtDanhMucDC.Name = "txtDanhMucDC";
            txtDanhMucDC.ReadOnly = true;
            txtDanhMucDC.Size = new Size(384, 44);
            txtDanhMucDC.TabIndex = 3;
            txtDanhMucDC.TextChanged += txtDanhMucDC_TextChanged;
            // 
            // grThaotac
            // 
            grThaotac.BackColor = Color.FromArgb(192, 255, 255);
            grThaotac.Controls.Add(btnHoanTatthemDM);
            grThaotac.Controls.Add(btnThemDMHT);
            grThaotac.Controls.Add(txtTenDM);
            grThaotac.Controls.Add(label4);
            grThaotac.Location = new Point(789, 97);
            grThaotac.Name = "grThaotac";
            grThaotac.Size = new Size(321, 544);
            grThaotac.TabIndex = 4;
            grThaotac.TabStop = false;
            // 
            // btnHoanTatthemDM
            // 
            btnHoanTatthemDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoanTatthemDM.Location = new Point(83, 482);
            btnHoanTatthemDM.Name = "btnHoanTatthemDM";
            btnHoanTatthemDM.Size = new Size(170, 40);
            btnHoanTatthemDM.TabIndex = 2;
            btnHoanTatthemDM.Text = "Hoàn tất";
            btnHoanTatthemDM.UseVisualStyleBackColor = true;
            btnHoanTatthemDM.Click += btnHoanTatthemDM_Click;
            // 
            // btnThemDMHT
            // 
            btnThemDMHT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemDMHT.Location = new Point(83, 482);
            btnThemDMHT.Name = "btnThemDMHT";
            btnThemDMHT.Size = new Size(170, 40);
            btnThemDMHT.TabIndex = 2;
            btnThemDMHT.Text = "Thêm";
            btnThemDMHT.UseVisualStyleBackColor = true;
            btnThemDMHT.Click += btnThemDMHT_Click;
            // 
            // txtTenDM
            // 
            txtTenDM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDM.Location = new Point(23, 201);
            txtTenDM.Multiline = true;
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(281, 34);
            txtTenDM.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 160);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên danh mục";
            // 
            // txtIDDM
            // 
            txtIDDM.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDDM.Location = new Point(829, 47);
            txtIDDM.Multiline = true;
            txtIDDM.Name = "txtIDDM";
            txtIDDM.Size = new Size(281, 34);
            txtIDDM.TabIndex = 1;
            txtIDDM.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(792, 47);
            label3.Name = "label3";
            label3.Size = new Size(31, 25);
            label3.TabIndex = 0;
            label3.Text = "ID";
            label3.Visible = false;
            // 
            // btnThemDM
            // 
            btnThemDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemDM.Image = Properties.Resources._4115237_add_plus_114047;
            btnThemDM.Location = new Point(679, 47);
            btnThemDM.Name = "btnThemDM";
            btnThemDM.Size = new Size(71, 44);
            btnThemDM.TabIndex = 5;
            btnThemDM.UseVisualStyleBackColor = true;
            btnThemDM.Click += btnThemDM_Click;
            // 
            // btnSuaDM
            // 
            btnSuaDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuaDM.Image = Properties.Resources.edit_icon_128873;
            btnSuaDM.Location = new Point(593, 667);
            btnSuaDM.Name = "btnSuaDM";
            btnSuaDM.Size = new Size(71, 44);
            btnSuaDM.TabIndex = 5;
            btnSuaDM.UseVisualStyleBackColor = true;
            btnSuaDM.Click += btnSuaDM_Click;
            // 
            // btnXoaDM
            // 
            btnXoaDM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoaDM.Image = Properties.Resources._4115230_cancel_close_cross_delete_114048;
            btnXoaDM.Location = new Point(679, 667);
            btnXoaDM.Name = "btnXoaDM";
            btnXoaDM.Size = new Size(71, 44);
            btnXoaDM.TabIndex = 5;
            btnXoaDM.UseVisualStyleBackColor = true;
            btnXoaDM.Click += btnXoaDM_Click;
            // 
            // fDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1148, 763);
            Controls.Add(btnXoaDM);
            Controls.Add(btnSuaDM);
            Controls.Add(btnThemDM);
            Controls.Add(grThaotac);
            Controls.Add(txtIDDM);
            Controls.Add(txtDanhMucDC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flpDanhMuc);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục";
            Load += fDanhMuc_Load;
            grThaotac.ResumeLayout(false);
            grThaotac.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpDanhMuc;
        private Label label2;
        private TextBox txtDanhMucDC;
        private GroupBox grThaotac;
        private TextBox txtIDDM;
        private Label label3;
        private Button btnThemDM;
        private Button btnSuaDM;
        private Button btnXoaDM;
        private Button btnHoanTatthemDM;
        private Button btnThemDMHT;
        private TextBox txtTenDM;
        private Label label4;
    }
}