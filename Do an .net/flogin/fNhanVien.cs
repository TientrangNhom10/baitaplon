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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        void loadNhanVien()
        {
            flpNhanVien.Controls.Clear();
            string query = "SELECT * FROM TaiKhoan WHERE LoaiTaiKhoan = 1";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tedangnhap = (string)reader["TenDangNhap"];
                    string tenhienthi = (string)reader["TenHienThi"];
                    int loatTK = (int)reader["LoaiTaiKhoan"];

                    Label lb = new Label();
                    lb.Text = tenhienthi;
                    lb.BorderStyle = BorderStyle.FixedSingle;

                    lb.Size = new Size(702, 40);
                    lb.Font = new Font(lb.Font.FontFamily, 12, lb.Font.Style);
                    lb.Click += Lb_Click;
                    lb.Tag = tenhienthi;
                    lb.Margin = new Padding(5);
                    flpNhanVien.Controls.Add(lb);
                }
                reader.Close();
                command.Dispose();
            }
        }



        private void Lb_Click(object? sender, EventArgs e)
        {
            Label cl = sender as Label;
            string tenhienthi = (string)cl.Tag;
            txtTenNhanVien.Text = tenhienthi;

        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            loadNhanVien();
            grThaoTac.Visible = false;
        }

        private void btnSuanv_Click(object sender, EventArgs e)
        {
            
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grThaoTac.Text = "Sửa nhân viên";
                grThaoTac.Visible = true;
                btnHoanTat.Visible = true;
                btnThemHoanTat.Visible = false;
                string query = "SELECT * FROM TaiKhoan WHERE TenHienThi = @tenhienthi AND LoaiTaiKhoan = 1";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tenhienthi", txtTenNhanVien.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTDN.Text = (string)reader["TenDangNhap"];
                        txtTHT.Text = (string)reader["TenHienThi"];
                        txtMK.Text = (string)reader["MatKhau"];
                    }
                    reader.Close();
                    command.Dispose();
                }
            }
        }

        private void btnXoanv_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string sql = "DELETE FROM TaiKhoan Where TenHienThi = @tht";

                using (SqlConnection connection = new SqlConnection(conn))
                {

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tht", txtTenNhanVien.Text);
                        command.ExecuteNonQuery();
                    }
                }
                loadNhanVien();
            }
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            grThaoTac.Text = "Thêm nhân viên";
            grThaoTac.Visible = true;
            btnThemHoanTat.Visible = true;
            btnHoanTat.Visible = false;
            txtTDN.Clear();
            txtTHT.Clear();
            txtMK.Clear();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE TaiKhoan SET TenHienThi = @tht, MatKhau = @mk WHERE TenDangNhap = @tdn";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tht", txtTHT.Text);
                    command.Parameters.AddWithValue("@tdn", txtTDN.Text);
                    command.Parameters.AddWithValue("@mk", txtMK.Text);
                    command.ExecuteNonQuery();
                }
            }
            grThaoTac.Visible = false;
            loadNhanVien();
        }

        private void btnThemHoanTat_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @tdn";
            string insertQuery = "INSERT INTO TaiKhoan (TenDangNhap, TenHienThi, MatKhau, LoaiTaiKhoan) VALUES (@tdn, @tht, @mk, 1)";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@tdn", txtTDN.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTDN.Focus();
                        txtTDN.SelectAll();
                        return;
                    }
                }
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tdn", txtTDN.Text);
                    insertCommand.Parameters.AddWithValue("@tht", txtTHT.Text);
                    insertCommand.Parameters.AddWithValue("@mk", txtMK.Text);
                    insertCommand.ExecuteNonQuery();
                }
            }

            grThaoTac.Visible = false;
            loadNhanVien();
        }


        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            if(btnThemHoanTat.Visible == false && btnHoanTat.Visible ==true)
            {
                grThaoTac.Visible = true;
                string query = "SELECT * FROM TaiKhoan WHERE TenHienThi = @tenhienthi AND LoaiTaiKhoan = 1";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tenhienthi", txtTenNhanVien.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTDN.Text = (string)reader["TenDangNhap"];
                        txtTHT.Text = (string)reader["TenHienThi"];
                        txtMK.Text = (string)reader["MatKhau"];
                    }
                    reader.Close();
                    command.Dispose();
                }
            }    
        }
    }
}
