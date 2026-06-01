namespace QuanLyNhaHang
{
    partial class FrmMonAn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaMon = new TextBox();
            txtTenMon = new TextBox();
            txtGiaTien = new TextBox();
            cboLoaiMon = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvMonAn = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 12;
            label1.Text = "Mã món:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 94);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 11;
            label2.Text = "Tên món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 38);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 10;
            label3.Text = "Giá tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(400, 94);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 9;
            label4.Text = "Danh mục:";
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaMon.Location = new Point(130, 34);
            txtMaMon.Margin = new Padding(3, 4, 3, 4);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(220, 30);
            txtMaMon.TabIndex = 8;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenMon.Location = new Point(130, 90);
            txtTenMon.Margin = new Padding(3, 4, 3, 4);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(220, 30);
            txtTenMon.TabIndex = 7;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaTien.Location = new Point(500, 34);
            txtGiaTien.Margin = new Padding(3, 4, 3, 4);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(220, 30);
            txtGiaTien.TabIndex = 6;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiMon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Items.AddRange(new object[] { "Nước lẩu", "Thịt nhúng", "Đồ viên thả lẩu", "Rau nấm ăn kèm", "Mì miến ăn kèm" });
            cboLoaiMon.Location = new Point(500, 90);
            cboLoaiMon.Margin = new Padding(3, 4, 3, 4);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(220, 31);
            cboLoaiMon.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(124, 162);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 44);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm món\r\n";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.SkyBlue;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(260, 162);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 44);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa món";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Crimson;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(393, 162);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 44);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa món";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Gainsboro;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(520, 162);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 44);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // dgvMonAn
            // 
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.BackgroundColor = Color.White;
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Location = new Point(34, 238);
            dgvMonAn.Margin = new Padding(3, 4, 3, 4);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.RowHeadersWidth = 51;
            dgvMonAn.Size = new Size(686, 288);
            dgvMonAn.TabIndex = 0;
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(760, 562);
            Controls.Add(dgvMonAn);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboLoaiMon);
            Controls.Add(txtGiaTien);
            Controls.Add(txtTenMon);
            Controls.Add(txtMaMon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ DANH MỤC MÓN LẨU & MÓN ĂN KÈM";
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cboLoaiMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvMonAn;
    }
}