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
            FrmDatBan frm = new FrmDatBan();
            frm.ShowDialog();
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
            FrmDatBan frm = new FrmDatBan();
            frm.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDon());
        }
        private void OpenChildForm(Form childForm)
        {
            // 1. Cấu hình để Form con không tự biến thành cửa sổ độc lập
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // 2. Thiết lập cho Form con tự động giãn nở khít khịt với vùng chứa
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();

            // 4. Thêm Form Hóa Đơn mới vào Panel và ra lệnh hiển thị
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
