using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Thư viện giúp tính Sum và FirstOrDefault
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmHoaDon : Form
    {
        // 🌟 1. ĐỊNH NGHĨA CẤU TRÚC MỘT DÒNG MÓN ĂN (Cái này lúc nãy bbi thiếu nè)
        public class ChiTietMonAn
        {
            public string TenMon { get; set; }
            public int SoLuong { get; set; }
            public double DonGia { get; set; }
            public double ThanhTien => SoLuong * DonGia;
        }

        // 🌟 2. KHAI BÁO DANH SÁCH ẢO ĐỂ LƯU MÓN ĐÃ CHỌN (Cái này lúc nãy bbi cũng thiếu nè)
        List<ChiTietMonAn> danhSachMonDaChon = new List<ChiTietMonAn>();

        public FrmHoaDon()
        {
            InitializeComponent();
            NapDuLieuMonAnLenComboBox();
            TaoMaHoaDonNgauNhien();
        }

        // Hàm nạp menu Lẩu và đồ nhúng vào ComboBox
        private void NapDuLieuMonAnLenComboBox()
        {
            cboMonAn.Items.Clear();

            // --- CÁC LOẠI NƯỚC LẨU ---
            cboMonAn.Items.Add("Combo Lẩu Thái 2 Ngăn - 350000");
            cboMonAn.Items.Add("Combo Lẩu Tứ Xuyên Cay Tê - 380000");
            cboMonAn.Items.Add("Combo Lẩu Nấm Dưỡng Sinh - 320000");

            // --- ĐỒ NHÚNG THỊT / HẢI SẢN ---
            cboMonAn.Items.Add("Thịt ba chỉ bò Mỹ (Khay) - 89000");
            cboMonAn.Items.Add("Bắp bò Úc tươi (Khay) - 99000");
            cboMonAn.Items.Add("Mực trứng / Tôm tươi (Đĩa) - 120000");
            cboMonAn.Items.Add("Combo Nấm & Rau tổng hợp - 45000");
            cboMonAn.Items.Add("Đậu hũ phô mai (Hộp) - 35000");

            // --- THỨC UỐNG ---
            cboMonAn.Items.Add("Trà búp hạt chia (Ca) - 29000");
            cboMonAn.Items.Add("Coca Cola / Pepsi (Lon) - 15000");

            if (cboMonAn.Items.Count > 0) cboMonAn.SelectedIndex = 0;
        }

        private void TaoMaHoaDonNgauNhien()
        {
            Random r = new Random();
            txtMaHD.Text = "HD" + r.Next(1000, 9999).ToString();
            txtSoBan.Text = "05"; // Thử nghiệm bàn số 5
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // ⚡ 3. SỰ KIỆN: TỰ ĐỘNG NHẢY ĐƠN GIÁ KHI ĐỔI MÓN TRÊN COMBOBOX
        private void cboMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonAn.SelectedItem != null)
            {
                string[] phanTach = cboMonAn.SelectedItem.ToString().Split('-');
                if (phanTach.Length == 2)
                {
                    string giaTien = phanTach[1].Trim();
                    txtDonGia.Text = double.Parse(giaTien).ToString("N0") + " VND";
                }
            }
        }

        // ➕ 4. SỰ KIỆN: BẤM NÚT THÊM MÓN
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cboMonAn.SelectedItem == null) return;

            string[] phanTach = cboMonAn.SelectedItem.ToString().Split('-');
            string tenMon = phanTach[0].Trim();
            double donGia = double.Parse(phanTach[1].Trim());
            int soLuong = (int)txtSoLuong.Value;

            var monCoSan = danhSachMonDaChon.FirstOrDefault(x => x.TenMon == tenMon);
            if (monCoSan != null)
            {
                monCoSan.SoLuong += soLuong;
            }
            else
            {
                danhSachMonDaChon.Add(new ChiTietMonAn { TenMon = tenMon, SoLuong = soLuong, DonGia = donGia });
            }

            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = danhSachMonDaChon;

            double tongTien = danhSachMonDaChon.Sum(x => x.ThanhTien);
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        // ❌ 5. SỰ KIỆN: BẤM NÚT XÓA MÓN
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow != null)
            {
                int index = dgvChiTiet.CurrentRow.Index;
                danhSachMonDaChon.RemoveAt(index);

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = danhSachMonDaChon;

                double tongTien = danhSachMonDaChon.Sum(x => x.ThanhTien);
                txtTongTien.Text = tongTien.ToString("N0") + " VND";
            }
        }

        // 💳 6. SỰ KIỆN: BẤM NÚT THANH TOÁN
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachMonDaChon.Count == 0)
            {
                MessageBox.Show("Chưa có món ăn nào trong danh sách để thanh toán bbi ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Thanh toán thành công cho bàn số {txtSoBan.Text}!\nTổng tiền thu: {txtTongTien.Text}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            danhSachMonDaChon.Clear();
            dgvChiTiet.DataSource = null;
            txtTongTien.Clear();

            TaoMaHoaDonNgauNhien();
        }

        // 🔄 7. SỰ KIỆN: BẤM NÚT LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            danhSachMonDaChon.Clear();
            dgvChiTiet.DataSource = null;
            txtTongTien.Clear();
            txtSoLuong.Value = 1;
            if (cboMonAn.Items.Count > 0) cboMonAn.SelectedIndex = 0;

            TaoMaHoaDonNgauNhien();
        }
    }
}