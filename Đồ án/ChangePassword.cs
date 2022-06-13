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
    public partial class ChangePassword : Form
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
        public ChangePassword()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Điền thiếu thông tin
            if (txtTenDangNhap.Text == "" || txtMatkhau.Text == "" || txtMatKhauMoi.Text == "" || txtReMatKhau.Text == "")
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
                connect.Open();
                string sql1 = "Select * From NguoiDung where TenDangNhap='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatkhau.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, connect);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    //Mật khẩu nhập lại không đúng
                    if (txtMatKhauMoi.Text != txtReMatKhau.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        //Hợp lệ
                        cmd1.Dispose();
                        reader1.Dispose();
                        String sql2 = "Update NguoiDung Set MatKhau='" + txtMatKhauMoi.Text + "' where TenDangNhap='" + txtTenDangNhap.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, connect);
                        cmd2.ExecuteNonQuery();
                        this.Hide();                       
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd2.Dispose();
                    }

                }
                else
                {
                    //Mật khẩu cũ sai 
                    MessageBox.Show("Tên đăng nhập hoặc mật cũ chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                connect.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
