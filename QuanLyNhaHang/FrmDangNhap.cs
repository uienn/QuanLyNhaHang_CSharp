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
            // 1. Ép hệ thống tìm trực tiếp linh kiện trên giao diện theo Tên (Name) để lấy dữ liệu
            TextBox oTaiKhoan = (TextBox)this.Controls.Find("txtTaiKhoan", true).FirstOrDefault();
            TextBox oMatKhau = (TextBox)this.Controls.Find("txtMatKhau", true).FirstOrDefault();
            TextBox oSoBan = (TextBox)this.Controls.Find("txtSoBan", true).FirstOrDefault();

            // Tạo các biến chứa chuỗi chữ đã gõ (nếu tìm thấy ô)
            string chuoiTaiKhoan = oTaiKhoan != null ? oTaiKhoan.Text.Trim() : "";
            string chuoiMatKhau = oMatKhau != null ? oMatKhau.Text.Trim() : "";
            string chuoiSoBan = oSoBan != null ? oSoBan.Text.Trim() : "";

            // 2. KIỂM TRA TRƯỜNG HỢP QUẢN LÝ (admin / 123)
            if (chuoiTaiKhoan == "admin" && chuoiMatKhau == "123")
            {
                MessageBox.Show("Đăng nhập quyền QUẢN LÝ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn Form Đăng Nhập đi để mở Form chính
                this.Hide();

                // Khởi tạo trực tiếp Form Chính (FrmMain) mới tinh của bbi
                FrmMain frmChinh = new FrmMain();

                // Gọi hàm mở khóa chức năng (nếu FrmMain của bbi có hàm này thì để, không có bbi xóa dòng dưới này đi nha)
                frmChinh.MoKhoaTatCaChucNang();

                // Bật Form Chính lên màn hình
                frmChinh.ShowDialog();

                // Khi tắt Form chính thì tắt luôn ứng dụng chạy ngầm
                this.Close();
            }
            // 4. KIỂM TRA TRƯỜNG HỢP KHÁCH HÀNG (Có nhập số bàn)
            else if (!string.IsNullOrEmpty(chuoiSoBan))
            {
                MessageBox.Show("Chào mừng quý khách ngồi bàn " + chuoiSoBan + "! Hệ thống gọi món đã sẵn sàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ĐOẠN CODE THAY THẾ CHO KHÁCH HÀNG (DÁN TỪ DÒNG 54):
                // 1. Ẩn Form Đăng Nhập đi
                this.Hide();

                // 2. Tạo mới Form Chính FrmMain
                FrmMain frmChinh = new FrmMain();

                // 3. Gọi hàm cấu hình giao diện riêng cho Khách hàng
                frmChinh.CauHinhGiaoDienKhachHang();

                // 4. Bật Form Chính lên màn hình
                frmChinh.ShowDialog();

                // 5. Đóng hẳn ứng dụng khi thoát
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

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();

            // 2. Hiển thị Form Đăng Ký lên dưới dạng hộp thoại độc lập
            frm.ShowDialog();
        }
    }

}
