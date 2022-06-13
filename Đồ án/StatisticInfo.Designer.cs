
namespace Đồ_án
{
    partial class StatisticInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new MaterialSkin.Controls.MaterialButton();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "THỐNG KÊ THÔNG TIN HỌC SINH";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(179, 93);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(141, 27);
            this.txtMaLop.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 651);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học sinh";
            // 
            // btnthoat
            // 
            this.btnthoat.AutoSize = false;
            this.btnthoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnthoat.BackColor = System.Drawing.Color.White;
            this.btnthoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnthoat.Depth = 0;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnthoat.HighEmphasis = true;
            this.btnthoat.Icon = ((System.Drawing.Image)(resources.GetObject("btnthoat.Icon")));
            this.btnthoat.Location = new System.Drawing.Point(839, 77);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnthoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnthoat.Size = new System.Drawing.Size(151, 48);
            this.btnthoat.TabIndex = 37;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnthoat.UseAccentColor = true;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(516, 77);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(168, 48);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(122)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.NgaySinh,
            this.GioiTinh,
            this.MaLop,
            this.DienUuTien,
            this.DanToc,
            this.HoTenCha,
            this.HoTenMe});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 625);
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
            this.TenHocSinh.Width = 200;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // DienUuTien
            // 
            this.DienUuTien.DataPropertyName = "DienUuTien";
            this.DienUuTien.HeaderText = "Diện ưu tiên";
            this.DienUuTien.MinimumWidth = 6;
            this.DienUuTien.Name = "DienUuTien";
            this.DienUuTien.Width = 150;
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "Dân tộc";
            this.DanToc.MinimumWidth = 6;
            this.DanToc.Name = "DanToc";
            this.DanToc.Width = 125;
            // 
            // HoTenCha
            // 
            this.HoTenCha.DataPropertyName = "HoTenCha";
            this.HoTenCha.HeaderText = "Cha";
            this.HoTenCha.MinimumWidth = 6;
            this.HoTenCha.Name = "HoTenCha";
            this.HoTenCha.Width = 200;
            // 
            // HoTenMe
            // 
            this.HoTenMe.DataPropertyName = "HoTenMe";
            this.HoTenMe.HeaderText = "Mẹ";
            this.HoTenMe.MinimumWidth = 6;
            this.HoTenMe.Name = "HoTenMe";
            this.HoTenMe.Width = 200;
            // 
            // StatisticInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatisticInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticInfo";
            this.Load += new System.EventHandler(this.StatisticInfo_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnthoat;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienUuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenMe;
    }
}