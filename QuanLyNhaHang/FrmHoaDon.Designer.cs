namespace QuanLyNhaHang
{
    partial class FrmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMaHD = new TextBox();
            txtSoBan = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpNgayLap = new DateTimePicker();
            label4 = new Label();
            txtTongTien = new TextBox();
            panel1 = new Panel();
            txtDonGia = new TextBox();
            label8 = new Label();
            dgvChiTiet = new DataGridView();
            btnXoaMon = new Button();
            btnThemMon = new Button();
            txtSoLuong = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            cboMonAn = new ComboBox();
            label5 = new Label();
            btnThanhToan = new Button();
            btnLamMoi = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 75);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(131, 73);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(125, 27);
            txtMaHD.TabIndex = 1;
            // 
            // txtSoBan
            // 
            txtSoBan.Location = new Point(131, 120);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(125, 27);
            txtSoBan.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 3;
            label2.Text = "Số bàn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 169);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 4;
            label3.Text = "Ngày lập:";
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(131, 169);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 216);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 6;
            label4.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(131, 216);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dgvChiTiet);
            panel1.Controls.Add(btnXoaMon);
            panel1.Controls.Add(btnThemMon);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboMonAn);
            panel1.Location = new Point(387, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 335);
            panel1.TabIndex = 8;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(203, 122);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 122);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 7;
            label8.Text = "Đơn giá:";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(0, 167);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(401, 168);
            dgvChiTiet.TabIndex = 6;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaMon.Location = new Point(231, 12);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(97, 29);
            btnXoaMon.TabIndex = 5;
            btnXoaMon.Text = "Xóa Món";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnThemMon
            // 
            btnThemMon.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMon.Location = new Point(95, 12);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(110, 29);
            btnThemMon.TabIndex = 4;
            btnThemMon.Text = "Thêm Món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(194, 87);
            txtSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(134, 27);
            txtSoLuong.TabIndex = 3;
            txtSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 87);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 2;
            label7.Text = "Số lượng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 53);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 1;
            label6.Text = "Chọn món:";
            label6.Click += label6_Click;
            // 
            // cboMonAn
            // 
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(193, 53);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(135, 28);
            cboMonAn.TabIndex = 0;
            cboMonAn.SelectedValueChanged += cboMonAn_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(510, 26);
            label5.Name = "label5";
            label5.Size = new Size(188, 31);
            label5.TabIndex = 9;
            label5.Text = "Chi Tiết Món Ăn";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(648, 400);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(126, 38);
            btnThanhToan.TabIndex = 10;
            btnThanhToan.Text = "Thanh Toán\r\n";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(524, 400);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 38);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm Mới\r\n";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(53, 15);
            label9.Name = "label9";
            label9.Size = new Size(182, 46);
            label9.TabIndex = 12;
            label9.Text = "HÓA ĐƠN";
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThanhToan);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(txtTongTien);
            Controls.Add(label4);
            Controls.Add(dtpNgayLap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoBan);
            Controls.Add(txtMaHD);
            Controls.Add(label1);
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaHD;
        private TextBox txtSoBan;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpNgayLap;
        private Label label4;
        private TextBox txtTongTien;
        private Panel panel1;
        private Label label6;
        private ComboBox cboMonAn;
        private Label label5;
        private DataGridView dgvChiTiet;
        private Button btnXoaMon;
        private Button btnThemMon;
        private NumericUpDown txtSoLuong;
        private Label label7;
        private Button btnThanhToan;
        private Button btnLamMoi;
        private TextBox txtDonGia;
        private Label label8;
        private Label label9;
    }
}