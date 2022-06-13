
namespace Đồ_án
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnBoChon = new MaterialSkin.Controls.MaterialButton();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(367, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(164, 263);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(246, 27);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDC
            // 
            this.txtDC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDC.Location = new System.Drawing.Point(164, 202);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(246, 27);
            this.txtDC.TabIndex = 8;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(164, 98);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(246, 27);
            this.txtTenGV.TabIndex = 7;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(164, 45);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(246, 27);
            this.txtMaGV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(164, 149);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(121, 28);
            this.cbxGioiTinh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giáo viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(451, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 500);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(122)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.TenGiaoVien,
            this.GioiTinh,
            this.DiaChi,
            this.SDT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 474);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.btnThoat.Location = new System.Drawing.Point(255, 514);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThoat.Size = new System.Drawing.Size(136, 36);
            this.btnThoat.TabIndex = 28;
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
            this.btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = ((System.Drawing.Image)(resources.GetObject("btnXoa.Icon")));
            this.btnXoa.Location = new System.Drawing.Point(255, 467);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(136, 36);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(56, 514);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSua.Size = new System.Drawing.Size(136, 36);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = ((System.Drawing.Image)(resources.GetObject("btnThem.Icon")));
            this.btnThem.Location = new System.Drawing.Point(56, 467);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(136, 36);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnBoChon.Location = new System.Drawing.Point(56, 419);
            this.btnBoChon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBoChon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBoChon.Size = new System.Drawing.Size(136, 36);
            this.btnBoChon.TabIndex = 29;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBoChon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBoChon.UseAccentColor = false;
            this.btnBoChon.UseVisualStyleBackColor = false;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Mã giáo viên";
            this.MaGiaoVien.MinimumWidth = 6;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Width = 150;
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.DataPropertyName = "TenGiaoVien";
            this.TenGiaoVien.HeaderText = "Họ tên";
            this.TenGiaoVien.MinimumWidth = 6;
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.Width = 250;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 350;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 200;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 609);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnBoChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}