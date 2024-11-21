namespace QuanLyQuanCafe
{
    partial class fThemBill
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
            txtTenMonThemBill = new TextBox();
            label2 = new Label();
            txtGiaThemBill = new TextBox();
            label3 = new Label();
            nbSoLuong = new NumericUpDown();
            btnHoanThanhThemBill = new Button();
            btnThoatThemBill = new Button();
            ((System.ComponentModel.ISupportInitialize)nbSoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên món ăn:";
            // 
            // txtTenMonThemBill
            // 
            txtTenMonThemBill.Location = new Point(237, 74);
            txtTenMonThemBill.Name = "txtTenMonThemBill";
            txtTenMonThemBill.ReadOnly = true;
            txtTenMonThemBill.Size = new Size(330, 34);
            txtTenMonThemBill.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 28);
            label2.TabIndex = 0;
            label2.Text = "Giá:";
            // 
            // txtGiaThemBill
            // 
            txtGiaThemBill.Location = new Point(237, 144);
            txtGiaThemBill.Name = "txtGiaThemBill";
            txtGiaThemBill.ReadOnly = true;
            txtGiaThemBill.Size = new Size(330, 34);
            txtGiaThemBill.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 0;
            label3.Text = "Số lượng:";
            // 
            // nbSoLuong
            // 
            nbSoLuong.Location = new Point(237, 216);
            nbSoLuong.Name = "nbSoLuong";
            nbSoLuong.Size = new Size(93, 34);
            nbSoLuong.TabIndex = 1;
            nbSoLuong.TextAlign = HorizontalAlignment.Center;
            nbSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnHoanThanhThemBill
            // 
            btnHoanThanhThemBill.Location = new Point(65, 297);
            btnHoanThanhThemBill.Name = "btnHoanThanhThemBill";
            btnHoanThanhThemBill.Size = new Size(146, 43);
            btnHoanThanhThemBill.TabIndex = 2;
            btnHoanThanhThemBill.Text = "Hoàn thành";
            btnHoanThanhThemBill.UseVisualStyleBackColor = true;
            btnHoanThanhThemBill.Click += btnHoanThanhThemBill_Click;
            // 
            // btnThoatThemBill
            // 
            btnThoatThemBill.Location = new Point(349, 297);
            btnThoatThemBill.Name = "btnThoatThemBill";
            btnThoatThemBill.Size = new Size(146, 43);
            btnThoatThemBill.TabIndex = 3;
            btnThoatThemBill.Text = "Hủy";
            btnThoatThemBill.UseVisualStyleBackColor = true;
            // 
            // fThemBill
            // 
            AcceptButton = btnHoanThanhThemBill;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(628, 377);
            Controls.Add(btnThoatThemBill);
            Controls.Add(btnHoanThanhThemBill);
            Controls.Add(nbSoLuong);
            Controls.Add(txtGiaThemBill);
            Controls.Add(txtTenMonThemBill);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "fThemBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đồ";
            Load += fThemBill_Load;
            ((System.ComponentModel.ISupportInitialize)nbSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenMonThemBill;
        private Label label2;
        private TextBox txtGiaThemBill;
        private Label label3;
        private NumericUpDown nbSoLuong;
        private Button btnHoanThanhThemBill;
        private Button btnThoatThemBill;
    }
}