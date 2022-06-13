
namespace Đồ_án
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboxQuyen = new System.Windows.Forms.ComboBox();
            this.comboxGT = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.textDNTK = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnBoChon = new MaterialSkin.Controls.MaterialButton();
            this.txtBoTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(368, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NGƯỜI DÙNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.comboxQuyen);
            this.groupBox1.Controls.Add(this.comboxGT);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(24, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // comboxQuyen
            // 
            this.comboxQuyen.FormattingEnabled = true;
            this.comboxQuyen.Items.AddRange(new object[] {
            "Admin",
            "GiaoVien",
            "HocSinh"});
            this.comboxQuyen.Location = new System.Drawing.Point(575, 167);
            this.comboxQuyen.Name = "comboxQuyen";
            this.comboxQuyen.Size = new System.Drawing.Size(152, 28);
            this.comboxQuyen.TabIndex = 11;
            // 
            // comboxGT
            // 
            this.comboxGT.FormattingEnabled = true;
            this.comboxGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboxGT.Location = new System.Drawing.Point(168, 170);
            this.comboxGT.Name = "comboxGT";
            this.comboxGT.Size = new System.Drawing.Size(121, 28);
            this.comboxGT.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(575, 103);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(575, 33);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(269, 27);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(168, 109);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(168, 38);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(261, 27);
            this.txtTenDN.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(449, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(449, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(449, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(24, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 320);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(122)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.HoTen,
            this.GioiTinh,
            this.MatKhau,
            this.Email,
            this.Quyen});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.textDNTK);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(24, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 104);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
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
            this.btnTimKiem.Location = new System.Drawing.Point(489, 41);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(150, 32);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // textDNTK
            // 
            this.textDNTK.Location = new System.Drawing.Point(168, 44);
            this.textDNTK.Name = "textDNTK";
            this.textDNTK.Size = new System.Drawing.Size(261, 27);
            this.textDNTK.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên đăng nhập";
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
            this.btnThem.Location = new System.Drawing.Point(928, 131);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(136, 35);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = false;
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = ((System.Drawing.Image)(resources.GetObject("btnSua.Icon")));
            this.btnSua.Location = new System.Drawing.Point(928, 178);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(136, 32);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(928, 222);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(136, 32);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(928, 266);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(136, 32);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = true;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.AutoSize = false;
            this.btnBoChon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBoChon.BackColor = System.Drawing.Color.White;
            this.btnBoChon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnBoChon.Depth = 0;
            this.btnBoChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBoChon.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBoChon.HighEmphasis = true;
            this.btnBoChon.Icon = null;
            this.btnBoChon.Location = new System.Drawing.Point(750, 395);
            this.btnBoChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBoChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBoChon.Size = new System.Drawing.Size(140, 32);
            this.btnBoChon.TabIndex = 25;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBoChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBoChon.UseAccentColor = false;
            this.btnBoChon.UseVisualStyleBackColor = false;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // txtBoTimKiem
            // 
            this.txtBoTimKiem.AutoSize = false;
            this.txtBoTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBoTimKiem.BackColor = System.Drawing.Color.White;
            this.txtBoTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.txtBoTimKiem.Depth = 0;
            this.txtBoTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtBoTimKiem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoTimKiem.HighEmphasis = true;
            this.txtBoTimKiem.Icon = null;
            this.txtBoTimKiem.Location = new System.Drawing.Point(928, 395);
            this.txtBoTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoTimKiem.Name = "txtBoTimKiem";
            this.txtBoTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtBoTimKiem.Size = new System.Drawing.Size(136, 32);
            this.txtBoTimKiem.TabIndex = 26;
            this.txtBoTimKiem.Text = "Bỏ tìm kiếm";
            this.txtBoTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.txtBoTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtBoTimKiem.UseAccentColor = false;
            this.txtBoTimKiem.UseVisualStyleBackColor = false;
            this.txtBoTimKiem.Click += new System.EventHandler(this.txtBoTimKiem_Click);
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 250;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 250;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền ";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 125;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.txtBoTimKiem);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxQuyen;
        private System.Windows.Forms.ComboBox comboxGT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textDNTK;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnBoChon;
        private MaterialSkin.Controls.MaterialButton txtBoTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}