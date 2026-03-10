namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            btnHuyBo = new Button();
            btnThem = new Button();
            btnNhap = new Button();
            txtDienThoai = new TextBox();
            btnSua = new Button();
            txtHoVaTen = new TextBox();
            btnXuat = new Button();
            label1 = new Label();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 198);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý ", "Nhân viên " });
            cboQuyenHan.Location = new Point(534, 154);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(174, 28);
            cboQuyenHan.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 105);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 20;
            label4.Text = "Mật khẩu (*):";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 154);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 19;
            label5.Text = "Quyền hạn (*):";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(534, 102);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(174, 27);
            txtMatKhau.TabIndex = 17;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(534, 44);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(174, 27);
            txtTenDangNhap.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(377, 47);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 15;
            label6.Text = "Tên đăng nhập (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 102);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 14;
            label3.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(124, 151);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(229, 27);
            txtDiaChi.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 151);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 13;
            label2.Text = "Địa chỉ:";
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ActiveBorder;
            btnHuyBo.Location = new Point(849, 99);
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
            btnThem.Location = new Point(737, 44);
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
            btnNhap.Location = new Point(954, 99);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(89, 30);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(124, 99);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(229, 27);
            txtDienThoai.TabIndex = 11;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ActiveBorder;
            btnSua.Location = new Point(737, 99);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(124, 41);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(229, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = SystemColors.ActiveBorder;
            btnXuat.Location = new Point(954, 152);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(89, 30);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(737, 152);
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
            btnTimKiem.Location = new Point(954, 44);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(89, 30);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveBorder;
            btnThoat.Location = new Point(849, 152);
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
            btnLuu.Location = new Point(849, 44);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(89, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(10, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1062, 265);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1056, 239);
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
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 509);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label2;
        private Button btnHuyBo;
        private Button btnThem;
        private Button btnNhap;
        private TextBox txtDienThoai;
        private Button btnSua;
        private TextBox txtHoVaTen;
        private Button btnXuat;
        private Label label1;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnLuu;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label4;
        private Label label5;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private ComboBox cboQuyenHan;
    }
}