namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            label4 = new Label();
            label5 = new Label();
            txtMoTa = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnNhap = new Button();
            txtTenSanPham = new TextBox();
            btnSua = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            cboHangSanXuat = new ComboBox();
            label1 = new Label();
            picHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboLoaiSanPham = new ComboBox();
            a = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(19, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1062, 295);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewImageColumn1 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1056, 269);
            dataGridView1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "HoVaTen";
            dataGridViewTextBoxColumn2.HeaderText = "Họ và tên ";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "DienThoai";
            dataGridViewTextBoxColumn3.HeaderText = "Điện thoại";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DiaChi";
            dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "TenDangNhap";
            dataGridViewTextBoxColumn5.HeaderText = "Tên đăng nhập";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "QuyenHan";
            dataGridViewTextBoxColumn6.HeaderText = "Quyền hạn";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Hình ảnh";
            dataGridViewImageColumn1.MinimumWidth = 6;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1056, 269);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên ";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // HinhAnh
            // 
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 170);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 20;
            label4.Text = "Mô tả sản phẩm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 84);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 19;
            label5.Text = "Đơn giá (*):";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(154, 167);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(597, 27);
            txtMoTa.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 44);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 15;
            label6.Text = "Số lượng (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 128);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 13;
            label2.Text = "Tên sản phẩm (*):";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ActiveBorder;
            btnHuyBo.Location = new Point(486, 222);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(89, 30);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveBorder;
            btnThem.Location = new Point(39, 222);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = SystemColors.ActiveBorder;
            btnNhap.Location = new Point(820, 222);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(89, 30);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(154, 128);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(597, 27);
            txtTenSanPham.TabIndex = 12;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveBorder;
            btnSua.Location = new Point(152, 222);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = SystemColors.ActiveBorder;
            btnXuat.Location = new Point(930, 222);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(89, 30);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(265, 222);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.ActiveBorder;
            btnTimKiem.Location = new Point(711, 222);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(89, 30);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveBorder;
            btnThoat.Location = new Point(601, 222);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(89, 30);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.ActiveBorder;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(377, 222);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(89, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(a);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Location = new Point(19, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 268);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(154, 84);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(291, 28);
            cboHangSanXuat.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 87);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 11;
            label1.Text = "Hãng sản xuất (*):";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(765, 41);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(144, 154);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 26;
            picHinhAnh.TabStop = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = SystemColors.ActiveBorder;
            btnDoiAnh.Location = new Point(930, 39);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(89, 30);
            btnDoiAnh.TabIndex = 25;
            btnDoiAnh.Text = "Đổi ảnh… ";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(601, 84);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 24;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(601, 42);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 23;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(154, 41);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(291, 28);
            cboLoaiSanPham.TabIndex = 10;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(22, 44);
            a.Name = "a";
            a.Size = new Size(93, 20);
            a.TabIndex = 0;
            a.Text = "Phân loại (*):";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 658);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ComboBox cboQuyenHan;
        private Label label4;
        private Label label5;
        private TextBox txtMoTa;
        private TextBox txtTenDangNhap;
        private Label label6;
        private Label label2;
        private Button btnHuyBo;
        private Button btnThem;
        private Button btnNhap;
        private TextBox txtTenSanPham;
        private Button btnSua;
        private Button btnXuat;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnLuu;
        private GroupBox groupBox1;
        private Label a;
        private ComboBox H;
        private ComboBox cboLoaiSanPham;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewImageColumn HinhAnh;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private ComboBox cboHangSanXuat;
        private Label label1;
    }
}