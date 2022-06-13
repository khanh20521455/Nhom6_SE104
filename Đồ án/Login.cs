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
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nHeightEllipse,
            int nWidthEllipse
            );
        public static string username;
        SqlConnection connect = new SqlConnection();
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

       

        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            //
            if (txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                username = txtUsername.Text.ToString();
                connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
                connect.Open();
                string sql1 = "Select * From NguoiDung where TenDangNhap='" + txtUsername.Text + "' and MatKhau='" + txtPass.Text + "' and Quyen='Admin'";
                SqlCommand cmd1 = new SqlCommand(sql1, connect);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                    Main frm = new Main();
                    frm.Show();
                    this.Hide();
                    frm.DangNhapToolStripMenuItem.Enabled = false;
                    frm.DiemCNToolStripMenuItem.Enabled = false;
                    frm.CVGVToolStripMenuItem.Enabled = false;
                    txtUsername.Text = "";
                    txtPass.Text = "";
                    reader1.Close();
                    reader1.Dispose();
                    cmd1.Dispose();
                }
                else
                {
                    reader1.Close();
                    reader1.Dispose();
                    cmd1.Dispose();
                    string sql2 = "Select * From NguoiDung where TenDangNhap='" + txtUsername.Text + "' and MatKhau='" + txtPass.Text + "' and Quyen='GiaoVien'";
                    SqlCommand cmd2 = new SqlCommand(sql2, connect);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                        Main frm = new Main();
                        frm.Show();
                        this.Hide();
                        txtUsername.Text = "";
                        txtPass.Text = "";
                        frm.DangNhapToolStripMenuItem.Enabled = false;
                        frm.QLNguoiDungToolStripMenuItem.Enabled = false;
                        frm.LopHocToolStripMenuItem.Enabled = false;
                        frm.MonHocToolStripMenuItem.Enabled = false;
                        frm.HocSinhToolStripMenuItem.Enabled = false;
                        frm.GiaoVienToolStripMenuItem.Enabled = false;
                        frm.PCGVToolStripMenuItem.Enabled = false;
                        frm.DiemCNToolStripMenuItem.Enabled = false;
                        reader2.Close();
                        reader2.Dispose();
                        cmd2.Dispose();
                    }
                    else
                    {
                        reader2.Close();
                        reader2.Dispose();
                        cmd2.Dispose();
                        string sql3 = "Select * From NguoiDung where TenDangNhap='" + txtUsername.Text + "' and MatKhau='" + txtPass.Text + "' and Quyen ='HocSinh'";
                        SqlCommand cmd3 = new SqlCommand(sql3, connect);
                        SqlDataReader reader3 = cmd3.ExecuteReader();
                        if (reader3.Read())
                        {
                            MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                            Main frm = new Main();
                            frm.Show();
                            this.Hide();
                            txtUsername.Text = "";
                            txtPass.Text = "";
                            frm.DangNhapToolStripMenuItem.Enabled = false;
                            frm.QLNguoiDungToolStripMenuItem.Enabled = false;
                            frm.QuanLyToolStripMenuItem.Enabled = false;
                            frm.ThongKeToolStripMenuItem.Enabled = false;
                            frm.TTDiemHSToolStripMenuItem.Enabled = false;
                            frm.CVGVToolStripMenuItem.Enabled = false;
                            reader3.Close();
                            reader3.Dispose();
                            cmd3.Dispose();
                        }
                        else
                        {
                            reader3.Close();
                            reader3.Dispose();
                            cmd3.Dispose();
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị sai !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Text = "";
                            txtPass.Text = "";

                        }
                    }
                }

            }

            connect.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
            
}
