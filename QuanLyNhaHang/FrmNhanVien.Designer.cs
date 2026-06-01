namespace QuanLyNhaHang
{
    partial class FrmNhanVien
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
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            cboChucVu = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnThemNV = new Button();
            btnXoaNV = new Button();
            dgvNhanVien = new DataGridView();
            panel1 = new Panel();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 33);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(181, 124);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(92, 27);
            txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(181, 177);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(152, 27);
            txtTenNV.TabIndex = 2;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(181, 224);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(107, 28);
            cboChucVu.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 124);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 4;
            label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 176);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 5;
            label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 227);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 6;
            label4.Text = "Chức vụ:";
            // 
            // btnThemNV
            // 
            btnThemNV.BackColor = Color.FromArgb(0, 192, 0);
            btnThemNV.Location = new Point(47, 290);
            btnThemNV.Name = "btnThemNV";
            btnThemNV.Size = new Size(129, 39);
            btnThemNV.TabIndex = 7;
            btnThemNV.Text = "Thêm Nhân Viên\r\n";
            btnThemNV.UseVisualStyleBackColor = false;
            btnThemNV.Click += btnThemNV_Click_1;
            // 
            // btnXoaNV
            // 
            btnXoaNV.BackColor = Color.Red;
            btnXoaNV.Location = new Point(214, 290);
            btnXoaNV.Name = "btnXoaNV";
            btnXoaNV.Size = new Size(119, 39);
            btnXoaNV.TabIndex = 8;
            btnXoaNV.Text = "Xóa Nhân Viên";
            btnXoaNV.UseVisualStyleBackColor = false;
            btnXoaNV.Click += btnXoaNV_Click_1;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(361, 104);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(439, 346);
            dgvNhanVien.TabIndex = 9;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 108);
            panel1.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(145, 409);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(panel1);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnXoaNV);
            Controls.Add(btnThemNV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboChucVu);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            Load += FrmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private ComboBox cboChucVu;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnThemNV;
        private Button btnXoaNV;
        private DataGridView dgvNhanVien;
        private Panel panel1;
        private Button btnThoat;
    }
}