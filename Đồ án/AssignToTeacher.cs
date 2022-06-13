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
    public partial class AssignToTeacher : Form
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

        public AssignToTeacher()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); 

        }

        

        private void AssignToTeacher_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LAPTOP-E2S05737\SQLEXPRESS;Initial Catalog=QLTHPT;Integrated Security=True");
            connect.Open();
            string sql = "Select * From PhanCongViec";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)

        {
            //kiểm tra khóa chính đã tồn tại hay chưa
            if (txtMaGV.Text == "" || txtMaMonHoc.Text == "" || txtMaLop.Text == "" || cbxNamHoc.Text == "" || cboHocKi.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra trùng Khóa->nếu trùng->ko thêm đc
                connect.Open();
                String sql = "select * from PhanCongViec " +
                    "where  MaMonHoc='" + txtMaMonHoc.Text + "' and MaLop='" + txtMaLop.Text + "' and HocKy='" + cboHocKi.Text +
                    "' and NamHoc='" + cbxNamHoc.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Nhiệm vụ đã được phân công", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmd.Dispose();
                    dr.Dispose();
                }
                else
                {
                    cmd.Dispose();
                    dr.Dispose();
                    //KIểm tra Mã giáo viên đã tồn tại chưa->nêu chưa->ko thêm đc
                    string sql11 = "SELECT * FROM GiaoVien WHERE MaGiaoVien = '" + txtMaGV.Text + "'";
                    SqlCommand cmd11 = new SqlCommand(sql11, connect);
                    SqlDataReader dr11;
                    dr11 = cmd11.ExecuteReader();
                    if (dr11.Read())
                    {
                        cmd11.Dispose();
                        dr11.Dispose();
                        //Kiểm tra đã tồn tại mã Môn chưa->nếu chưa->ko thêm đc
                        string sql22 = "SELECT * FROM MonHoc WHERE MaMonHoc = '" + txtMaMonHoc.Text + "'";
                        SqlCommand cmd22 = new SqlCommand(sql22, connect);
                        SqlDataReader dr22;
                        dr22 = cmd22.ExecuteReader();
                        if (dr22.Read())
                        {
                            cmd22.Dispose();
                            dr22.Dispose();
                            string sql33 = "SELECT * FROM LopHoc WHERE MaLop = '" + txtMaLop.Text + "'";
                            SqlCommand cmd33 = new SqlCommand(sql33, connect);
                            SqlDataReader dr33;
                            dr33 = cmd33.ExecuteReader();
                            if (dr33.Read())
                            {
                                dr33.Dispose();
                                cmd33.Dispose();
                                //Thêm nhiệm vụ
                                string insert = "insert into PhanCongViec values('" + txtMaGV.Text + "','" + txtMaMonHoc.Text + "','" + txtMaLop.Text +
                                    "','" + cboHocKi.Text + "','" + cboHocKi.Text + "','" + int.Parse(txtSoTiet.Text) + "','" + txtNgaygio.Text + "')";
                                SqlCommand cmd1 = new SqlCommand(insert, connect);
                                cmd1.ExecuteNonQuery();
                                txtMaGV.Text = txtMaLop.Text = txtMaMonHoc.Text = txtNgaygio.Text = txtSoTiet.Text = "";
                                txtMaGV.Text = txtMaLop.Text = txtMaMonHoc.Text = txtNgaygio.Text = txtSoTiet.Text
                                = cboHocKi.Text = cbxNamHoc.Text = "";
                                MessageBox.Show("Thêm mới thành công", "Thông báo!");
                                cmd1.Dispose();
                                //update datagridView
                                string sql2 = "Select * From PhanCongViec";
                                DataSet ds = new DataSet();
                                SqlDataAdapter da = new SqlDataAdapter(sql2, connect);
                                da.Fill(ds);
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Mã lớp " + txtMaLop.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dr33.Dispose();
                                cmd33.Dispose();
                            }

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

                        MessageBox.Show("Mã giáo viên " + txtMaGV.Text + " chưa tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                connect.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                txtMaGV.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtMaMonHoc.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                txtMaLop.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                cboHocKi.Text = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                cbxNamHoc.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                txtSoTiet.Text = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                txtNgaygio.Text = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                txtMaLop.Enabled = txtMaMonHoc.Enabled = cboHocKi.Enabled = cbxNamHoc.Enabled = false;

            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = txtMaLop.Text = txtMaMonHoc.Text = txtNgaygio.Text = txtSoTiet.Text
                = cboHocKi.Text = cbxNamHoc.Text = "";
            txtMaLop.Enabled = txtMaMonHoc.Enabled = cboHocKi.Enabled = cbxNamHoc.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connect.Open();
            string update = "Update PhanCongViec Set MaGiaoVien='" + txtMaGV.Text + "',SoTiet='" + txtSoTiet.Text + "',NgayGio='" +
                            txtNgaygio.Text + "'" + "where  MaMonHoc='" + txtMaMonHoc.Text + "' and MaLop='" + txtMaLop.Text + "' and HocKy='" + cboHocKi.Text +
                    "' and NamHoc='" + cbxNamHoc.Text + "'";
            SqlCommand cmd = new SqlCommand(update, connect);
            cmd.ExecuteNonQuery();
            txtMaGV.Text = txtMaLop.Text = txtMaMonHoc.Text = txtNgaygio.Text = txtSoTiet.Text
                = cboHocKi.Text = cbxNamHoc.Text = "";
            txtMaLop.Enabled = txtMaMonHoc.Enabled = cboHocKi.Enabled = cbxNamHoc.Enabled = true;
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            //update datagridView
            string sql2 = "Select * From PhanCongViec";
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
                string delete = "delete from PhanCongViec " +
                    "where  MaMonHoc='" + txtMaMonHoc.Text + "' and MaLop='" + txtMaLop.Text + "' and HocKy='" + cboHocKi.Text +
                    "' and NamHoc='" + cbxNamHoc.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, connect);
                cmd.ExecuteNonQuery();
                txtMaGV.Text = txtMaLop.Text = txtMaMonHoc.Text = txtNgaygio.Text = txtSoTiet.Text
                = cboHocKi.Text = cbxNamHoc.Text = "";
                txtMaLop.Enabled = txtMaMonHoc.Enabled = cboHocKi.Enabled = cbxNamHoc.Enabled = true;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                //update datagridView
                string sql2 = "Select * From PhanCongViec";
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
