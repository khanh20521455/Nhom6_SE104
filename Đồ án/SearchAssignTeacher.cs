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
    public partial class SearchAssignTeacher : Form
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
        public SearchAssignTeacher()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

        }

        private void SearchAssignTeacher_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select MaMonHoc, MaLop, SoTiet, NgayGio " +
                "from PhanCongViec where " +
                "MaGiaoVien='" + Login.username + "' and HocKy='" + cboHocKi.Text + "' and NamHoc='" + cbxNamHoc.Text + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
