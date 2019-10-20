namespace Library.WinUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verilenKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.kitapToolStripMenuItem,
            this.ödünçKitaplarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtToolStripMenuItem,
            this.öğrenciDüzenlemeToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.öğrenciToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.öğrenciKayıtToolStripMenuItem.Text = "Öğrenci Kayıt";
            this.öğrenciKayıtToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKayıtToolStripMenuItem_Click);
            // 
            // öğrenciDüzenlemeToolStripMenuItem
            // 
            this.öğrenciDüzenlemeToolStripMenuItem.Name = "öğrenciDüzenlemeToolStripMenuItem";
            this.öğrenciDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.öğrenciDüzenlemeToolStripMenuItem.Text = "Öğrenci Düzenleme";
            this.öğrenciDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.öğrenciDüzenlemeToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKayıtToolStripMenuItem,
            this.kitapDüzenlemeToolStripMenuItem,
            this.kitapRaporuToolStripMenuItem});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.kitapToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapKayıtToolStripMenuItem
            // 
            this.kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            this.kitapKayıtToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.kitapKayıtToolStripMenuItem.Text = "Kitap Kayıt";
            this.kitapKayıtToolStripMenuItem.Click += new System.EventHandler(this.kitapKayıtToolStripMenuItem_Click);
            // 
            // kitapDüzenlemeToolStripMenuItem
            // 
            this.kitapDüzenlemeToolStripMenuItem.Name = "kitapDüzenlemeToolStripMenuItem";
            this.kitapDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.kitapDüzenlemeToolStripMenuItem.Text = "Kitap düzenleme";
            this.kitapDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.kitapDüzenlemeToolStripMenuItem_Click);
            // 
            // ödünçKitaplarToolStripMenuItem
            // 
            this.ödünçKitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİşlemToolStripMenuItem,
            this.verilenKitaplarToolStripMenuItem});
            this.ödünçKitaplarToolStripMenuItem.Name = "ödünçKitaplarToolStripMenuItem";
            this.ödünçKitaplarToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.ödünçKitaplarToolStripMenuItem.Text = "Ödünç İşlemleri";
            // 
            // yeniİşlemToolStripMenuItem
            // 
            this.yeniİşlemToolStripMenuItem.Name = "yeniİşlemToolStripMenuItem";
            this.yeniİşlemToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.yeniİşlemToolStripMenuItem.Text = "Yeni İşlem";
            this.yeniİşlemToolStripMenuItem.Click += new System.EventHandler(this.yeniİşlemToolStripMenuItem_Click);
            // 
            // verilenKitaplarToolStripMenuItem
            // 
            this.verilenKitaplarToolStripMenuItem.Name = "verilenKitaplarToolStripMenuItem";
            this.verilenKitaplarToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.verilenKitaplarToolStripMenuItem.Text = "Verilen Kitaplar";
            this.verilenKitaplarToolStripMenuItem.Click += new System.EventHandler(this.verilenKitaplarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kitapRaporuToolStripMenuItem
            // 
            this.kitapRaporuToolStripMenuItem.Name = "kitapRaporuToolStripMenuItem";
            this.kitapRaporuToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.kitapRaporuToolStripMenuItem.Text = "Kitap Raporu";
            this.kitapRaporuToolStripMenuItem.Click += new System.EventHandler(this.kitapRaporuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 592);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verilenKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapRaporuToolStripMenuItem;
    }
}

