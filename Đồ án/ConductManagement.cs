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
    public partial class ConductManagement : Form
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
        public ConductManagement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void ConductManagement_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "select HocSinh.MaHocSinh, TenHocSinh, HanhKiem from HocSinh, HanhKiem where HanhKiem.MaHocSinh = HocSinh.MaHocSinh";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select HocSinh.MaHocSinh, TenHocSinh, HanhKiem from HocSinh, HanhKiem " +
                        "where HanhKiem.MaHocSinh = HocSinh.MaHocSinh " +
                        " and HocSinh.MaLop = '" + txtMaLop.Text +
                        "' and HocKy = '" + cbxHocKy.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnBoTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            txtMaLop.Text = cbxHocKy.Text = cbxNamHoc.Text = "";
            string sql = "select HocSinh.MaHocSinh, TenHocSinh, HanhKiem from HocSinh, HanhKiem" +
                " where HanhKiem.MaHocSinh = HocSinh.MaHocSinh";
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
                txtMaHocSinh.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTenHocSinh.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                cbxHanhKiem.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                groupBox1.Enabled = false;
                txtMaHocSinh.Enabled = false;
                txtTenHocSinh.Enabled = false;

            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtMaHocSinh.Enabled = true;
            txtTenHocSinh.Enabled = true;
            txtMaHocSinh.Text = txtTenHocSinh.Text = cbxHanhKiem.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connect.Open();

            string update = "update HanhKiem set HanhKiem = '" + cbxHanhKiem.Text +
                "' where MaHocSinh = '" + txtMaHocSinh.Text + "' and HocKy = '" + cbxHocKy.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'";
            SqlCommand cmd = new SqlCommand(update, connect);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //update datagridView
            string sql2 = " select HocSinh.MaHocSinh, TenHocSinh, HanhKiem from HocSinh, HanhKiem" +
                    " where HanhKiem.MaHocSinh = HocSinh.MaHocSinh " +
                    " and HocSinh.MaLop = '" + txtMaLop.Text +
                    "' and HocKy = '" + cbxHocKy.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            groupBox1.Enabled = true;
            txtMaHocSinh.Enabled = true;
            txtTenHocSinh.Enabled = true;
            txtMaHocSinh.Text = txtTenHocSinh.Text = cbxHanhKiem.Text = "";
            // Trả tài nguyên
            cmd.Dispose();
            connect.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect.Open();
                string delete = "delete from HanhKiem " +
                    "where MaHocSinh='" + txtMaHocSinh.Text + "' and HocKy='" + cbxHocKy.Text + "'and NamHoc='" + cbxNamHoc.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                groupBox1.Enabled = true;
                txtMaHocSinh.Enabled = true;
                txtTenHocSinh.Enabled = true;
                txtMaHocSinh.Text = txtTenHocSinh.Text = cbxHanhKiem.Text = "";
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "select HocSinh.MaHocSinh, TenHocSinh, HanhKiem from HocSinh, HanhKiem " +
                        "where HanhKiem.MaHocSinh = HocSinh.MaHocSinh " +
                        " and HocSinh.MaLop = '" + txtMaLop.Text +
                        "' and HocKy = '" + cbxHocKy.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'"; ;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // Trả tài nguyên
                cmd.Dispose();
                connect.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra điền đủ khóa chính chưa
            if (txtMaHocSinh.Text == "" || txtTenHocSinh.Text == "" || cbxHocKy.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng Khóa->nếu trùng thì ko thêm đc
                connect.Open();
                String sql = "select * from HanhKiem " +
                    "where  MaHocSinh='" + txtMaHocSinh.Text + "' and HocKy='" + cbxHocKy.Text +
                    "' and NamHoc='" + cbxNamHoc.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Hạnh kiểm đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    cmd.Dispose();
                    dr.Dispose();
                    //KIểm tra Mã học sinh đã tồn tại chưa->nếu chưa->ko thêm đc
                    string sql11 = "SELECT * FROM HocSinh WHERE MaHocSinh = '" + txtMaHocSinh.Text + "'";
                    SqlCommand cmd11 = new SqlCommand(sql11, connect);
                    SqlDataReader dr11;
                    dr11 = cmd11.ExecuteReader();
                    if (dr11.Read())
                    {
                        cmd11.Dispose();
                        dr11.Dispose();

                        string insert = "insert into HanhKiem values('" + txtMaHocSinh.Text +
                            "','" + cbxHocKy.Text + "','" + cbxNamHoc.Text + "','" + cbxHanhKiem.Text + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, connect);
                        cmd1.ExecuteNonQuery();
                        txtMaHocSinh.Text = txtTenHocSinh.Text = cbxHanhKiem.Text = "";
                        MessageBox.Show("Thêm mới thành công", "Thông báo!");
                        cmd1.Dispose();
                        //update datagridView
                        string sql2 = "select HocSinh.MaHocSinh, TenHocSinh, HanhKiem from HocSinh, HanhKiem " +
                    "where HanhKiem.MaHocSinh = HocSinh.MaHocSinh " +
                    " and HocSinh.MaLop = '" + txtMaLop.Text +
                    "' and HocKy = '" + cbxHocKy.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'";
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];



                    }
                    else
                    {
                        cmd11.Dispose();
                        dr11.Dispose();

                        MessageBox.Show("Mã học sinh " + txtMaHocSinh.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                connect.Close();
            }
        }
    }
}
