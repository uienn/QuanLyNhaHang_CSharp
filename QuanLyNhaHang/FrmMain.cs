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
    }
}
