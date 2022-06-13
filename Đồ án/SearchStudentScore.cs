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
    public partial class SearchStudentScore : Form
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
        public SearchStudentScore()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void SearchStudentScore_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select TenMonHoc, DiemMieng, Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2, DiemCuoiKy," +
                " (DiemMieng + Diem15pLan1 + Diem15pLan2 + Diem45pLan1 * 2 + Diem45pLan2 * 2 + DiemCuoiKy * 3) / 10 as DiemTrungBinh " +
                "from MonHoc, Diem where Diem.MaMonHoc = MonHoc.MaMonHoc and MaHocSinh = '" + txtMaHocSinh.Text + "' and HocKy = '" + cboHocKi.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'";
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
