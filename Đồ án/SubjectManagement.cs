using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Đồ_án
{
    public partial class SubjectManagement : Form
    {
        SqlConnection connect = new SqlConnection();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nHeightEllipse,
          int nWidthEllipse
          );
        public SubjectManagement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void SubjectManagement_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "Select * From MonHoc";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                txtMaMonHoc.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTenMonHoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                cbxKhoiLop.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtMaMonHoc.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa môn học-> xóa bảng điểm, PHÂN CÔNG VIỆC của môn học đó
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect.Open();
                string delete = "Delete from PhanCongViec WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
                string delete1 = "Delete from Diem WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
                string delete2 = "Delete from MonHoc WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand(delete1, connect);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(delete2, connect);
                cmd2.ExecuteNonQuery();
                txtMaMonHoc.Enabled = true;
                txtMaMonHoc.Text = txtTenMonHoc.Text = cbxKhoiLop.Text = "";
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From MonHoc";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Trả tài nguyên
                cmd.Dispose();
                cmd1.Dispose();
                cmd2.Dispose();
                connect.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem thông tin đã điền đủ hay chưa
            if (txtMaMonHoc.Text == "" || txtTenMonHoc.Text == "" || cbxKhoiLop.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng Mã môn-> nếu có ko dc thêm
                connect.Open();
                String sql = "SELECT * FROM MonHoc WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Mã môn học " + txtMaMonHoc.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMonHoc.Text = txtTenMonHoc.Text = cbxKhoiLop.Text = "";
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    //Thêm môn học
                    cmd.Dispose();
                    dr.Dispose();
                    String insert = "Insert into MonHoc(MaMonHoc, TenMonHoc, KhoiLop) values('" + txtMaMonHoc.Text + "', N'" + txtTenMonHoc.Text + "', '" + cbxKhoiLop.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(insert, connect);
                    cmd1.ExecuteNonQuery();
                    txtMaMonHoc.Text = txtTenMonHoc.Text = cbxKhoiLop.Text = "";
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                    cmd1.Dispose();                  
                    string sql2 = "Select * From MonHoc";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];


                }
                connect.Close();
            }
        }

        private void btnBochon_Click(object sender, EventArgs e)
        {
            txtMaMonHoc.Enabled = true;
            txtMaMonHoc.Text = txtTenMonHoc.Text = cbxKhoiLop.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connect.Open();
            string update = "Update MonHoc set TenMonHoc=N'" + txtTenMonHoc.Text + "',KhoiLop='" + cbxKhoiLop.Text + "' WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
            SqlCommand cmd = new SqlCommand(update, connect);
            cmd.ExecuteNonQuery();
            txtMaMonHoc.Enabled = true;
            txtMaMonHoc.Text = txtTenMonHoc.Text = cbxKhoiLop.Text = "";
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //update datagridView
            string sql2 = "Select * From MonHoc";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
            // Trả tài nguyên
            cmd.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                txtMaMonHoc.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTenMonHoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                cbxKhoiLop.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtMaMonHoc.Enabled = false;
            }
        }
    }
}
