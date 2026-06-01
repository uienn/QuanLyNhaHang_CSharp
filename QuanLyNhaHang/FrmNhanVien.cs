using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmNhanVien : Form
    {
        // Bảng bộ nhớ tạm lưu trữ danh sách Nhân Viên
        DataTable dtNhanVien = new DataTable();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        // 1. Khởi tạo cấu hình bảng và nạp dữ liệu mẫu ban đầu khi mở Form
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // Định nghĩa 3 cột cốt lõi cho bảng dữ liệu
            dtNhanVien.Columns.Add("Mã NV");
            dtNhanVien.Columns.Add("Tên Nhân Viên");
            dtNhanVien.Columns.Add("Chức Vụ");

            // Liên kết DataTable với cái bảng trắng bên phải của bbi
            dgvNhanVien.DataSource = dtNhanVien;

            // Nạp sẵn vài nhân viên mẫu cho nhà hàng lẩu thêm sinh động nhe bbi
            dtNhanVien.Rows.Add("NV01", "Nguyễn Văn Anh", "Quản lý");
            dtNhanVien.Rows.Add("NV02", "Trần Thị Bình", "Thu ngân");
            dtNhanVien.Rows.Add("NV03", "Lê Văn Cường", "Phục vụ");

            // Nạp danh sách các chức vụ vào ô ComboBox lựa chọn
            cboChucVu.Items.Clear();
            cboChucVu.Items.Add("Quản lý");
            cboChucVu.Items.Add("Thu ngân");
            cboChucVu.Items.Add("Đầu bếp");
            cboChucVu.Items.Add("Phục vụ");

            // Tự động giãn nở các cột cho khít khung hình
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // 2. Logic khi bấm nút "Thêm Nhân Viên"
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra bắt buộc bbi phải điền đầy đủ thông tin đầu vào
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Bbi ơi, vui lòng điền đầy đủ Mã, Tên và chọn Chức vụ cho nhân viên nha!", "Thông báo");
                return;
            }

            string maMoi = txtMaNV.Text.Trim().ToUpper();

            // THUẬT TOÁN RÀNG BUỘC: Quét kiểm tra trùng Mã nhân viên
            foreach (DataRow row in dtNhanVien.Rows)
            {
                if (row["Mã NV"].ToString() == maMoi)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại rồi bbi! Vui lòng nhập mã khác nhe.", "Lỗi trùng mã");
                    return;
                }
            }

            // Nếu mọi thứ ổn áp, tiến hành thêm dòng mới vào bảng
            dtNhanVien.Rows.Add(maMoi, txtTenNV.Text.Trim(), cboChucVu.Text);
            MessageBox.Show($"Đã thêm nhân viên '{txtTenNV.Text}' thành công!", "Thành công");

            // Dọn dẹp các ô nhập để sẵn sàng gõ người tiếp theo
            LamMoiOChon();
        }

        // 3. Logic khi bấm nút "Xóa Nhân Viên"
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem chuột đã chọn dòng nào trên bảng chưa
            if (dgvNhanVien.CurrentRow != null && dgvNhanVien.CurrentRow.Index >= 0)
            {
                string tenNV = dgvNhanVien.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();

                // Hỏi lại cho chắc ăn nè
                DialogResult dr = MessageBox.Show($"Bbi có chắc chắn muốn xóa nhân viên '{tenNV}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int index = dgvNhanVien.CurrentRow.Index;
                    dtNhanVien.Rows[index].Delete();
                    MessageBox.Show("Đã xóa nhân viên thành công khỏi hệ thống!");
                    LamMoiOChon();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một nhân viên trên bảng để xóa nhe bbi!", "Thông báo");
            }
        }

        // 4. Khi click vào dòng dưới bảng -> Đẩy ngược dữ liệu lên trên để xem
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null && dgvNhanVien.CurrentRow.Cells["Mã NV"].Value != null)
            {
                txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["Mã NV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
                cboChucVu.Text = dgvNhanVien.CurrentRow.Cells["Chức Vụ"].Value.ToString();
            }
        }

        private void LamMoiOChon()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            cboChucVu.SelectedIndex = -1;
            txtMaNV.Focus();
        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng cửa sổ nhân viên lại
        }
    }
}