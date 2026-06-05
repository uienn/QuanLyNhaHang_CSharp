namespace QuanLyNhaHang
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnQuanLyNhanVien = new Button();
            btnHoaDon = new Button();
            btnDatBan = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            đăngKýToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            panelContent = new Panel();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(btnQuanLyNhanVien);
            panel1.Controls.Add(btnHoaDon);
            panel1.Controls.Add(btnDatBan);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 455);
            panel1.TabIndex = 1;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.BackColor = Color.SkyBlue;
            btnQuanLyNhanVien.Dock = DockStyle.Top;
            btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            btnQuanLyNhanVien.FlatStyle = FlatStyle.Flat;
            btnQuanLyNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLyNhanVien.Location = new Point(0, 175);
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(230, 35);
            btnQuanLyNhanVien.TabIndex = 5;
            btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên\r\n";
            btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            btnQuanLyNhanVien.Click += button4_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.SkyBlue;
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoaDon.Location = new Point(0, 140);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(230, 35);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "\U0001f9fe Hóa Đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnDatBan
            // 
            btnDatBan.BackColor = Color.SkyBlue;
            btnDatBan.Dock = DockStyle.Top;
            btnDatBan.FlatAppearance.BorderSize = 0;
            btnDatBan.FlatStyle = FlatStyle.Flat;
            btnDatBan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatBan.Location = new Point(0, 105);
            btnDatBan.Name = "btnDatBan";
            btnDatBan.Size = new Size(230, 35);
            btnDatBan.TabIndex = 3;
            btnDatBan.Text = "\U0001fa91 Đặt Bàn";
            btnDatBan.UseVisualStyleBackColor = false;
            btnDatBan.Click += đặtBànToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 70);
            button3.Name = "button3";
            button3.Size = new Size(230, 35);
            button3.TabIndex = 2;
            button3.Text = "📦 Quản Lý Kho";
            button3.UseVisualStyleBackColor = false;
            button3.Click += quảnLýKhoToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 35);
            button2.Name = "button2";
            button2.Size = new Size(230, 35);
            button2.TabIndex = 1;
            button2.Text = "🍲 Quản Lý Món Ăn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += quảnLýMónĂnToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(230, 35);
            button1.TabIndex = 0;
            button1.Text = "🏠 Trang Chủ\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { đăngKýToolStripMenuItem, đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(178, 124);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // đăngKýToolStripMenuItem
            // 
            đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            đăngKýToolStripMenuItem.Size = new Size(177, 30);
            đăngKýToolStripMenuItem.Text = "Đăng Ký";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(177, 30);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(177, 30);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(177, 30);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(230, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(572, 455);
            panelContent.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 455);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "FrmMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button btnDatBan;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem đăngKýToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Button btnHoaDon;
        private Panel panelContent;
        private Button btnQuanLyNhanVien;
    }
}
