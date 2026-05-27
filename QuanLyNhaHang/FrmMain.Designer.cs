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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngKysToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMónĂnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKhoToolStripMenuItem = new ToolStripMenuItem();
            đặtBànToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýMónĂnToolStripMenuItem, quảnLýKhoToolStripMenuItem, đặtBànToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngKysToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(224, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // đăngKysToolStripMenuItem
            // 
            đăngKysToolStripMenuItem.Name = "đăngKysToolStripMenuItem";
            đăngKysToolStripMenuItem.Size = new Size(224, 26);
            đăngKysToolStripMenuItem.Text = "Đăng Ký";
            đăngKysToolStripMenuItem.Click += đăngKysToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // quảnLýMónĂnToolStripMenuItem
            // 
            quảnLýMónĂnToolStripMenuItem.Name = "quảnLýMónĂnToolStripMenuItem";
            quảnLýMónĂnToolStripMenuItem.Size = new Size(131, 24);
            quảnLýMónĂnToolStripMenuItem.Text = "Quản Lý Món Ăn";
            quảnLýMónĂnToolStripMenuItem.Click += quảnLýMónĂnToolStripMenuItem_Click;
            // 
            // quảnLýKhoToolStripMenuItem
            // 
            quảnLýKhoToolStripMenuItem.Name = "quảnLýKhoToolStripMenuItem";
            quảnLýKhoToolStripMenuItem.Size = new Size(105, 24);
            quảnLýKhoToolStripMenuItem.Text = "Quản Lý Kho";
            quảnLýKhoToolStripMenuItem.Click += quảnLýKhoToolStripMenuItem_Click;
            // 
            // đặtBànToolStripMenuItem
            // 
            đặtBànToolStripMenuItem.Name = "đặtBànToolStripMenuItem";
            đặtBànToolStripMenuItem.Size = new Size(76, 24);
            đặtBànToolStripMenuItem.Text = "Đặt Bàn";
            đặtBànToolStripMenuItem.Click += đặtBànToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýMónĂnToolStripMenuItem;
        private ToolStripMenuItem quảnLýKhoToolStripMenuItem;
        private ToolStripMenuItem đặtBànToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngKysToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}
