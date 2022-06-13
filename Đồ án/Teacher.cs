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
    public partial class Teacher : Form
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
        public Teacher()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "Select * From GiaoVien";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                txtMaGV.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTenGV.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                cbxGioiTinh.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtDC.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                txtSDT.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                txtMaGV.Enabled = false;
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = txtTenGV.Text = cbxGioiTinh.Text = txtDC.Text = txtSDT.Text = "";
            txtMaGV.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra đã điền mã giáo viên chưa

            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng Mã Giáo viên-> trùng thì ko thêm đc
                connect.Open();
                String sql = "SELECT * FROM GiaoVien WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Mã giáo viên " + txtMaGV.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaGV.Text = txtTenGV.Text = cbxGioiTinh.Text = txtDC.Text = txtSDT.Text = "";
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    //Thêm giáo viên
                    cmd.Dispose();
                    dr.Dispose();
                    String insert = "insert into GiaoVien(MaGiaoVien,TenGiaoVien, GioiTinh, DiaChi, SDT) values('" +
                    txtMaGV.Text + "', N'" + txtTenGV.Text + "','" + cbxGioiTinh.Text + "',N'" + txtDC.Text + "','" + txtSDT.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(insert, connect);
                    cmd1.ExecuteNonQuery();
                    txtMaGV.Text = txtTenGV.Text = cbxGioiTinh.Text = txtDC.Text = txtSDT.Text = "";
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                    cmd1.Dispose();
                    //update datagridView
                    string sql2 = "Select * From GiaoVien";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];


                }
                connect.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connect.Open();
            string update = "Update GiaoVien set TenGiaoVien=N'" + txtTenGV.Text + "',GioiTinh=N'" + cbxGioiTinh.Text + "', DiaChi=N'"
                + txtDC.Text + "',SDT='" + txtSDT.Text + "' WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
            SqlCommand cmd = new SqlCommand(update, connect);
            cmd.ExecuteNonQuery();
            txtMaGV.Text = txtTenGV.Text = cbxGioiTinh.Text = txtDC.Text = txtSDT.Text = "";
            txtMaGV.Enabled = true;
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //update datagridView
            string sql2 = "Select * From GiaoVien";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
            // Trả tài nguyên
            cmd.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect.Open();
                String sql2 = "SELECT * FROM LopHoc WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, connect);
                SqlDataReader dr;
                dr = cmd2.ExecuteReader();
                //Kiểm tra giáo viên có đang chủ nhiệm ko-> nếu có thì ko thể xóa
                if (dr.Read())
                {
                    dr.Dispose();
                    cmd2.Dispose();
                    MessageBox.Show("Giáo viên đang chủ nhiệm, không thể xóa!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Xóa Phân công cong việc có giáo viên bị xóa
                    dr.Dispose();
                    cmd2.Dispose();
                    string delete1 = "Delete from PhanCongViec WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(delete1, connect);
                    cmd1.ExecuteNonQuery();
                    string delete = "Delete from GiaoVien WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
                    SqlCommand cmd = new SqlCommand(delete, connect);
                    cmd.ExecuteNonQuery();
                    txtMaGV.Text = txtTenGV.Text = cbxGioiTinh.Text = txtDC.Text = txtSDT.Text = "";
                    txtMaGV.Enabled = true;
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                    //update datagridView
                    string sql3 = "Select * From GiaoVien";
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql3, connect);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    // Trả tài nguyên
                    cmd.Dispose();
                    cmd1.Dispose();
                }
                connect.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
