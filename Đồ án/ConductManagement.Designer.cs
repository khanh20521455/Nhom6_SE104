
namespace Đồ_án
{
    partial class ConductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConductManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.cbxNamHoc = new System.Windows.Forms.ComboBox();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.cbxHanhKiem = new System.Windows.Forms.ComboBox();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBoTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.btnBoChon = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(330, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HẠNH KIỂM HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbxNamHoc);
            this.groupBox1.Controls.Add(this.cbxHocKy);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(36, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
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
            this.btnTimKiem.Location = new System.Drawing.Point(852, 33);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(159, 32);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbxNamHoc
            // 
            this.cbxNamHoc.FormattingEnabled = true;
            this.cbxNamHoc.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022"});
            this.cbxNamHoc.Location = new System.Drawing.Point(661, 36);
            this.cbxNamHoc.Name = "cbxNamHoc";
            this.cbxNamHoc.Size = new System.Drawing.Size(147, 28);
            this.cbxNamHoc.TabIndex = 11;
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxHocKy.Location = new System.Drawing.Point(395, 36);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(85, 28);
            this.cbxHocKy.TabIndex = 10;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(116, 36);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 27);
            this.txtMaLop.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(550, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(300, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(36, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 465);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(122)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.HanhKiem});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 439);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.TenHocSinh.HeaderText = "Tên học sinh";
            this.TenHocSinh.MinimumWidth = 6;
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.Width = 270;
            // 
            // HanhKiem
            // 
            this.HanhKiem.DataPropertyName = "HanhKiem";
            this.HanhKiem.HeaderText = "Hạnh Kiểm";
            this.HanhKiem.MinimumWidth = 6;
            this.HanhKiem.Name = "HanhKiem";
            this.HanhKiem.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.txtTenHocSinh);
            this.groupBox3.Controls.Add(this.cbxHanhKiem);
            this.groupBox3.Controls.Add(this.txtMaHocSinh);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(36, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1028, 86);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(444, 36);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(251, 27);
            this.txtTenHocSinh.TabIndex = 12;
            // 
            // cbxHanhKiem
            // 
            this.cbxHanhKiem.FormattingEnabled = true;
            this.cbxHanhKiem.Items.AddRange(new object[] {
            "T",
            "K",
            "TB"});
            this.cbxHanhKiem.Location = new System.Drawing.Point(890, 36);
            this.cbxHanhKiem.Name = "cbxHanhKiem";
            this.cbxHanhKiem.Size = new System.Drawing.Size(121, 28);
            this.cbxHanhKiem.TabIndex = 11;
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(147, 36);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(121, 27);
            this.txtMaHocSinh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(747, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hạnh kiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(311, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên học sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã học sinh";
            // 
            // btnBoTimKiem
            // 
            this.btnBoTimKiem.AutoSize = false;
            this.btnBoTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBoTimKiem.BackColor = System.Drawing.Color.White;
            this.btnBoTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBoTimKiem.Depth = 0;
            this.btnBoTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoTimKiem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBoTimKiem.HighEmphasis = true;
            this.btnBoTimKiem.Icon = null;
            this.btnBoTimKiem.Location = new System.Drawing.Point(926, 427);
            this.btnBoTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBoTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBoTimKiem.Name = "btnBoTimKiem";
            this.btnBoTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBoTimKiem.Size = new System.Drawing.Size(136, 52);
            this.btnBoTimKiem.TabIndex = 28;
            this.btnBoTimKiem.Text = "Bỏ tìm kiếm";
            this.btnBoTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBoTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBoTimKiem.UseAccentColor = false;
            this.btnBoTimKiem.UseVisualStyleBackColor = false;
            this.btnBoTimKiem.Click += new System.EventHandler(this.btnBoTimKiem_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.AutoSize = false;
            this.btnBoChon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBoChon.BackColor = System.Drawing.Color.White;
            this.btnBoChon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBoChon.Depth = 0;
            this.btnBoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoChon.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBoChon.HighEmphasis = true;
            this.btnBoChon.Icon = null;
            this.btnBoChon.Location = new System.Drawing.Point(752, 427);
            this.btnBoChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBoChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBoChon.Size = new System.Drawing.Size(125, 52);
            this.btnBoChon.TabIndex = 27;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBoChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBoChon.UseAccentColor = false;
            this.btnBoChon.UseVisualStyleBackColor = false;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = ((System.Drawing.Image)(resources.GetObject("btnSua.Icon")));
            this.btnSua.Location = new System.Drawing.Point(752, 634);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(136, 52);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThoat.Depth = 0;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = ((System.Drawing.Image)(resources.GetObject("btnThoat.Icon")));
            this.btnThoat.Location = new System.Drawing.Point(926, 634);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(136, 52);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = true;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = ((System.Drawing.Image)(resources.GetObject("btnXoa.Icon")));
            this.btnXoa.Location = new System.Drawing.Point(926, 527);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(136, 53);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = ((System.Drawing.Image)(resources.GetObject("btnThem.Icon")));
            this.btnThem.Location = new System.Drawing.Point(752, 530);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(136, 50);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ConductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnBoTimKiem);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConductManagement";
            this.Text = "ConductManagenment";
            this.Load += new System.EventHandler(this.ConductManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxNamHoc;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxHanhKiem;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton btnBoTimKiem;
        private MaterialSkin.Controls.MaterialButton btnBoChon;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
        private System.Windows.Forms.TextBox txtTenHocSinh;
    }
}