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
    public partial class fThongTinCaNhan : Form
    {
        private string tenhienthi;
        public fThongTinCaNhan(string tenhienthi)
        {
            InitializeComponent();
            this.tenhienthi = tenhienthi;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatCapNhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update TaiKhoan Set Tenhienthi = @tenhienthi ,MatKhau = @mk Where TenDangNhap = @tdn";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@mk", txtNhapPass.Text);
                        cmd.Parameters.AddWithValue("@tenhienthi", txtTenHienThi.Text);
                        cmd.Parameters.AddWithValue("@tdn", txtTenDangNhap.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật thành công. Restart chương trình để áp dụng");
                
            }
            catch {
                MessageBox.Show("Cập nhật lỗi.");
            }
            finally
            {
                this.Close();
            }
            
        }
        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";
        public  void loadthongtincanhan(string tenhienthi)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenHienThi = @tht";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tht", tenhienthi);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tenDN = (string)reader["TenDangNhap"];
                    string tenHT = (string)reader["TenHienThi"];
                    string MK = (string)reader["MatKhau"];

                    txtTenDangNhap.Text = tenDN;
                    txtTenHienThi.Text = tenHT;
                    txtMatKhau.Text = MK;
                }
                reader.Close();
                command.Dispose();

            }
        }

        private void fThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadthongtincanhan(tenhienthi);
        }
    }
}
