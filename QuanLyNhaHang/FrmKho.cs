using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FrmKho : Form
    {
        
        DataTable dtTongKho = new DataTable();

        public FrmKho()
        {
            InitializeComponent();
        }

       
        private void FrmKho_Load(object sender, EventArgs e)
        {
            
            dtTongKho.Columns.Add("Mã Hàng");
            dtTongKho.Columns.Add("Tên Mặt Hàng");
            dtTongKho.Columns.Add("Số Lượng Tồn", typeof(double));
            dtTongKho.Columns.Add("Trạng Thái");
            dgvTongKho.DataSource = dtTongKho;

            
            dtTongKho.Rows.Add("SP01", "Thịt bò Mỹ", 10.0, "");
            dtTongKho.Rows.Add("SP02", "Rau xà lách", 2.0, ""); 
            dtTongKho.Rows.Add("SP03", "Hải sản tươi", 15.0, "");

            
            cboMatHang.Items.Clear();
            foreach (DataRow row in dtTongKho.Rows)
            {
                cboMatHang.Items.Add(row["Tên Mặt Hàng"].ToString());
            }

            dgvTongKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CapNhatTrangThaiKho();
        }

        private void btnXacNhanNhap_Click(object sender, EventArgs e)
        {
            
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

            foreach (DataRow row in dtTongKho.Rows)
            {
                if (row["Tên Mặt Hàng"].ToString() == tenHangChon)
                {
                    double tonHienTai = Convert.ToDouble(row["Số Lượng Tồn"]);

                    
                    row["Số Lượng Tồn"] = tonHienTai + soLuongNhapThem;

                    timThay = true;
                    break;
                }
            }

            if (timThay)
            {
                MessageBox.Show($"Đã nhập thêm {soLuongNhapThem} vào mặt hàng '{tenHangChon}'. Tồn kho đã tự động cộng dồn!", "Thành công");

                
                txtSoLuongNhap.Clear();
                cboMatHang.SelectedIndex = -1;

                
                CapNhatTrangThaiKho();
            }
        }

        
        private void CapNhatTrangThaiKho()
        {
            foreach (DataGridViewRow gridRow in dgvTongKho.Rows)
            {
                if (gridRow.Cells["Số Lượng Tồn"].Value != null)
                {
                    double tonKho = Convert.ToDouble(gridRow.Cells["Số Lượng Tồn"].Value);

                    
                    if (tonKho <= 5.0)
                    {
                        gridRow.Cells["Trạng Thái"].Value = "Sắp hết hàng!";
                        gridRow.DefaultCellStyle.BackColor = Color.MistyRose; 
                        gridRow.DefaultCellStyle.ForeColor = Color.Red;       
                    }
                    else
                    {
                        gridRow.Cells["Trạng Thái"].Value = "An toàn (Đủ tồn)";
                        gridRow.DefaultCellStyle.BackColor = Color.White;    
                        gridRow.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        
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
