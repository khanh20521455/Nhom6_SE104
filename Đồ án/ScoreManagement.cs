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
    public partial class ScoreManagement : Form
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
        public ScoreManagement()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void ScoreManagement_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "select Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2, DiemCuoiKy " +
                "from Diem, HocSinh where Diem.MaHocSinh = HocSinh.MaHocSinh";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2, DiemCuoiKy " +
                "from Diem, HocSinh where Diem.MaHocSinh = HocSinh.MaHocSinh" +
                " and MaMonHoc = '" + txtMaMonHoc.Text + "'and HocKy = '" + cboHocKi.Text
                + "'and NamHoc = '" + cbxNamHoc.Text + "'and Diem.MaHocSinh in" +
                " (select MaHocSinh from HocSinh where MaLop = '" + txtMaLop.Text + "')";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnBoTimKiem_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = "select Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2,DiemCuoiKy" +
                " from Diem, HocSinh " +
                " where Diem.MaHocSinh = HocSinh.MaHocSinh";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
            txtMaLop.Text = txtMaMonHoc.Text = cbxNamHoc.Text = cboHocKi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã điền đủ thông tin khóa chính chưa
            if (txtMaHocSinh.Text == "" || txtMaMonHoc.Text == "" || txtMaLop.Text == "" || cbxNamHoc.Text == "" || cboHocKi.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng Khóa
                connect.Open();
                String sql = "select * from Diem " +
                    "where  MaMonHoc='" + txtMaMonHoc.Text + "' and MaHocSinh='" + txtMaHocSinh.Text + "' and HocKy='" + cboHocKi.Text +
                    "' and NamHoc='" + cbxNamHoc.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Điểm đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    cmd.Dispose();
                    dr.Dispose();
                    //KIểm tra Mã học sinh-> nếu chưa tồn tại->ko thêm đc
                    string sql11 = "SELECT * FROM HocSinh WHERE MaHocSinh = '" + txtMaHocSinh.Text + "'";
                    SqlCommand cmd11 = new SqlCommand(sql11, connect);
                    SqlDataReader dr11;
                    dr11 = cmd11.ExecuteReader();
                    if (dr11.Read())
                    {
                        cmd11.Dispose();
                        dr11.Dispose();
                        //Kiểm tra đã tồn tại mã Môn chưa->nếu chưa tồn tại->ko thêm đc
                        string sql22 = "SELECT * FROM MonHoc WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
                        SqlCommand cmd22 = new SqlCommand(sql22, connect);
                        SqlDataReader dr22;
                        dr22 = cmd22.ExecuteReader();
                        if (dr22.Read())
                        {
                            cmd22.Dispose();
                            dr22.Dispose();

                            //Thêm điểm
                            string insert = "insert into Diem values('" + txtMaHocSinh.Text + "','" + txtMaMonHoc.Text +
                                "','" + cboHocKi.Text + "','" + cbxNamHoc.Text + "','" + txtDiemMieng.Text
                                + "','" + txtDiem15p1.Text + "','" + txtDiem15p2.Text + "','" + txtDiem45p1.Text
                                + "','" + txtDiem45p2.Text + "','" + txtDiemCK.Text + "')";
                            SqlCommand cmd1 = new SqlCommand(insert, connect);
                            cmd1.ExecuteNonQuery();
                            txtMaHocSinh.Text = txtTenHS.Text = txtDiemMieng.Text = txtDiem15p1.Text = txtDiem15p2.Text
                            = txtDiem45p1.Text = txtDiem45p2.Text = txtDiemCK.Text = "";
                            groupBox1.Enabled = true;
                            txtMaHocSinh.Enabled = true;
                            txtTenHS.Enabled = true;
                            MessageBox.Show("Thêm mới thành công", "Thông báo!");
                            cmd1.Dispose();
                            //update datagridView
                            string sql2 = "select Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2, DiemCuoiKy " +
                            "from Diem, HocSinh where Diem.MaHocSinh = HocSinh.MaHocSinh" +
                            " and MaMonHoc = '" + txtMaMonHoc.Text + "'and HocKy = '" + cboHocKi.Text
                            + "'and NamHoc = '" + cbxNamHoc.Text + "'and Diem.MaHocSinh in" +
                            " (select MaHocSinh from HocSinh where MaLop = '" + txtMaLop.Text + "')";
                            groupBox1.Enabled = true;
                            DataSet ds = new DataSet();
                            SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                            da.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];

                        }
                        else
                        {
                            MessageBox.Show("Mã môn học " + txtMaMonHoc.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cmd22.Dispose();
                            dr22.Dispose();
                        }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                txtMaHocSinh.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTenHS.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                txtDiemMieng.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                txtDiem15p1.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                txtDiem15p2.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                txtDiem45p1.Text = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                txtDiem45p2.Text = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                txtDiemCK.Text = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                groupBox1.Enabled = false;
                txtMaHocSinh.Enabled = false;
                txtTenHS.Enabled = false;

            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            txtMaHocSinh.Text = txtTenHS.Text = txtDiemMieng.Text = txtDiem15p1.Text = txtDiem15p2.Text
               = txtDiem45p1.Text = txtDiem45p2.Text = txtDiemCK.Text = "";
            groupBox1.Enabled = true;
            txtMaHocSinh.Enabled = true;
            txtTenHS.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connect.Open();

            string update = "update Diem set DiemMieng= " + float.Parse(txtDiemMieng.Text) +
                ", Diem15pLan1 = " + float.Parse(txtDiem15p1.Text) +
                ", Diem15pLan2 =" + float.Parse(txtDiem15p2.Text) + ", Diem45pLan1 =" +
                float.Parse(txtDiem45p1.Text) + ", Diem45pLan2 = " + float.Parse(txtDiem45p2.Text) +
                ", DiemCuoiKy =" + float.Parse(txtDiemCK.Text) + " where MaHocSinh = '" + txtMaHocSinh.Text
                + "' and MaMonHoc = '" + txtMaMonHoc.Text + "' and HocKy = '" + cboHocKi.Text + "' and NamHoc = '" + cbxNamHoc.Text + "'";
            SqlCommand cmd = new SqlCommand(update, connect);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //update datagridView
            string sql2 = "select Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2, DiemCuoiKy " +
                "from Diem, HocSinh where Diem.MaHocSinh = HocSinh.MaHocSinh" +
                " and MaMonHoc = '" + txtMaMonHoc.Text + "'and HocKy = '" + cboHocKi.Text
                + "'and NamHoc = '" + cbxNamHoc.Text + "'and Diem.MaHocSinh in" +
                " (select MaHocSinh from HocSinh where MaLop = '" + txtMaLop.Text + "')";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            groupBox1.Enabled = true;
            txtMaHocSinh.Text = txtTenHS.Text = txtDiemMieng.Text = txtDiem15p1.Text = txtDiem15p2.Text
                = txtDiem45p1.Text = txtDiem45p2.Text = txtDiemCK.Text = "";
            groupBox1.Enabled = true;
            txtMaHocSinh.Enabled = true;
            txtTenHS.Enabled = true;
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
                string delete = "delete from Diem " +
                    "where MaHocSinh='" + txtMaHocSinh.Text + "' and MaMonHoc='" + txtMaMonHoc.Text + "' and HocKy='" + cboHocKi.Text + "'and NamHoc='" + cbxNamHoc.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                txtMaHocSinh.Text = txtTenHS.Text = txtDiemMieng.Text = txtDiem15p1.Text = txtDiem15p2.Text
               = txtDiem45p1.Text = txtDiem45p2.Text = txtDiemCK.Text = "";
                groupBox1.Enabled = true;
                txtMaHocSinh.Enabled = true;
                txtTenHS.Enabled = true;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "select Diem.MaHocSinh, TenHocSinh, DiemMieng,Diem15pLan1, Diem15pLan2, Diem45pLan1, Diem45pLan2, DiemCuoiKy " +
                            "from Diem, HocSinh where Diem.MaHocSinh = HocSinh.MaHocSinh" +
                            " and MaMonHoc = '" + txtMaMonHoc.Text + "'and HocKy = '" + cboHocKi.Text
                            + "'and NamHoc = '" + cbxNamHoc.Text + "'and Diem.MaHocSinh in" +
                            " (select MaHocSinh from HocSinh where MaLop = '" + txtMaLop.Text + "')";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // Trả tài nguyên
                cmd.Dispose();
                connect.Close();
            }
        }
    }
}
