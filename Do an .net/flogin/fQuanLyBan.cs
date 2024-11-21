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

namespace QuanLyQuanCafe
{
    public partial class fQuanLyBan : Form
    {
        public fQuanLyBan()
        {
            InitializeComponent();
        }

        public class BanAnInfo
        {
            public string TenBan { get; set; }
            public int Id { get; set; }

            public BanAnInfo(string tenBan, int id)
            {
                TenBan = tenBan;
                Id = id;
            }
        }

        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";
        void loadNBanAn()
        {
            flpBanAn.Controls.Clear();
            string query = "SELECT * FROM BanAn";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tenban = (string)reader["TenBan"];
                    string khuvuc = (string)reader["khuvuc"];
                    int id = (int)reader["id"];

                    Label lb = new Label();
                    lb.Text = tenban;
                    lb.BorderStyle = BorderStyle.FixedSingle;

                    lb.Size = new Size(701, 40);
                    lb.Font = new Font(lb.Font.FontFamily, 12, lb.Font.Style);
                    lb.Click += Lb_Click;
                    lb.Tag = new BanAnInfo(tenban, id);
                    lb.Margin = new Padding(5);
                    flpBanAn.Controls.Add(lb);
                }
                reader.Close();
                command.Dispose();
            }
        }

        private void Lb_Click(object? sender, EventArgs e)
        {
            Label cl = sender as Label;
            if (cl != null && cl.Tag is BanAnInfo)
            {
                BanAnInfo info = (BanAnInfo)cl.Tag;
                txtBanDangChon.Text = info.TenBan;
                txtIDBDC.Text = info.Id.ToString();
            }
        }

        private void fQuanLyBan_Load(object sender, EventArgs e)
        {
            loadNBanAn();
            grthaotac.Visible = false;
        }

        private void btnSưaBan_Click(object sender, EventArgs e)
        {
            if (txtBanDangChon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grthaotac.Text = "Sửa bàn";
                grthaotac.Visible = true;
                btnHoanTatThem.Visible = true;
                btnThemHT.Visible = false;
                string query = "SELECT * FROM BanAn WHERE id = @id";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", txtIDBDC.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tenban = (string)reader["TenBan"];
                        string khuvuc = (string)reader["KhuVuc"];
                        txtTenBan.Text = tenban;
                        txtKhuvuc.Text = khuvuc;
                    }

                    reader.Close();
                    command.Dispose();

                }

            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string sql = "DELETE FROM BanAn Where id = @id";

                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", txtIDBDC.Text);
                        command.ExecuteNonQuery();
                    }
                }
                loadNBanAn();
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            grthaotac.Text = "Thêm bàn";
            grthaotac.Visible = true;
            btnThemHT.Visible = true;
            btnHoanTatThem.Visible = false;
            txtTenBan.Clear();
            txtKhuvuc.Clear();
        }

        private void btnHoanTatThem_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE BanAn SET TenBan = @tb, KhuVuc = @kv WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tb", txtTenBan.Text);
                    command.Parameters.AddWithValue("@kv", txtKhuvuc.Text);
                    command.Parameters.AddWithValue("@id", txtIDBDC.Text);
                    command.ExecuteNonQuery();
                }
            }
            grthaotac.Visible = false;
            loadNBanAn();
        }

        private void btnThemHT_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO BanAn (TenBan, KhuVuc, TrangThai) VALUES (@tb, @kv, 0)";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tb", txtTenBan.Text);
                    insertCommand.Parameters.AddWithValue("@kv", txtKhuvuc.Text);
                    insertCommand.ExecuteNonQuery();
                }
            }
            grthaotac.Visible = false;
            loadNBanAn();
        }

        private void txtBanDangChon_TextChanged(object sender, EventArgs e)
        {
            if (btnThemHT.Visible == false && btnHoanTatThem.Visible == true)
            {
                grthaotac.Visible = true;
                string query = "SELECT * FROM BanAn WHERE TenBan = @tba";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tba", txtBanDangChon.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTenBan.Text = (string)reader["TenBan"];
                        txtKhuvuc.Text = (string)reader["KhuVuc"];
                    }
                    reader.Close();
                    command.Dispose();
                }
            }
        }
    }
}
