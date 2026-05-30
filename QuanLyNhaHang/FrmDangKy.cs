using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra không được để trống bất kỳ trường thông tin nào
            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()) ||
                string.IsNullOrEmpty(txtTenDN.Text.Trim()) ||
                string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text.Trim()) ||
                string.IsNullOrEmpty(txtMatKhau.Text.Trim()) ||
                string.IsNullOrEmpty(txtXacNhanMK.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả các thông tin bắt buộc (*)",
                                "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra định dạng Email hợp lệ
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Định dạng Email không hợp lệ (Ví dụ: abc@gmail.com)!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // 3. Kiểm tra số điện thoại phải là số
            if (!long.TryParse(txtSoDienThoai.Text.Trim(), out _))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng chỉ nhập các ký tự số.",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // 4. Kiểm tra mật khẩu xác nhận có khớp nhau hay không
            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp! Vui lòng kiểm tra lại.",
                                "Xác thực thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhanMK.Focus();
                return;
            }

            // Thông báo khi mọi thứ hợp lệ
            MessageBox.Show("Đăng ký tài khoản mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); // Lệnh đóng Form Đăng Ký khi bấm nút Hủy
        }
    }
}
