namespace QuanLyQuanCafe
{
    partial class fDoanhThu
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
            txtTongTien = new TextBox();
            label4 = new Label();
            btnThoatThongKe = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnThongKe = new Button();
            label3 = new Label();
            label2 = new Label();
            dateKetThuc = new DateTimePicker();
            dateBatDau = new DateTimePicker();
            dataDoanhThu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(txtTongTien);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnThoatThongKe);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataDoanhThu);
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 741);
            panel1.TabIndex = 0;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = SystemColors.ButtonHighlight;
            txtTongTien.Location = new Point(591, 652);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(281, 32);
            txtTongTien.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(444, 650);
            label4.Name = "label4";
            label4.Size = new Size(128, 33);
            label4.TabIndex = 3;
            label4.Text = "Tổng doanh thu:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThoatThongKe
            // 
            btnThoatThongKe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoatThongKe.Location = new Point(6, 693);
            btnThoatThongKe.Name = "btnThoatThongKe";
            btnThoatThongKe.Size = new Size(872, 48);
            btnThoatThongKe.TabIndex = 3;
            btnThoatThongKe.Text = "Thoát";
            btnThoatThongKe.UseVisualStyleBackColor = true;
            btnThoatThongKe.Click += btnThoatThongKe_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 10);
            label1.Name = "label1";
            label1.Size = new Size(364, 51);
            label1.TabIndex = 2;
            label1.Text = "Thống kê doanh thu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThongKe);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateKetThuc);
            panel2.Controls.Add(dateBatDau);
            panel2.Location = new Point(3, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 120);
            panel2.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(255, 255, 128);
            btnThongKe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(3, 69);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(872, 48);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Áp dụng";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 20);
            label3.Name = "label3";
            label3.Size = new Size(128, 34);
            label3.TabIndex = 1;
            label3.Text = "đến ngày";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 20);
            label2.Name = "label2";
            label2.Size = new Size(128, 34);
            label2.TabIndex = 1;
            label2.Text = "Từ ngày";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateKetThuc
            // 
            dateKetThuc.CustomFormat = "dd/MM/yyyy";
            dateKetThuc.Format = DateTimePickerFormat.Custom;
            dateKetThuc.Location = new Point(583, 25);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(151, 38);
            dateKetThuc.TabIndex = 0;
            // 
            // dateBatDau
            // 
            dateBatDau.CustomFormat = "dd/MM/yyyy";
            dateBatDau.Format = DateTimePickerFormat.Custom;
            dateBatDau.Location = new Point(281, 25);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(151, 38);
            dateBatDau.TabIndex = 1;
            dateBatDau.Value = new DateTime(2024, 5, 18, 9, 39, 59, 0);
            // 
            // dataDoanhThu
            // 
            dataDoanhThu.BackgroundColor = SystemColors.ButtonHighlight;
            dataDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDoanhThu.Location = new Point(6, 203);
            dataDoanhThu.Name = "dataDoanhThu";
            dataDoanhThu.RowHeadersVisible = false;
            dataDoanhThu.RowHeadersWidth = 51;
            dataDoanhThu.Size = new Size(875, 427);
            dataDoanhThu.TabIndex = 0;
            // 
            // fDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 765);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fDoanhThu";
            Load += fDoanhThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataDoanhThu;
        private DateTimePicker dateBatDau;
        private Label label1;
        private Label label2;
        private DateTimePicker dateKetThuc;
        private Label label3;
        private Button btnThoatThongKe;
        private Button btnThongKe;
        private TextBox txtTongTien;
        private Label label4;
    }
}