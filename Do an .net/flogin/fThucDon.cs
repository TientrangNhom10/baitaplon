using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCafe.fDanhMuc;

namespace QuanLyQuanCafe
{
    public partial class fThucDon : Form
    {
        public class Thucdoninfo
        {
            public string TenMon { get; set; }
            public int Id { get; set; }

            public int idDM { get; set; }

            public Thucdoninfo(string TenMon, int Id, int idDM)
            {
                this.TenMon = TenMon;
                this.Id = Id;
                this.idDM = idDM;
            }
        }

        public int DoitensangidDM(string TenDanhMuc)
        {
            string sql = "SELECT id FROM DanhMuc WHERE TenDanhMuc = @tdm";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@tdm", TenDanhMuc);
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

        public fThucDon()
        {
            InitializeComponent();
        }
        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        void loadThucDon()
        {
            flpThucDon.Controls.Clear();
            string query = "SELECT * FROM MonAn";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tenmon = (string)reader["TenMonAn"];
                    double gia = (double)reader["Gia"];
                    int id = (int)reader["id"];
                    int idDM = (int)reader["idDanhMuc"];
                    Label lb = new Label();
                    lb.Text = tenmon;
                    lb.BorderStyle = BorderStyle.FixedSingle;

                    lb.Size = new Size(701, 40);
                    lb.Font = new Font(lb.Font.FontFamily, 12, lb.Font.Style);
                    lb.Click += Lb_Click;
                    lb.Tag = new Thucdoninfo(tenmon, id, idDM);
                    lb.Margin = new Padding(5);
                    flpThucDon.Controls.Add(lb);
                }
                reader.Close();
                command.Dispose();
            }
        }

        private void Lb_Click(object? sender, EventArgs e)
        {
            Label cl = sender as Label;
            if (cl != null && cl.Tag is Thucdoninfo)
            {
                Thucdoninfo info = (Thucdoninfo)cl.Tag;
                txtChonMon.Text = info.TenMon;
                txtidTD.Text = info.Id.ToString();
                txtIDDM.Text = info.idDM.ToString();
            }
        }

        private void fThucDon_Load(object sender, EventArgs e)
        {
            loaddanhmuc();
            loadThucDon();
            grthaoTac.Visible = false;
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            if (txtChonMon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grthaoTac.Text = "Sửa thực đơn";
                grthaoTac.Visible = true;
                btnHoantatthem.Visible = true;
                btnThemht.Visible = false;
                string query = "SELECT * FROM MonAn WHERE id = @id";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", txtidTD.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tenmon = (string)reader["TenMonAn"];
                        double gia = (double)reader["Gia"];

                        txtTenmonan.Text = tenmon;
                        txtGia.Text = gia.ToString();
                    }
                    reader.Close();
                    command.Dispose();

                }

            }
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string sql = "DELETE FROM MonAn Where id = @id";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", txtidTD.Text);
                        command.ExecuteNonQuery();
                    }
                }
                loadThucDon();
            }
        }

        private void btnThemTD_Click(object sender, EventArgs e)
        {
            grthaoTac.Text = "Thêm danh mục";
            grthaoTac.Visible = true;
            btnThemht.Visible = true;
            btnHoantatthem.Visible = false;
            txtTenmonan.Clear();
            txtGia.Clear();
        }

        private void btnHoantatthem_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE MonAn SET TenMonAn = @tma, Gia = @gia, idDanhMuc = @iddm WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@iddm", DoitensangidDM(cbDanhMuc.Text));
                    command.Parameters.AddWithValue("@tma", txtTenmonan.Text);
                    command.Parameters.AddWithValue("@id", txtidTD.Text);
                    command.Parameters.AddWithValue("@gia", txtGia.Text);
                    command.ExecuteNonQuery();
                }
            }
            grthaoTac.Visible = false;
            loadThucDon();
        }

        private void btnThemht_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO MonAn (TenMonAn, Gia, idDanhMuc) VALUES (@tma, @gia, @idDm)";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tma", txtTenmonan.Text);
                    insertCommand.Parameters.AddWithValue("@gia", txtGia.Text);
                    insertCommand.Parameters.AddWithValue("@idDm", DoitensangidDM(cbDanhMuc.Text));
                    insertCommand.ExecuteNonQuery();
                }
            }
            grthaoTac.Visible = false;
            loadThucDon();
        }

        private void txtChonMon_TextChanged(object sender, EventArgs e)
        {
            if (btnThemht.Visible == false && btnHoantatthem.Visible == true)
            {
                grthaoTac.Visible = true;
                string query = "SELECT * FROM MonAn WHERE TenMonAn = @tma";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tma", txtChonMon.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTenmonan.Text = (string)reader["TenMonAn"];
                        double gia = (double)reader["Gia"];
                        txtGia.Text = gia.ToString();
                    }
                    reader.Close();
                    command.Dispose();
                }
            }
        }

        void loaddanhmuc()
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
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIDDM_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDDM.Text))
            {
                if (int.TryParse(txtIDDM.Text, out int idDm))
                {
                    string sql = "select TenDanhMuc from DanhMuc where id = @id";
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", idDm);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string tenDanhMuc = reader["TenDanhMuc"].ToString();
                                    cbDanhMuc.Text = tenDanhMuc;
                                }
                                else
                                {
                                    cbDanhMuc.Text = string.Empty; // Xử lý khi không tìm thấy dữ liệu
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Xử lý khi idDm không phải là số hợp lệ
                    cbDanhMuc.Text = string.Empty;
                }
            }
            else
            {
                // Xử lý khi txtidTD rỗng hoặc null
                cbDanhMuc.Text = string.Empty;
            }
        }
    }
}
