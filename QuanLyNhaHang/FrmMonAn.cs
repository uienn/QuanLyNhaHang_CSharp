using Microsoft.Data.SqlClient; 
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyNhaHang
{
    public partial class FrmMonAn : Form
    {
        
        string chuoiSql = @"Data Source=.;Initial Catalog=QuanLyNhaHangLau;Integrated Security=True;Encrypt=False";

        public FrmMonAn()
        {
            InitializeComponent();
        }

        
        private void FrmMonAn_Load(object sender, EventArgs e)
        {
            HienThiDanhSachMonAn();
        }

        
        public void HienThiDanhSachMonAn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiSql))
                {
                    conn.Open();

                    
                    string sql = "SELECT MaMon AS [Mã Món], TenMon AS [Tên Món Ăn], LoaiMon AS [Loại], GiaBan AS [Giá Bán], TrangThai AS [Trạng Thái] FROM MonAn";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt); 

                        dgvMonAn.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được danh mục món ăn rồi admin ơi! Lỗi: " + ex.Message, "Thông báo");
            }
        }

        private void FrmMonAn_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSachMonAn();
        }

        private void dgvMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonAn.Rows[e.RowIndex];

                
                txtMaMon.Text = row.Cells["MaMon"].Value.ToString();
                txtTenMon.Text = row.Cells["TenMon"].Value.ToString();
                txtGiaTien.Text = row.Cells["GiaBan"].Value.ToString();
                cbDanhMuc.Text = row.Cells["LoaiMon"].Value.ToString();

                
                txtMaMon.ReadOnly = true;
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            
            {
                string maMon = txtMaMon.Text.Trim();
                string tenMon = txtTenMon.Text.Trim();
                string giaText = txtGiaTien.Text.Trim();
                string loaiMon = cbDanhMuc.Text;

                if (string.IsNullOrEmpty(maMon) || string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(giaText))
                {
                    MessageBox.Show("Admin ơi, điền đầy đủ thông tin Mã, Tên và Giá của món ăn mới nhe!", "Thông báo");
                    return;
                }

                if (!int.TryParse(giaText, out int giaBan))
                {
                    MessageBox.Show("Giá tiền phải nhập bằng số nguyên nha admin ơi!", "Thông báo");
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(chuoiSql))
                    {
                        conn.Open();
                        string sql = "INSERT INTO MonAn (MaMon, TenMon, LoaiMon, GiaBan, TrangThai) VALUES (@ma, @ten, @loai, @gia, @trangthai)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ma", maMon);
                            cmd.Parameters.AddWithValue("@ten", tenMon);
                            cmd.Parameters.AddWithValue("@loai", loaiMon);
                            cmd.Parameters.AddWithValue("@gia", giaBan);
                            cmd.Parameters.AddWithValue("@trangthai", "Còn hàng");

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Thêm món ăn mới vào thực đơn thành công mỹ mãn! 🥰", "Thành công");
                                txtMaMon.Clear();
                                txtTenMon.Clear();
                                txtGiaTien.Clear();
                                HienThiDanhSachMonAn(); 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thêm được món rồi! Lỗi cụ thể: " + ex.Message, "Thông báo lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMon = txtMaMon.Text.Trim();
            string tenMon = txtTenMon.Text.Trim();
            string giaText = txtGiaTien.Text.Trim();
            string loaiMon = cbDanhMuc.Text;

            if (string.IsNullOrEmpty(maMon))
            {
                MessageBox.Show("vui lòng chọn món ăn từ bảng dưới đây để sửa!", "Thông báo");
                return;
            }

            if (!int.TryParse(giaText, out int giaBan))
            {
                MessageBox.Show("Giá tiền phải nhập bằng số nguyên nha bbi!", "Thông báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiSql))
                {
                    conn.Open();
                    
                    string sql = "UPDATE MonAn SET TenMon = @ten, LoaiMon = @loai, GiaBan = @gia WHERE MaMon = @ma";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ma", maMon);
                        cmd.Parameters.AddWithValue("@ten", tenMon);
                        cmd.Parameters.AddWithValue("@loai", loaiMon);
                        cmd.Parameters.AddWithValue("@gia", giaBan);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin món ăn thành công rồi ! 🥰", "Thành công");
                            btnLamMoi_Click(sender, e); 
                            HienThiDanhSachMonAn(); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa món rồi admin ơi: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMon = txtMaMon.Text.Trim();

            if (string.IsNullOrEmpty(maMon))
            {
                MessageBox.Show("Vui lòng chọn món ăn từ bảng dưới đây để xóa nhe!", "Thông báo");
                return;
            }

            
            DialogResult dr = MessageBox.Show($"admincó chắc chắn muốn xóa món {maMon} ra khỏi thực đơn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(chuoiSql))
                    {
                        conn.Open();
                        
                        string sql = "DELETE FROM MonAn WHERE MaMon = @ma";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ma", maMon);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Đã xóa món ăn thành công mỹ mãn! 🧼", "Thành công");
                                btnLamMoi_Click(sender, e); 
                                HienThiDanhSachMonAn();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không xóa được món rồi admin ơi! Lỗi: " + ex.Message, "Thông báo lỗi");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtGiaTien.Clear();
            if (cbDanhMuc.Items.Count > 0) cbDanhMuc.SelectedIndex = 0; 

            txtMaMon.ReadOnly = false; 
            txtMaMon.Focus(); 
        }
    }
}