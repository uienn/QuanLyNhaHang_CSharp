namespace QuanLyNhaHang
{
    partial class FrmDangNhap
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
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            label2 = new Label();
            btnDangNhap = new Button();
            label4 = new Label();
            label3 = new Label();
            txtSoBan = new TextBox();
            btnThoat = new Button();
            lnkDangKy = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 155);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản Admin:\r\n";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(381, 155);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(125, 27);
            txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(381, 203);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 203);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(350, 325);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(119, 39);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(304, 70);
            label4.Name = "label4";
            label4.Size = new Size(227, 46);
            label4.TabIndex = 6;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 259);
            label3.Name = "label3";
            label3.Size = new Size(230, 25);
            label3.TabIndex = 7;
            label3.Text = "Nhập số bàn để gọi món :";
            // 
            // txtSoBan
            // 
            txtSoBan.Location = new Point(381, 257);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(125, 27);
            txtSoBan.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(694, 409);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.Location = new Point(302, 409);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(229, 20);
            lnkDangKy.TabIndex = 10;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Chưa có tài khoản? Đăng kí ngay.";
            lnkDangKy.LinkClicked += lnkDangKy_LinkClicked;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkDangKy);
            Controls.Add(btnThoat);
            Controls.Add(txtSoBan);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(label2);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label1);
            Name = "FrmDangNhap";
            Text = "FrmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Label label2;
        private Button btnDangNhap;
        private Label label4;
        private Label label3;
        private TextBox txtSoBan;
        private Button btnThoat;
        private LinkLabel lnkDangKy;
    }
}