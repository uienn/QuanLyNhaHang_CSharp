namespace QuanLyNhaHang
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.ShowDialog();
        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonAn frm = new FrmMonAn();
            frm.ShowDialog();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKho frm = new FrmKho();
            frm.ShowDialog();
        }

        private void đặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại thông báo số Hotline đặt bàn của nhà hàng 
            MessageBox.Show(
                "🍲 NHÀ HÀNG LẨU KICHI HÂN HẠNH PHỤC VỤ QUÝ KHÁCH! 🍲\n\n" +
                "📞 Hotline đặt bàn giữ chỗ trước: 0867.050.507" +
                "✨ (Vui lòng gọi trước 30 phút để nhà hàng chuẩn bị nước lẩu và không gian tốt nhất cho quý khách nhé!)",
                "LIÊN HỆ ĐẶT BÀN",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void đăngKysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form chính đi
            FrmDangNhap frm = new FrmDangNhap();
            frm.ShowDialog();
            this.Close(); // Đóng hẳn form chính khi form đăng nhập tắt
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show((Button)sender, new Point(0, ((Button)sender).Height));
        }
        // Hàm dành cho Quản lý: Bật hết các tính năng lên để sử dụng
        public void MoKhoaTatCaChucNang()
        {
            // Bạn kiểm tra lại tên (Name) chính xác của các nút trên Menu của bạn để sửa lại nếu bị đỏ nha
            button2.Enabled = true;
            button3.Enabled = true;
            btnDatBan.Enabled = true;
        }

        // Hàm dành cho Khách hàng: Khóa chức năng quản lý, chỉ cho đặt bàn / gọi món
        public void CauHinhGiaoDienKhachHang()
        {
            button2.Enabled = false; // Khách không được xem/sửa món ăn
            button3.Enabled = false;   // Khách không được xem kho
            btnDatBan.Enabled = true;      // Khách được quyền đặt bàn và gọi món

            // Tự động mở thẳng Form Gọi Món (FrmDatBan) lên cho khách thao tác luôn
            đặtBànToolStripMenuItem_Click(null, null);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo riêng một Form Hóa Đơn mới tinh
            FrmHoaDon fHoaDon = new FrmHoaDon();

            // 2. Ép nó hiển thị bật lên thành một cửa sổ độc lập hoàn toàn
            fHoaDon.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo riêng một Form Nhân Viên mới tinh
            FrmNhanVien fNhanVien = new FrmNhanVien();

            // 2. Ép nó hiển thị bật lên thành một cửa sổ độc lập hoàn toàn
            fNhanVien.ShowDialog();
        }
    }
}
