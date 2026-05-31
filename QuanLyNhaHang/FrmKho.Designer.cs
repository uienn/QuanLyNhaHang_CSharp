namespace QuanLyNhaHang
{
    partial class FrmKho
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
            groupBox1 = new GroupBox();
            btnChiTiet = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dgvKhoHang = new DataGridView();
            groupBox3 = new GroupBox();
            label4 = new Label();
            cboNhanVien = new ComboBox();
            cboNhaCungCap = new ComboBox();
            label3 = new Label();
            txtMaHDN = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhoHang).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 41);
            label1.TabIndex = 0;
            label1.Text = "NHẬP HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.NavajoWhite;
            groupBox1.Controls.Add(btnChiTiet);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(632, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 405);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnChiTiet
            // 
            btnChiTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChiTiet.Location = new Point(27, 320);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(103, 51);
            btnChiTiet.TabIndex = 2;
            btnChiTiet.Text = "📑 Chi Tiết Phiếu Nhập";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(27, 267);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "➡️ Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(27, 214);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 35);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "❌ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(27, 159);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(103, 36);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "💾 Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(27, 102);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 36);
            btnSua.TabIndex = 1;
            btnSua.Text = "📝 Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(27, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 38);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.NavajoWhite;
            groupBox2.Controls.Add(dgvKhoHang);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(33, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 184);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách";
            // 
            // dgvKhoHang
            // 
            dgvKhoHang.BackgroundColor = Color.White;
            dgvKhoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoHang.Dock = DockStyle.Fill;
            dgvKhoHang.Location = new Point(3, 27);
            dgvKhoHang.Name = "dgvKhoHang";
            dgvKhoHang.RowHeadersWidth = 51;
            dgvKhoHang.Size = new Size(566, 154);
            dgvKhoHang.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.NavajoWhite;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cboNhanVien);
            groupBox3.Controls.Add(cboNhaCungCap);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtMaHDN);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(33, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(572, 176);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông Tin Phiếu Phập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 129);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên nhân viên :\r\n";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(223, 126);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 33);
            cboNhanVien.TabIndex = 4;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(223, 80);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(151, 33);
            cboNhaCungCap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 83);
            label3.Name = "label3";
            label3.Size = new Size(171, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên nhà cung cấp :\r\n";
            // 
            // txtMaHDN
            // 
            txtMaHDN.Location = new Point(223, 36);
            txtMaHDN.Name = "txtMaHDN";
            txtMaHDN.Size = new Size(125, 31);
            txtMaHDN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 43);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn nhập :\r\n";
            // 
            // FrmKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmKho";
            Text = "FrmKho";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhoHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private Button button3;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dgvKhoHang;
        private Label label2;
        private System.Windows.Forms.Button btnChiTiet;
        private ComboBox cboNhaCungCap;
        private Label label3;
        private TextBox txtMaHDN;
        private Label label4;
        private ComboBox cboNhanVien;
    }
}