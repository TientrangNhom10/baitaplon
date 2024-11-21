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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }
        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhapDk.Text;
            string tenhienthi = txtTenHienThiDK.Text;
            string matkhau = txtMatKhauDk.Text;
            string matkhaunhaplai = txtMatKhauDkLai.Text;

            if (matkhau != matkhaunhaplai)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại.");
                txtMatKhauDkLai.Focus();
                txtMatKhauDkLai.SelectAll();
            }
            else
            {
                string query = $"INSERT INTO TaiKhoan (TenDangNhap, TenHienThi, MatKhau) VALUES ('{tendangnhap}', '{tenhienthi}', '{matkhau}')";
                string query1 = $"SELECT COUNT(1) FROM TaiKhoan WHERE TenDangNhap = '{tendangnhap}'";

                SqlConnection connection = new SqlConnection(conn);
                SqlCommand command = new SqlCommand(query, connection);
                SqlCommand command1 = new SqlCommand(query1, connection);

                try
                {

                    connection.Open();
                    int count = (int)command1.ExecuteScalar();
                    if (count == 1)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        txtTenDangNhapDk.Focus();
                        txtTenDangNhapDk.SelectAll();
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công!");
                        if (connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }

                }

            }
        }

        private void btnThoatDangKy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
