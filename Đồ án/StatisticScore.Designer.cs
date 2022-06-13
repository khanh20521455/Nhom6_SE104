
namespace Đồ_án
{
    partial class StatisticScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticScore));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHocKi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15pLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15pLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem45pLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem45pLan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(380, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "THỐNG KÊ ĐIỂM HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaMonHoc);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxNamHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboHocKi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(31, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 81);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(110, 24);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(119, 27);
            this.txtMaLop.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã Lớp";
            // 
            // cbxNamHoc
            // 
            this.cbxNamHoc.FormattingEnabled = true;
            this.cbxNamHoc.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022"});
            this.cbxNamHoc.Location = new System.Drawing.Point(773, 23);
            this.cbxNamHoc.Name = "cbxNamHoc";
            this.cbxNamHoc.Size = new System.Drawing.Size(146, 28);
            this.cbxNamHoc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(668, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Năm học";
            // 
            // cboHocKi
            // 
            this.cboHocKi.FormattingEnabled = true;
            this.cboHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboHocKi.Location = new System.Drawing.Point(567, 23);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(61, 28);
            this.cboHocKi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(486, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Học kì";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(31, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1129, 629);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách công việc";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnThoat.Depth = 0;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = ((System.Drawing.Image)(resources.GetObject("btnThoat.Icon")));
            this.btnThoat.Location = new System.Drawing.Point(986, 129);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(174, 32);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = true;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = false;
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Icon")));
            this.btnTimKiem.Location = new System.Drawing.Point(986, 69);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(174, 32);
            this.btnTimKiem.TabIndex = 38;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(339, 23);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(119, 27);
            this.txtMaMonHoc.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(251, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã môn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(122)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.DiemMieng,
            this.Diem15pLan1,
            this.Diem15pLan2,
            this.Diem45pLan1,
            this.Diem45pLan2,
            this.DiemCuoiKy,
            this.DTB});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 603);
            this.dataGridView1.TabIndex = 1;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            this.MaHocSinh.HeaderText = "Mã học sinh";
            this.MaHocSinh.MinimumWidth = 6;
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Width = 150;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.DataPropertyName = "TenHocSinh";
            this.TenHocSinh.HeaderText = "Họ tên";
            this.TenHocSinh.MinimumWidth = 6;
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHocSinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenHocSinh.Width = 250;
            // 
            // DiemMieng
            // 
            this.DiemMieng.DataPropertyName = "DiemMieng";
            this.DiemMieng.HeaderText = "Miệng";
            this.DiemMieng.MinimumWidth = 6;
            this.DiemMieng.Name = "DiemMieng";
            // 
            // Diem15pLan1
            // 
            this.Diem15pLan1.DataPropertyName = "Diem15pLan1";
            this.Diem15pLan1.HeaderText = "15\' lần1";
            this.Diem15pLan1.MinimumWidth = 6;
            this.Diem15pLan1.Name = "Diem15pLan1";
            // 
            // Diem15pLan2
            // 
            this.Diem15pLan2.DataPropertyName = "Diem15pLan2";
            this.Diem15pLan2.HeaderText = "15\' lần 2";
            this.Diem15pLan2.MinimumWidth = 6;
            this.Diem15pLan2.Name = "Diem15pLan2";
            // 
            // Diem45pLan1
            // 
            this.Diem45pLan1.DataPropertyName = "Diem45pLan1";
            this.Diem45pLan1.HeaderText = "45\' lần 1";
            this.Diem45pLan1.MinimumWidth = 6;
            this.Diem45pLan1.Name = "Diem45pLan1";
            // 
            // Diem45pLan2
            // 
            this.Diem45pLan2.DataPropertyName = "Diem45pLan2";
            this.Diem45pLan2.HeaderText = "45\' lần 2";
            this.Diem45pLan2.MinimumWidth = 6;
            this.Diem45pLan2.Name = "Diem45pLan2";
            // 
            // DiemCuoiKy
            // 
            this.DiemCuoiKy.DataPropertyName = "DiemCuoiKy";
            this.DiemCuoiKy.HeaderText = "Cuối kì";
            this.DiemCuoiKy.MinimumWidth = 6;
            this.DiemCuoiKy.Name = "DiemCuoiKy";
            // 
            // DTB
            // 
            this.DTB.DataPropertyName = "DTB";
            this.DTB.HeaderText = "DTB";
            this.DTB.MinimumWidth = 6;
            this.DTB.Name = "DTB";
            // 
            // StatisticScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 800);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatisticScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticScore";
            this.Load += new System.EventHandler(this.StatisticScore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHocKi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15pLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15pLan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem45pLan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem45pLan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    }
}