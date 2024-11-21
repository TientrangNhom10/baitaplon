using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using static QuanLyQuanCafe.fQuanLyBan;

namespace QuanLyQuanCafe
{
    public partial class fDanhMuc : Form
    {
        public class DanhMucinfo
        {
            public string TenDm { get; set; }
            public int Id { get; set; }

            public DanhMucinfo(string TenDm, int Id)
            {
                this.TenDm = TenDm;
                this.Id = Id;
            }
        }

        public fDanhMuc()
        {
            InitializeComponent();
        }
        string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";

        void loadDanhMuc()
        {
            flpDanhMuc.Controls.Clear();
            string query = "SELECT * FROM DanhMuc";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string tenDM = (string)reader["TenDanhMuc"];
                    int id = (int)reader["id"];

                    Label lb = new Label();
                    lb.Text = tenDM;
                    lb.BorderStyle = BorderStyle.FixedSingle;

                    lb.Size = new Size(701, 40);
                    lb.Font = new Font(lb.Font.FontFamily, 12, lb.Font.Style);
                    //lb.Click += Lb_Click;
                    lb.Click += Lb_Click;
                    lb.Tag = new DanhMucinfo(tenDM, id);
                    lb.Margin = new Padding(5);
                    flpDanhMuc.Controls.Add(lb);
                }
                reader.Close();
                command.Dispose();
            }
        }

        private void Lb_Click(object? sender, EventArgs e)
        {
            Label cl = sender as Label;
            if (cl != null && cl.Tag is DanhMucinfo)
            {
                DanhMucinfo info = (DanhMucinfo)cl.Tag;
                txtDanhMucDC.Text = info.TenDm;
                txtIDDM.Text = info.Id.ToString();
            }
        }

        private void fDanhMuc_Load(object sender, EventArgs e)
        {
            loadDanhMuc();
            grThaotac.Visible = false;
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            if (txtDanhMucDC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grThaotac.Text = "Sửa bàn";
                grThaotac.Visible = true;
                btnHoanTatthemDM.Visible = true;
                btnThemDMHT.Visible = false;
                string query = "SELECT * FROM DanhMuc WHERE id = @id";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", txtIDDM.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tendm = (string)reader["TenDanhMuc"];
                        txtTenDM.Text = tendm;
                    }
                    reader.Close();
                    command.Dispose();

                }

            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    string sql = "DELETE FROM DanhMuc Where id = @id";

                    using (SqlConnection connection = new SqlConnection(conn))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", txtIDDM.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                    loadDanhMuc();
                }
            }
            catch 
            {
                MessageBox.Show("Bạn cần xóa hết những món ăn có trong danh mục trước!!");
            }
            
        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            grThaotac.Text = "Thêm danh mục";
            grThaotac.Visible = true;
            btnThemDMHT.Visible = true;
            btnHoanTatthemDM.Visible = false;
            txtTenDM.Clear();
        }

        private void btnHoanTatthemDM_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc = @tdm WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tdm", txtTenDM.Text);
                    command.Parameters.AddWithValue("@id", txtIDDM.Text);
                    command.ExecuteNonQuery();
                }
            }
            grThaotac.Visible = false;
            loadDanhMuc();
        }

        private void btnThemDMHT_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO DanhMuc (TenDanhMuc) VALUES (@tdm)";

            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@tdm", txtTenDM.Text);
                    insertCommand.ExecuteNonQuery();
                }
            }
            grThaotac.Visible = false;
            loadDanhMuc();
        }

        private void txtDanhMucDC_TextChanged(object sender, EventArgs e)
        {
            if (btnThemDMHT.Visible == false && btnHoanTatthemDM.Visible == true)
            {
                grThaotac.Visible = true;
                string query = "SELECT * FROM DanhMuc WHERE TenDanhMuc = @tdm";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tdm", txtDanhMucDC.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtTenDM.Text = (string)reader["TenDanhMuc"];
                    }
                    reader.Close();
                    command.Dispose();
                }
            }
        }
    }
}
