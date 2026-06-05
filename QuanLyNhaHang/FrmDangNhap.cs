using System;
using System.Data;
using Microsoft.Data.SqlClient; 
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
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Bbi ơi, vui lòng điền đầy đủ cả tài khoản và mật khẩu nhe!", "Thông báo");
                return;
            }

            try
            {
                
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

                            
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();

                            this.Hide(); 
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

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKy frmDK = new FrmDangKy();
            frmDK.ShowDialog();
        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}