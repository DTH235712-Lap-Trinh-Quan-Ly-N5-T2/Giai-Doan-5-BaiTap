using QuanLyBanHang.Data; // Đảm bảo bạn đã có namespace này cho DbContext
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHangSanXuat : Form
    {
        // Khởi tạo các biến dùng chung
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;

        public frmHangSanXuat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm hỗ trợ bật/tắt các controls theo trạng thái xử lý
        /// </summary>
        private void BatTatChucNang(bool giaTri)
        {
            // Nhóm các nút/ô văn bản cần sáng khi Thêm/Sửa
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;

            // Nhóm các nút cần mờ khi đang Thêm/Sửa
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            // 1. Thiết lập trạng thái ban đầu của các nút
            BatTatChucNang(false);

            // 2. Lấy danh sách dữ liệu từ CSDL
            List<HangSanXuat> dsHang = context.HangSanXuat.ToList();

            // 3. Sử dụng BindingSource để đồng bộ dữ liệu giữa DataGridView và TextBox
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsHang;

            // Xóa các binding cũ nếu có và thêm mới cho txtTenHangSanXuat
            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            // Hiển thị lên DataGridView
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
            txtTenHangSanXuat.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);
            // Lấy ID của dòng đang chọn để chuẩn bị cập nhật
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangSanXuat.Focus();
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    // Xử lý Thêm mới
                    HangSanXuat hsx = new HangSanXuat();
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Add(hsx);
                }
                else
                {
                    // Xử lý Cập nhật
                    HangSanXuat hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                        context.HangSanXuat.Update(hsx);
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");

                // Tải lại form để cập nhật danh sách
                frmHangSanXuat_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hãng sản xuất này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                    HangSanXuat hsx = context.HangSanXuat.Find(id);

                    if (hsx != null)
                    {
                        context.HangSanXuat.Remove(hsx);
                        context.SaveChanges();
                        frmHangSanXuat_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa do hãng này đang được sử dụng ở bảng khác!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Tải lại form để hủy các thay đổi đang nhập dở
            frmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Các sự kiện không dùng tới bạn có thể để trống hoặc xóa (nếu đã xóa trong Designer)
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void txtTenHangSanXuat_TextChanged(object sender, EventArgs e) { }
    }
}