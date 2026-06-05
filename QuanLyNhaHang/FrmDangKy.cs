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

            
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Định dạng Email không hợp lệ (Ví dụ: abc@gmail.com)!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            
            if (!long.TryParse(txtSoDienThoai.Text.Trim(), out _))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng chỉ nhập các ký tự số.",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            
            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp! Vui lòng kiểm tra lại.",
                                "Xác thực thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhanMK.Focus();
                return;
            }

            
            MessageBox.Show("Đăng ký tài khoản mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
