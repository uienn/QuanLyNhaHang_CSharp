using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmKho : Form
    {
        // Bảng dữ liệu cốt lõi quản lý Tổng Kho Hàng
        DataTable dtTongKho = new DataTable();

        public FrmKho()
        {
            InitializeComponent();
        }

        // 1. Khởi tạo dữ liệu Tổng Kho ban đầu khi mở Form
        private void FrmKho_Load(object sender, EventArgs e)
        {
            // Thiết lập các cột cho bảng quản lý tổng thể
            dtTongKho.Columns.Add("Mã Hàng");
            dtTongKho.Columns.Add("Tên Mặt Hàng");
            dtTongKho.Columns.Add("Số Lượng Tồn", typeof(double));
            dtTongKho.Columns.Add("Trạng Thái");
            dgvTongKho.DataSource = dtTongKho;

            // Nạp dữ liệu gốc ban đầu của nhà hàng (Mã, Tên, Tồn kho hiện tại)
            dtTongKho.Rows.Add("SP01", "Thịt bò Mỹ", 10.0, "");
            dtTongKho.Rows.Add("SP02", "Rau xà lách", 2.0, ""); // Tồn quá ít
            dtTongKho.Rows.Add("SP03", "Hải sản tươi", 15.0, "");

            // Đổ danh sách tên mặt hàng vào ComboBox để nhân viên chọn khi nhập kho
            cboMatHang.Items.Clear();
            foreach (DataRow row in dtTongKho.Rows)
            {
                cboMatHang.Items.Add(row["Tên Mặt Hàng"].ToString());
            }

            dgvTongKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CapNhatTrangThaiKho();
        }

        // 2. LOGIC QUAN TRỌNG: Nhập hàng và tự động cập nhật số lượng tồn kho
        private void btnXacNhanNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn món và nhập số lượng chưa
            if (cboMatHang.SelectedIndex == -1 || string.IsNullOrEmpty(txtSoLuongNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn Mặt hàng và nhập Số lượng muốn nhập kho!", "Thông báo");
                return;
            }

            double soLuongNhapThem = 0;
            if (!double.TryParse(txtSoLuongNhap.Text, out soLuongNhapThem) || soLuongNhapThem <= 0)
            {
                MessageBox.Show("Số lượng nhập kho phải là một số lớn hơn 0!", "Lỗi nhập liệu");
                return;
            }

            string tenHangChon = cboMatHang.Text;
            bool timThay = false;

            // Duyệt qua toàn bộ kho để tìm mặt hàng vừa chọn nhập
            foreach (DataRow row in dtTongKho.Rows)
            {
                if (row["Tên Mặt Hàng"].ToString() == tenHangChon)
                {
                    // Lấy số lượng tồn cũ ra
                    double tonHienTai = Convert.ToDouble(row["Số Lượng Tồn"]);

                    // CẬP NHẬT TỒN KHO: Tồn mới = Tồn cũ + Số lượng vừa nhập thêm
                    row["Số Lượng Tồn"] = tonHienTai + soLuongNhapThem;

                    timThay = true;
                    break;
                }
            }

            if (timThay)
            {
                MessageBox.Show($"Đã nhập thêm {soLuongNhapThem} vào mặt hàng '{tenHangChon}'. Tồn kho đã tự động cộng dồn!", "Thành công");

                // Reset ô nhập liệu để sẵn sàng nhập món khác
                txtSoLuongNhap.Clear();
                cboMatHang.SelectedIndex = -1;

                // Quét lại kho để cập nhật cảnh báo hết hàng hoặc đủ hàng
                CapNhatTrangThaiKho();
            }
        }

        // 3. Tự động kiểm tra lượng tồn để đưa ra cảnh báo trực quan
        private void CapNhatTrangThaiKho()
        {
            foreach (DataGridViewRow gridRow in dgvTongKho.Rows)
            {
                if (gridRow.Cells["Số Lượng Tồn"].Value != null)
                {
                    double tonKho = Convert.ToDouble(gridRow.Cells["Số Lượng Tồn"].Value);

                    // Quy định: Nếu mặt hàng nào tồn dưới 5 ký/lít -> Báo động sắp hết
                    if (tonKho <= 5.0)
                    {
                        gridRow.Cells["Trạng Thái"].Value = "Sắp hết hàng!";
                        gridRow.DefaultCellStyle.BackColor = Color.MistyRose; // Tô nền hồng
                        gridRow.DefaultCellStyle.ForeColor = Color.Red;       // Chữ đỏ
                    }
                    else
                    {
                        gridRow.Cells["Trạng Thái"].Value = "An toàn (Đủ tồn)";
                        gridRow.DefaultCellStyle.BackColor = Color.White;    // Nền trắng bình thường
                        gridRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        // 4. Sự kiện click chọn dòng trong bảng kho
        private void dgvTongKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTongKho.CurrentRow != null && dgvTongKho.CurrentRow.Cells["Tên Mặt Hàng"].Value != null)
            {
                cboMatHang.Text = dgvTongKho.CurrentRow.Cells["Tên Mặt Hàng"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhanNhap_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }
    }
}
