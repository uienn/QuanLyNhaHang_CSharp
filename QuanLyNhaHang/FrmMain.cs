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
            this.Hide();
            FrmDangNhap frm = new FrmDangNhap();
            frm.ShowDialog();
            this.Close();
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

        public void MoKhoaTatCaChucNang()
        {

            button2.Enabled = true;
            button3.Enabled = true;
            btnDatBan.Enabled = true;
        }


        public void CauHinhGiaoDienKhachHang()
        {
            button2.Enabled = false; 
            button3.Enabled = false;   
            btnDatBan.Enabled = true;     

            
            đặtBànToolStripMenuItem_Click(null, null);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            
            FrmHoaDon fHoaDon = new FrmHoaDon();

            
            fHoaDon.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FrmNhanVien fNhanVien = new FrmNhanVien();

            
            fNhanVien.ShowDialog();
        }
    }
}
