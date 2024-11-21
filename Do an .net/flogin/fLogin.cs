using QuanLyQuanCafe;
using System.Data.SqlClient;

namespace flogin
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            string sql = "SELECT LoaiTaiKhoan, TenHienThi FROM TaiKhoan WHERE TenDangNhap = @tendangnhap AND MatKhau = @matkhau";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tendangnhap", username);
                    command.Parameters.AddWithValue("@matkhau", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string loaiTaiKhoan = reader["LoaiTaiKhoan"].ToString();
                            string tenHienThi = reader["TenHienThi"].ToString();

                            fQuanLy fQL = new fQuanLy(loaiTaiKhoan, tenHienThi);
                            this.Hide();
                            fQL.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTenDangNhap.Focus();
                            txtTenDangNhap.SelectAll();
                        }
                    }
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }



        private void flogin_Load(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
