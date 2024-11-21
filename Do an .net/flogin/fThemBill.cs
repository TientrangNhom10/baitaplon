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
    public partial class fThemBill : Form
    {
        private int MonAnID;
        private int idBanDangchon;
        public fThemBill(int MonAnID, int idBanDangchon)
        {
            InitializeComponent();
            this.MonAnID = MonAnID;
            this.idBanDangchon = idBanDangchon;
        }
        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        public string ThongTinTenMon()
        {
            string sql = "SELECT * FROM MonAn WHERE id = @MonAnID";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MonAnID", MonAnID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return (string)reader["TenMonAn"];
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }
        public double ThongTinGia()
        {
            string sql = "SELECT * FROM MonAn WHERE id = @MonAnID";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MonAnID", MonAnID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return (double)reader["Gia"];
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        private void fThemBill_Load(object sender, EventArgs e)
        {
            txtTenMonThemBill.Text = ThongTinTenMon();
            txtGiaThemBill.Text = ThongTinGia().ToString();
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
                        command.Parameters.AddWithValue("@idBan", idBanDangchon);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra hóa đơn: " + ex.Message);
                return false;
            }
        }


        public bool KiemTraThongTinBill()
        {
            string sql = "SELECT COUNT(*) FROM ThongTinHoaDon WHERE idHoaDon = @idHoaDon AND idMonAn = @idMonAn";
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@idHoaDon", idHoaDonCoSan(idBanDangchon));
                        command.Parameters.AddWithValue("@idMonAn", MonAnID);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần thiết, ví dụ: ghi log, thông báo lỗi, vv.
                Console.WriteLine("Lỗi khi kiểm tra thông tin hóa đơn: " + ex.Message);
                return false;
            }
        }


        public int IDHoaDonMax()
        {
            string sql = $"SELECT MAX(id) FROM HoaDon";
            int maxId = 0;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                    }
                }
            }
            return maxId;
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

        private void btnHoanThanhThemBill_Click(object sender, EventArgs e)
        {
            try
            {
                if(KiemTraBill()==false)
                {
                    string sql = "INSERT INTO HoaDon (idBanAn, ThoiGian, TrangThai) VALUES (@idBan, GETDATE(), 0)";
                    string sql1 = "INSERT INTO ThongTinHoaDon (idHoaDon, idMonAn, SoLuong) VALUES (@idHoaDon, @idMonAn, @soluong)";
                    using ( SqlConnection connection = new SqlConnection(conn))
                    { 
                        connection.Open();
                        using( SqlCommand command = new SqlCommand(sql,connection) )
                        {
                            command.Parameters.AddWithValue("@idBan", idBanDangchon);
                            command.ExecuteNonQuery();
                        }
                    }

                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql1, connection))
                        {
                            command.Parameters.AddWithValue("@idHoaDon", IDHoaDonMax());
                            command.Parameters.AddWithValue("@idMonAn", MonAnID);
                            command.Parameters.AddWithValue("@soluong", nbSoLuong.Value);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else if( KiemTraBill() ==true && KiemTraThongTinBill() == false)
                {
                    string sql = "INSERT INTO ThongTinHoaDon (idHoaDon, idMonAn, SoLuong) VALUES (@idHoaDon, @idMonAn, @soluong)";
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@idHoaDon", idHoaDonCoSan(idBanDangchon));
                            command.Parameters.AddWithValue("@idMonAn", MonAnID);
                            command.Parameters.AddWithValue("@soluong", nbSoLuong.Value);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else if( KiemTraBill() ==true && KiemTraThongTinBill()==true)
                {
                    string sql = "UPDATE ThongTinHoaDon SET SoLuong = SoLuong + @SoLuongMoi WHERE idHoaDon = @idHoaDon AND idMonAn = @idMonAn";
                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@idHoaDon", idHoaDonCoSan(idBanDangchon));
                            command.Parameters.AddWithValue("@idMonAn", MonAnID);
                            command.Parameters.AddWithValue("@SoLuongMoi", nbSoLuong.Value);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng chọn bàn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.Hide();
            }
        }
    }
}
