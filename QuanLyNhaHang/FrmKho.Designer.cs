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
            cboMatHang = new ComboBox();
            txtSoLuongNhap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnXacNhanNhap = new Button();
            btnThoat = new Button();
            dgvTongKho = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTongKho).BeginInit();
            SuspendLayout();
            // 
            // cboMatHang
            // 
            cboMatHang.FormattingEnabled = true;
            cboMatHang.Location = new Point(183, 75);
            cboMatHang.Name = "cboMatHang";
            cboMatHang.Size = new Size(151, 28);
            cboMatHang.TabIndex = 0;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Location = new Point(183, 109);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(125, 27);
            txtSoLuongNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 83);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Chọn mặt hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 109);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Số lượng nhập:";
            // 
            // btnXacNhanNhap
            // 
            btnXacNhanNhap.Location = new Point(600, 74);
            btnXacNhanNhap.Name = "btnXacNhanNhap";
            btnXacNhanNhap.Size = new Size(122, 29);
            btnXacNhanNhap.TabIndex = 4;
            btnXacNhanNhap.Text = "Xác Nhận Nhập";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            btnXacNhanNhap.Click += btnXacNhanNhap_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(615, 109);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // dgvTongKho
            // 
            dgvTongKho.BackgroundColor = Color.White;
            dgvTongKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongKho.Location = new Point(-1, 144);
            dgvTongKho.Name = "dgvTongKho";
            dgvTongKho.RowHeadersWidth = 51;
            dgvTongKho.Size = new Size(802, 305);
            dgvTongKho.TabIndex = 6;
            dgvTongKho.CellClick += dgvTongKho_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 9);
            label3.Name = "label3";
            label3.Size = new Size(221, 41);
            label3.TabIndex = 7;
            label3.Text = "QUẢN LÝ KHO";
            // 
            // FrmKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dgvTongKho);
            Controls.Add(btnThoat);
            Controls.Add(btnXacNhanNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoLuongNhap);
            Controls.Add(cboMatHang);
            Name = "FrmKho";
            Text = "FrmKho";
            Load += FrmKho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTongKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMatHang;
        private TextBox txtSoLuongNhap;
        private Label label1;
        private Label label2;
        private Button btnXacNhanNhap;
        private Button btnThoat;
        private DataGridView dgvTongKho;
        private Label label3;
    }
}