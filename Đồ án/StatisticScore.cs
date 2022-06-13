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
    public partial class StatisticScore : Form
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
        public StatisticScore()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void StatisticScore_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "SELECT TOP 5 WITH TIES Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2,DiemCuoiKy," +
                "  (DiemMieng + Diem15pLan1 + Diem15pLan2 + Diem45pLan1 * 2 + Diem45pLan2 * 2 + DiemCuoiKy * 3) / 10 as DTB " +
                "FROM Diem, HocSinh, LopHoc WHERE Diem.MaHocSinh = HocSinh.MaHocSinh and HocSinh.MaLop=LopHoc.MaLop" +
                " AND MaMonHoc = '" + txtMaMonHoc.Text + "' and HocSinh.MaLop = '" + txtMaLop.Text + "' and HocKy = '" + cboHocKi.Text
                + "' and NamHoc = '" + cbxNamHoc.Text + "'  ORDER BY DTB DESC";
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
