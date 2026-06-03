using Microsoft.Data.SqlClient; // Thư viện NuGet bbi vừa cài xịn sò lúc nãy nè
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyNhaHang
{
    public partial class FrmMonAn : Form
    {
        // Chuỗi kết nối chuẩn đồng bộ trỏ thẳng sang SQL Server máy 
        string chuoiSql = @"Data Source=.;Initial Catalog=QuanLyNhaHangLau;Integrated Security=True;Encrypt=False";

        public FrmMonAn()
        {
            InitializeComponent();
        }

        // Sự kiện tự động kích hoạt ngay khi Form Món Ăn vừa được load lên màn hình
        private void FrmMonAn_Load(object sender, EventArgs e)
        {
            HienThiDanhSachMonAn();
        }

        // Hàm kết nối SQL Server và lấy danh mục món ăn đổ vào bảng lưới DataGridView
        public void HienThiDanhSachMonAn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(chuoiSql))
                {
                    conn.Open();

                    // Câu lệnh SQL lấy toàn bộ thực đơn lẩu từ database
                    string sql = "SELECT MaMon AS [Mã Món], TenMon AS [Tên Món Ăn], LoaiMon AS [Loại], GiaBan AS [Giá Bán], TrangThai AS [Trạng Thái] FROM MonAn";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt); // Tải dữ liệu vào bảng tạm trong bộ nhớ

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

                // Điền dữ liệu từ các cột dưới bảng lên các ô TextBox ở trên
                txtMaMon.Text = row.Cells["MaMon"].Value.ToString();
                txtTenMon.Text = row.Cells["TenMon"].Value.ToString();
                txtGiaTien.Text = row.Cells["GiaBan"].Value.ToString();
                cbDanhMuc.Text = row.Cells["LoaiMon"].Value.ToString();

                // Khóa ô Mã món lại không cho sửa (vì mã món là Khóa chính, không được thay đổi)
                txtMaMon.ReadOnly = true;
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            // Bbi xem tên hàm máy vừa sinh ra là gì thì giữ nguyên tên hàm đó,
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
                                HienThiDanhSachMonAn(); // Gọi lại hàm load để bảng lưới cập nhật liền
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
                    // Câu lệnh UPDATE SQL để sửa thông tin dựa theo Mã món
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
                            btnLamMoi_Click(sender, e); // Gọi hàm làm mới để xóa sạch chữ và mở khóa ô Mã món
                            HienThiDanhSachMonAn(); // Hàm load lại bảng lưới của bbi nhe
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

            // Hiện hộp thoại hỏi bbi xem có chắc chắn muốn xóa không nhe
            DialogResult dr = MessageBox.Show($"admincó chắc chắn muốn xóa món {maMon} ra khỏi thực đơn không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(chuoiSql))
                    {
                        conn.Open();
                        // Câu lệnh DELETE SQL
                        string sql = "DELETE FROM MonAn WHERE MaMon = @ma";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@ma", maMon);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Đã xóa món ăn thành công mỹ mãn! 🧼", "Thành công");
                                btnLamMoi_Click(sender, e); // Làm mới lại các ô nhập dữ liệu
                                HienThiDanhSachMonAn(); // Tải lại bảng lưới
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
            if (cbDanhMuc.Items.Count > 0) cbDanhMuc.SelectedIndex = 0; // Đưa combobox về món đầu tiên

            txtMaMon.ReadOnly = false; 
            txtMaMon.Focus(); // Đưa con trỏ chuột tự động nhảy vào ô Mã món luôn nhe
        }
    }
}