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
    public partial class StudenManagement : Form
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
        public StudenManagement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void StudenManagement_Load(object sender, EventArgs e)
        {

            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "Select * From HocSinh";
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
                txtMaLop.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                cbxGioiTinh.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                txtNgaySinh.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                cbxUT.Text = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                txtDanToc.Text = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                txtTenCha.Text = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                txtTenMe.Text = dataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                txtMaHocSinh.Enabled = false;

            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            txtMaHocSinh.Text = txtTenHocSinh.Text = txtMaLop.Text = cbxGioiTinh.Text = txtNgaySinh.Text =
           cbxUT.Text = txtDanToc.Text = txtTenCha.Text = txtTenMe.Text = "";
            txtMaHocSinh.Enabled = true;
        }

        private void btnBoTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            txtMLTK.Text = "";
            string sql = "Select * From HocSinh ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "Select * From HocSinh where MaLop = '" + txtMLTK.Text + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã học sinh đã điền chưa
            if (txtMaHocSinh.Text == "")
            {
                MessageBox.Show("Mã học sinh không được để trống", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng MaHocSinh->nếu trùng thì ko thêm đc
                connect.Open();
                String sql = "SELECT * FROM HocSinh WHERE MaHocSinh = '" + txtMaHocSinh.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Mã học sinh " + txtMaHocSinh.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHocSinh.Text = txtTenHocSinh.Text = txtMaLop.Text = cbxGioiTinh.Text = txtNgaySinh.Text =
                    cbxUT.Text = txtDanToc.Text = txtTenCha.Text = txtTenMe.Text = "";
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    cmd.Dispose();
                    dr.Dispose();
                    //KIểm tra Mã lớp đã tồn tại chưa->nếu chưa thì kho thêm đc
                    string sql11 = "SELECT * FROM LopHoc WHERE MaLop = '" + txtMaLop.Text + "'";
                    SqlCommand cmd11 = new SqlCommand(sql11, connect);
                    SqlDataReader dr11;
                    dr11 = cmd11.ExecuteReader();
                    if (dr11.Read())
                    {
                        cmd11.Dispose();
                        dr11.Dispose();
                        //Thêm học sinh
                        String insert = "insert into HocSinh(MaHocSinh, TenHocSinh, MaLop, GioiTinh, NgaySinh, DienUuTien, DanToc, HoTenCha, HoTenMe)" +
                        "values('" + txtMaHocSinh.Text + "', N'" + txtTenHocSinh.Text + "', '" + txtMaLop.Text + "', N'" + cbxGioiTinh.Text +
                        "', '" + txtNgaySinh.Text + "', N'" + cbxUT.Text + "', N'" + txtDanToc.Text + "', N'" + txtTenCha.Text + "', N'" + txtTenMe.Text + "')";
                        SqlCommand cmd1 = new SqlCommand(insert, connect);
                        cmd1.ExecuteNonQuery();
                        cbxUT.Text = txtDanToc.Text = txtTenCha.Text = txtTenMe.Text = "";
                        MessageBox.Show("Thêm mới thành công", "Thông báo!");
                        cmd1.Dispose();
                        //update datagridView
                        string sql2 = "Select * From HocSinh where MaLop = '" + txtMLTK.Text + "'";
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                    }
                    else
                    {
                        cmd11.Dispose();
                        dr11.Dispose();

                        MessageBox.Show("Mã lớp " + txtMaLop.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                connect.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra mã lớp đã tồn tại chưa->nếu chưa thì ko update đc
            connect.Open();
            string sql11 = "SELECT * FROM LopHoc WHERE MaLop = '" + txtMaLop.Text + "'";
            SqlCommand cmd11 = new SqlCommand(sql11, connect);
            SqlDataReader dr11;
            dr11 = cmd11.ExecuteReader();
            if (dr11.Read())
            {
                cmd11.Dispose();
                dr11.Dispose();
                string update = "Update HocSinh set TenHocSinh=N'" + txtTenHocSinh.Text + "',MaLop='" + txtMaLop.Text + "', GioiTinh=N'"
                    + cbxGioiTinh.Text + "',NgaySinh='" + txtNgaySinh.Text + "',DienUuTien=N'" + cbxUT.Text + "',DanToc=N'" + txtDanToc.Text + "',HoTenCha=N'"
                    + txtTenCha.Text + "', HoTenMe=N'" + txtTenMe.Text + "' WHERE MaHocSinh = '" + txtMaHocSinh.Text + "'";
                SqlCommand cmd = new SqlCommand(update, connect);
                cmd.ExecuteNonQuery();
                txtMaHocSinh.Text = txtTenHocSinh.Text = txtMaLop.Text = cbxGioiTinh.Text = txtNgaySinh.Text =
                cbxUT.Text = txtDanToc.Text = txtTenCha.Text = txtTenMe.Text = "";
                txtMaHocSinh.Enabled = true;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From HocSinh where MaLop = '" + txtMLTK.Text + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                // Trả tài nguyên
                cmd.Dispose();
            }
            else
            {
                cmd11.Dispose();
                dr11.Dispose();

                MessageBox.Show("Mã Lớp " + txtMaLop.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa hạnh kiểm, điểm của học sinh đó
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect.Open();
                string delete1 = "delete from HanhKiem where MaHocSinh = '" + txtMaHocSinh.Text + "'";
                string delete2 = "delete from Diem where MaHocSinh = '" + txtMaHocSinh.Text + "'";
                string delete3 = "Delete from HocSinh WHERE MaHocSinh = '" + txtMaHocSinh.Text + "'";
                SqlCommand cmd1 = new SqlCommand(delete1, connect);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(delete2, connect);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(delete3, connect);
                cmd3.ExecuteNonQuery();
                txtMaHocSinh.Text = txtTenHocSinh.Text = txtMaLop.Text = cbxGioiTinh.Text = txtNgaySinh.Text =
                cbxUT.Text = txtDanToc.Text = txtTenCha.Text = txtTenMe.Text = "";
                txtMaHocSinh.Enabled = true;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From HocSinh where MaLop = '" + txtMLTK.Text + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // Trả tài nguyên
                cmd1.Dispose();
                cmd2.Dispose();
                cmd2.Dispose();
                connect.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
