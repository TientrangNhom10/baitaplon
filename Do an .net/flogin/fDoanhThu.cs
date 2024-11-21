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
    public partial class fDoanhThu : Form
    {
        private string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        public fDoanhThu()
        {
            InitializeComponent();
        }

        private void fDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnThoatThongKe_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateBatDau.Value;
            DateTime date2 = dateKetThuc.Value;
            if (date1.Date > date2.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = @"SELECT MonAn.TenMonAn, MonAn.Gia, SUM(ThongTinHoaDon.SoLuong) AS TongSoLuong
            FROM  HoaDon HD 
            JOIN ThongTinHoaDon ON HD.id = ThongTinHoaDon.idHoaDon 
            JOIN MonAn ON ThongTinHoaDon.idMonAn = MonAn.id 
            WHERE HD.ThoiGian >= @NgayBatDau AND HD.ThoiGian <= @NgayKetThuc AND HD.TrangThai = 1
            GROUP BY MonAn.TenMonAn, MonAn.Gia";

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@NgayBatDau", date1);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", date2);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataDoanhThu.DataSource = tb;
                        txtTongTien.Text =  tongtien(tb).ToString();
                    }
                }
            }

            dataDoanhThu.Columns["TenMonAn"].Width = 300;
            dataDoanhThu.Columns["TongSoLuong"].Width = 172;
            dataDoanhThu.Columns["Gia"].Width = 200;
            dataDoanhThu.Columns["TongTienTungMon"].Width = 200;
            dataDoanhThu.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dataDoanhThu.Columns["TongSoLuong"].HeaderText = "Số lượng";
            dataDoanhThu.Columns["Gia"].HeaderText = "Giá";
            dataDoanhThu.Columns["TongTienTungMon"].HeaderText = "Tổng tiền";




        }

        private float tongtien(DataTable dataDoanhThu)
        {
            float tongtien = 0;

            DataColumn tongtientheomon = new DataColumn("TongTienTungMon", typeof(float));
            dataDoanhThu.Columns.Add(tongtientheomon);

            for (int i = 0; i < dataDoanhThu.Rows.Count; i++)
            {
                float sl = float.Parse(dataDoanhThu.Rows[i]["TongSoLuong"].ToString());
                float gia = float.Parse(dataDoanhThu.Rows[i]["Gia"].ToString());
                float tt = sl * gia;

                dataDoanhThu.Rows[i]["TongTienTungMon"] = tt;

                tongtien += tt;
            }
            return tongtien;
        }

    }
}
