using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmKho : Form
    {
        // 1. Tạo danh sách quản lý phiếu nhập kho hàng tồn
        private List<PhieuNhapKho> danhSachPhieuNhap = new List<PhieuNhapKho>();

        public FrmKho()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                KhoiTaoDuLieuMau();
                HienThiDanhSachLenBang();
            }
        }

        // 2. Khởi tạo dữ liệu mẫu hàng tồn ban đầu cho nhà hàng lẩu
        private void KhoiTaoDuLieuMau()
        {
            danhSachPhieuNhap.Add(new PhieuNhapKho { MaHDN = "PN001", TenNCC = "NCC Thịt Bò Mỹ Cường Thịnh", TenNhanVien = "Nguyễn Văn A" });
            danhSachPhieuNhap.Add(new PhieuNhapKho { MaHDN = "PN002", TenNCC = "NCC Hải Sản Tươi HueFoods", TenNhanVien = "Trần Thị B" });

            // Nạp dữ liệu vào ComboBox Nhà Cung Cấp
            cboNhaCungCap.Items.Add("NCC Thịt Bò Mỹ Cường Thịnh");
            cboNhaCungCap.Items.Add("NCC Hải Sản Tươi HueFoods");
            cboNhaCungCap.Items.Add("NCC Nấm Rau Sạch Đà Lạt");
            cboNhaCungCap.SelectedIndex = 0;

            // Nạp dữ liệu vào ComboBox Nhân Viên
            cboNhanVien.Items.Add("Nguyễn Văn A");
            cboNhanVien.Items.Add("Trần Thị B");
            cboNhanVien.SelectedIndex = 0;
        }

        // 3. Đẩy danh sách lên DataGridView và căn chỉnh tiêu đề tiếng Việt
        private void HienThiDanhSachLenBang()
        {
            dgvKhoHang.DataSource = null;
            dgvKhoHang.DataSource = danhSachPhieuNhap;

            if (dgvKhoHang.Columns["MaHDN"] != null) dgvKhoHang.Columns["MaHDN"].HeaderText = "Mã Hóa Đơn Nhập";
            if (dgvKhoHang.Columns["TenNCC"] != null) dgvKhoHang.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            if (dgvKhoHang.Columns["TenNhanVien"] != null) dgvKhoHang.Columns["TenNhanVien"].HeaderText = "Nhân Viên Nhập";
        }

        // 4. Nút THÊM: Xóa trắng ô nhập để chuẩn bị gõ phiếu mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHDN.Clear();
            txtMaHDN.Focus();
        }

        // 5. Nút LƯU: Lưu phiếu mới hoặc Cập nhật phiếu cũ sau khi Sửa
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHDN.Text))
            {
                MessageBox.Show("Bbi ơi, vui lòng nhập Mã hóa đơn nhập đã nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã này đã tồn tại trong kho chưa (Nếu có thì là đang SỬA, nếu chưa thì là THÊM MỚI)
            var phieuTonTai = danhSachPhieuNhap.FirstOrDefault(p => p.MaHDN.Trim().ToLower() == txtMaHDN.Text.Trim().ToLower());

            if (phieuTonTai != null)
            {
                // Cập nhật lại thông tin hàng tồn kho cũ
                phieuTonTai.TenNCC = cboNhaCungCap.SelectedItem.ToString();
                phieuTonTai.TenNhanVien = cboNhanVien.SelectedItem.ToString();
                MessageBox.Show("Đã cập nhật thay đổi phiếu nhập kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới hoàn toàn một phiếu nhập kho
                PhieuNhapKho phieuMoi = new PhieuNhapKho
                {
                    MaHDN = txtMaHDN.Text.Trim(),
                    TenNCC = cboNhaCungCap.SelectedItem.ToString(),
                    TenNhanVien = cboNhanVien.SelectedItem.ToString()
                };
                danhSachPhieuNhap.Add(phieuMoi);
                MessageBox.Show("Đã lưu phiếu nhập kho hàng mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            HienThiDanhSachLenBang();
        }

        // 6. Nút SỬA: Đưa con trỏ vào ô để chỉnh sửa thông tin hàng hóa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhoHang.CurrentRow != null)
            {
                txtMaHDN.Text = dgvKhoHang.CurrentRow.Cells["MaHDN"].Value.ToString();
                MessageBox.Show("Bbi hãy chọn lại Nhà cung cấp hoặc Nhân viên ở dưới rồi bấm nút [Lưu] để hoàn tất sửa đổi nha!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trên bảng danh sách để sửa bbi ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 7. Nút XÓA: Loại bỏ phiếu nhập ra khỏi danh sách quản lý tồn kho
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoHang.CurrentRow != null)
            {
                string maXoa = dgvKhoHang.CurrentRow.Cells["MaHDN"].Value.ToString();

                DialogResult r = MessageBox.Show($"Bbi có chắc chắn muốn xóa phiếu nhập {maXoa} này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    var phieuXoa = danhSachPhieuNhap.FirstOrDefault(p => p.MaHDN == maXoa);
                    if (phieuXoa != null)
                    {
                        danhSachPhieuNhap.Remove(phieuXoa);
                        HienThiDanhSachLenBang();
                        txtMaHDN.Clear();
                        MessageBox.Show("Đã xóa phiếu nhập thành công khỏi hệ thống kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một dòng trên bảng để xóa nhe bbi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 8. Sự kiện Click dòng trên bảng tự nhảy thông tin xuống dưới ô nhập
        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKhoHang.Rows[e.RowIndex].Cells["MaHDN"].Value != null)
            {
                DataGridViewRow row = dgvKhoHang.Rows[e.RowIndex];
                txtMaHDN.Text = row.Cells["MaHDN"].Value.ToString();

                if (cboNhaCungCap.Items.Contains(row.Cells["TenNCC"].Value.ToString()))
                    cboNhaCungCap.SelectedItem = row.Cells["TenNCC"].Value.ToString();

                if (cboNhanVien.Items.Contains(row.Cells["TenNhanVien"].Value.ToString()))
                    cboNhanVien.SelectedItem = row.Cells["TenNhanVien"].Value.ToString();
            }
        }

        // 9. Nút THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }
    }

    // Cấu trúc mô phỏng dữ liệu phiếu nhập kho hàng tồn
    public class PhieuNhapKho
    {
        public string MaHDN { get; set; }
        public string TenNCC { get; set; }
        public string TenNhanVien { get; set; }
    }
}