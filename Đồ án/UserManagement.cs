using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Đồ_án
{
    public partial class UserManagement : Form
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
        public UserManagement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
        
        private void UserManagement_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "Select * From NguoiDung";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            txtTenDN.Enabled = true;
            txtTenDN.Text = txtMatKhau.Text = txtHoTen.Text = txtEmail.Text = comboxGT.Text = comboxQuyen.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "Select * From NguoiDung where TenDangNhap = '" + textDNTK.Text + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void txtBoTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            textDNTK.Text = "";
            string sql = "Select * From NguoiDung ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng username
                string TenDn = txtTenDN.Text;
                connect.Open();
                String sql = "SELECT * FROM NguoiDung WHERE TenDangNhap = '" + TenDn + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tài khoản " + txtTenDN.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDN.Text = txtMatKhau.Text = txtHoTen.Text = txtEmail.Text = comboxGT.Text = comboxQuyen.Text = "";
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    //Thêm người dùng
                    cmd.Dispose();
                    dr.Dispose();
                    String insert = "INSERT INTO NguoiDung(TenDangNhap,MatKhau,HoTen,Email,GioiTinh,Quyen) values ('" + txtTenDN.Text +
                        "','" + txtMatKhau.Text + "',N'" + txtHoTen.Text + "','" + txtEmail.Text + "',N'" + comboxGT.Text + "',N'" + comboxQuyen.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(insert, connect);
                    cmd1.ExecuteNonQuery();
                    txtTenDN.Text = txtMatKhau.Text = txtHoTen.Text = txtEmail.Text = comboxGT.Text = comboxQuyen.Text = "";
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                    cmd1.Dispose();
                    //update datagridView
                    string sql2 = "Select * From NguoiDung";
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
            string update = "Update NguoiDung Set MatKhau='" + txtMatKhau.Text + "',HoTen=N'" + txtHoTen.Text + "',Email='" +
                            txtEmail.Text + "',GioiTinh=N'" + comboxGT.Text + "',Quyen=N'" + comboxQuyen.Text + "' WHERE TenDangNhap = '" + txtTenDN.Text + "'";
            SqlCommand cmd = new SqlCommand(update, connect);
            cmd.ExecuteNonQuery();
            txtTenDN.Enabled = true;
            txtTenDN.Text = txtMatKhau.Text = txtHoTen.Text = txtEmail.Text = comboxGT.Text = comboxQuyen.Text = "";
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //update datagridView
            string sql2 = "Select * From NguoiDung";
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
                string delete = "Delete from NguoiDung WHERE TenDangNhap = '" + txtTenDN.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                txtTenDN.Enabled = true;
                textDNTK.Text = "";
                txtTenDN.Text = txtMatKhau.Text = txtHoTen.Text = txtEmail.Text = comboxGT.Text = comboxQuyen.Text = "";
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From NguoiDung";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // Trả tài nguyên
                cmd.Dispose();
                connect.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                txtTenDN.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtMatKhau.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                txtHoTen.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                comboxGT.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                comboxQuyen.Text = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                txtTenDN.Enabled = false;

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
