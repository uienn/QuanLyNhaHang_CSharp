using System;
using System.Data;
using Microsoft.Data.SqlClient; // Thư viện NuGet chuẩn
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        // 1. Hàm xử lý cho nút Đăng Nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Bbi ơi, vui lòng điền đầy đủ cả tài khoản và mật khẩu nhe!", "Thông báo");
                return;
            }

            try
            {
                // Chuỗi kết nối kết nối thẳng vào SQL Server trên máy 
                string chuoiSql = @"Data Source=.;Initial Catalog=QuanLyNhaHangLau;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(chuoiSql))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @tk AND MatKhau = @mk";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        int ketQua = (int)cmd.ExecuteScalar();

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Đăng nhập hệ thống thành công rực rỡ! 🥰", "Thành công");

                            // Khởi tạo và bật Form Main lên
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();

                            this.Hide(); // Ẩn form đăng nhập cũ
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu rồi bbi ơi! Kiểm tra lại nhe.", "Lỗi đăng nhập");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hệ thống: " + ex.Message, "Thông báo");
            }
        }

        // 2. Sửa tên hàm cho trùng khớp với lnkDangKy_LinkClicked ở dòng 116
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKy frmDK = new FrmDangKy();
            frmDK.ShowDialog();
        }

        // 3. Bổ sung hàm cho nút Thoát ở dòng 105 đang bị thiếu
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát hẳn phần mềm luôn nhe bbi
        }
    }
}