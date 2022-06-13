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
    public partial class ClassManagement : Form
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
        public ClassManagement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "Select * From LopHoc";
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
                txtMaLop.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTenLop.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                txtMaGV.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtSS.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                txtMaLop.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã lớp đã điền chưa

            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng Mã Lớp->không thêm đc
                connect.Open();
                String sql = "SELECT * FROM LopHoc WHERE MaLop = '" + txtMaLop.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Mã lớp học " + txtMaLop.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLop.Text = txtTenLop.Text = txtMaGV.Text = txtSS.Text = "";
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    cmd.Dispose();
                    dr.Dispose();
                    //Kiểm tra tồn tại mã giáo viên->nếu chưa tồn tại không thêm đc
                    string sql11 = "SELECT * FROM GiaoVien WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
                    SqlCommand cmd11 = new SqlCommand(sql11, connect);
                    SqlDataReader dr11;
                    dr11 = cmd11.ExecuteReader();
                    if (dr11.Read())
                    {
                        cmd11.Dispose();
                        dr11.Dispose();
                        //Thêm lớp hợp lệ
                        string insert = "insert into LopHoc(MaLop,TenLop, MaGiaoVien, SiSo) values('" +
                        txtMaLop.Text + "','" + txtTenLop.Text + "','" + txtMaGV.Text + "','" + txtSS.Text + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, connect);
                        cmd1.ExecuteNonQuery();
                        txtMaLop.Text = txtTenLop.Text = txtMaGV.Text = txtSS.Text = "";
                        MessageBox.Show("Thêm mới thành công", "Thông báo!");
                        cmd1.Dispose();
                        //update datagridView
                        string sql2 = "Select * From LopHoc";
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        //Mã giáo viên chưa tồn tại
                        cmd11.Dispose();
                        dr11.Dispose();

                        MessageBox.Show("Mã Giáo viên " + txtMaGV.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                connect.Close();
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {

            txtMaLop.Text = txtTenLop.Text = txtMaGV.Text = txtSS.Text = "";
            txtMaLop.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql11 = "SELECT * FROM GiaoVien WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
            SqlCommand cmd11 = new SqlCommand(sql11, connect);
            SqlDataReader dr11;
            dr11 = cmd11.ExecuteReader();
            if (dr11.Read())
            {
                //Thêm hợp lệ
                cmd11.Dispose();
                dr11.Dispose();
                string update = "Update LopHoc set TenLop=N'" + txtTenLop.Text + "',MaGiaoVien='" + txtMaGV.Text + "', SiSo='"
                    + txtSS.Text + "' WHERE MaLop = '" + txtMaLop.Text + "'";
                SqlCommand cmd = new SqlCommand(update, connect);
                cmd.ExecuteNonQuery();
                txtMaLop.Text = txtTenLop.Text = txtMaGV.Text = txtSS.Text = "";
                txtMaLop.Enabled = true;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From LopHoc";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Trả tài nguyên
                cmd.Dispose();
            }
            else
            {
                //Mã giáo viên chưa tồn tại
                cmd11.Dispose();
                dr11.Dispose();

                MessageBox.Show("Mã Giáo viên " + txtMaGV.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Xóa lớp->xóa Học sinh, bảng điểm, hạnh kiểm, phân công việc của lớp đó
                connect.Open();
                string delete1 = "delete from HanhKiem where MaHocSinh in(select MaHocSinh from HocSinh,LopHoc " +
                                "where HocSinh.MaLop = LopHoc.MaLop and LopHoc.MaLop = '" + txtMaLop.Text + "')";
                string delete2 = "delete from Diem where MaHocSinh in(select MaHocSinh from HocSinh,LopHoc " +
                                "where HocSinh.MaLop = LopHoc.MaLop and LopHoc.MaLop = '" + txtMaLop.Text + "')";
                string delete3 = "delete from HocSinh where MaLop = '" + txtMaLop.Text + "'";
                string delete4 = "delete from PhanCongViec where MaLop = '" + txtMaLop.Text + "'";
                string delete5 = "Delete from LopHoc WHERE MaLop = '" + txtMaLop.Text + "'";
                SqlCommand cmd1 = new SqlCommand(delete1, connect);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(delete2, connect);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(delete3, connect);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand(delete4, connect);
                cmd4.ExecuteNonQuery();
                SqlCommand cmd5 = new SqlCommand(delete5, connect);
                cmd5.ExecuteNonQuery();
                txtMaLop.Text = txtTenLop.Text = txtMaGV.Text = txtSS.Text = "";
                txtMaLop.Enabled = true;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From LopHoc";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // Trả tài nguyên
                cmd1.Dispose();
                cmd2.Dispose();
                cmd3.Dispose();
                cmd4.Dispose();
                cmd5.Dispose();
                connect.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
