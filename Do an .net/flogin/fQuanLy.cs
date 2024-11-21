using QuanLyQuanCafe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace flogin
{
    public partial class fQuanLy : Form
    {
        private int id;
        private int idBanDangChon;
        private string khuvuc;
        private string TrangThai;
        private string TenHienThi;
        public fQuanLy(string trangThai, string TenHienThi)
        {
            InitializeComponent();
            TrangThai = trangThai;
            this.TenHienThi = TenHienThi;
        }

        #region kết nối các form
        private void DanhmucMenu_Click(object sender, EventArgs e)
        {
            fDanhMuc fdm = new fDanhMuc();
            fdm.ShowDialog();
            this.Show();

        }

        private void ThucDonMenu_Click(object sender, EventArgs e)
        {
            fThucDon ftd = new fThucDon();
            ftd.ShowDialog();
            this.Show();
        }

        private void DoanhThuMenu_Click(object sender, EventArgs e)
        {
            fDoanhThu ftkdt = new fDoanhThu();
            ftkdt.ShowDialog();
            this.Show();
        }

        private void ThongTinCaNhanMenu_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan fttcn = new fThongTinCaNhan(TenHienThi);
            fttcn.ShowDialog();
            this.Show();
        }



        private void BanAnMenu_Click(object sender, EventArgs e)
        {
            fQuanLyBan fqlb = new fQuanLyBan();
            fqlb.ShowDialog();
            this.Show();
        }

        private void menuTKNV_Click(object sender, EventArgs e)
        {
            fNhanVien fnv = new fNhanVien();
            fnv.ShowDialog();
            this.Show();
        }

        #endregion

        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";
        private void LoadTables(string khuVuc)
        {

            flpTable.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT * FROM BanAn WHERE KhuVuc = '" + khuVuc.ToString() + "' ";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int tableId = (int)reader["id"];
                    string tableName = (string)reader["TenBan"];
                    int trangthai = (int)reader["TrangThai"];
                    Button tableButton = new Button();
                    tableButton.Text = tableName;
                    if (trangthai == 0)
                    {
                        tableButton.BackColor = Color.Tomato;
                    }
                    else if (trangthai == 1)
                    {
                        tableButton.BackColor = Color.Gold;
                    }
                    else
                    {
                        tableButton.BackColor = Color.LightGreen;
                    }
                    tableButton.Tag = tableId;
                    tableButton.Size = new Size(90, 90);
                    tableButton.Click += TableButton_Click;
                    flpTable.Controls.Add(tableButton);
                }
                reader.Close();
            }
        }

        void xoaSoLuong0()
        {
            string sql = "delete from ThongTinHoaDon where SoLuong = 0 and idHoaDon = @idhoadon";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@idhoadon", idHoaDonCoSan(idBanDangChon));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void ShowHoaDon(int tableId)
        {
            xoaSoLuong0();
            dtgvThucDon.DataSource = null;
            string query = @"
            SELECT MonAn.TenMonAn, ThongTinHoaDon.SoLuong, MonAn.Gia
            FROM HoaDon
            INNER JOIN ThongTinHoaDon ON HoaDon.id = ThongTinHoaDon.idHoaDon
            INNER JOIN MonAn ON ThongTinHoaDon.idMonAn = MonAn.id
            WHERE HoaDon.idBanAn = @TableId
            AND HoaDon.TrangThai = 0";


            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TableId", tableId);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dtgvThucDon.DataSource = tb;
                        if (dtgvThucDon.DataSource != null)
                        {
                            txtTongTien.Text = tongtien(tb).ToString();
                        }
                    }
                }
            }

            dtgvThucDon.Columns["TenMonAn"].Width = 280;
            dtgvThucDon.Columns["SoLuong"].Width = 163;
            dtgvThucDon.Columns["Gia"].Width = 200;
            dtgvThucDon.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dtgvThucDon.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgvThucDon.Columns["Gia"].HeaderText = "Giá";
            dtgvThucDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        static float tongtien(DataTable dtgvThucDon)
        {
            float tongtien = 0;
            for (int i = 0; i < dtgvThucDon.Rows.Count; i++)
            {
                float sl = float.Parse(dtgvThucDon.Rows[i][1].ToString());
                float gia = float.Parse(dtgvThucDon.Rows[i][2].ToString());
                float tt = sl * gia;
                tongtien += tt;
            }
            return tongtien;
        }

        private void txtKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKhachTra.Text))
            {
                txtTienThua.Text = "";
                return;
            }
            try
            {
                float khachTra = float.Parse(txtKhachTra.Text);
                float tongTien = float.Parse(txtTongTien.Text);
                txtTienThua.Text = (khachTra - tongTien).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng nhập số.");
                txtKhachTra.Focus();
                txtKhachTra.SelectAll();
            }
        }

        void loadMonAn(int idDanhMuc)
        {
            flpMonAnShow.Controls.Clear();
            string sql = "select * from MonAn where idDanhMuc = '" + idDanhMuc.ToString() + "'";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int MonAnID = (int)reader["id"];
                        string tenmonan = (string)reader["TenMonAn"];
                        double gia = (double)reader["Gia"];
                        Button foodButton = new Button();
                        foodButton.Text = tenmonan + "\n" + "(" + gia + ")";
                        foodButton.Tag = MonAnID;
                        foodButton.Size = new Size(120, 120);
                        foodButton.Click += foodButton_Click;
                        flpMonAnShow.Controls.Add(foodButton);
                    }
                    reader.Close();
                }
            }
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int MonAnID = (int)clickedButton.Tag;
            fThemBill ftb = new fThemBill(MonAnID, idBanDangChon);
            ftb.ShowDialog();
            this.Show();
            if (khuvuc != null)
            {
                doitrangthaiban1(idBanDangChon);
                LoadTables(khuvuc);
                ShowHoaDon(idBanDangChon);
            }

        }

        void BanDangChon(int tableId)
        {
            txtBanDangChon.Text = null;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT * FROM BanAn";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int tbid = (int)reader["id"];
                    string tableName = (string)reader["TenBan"];
                    if (tbid == tableId)
                    {
                        txtBanDangChon.Text = tableName;
                    }
                }
                reader.Close();
            }

        }

        public bool KiemTraBill()
        {
            string sql = "SELECT COUNT(*) FROM HoaDon WHERE idBanAn = @idBan AND TrangThai = 0";
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idBan", idBanDangChon);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra hóa đơn: " + ex.Message);
                return false;
            }
        }

        void doitrangthaiban1(int tableId)/////////////
        {
            if (KiemTraBill() == true)
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string sql = "UPDATE BanAn SET TrangThai = 1 WHERE id = @TableId";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@TableId", tableId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }

        void doitrangthaiban2(int tableId)/////////////
        {
            if (KiemTraBill() == true)
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string sql = "UPDATE BanAn SET TrangThai = 2 WHERE id = @TableId";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@TableId", tableId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }

        void doitrangthaiban0(int tableId)/////////////
        {
            //if (KiemTraBill() == true)
            //{
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "UPDATE BanAn SET TrangThai = 0 WHERE id = @TableId";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@TableId", tableId);
                    //cmd.Parameters.AddWithValue("@TrangThai", dtgvThucDon.Rows.Count == 0 ? 0 : 1);
                    cmd.ExecuteNonQuery();
                }
            }
            //}

        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            txtKhachTra.Text = null;
            txtTienThua.Text = null;
            Button clickedButton = sender as Button;
            int tableId = (int)clickedButton.Tag;
            idBanDangChon = tableId;
            ShowHoaDon(tableId);
            BanDangChon(tableId);
        }

        private void loadkhuvuc()
        {
            string sql = "SELECT DISTINCT KhuVuc FROM BanAn";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string khuvuc = (string)reader["KhuVuc"];
                cbKhuVuc.Items.Add(khuvuc);
            }
            connection.Close();
            command.Dispose();
        }

        private void loaddanhmuc()
        {
            string sql = "select * from DanhMuc";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string danhmuc = (string)reader["TenDanhMuc"];
                cbDanhMuc.Items.Add(danhmuc);
            }
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedKhuVuc = cbKhuVuc.SelectedItem.ToString();
            //LoadTables(selectedKhuVuc);
            //txtHienThiKhuVuc.Text = selectedKhuVuc;
            khuvuc = cbKhuVuc.SelectedItem.ToString();
            LoadTables(khuvuc);
            txtHienThiKhuVuc.Text = khuvuc;
        }

        private void txtHienThiKhuVuc_TextChanged(object sender, EventArgs e)
        {

        }

        public int DoiTenMonAnSangID(string tenmonan)///////////////
        {
            string sql = "SELECT id FROM MonAn WHERE TenMonAn = @tenmonan";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@tenmonan", tenmonan);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return (int)reader["id"];
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public int DoiTenDanhMucSangID(string TenDanhMuc)
        {
            string sql = "SELECT id FROM DanhMuc WHERE TenDanhMuc = @TenDanhMuc";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@TenDanhMuc", TenDanhMuc);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return (int)reader["id"];
                    }
                    else
                    {
                        // Xử lý trường hợp không tìm thấy kết quả
                        return 0;
                    }
                }
            }
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = DoiTenDanhMucSangID(cbDanhMuc.SelectedItem.ToString());
            loadMonAn(id);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            flpMonAnShow.Controls.Clear();
            string timKiem = txtTimKiem.Text.Trim();
            string query = $"SELECT * FROM MonAn WHERE idDanhMuc = @IdDanhMuc AND TenMonAn LIKE @TimKiem";
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TimKiem", $"%{timKiem}%");
                    command.Parameters.AddWithValue("@IdDanhMuc", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int MonAnID = (int)reader["id"];
                        string tenmonan = (string)reader["TenMonAn"];
                        double gia = (double)reader["Gia"];
                        Button foodButton = new Button();
                        foodButton.Text = tenmonan + "\n" + "(" + gia + ")";
                        foodButton.Tag = MonAnID;
                        foodButton.Size = new Size(120, 120);
                        foodButton.Click += foodButton_Click;
                        flpMonAnShow.Controls.Add(foodButton);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (idBanDangChon != 0)
                {
                    string sql = "update HoaDon set TrangThai = 1 where idBanAn = @idBanDangChon";
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@idBanDangChon", idBanDangChon);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    ShowHoaDon(idBanDangChon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn bàn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (khuvuc != null)
            {
                doitrangthaiban0(idBanDangChon);
                LoadTables(khuvuc);
            }

        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {
            loadkhuvuc();
            loaddanhmuc();

            menuTaiKhoan.Text = TenHienThi;

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.Name = "DeleteButtonColumn";
            delete.HeaderText = "";
            delete.Text = "(-)";
            delete.UseColumnTextForButtonValue = true;
            dtgvThucDon.Columns.Add(delete);
            delete.Width = 55;

            DataGridViewButtonColumn them = new DataGridViewButtonColumn();
            them.Name = "InsertButtonColumn";
            them.HeaderText = "";
            them.Text = "(+)";
            them.UseColumnTextForButtonValue = true;
            dtgvThucDon.Columns.Add(them);
            them.Width = 55;

            if (TrangThai == "1")
            {
                menuQLy.Visible = false;
            }

        }

        void xoadongtructiep(int idmonan, int idhoadon)///////////
        {
            string sql = "UPDATE ThongTinHoaDon SET SoLuong = SoLuong - 1 WHERE idMonAn = @idmonan AND idHoaDon = @idhoadon ";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@idmonan", idmonan);
                    cmd.Parameters.AddWithValue("@idhoadon", idhoadon);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void themdongtructiep(int idmonan, int idhoadon)
        {
            string sql = "UPDATE ThongTinHoaDon SET SoLuong = SoLuong + 1 WHERE idMonAn = @idmonan AND idHoaDon = @idhoadon ";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@idmonan", idmonan);
                    cmd.Parameters.AddWithValue("@idhoadon", idhoadon);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void dtgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)///////////////
        {
            if (e.ColumnIndex == dtgvThucDon.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                string tenmon = (string)dtgvThucDon.Rows[e.RowIndex].Cells["TenMonAn"].Value;
                xoadongtructiep(DoiTenMonAnSangID(tenmon), idHoaDonCoSan(idBanDangChon));
                ShowHoaDon(idBanDangChon);
                //dtgvThucDon.Rows.RemoveAt(e.RowIndex);
            }

            if (e.ColumnIndex == dtgvThucDon.Columns["InsertButtonColumn"].Index && e.RowIndex >= 0)
            {
                string tenmon = (string)dtgvThucDon.Rows[e.RowIndex].Cells["TenMonAn"].Value;
                themdongtructiep(DoiTenMonAnSangID(tenmon), idHoaDonCoSan(idBanDangChon));
                ShowHoaDon(idBanDangChon);
                //dtgvThucDon.Rows.RemoveAt(e.RowIndex);
            }
        }
        public int idHoaDonCoSan(int idBanAn)
        {
            int idHoaDon = 0;
            string sql = "SELECT id FROM HoaDon WHERE idBanAn = @idBan AND TrangThai = 0";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@idBan", idBanAn);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        idHoaDon = Convert.ToInt32(result);
                    }
                }
            }
            return idHoaDon;
        }

        private void btnHoanThanhThucDon_Click(object sender, EventArgs e)
        {
            if (khuvuc != null)
            {
                doitrangthaiban2(idBanDangChon);
                LoadTables(khuvuc);
            }
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
