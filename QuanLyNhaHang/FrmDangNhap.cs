using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Lấy đối tượng Form chính đang chạy ngầm
            btnQuanLyKho frmMain = (btnQuanLyKho)Application.OpenForms["btnQuanLyKho"];

            // 2. Ép hệ thống tìm trực tiếp linh kiện trên giao diện theo Tên (Name) để lấy dữ liệu
            TextBox oTaiKhoan = (TextBox)this.Controls.Find("txtTaiKhoan", true).FirstOrDefault();
            TextBox oMatKhau = (TextBox)this.Controls.Find("txtMatKhau", true).FirstOrDefault();
            TextBox oSoBan = (TextBox)this.Controls.Find("txtSoBan", true).FirstOrDefault();

            // Tạo các biến chứa chuỗi chữ đã gõ (nếu tìm thấy ô)
            string chuoiTaiKhoan = oTaiKhoan != null ? oTaiKhoan.Text.Trim() : "";
            string chuoiMatKhau = oMatKhau != null ? oMatKhau.Text.Trim() : "";
            string chuoiSoBan = oSoBan != null ? oSoBan.Text.Trim() : "";

            // 3. KIỂM TRA TRƯỜNG HỢP QUẢN LÝ (admin / 123)
            if (chuoiTaiKhoan == "admin" && chuoiMatKhau == "123")
            {
                MessageBox.Show("Đăng nhập quyền QUẢN LÝ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (frmMain != null)
                {
                    frmMain.MoKhoaTatCaChucNang();
                }
                this.Close();
            }
            // 4. KIỂM TRA TRƯỜNG HỢP KHÁCH HÀNG (Có nhập số bàn)
            else if (!string.IsNullOrEmpty(chuoiSoBan))
            {
                MessageBox.Show("Chào mừng quý khách ngồi bàn " + chuoiSoBan + "! Hệ thống gọi món đã sẵn sàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (frmMain != null)
                {
                    frmMain.CauHinhGiaoDienKhachHang();
                }
                this.Close();
            }
            // 5. SAI HOẶC ĐỂ TRỐNG
            else
            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản Quản lý HOẶC nhập Số bàn!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát hẳn chương trình
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit(); // Thoát toàn bộ ứng dụng
            }
        }
    }
    
}
