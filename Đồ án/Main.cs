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

namespace Đồ_án
{

    public partial class Main : Form
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
        public Main()
        {
           
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreManagement frm = new ScoreManagement();
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword();
            change.Show();
        }

        private void QLNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement frm = new UserManagement();
            frm.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void LopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassManagement frm = new ClassManagement();
            frm.Show();

        }

        private void MonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectManagement frm = new SubjectManagement();
            frm.Show();

        }

        private void HocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudenManagement frm = new StudenManagement();
            frm.Show();
        }

        private void GiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher frm = new Teacher();
            frm.Show();
        }

        private void HanhKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConductManagement frm = new ConductManagement();
            frm.Show();
        }

        private void PCGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignToTeacher frm = new AssignToTeacher();
            frm.Show();
        }

        private void TTDiemHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudentScore frm = new SearchStudentScore();
            frm.Show();

        }

        private void DiemCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPersonalScore frm = new SearchPersonalScore();
            frm.Show();
        }

        private void CVGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAssignTeacher frm = new SearchAssignTeacher();
            frm.Show();
        }

        private void DSHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticInfo frm = new StatisticInfo();
            frm.Show();
        }

        private void TKDiemHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticScore frm = new StatisticScore();
            frm.Show();
        }
    }
}
