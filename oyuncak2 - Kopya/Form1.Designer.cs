namespace oyuncak2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNASAYFAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MÜŞTERİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fATURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLETİŞİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dövizKuruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNASAYFAToolStripMenuItem,
            this.üRÜNLERToolStripMenuItem,
            this.MÜŞTERİLERToolStripMenuItem,
            this.sTOKToolStripMenuItem,
            this.pERSONELToolStripMenuItem,
            this.fATURAToolStripMenuItem,
            this.iLETİŞİMToolStripMenuItem,
            this.dövizKuruToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNASAYFAToolStripMenuItem
            // 
            this.aNASAYFAToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_home_page_30;
            this.aNASAYFAToolStripMenuItem.Name = "aNASAYFAToolStripMenuItem";
            this.aNASAYFAToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.aNASAYFAToolStripMenuItem.Text = "ANASAYFA";
            // 
            // üRÜNLERToolStripMenuItem
            // 
            this.üRÜNLERToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_plush_96;
            this.üRÜNLERToolStripMenuItem.Name = "üRÜNLERToolStripMenuItem";
            this.üRÜNLERToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.üRÜNLERToolStripMenuItem.Text = "ÜRÜNLER";
            this.üRÜNLERToolStripMenuItem.Click += new System.EventHandler(this.üRÜNLERToolStripMenuItem_Click);
            // 
            // MÜŞTERİLERToolStripMenuItem
            // 
            this.MÜŞTERİLERToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_male_female_user_group_961;
            this.MÜŞTERİLERToolStripMenuItem.Name = "MÜŞTERİLERToolStripMenuItem";
            this.MÜŞTERİLERToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.MÜŞTERİLERToolStripMenuItem.Text = "MÜŞTERİLER";
            this.MÜŞTERİLERToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİLERToolStripMenuItem_Click);
            // 
            // sTOKToolStripMenuItem
            // 
            this.sTOKToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_box_642;
            this.sTOKToolStripMenuItem.Name = "sTOKToolStripMenuItem";
            this.sTOKToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.sTOKToolStripMenuItem.Text = "STOK";
            this.sTOKToolStripMenuItem.Click += new System.EventHandler(this.sTOKToolStripMenuItem_Click);
            // 
            // pERSONELToolStripMenuItem
            // 
            this.pERSONELToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_personal_assistant_641;
            this.pERSONELToolStripMenuItem.Name = "pERSONELToolStripMenuItem";
            this.pERSONELToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.pERSONELToolStripMenuItem.Text = "PERSONEL";
            this.pERSONELToolStripMenuItem.Click += new System.EventHandler(this.pERSONELToolStripMenuItem_Click);
            // 
            // fATURAToolStripMenuItem
            // 
            this.fATURAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaBilgileriToolStripMenuItem,
            this.faturaDetaylarıToolStripMenuItem});
            this.fATURAToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_purchase_order_402;
            this.fATURAToolStripMenuItem.Name = "fATURAToolStripMenuItem";
            this.fATURAToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.fATURAToolStripMenuItem.Text = "FATURA";
            this.fATURAToolStripMenuItem.Click += new System.EventHandler(this.fATURAToolStripMenuItem_Click);
            // 
            // faturaBilgileriToolStripMenuItem
            // 
            this.faturaBilgileriToolStripMenuItem.Name = "faturaBilgileriToolStripMenuItem";
            this.faturaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.faturaBilgileriToolStripMenuItem.Text = "Bilgiler";
            this.faturaBilgileriToolStripMenuItem.Click += new System.EventHandler(this.faturaBilgileriToolStripMenuItem_Click);
            // 
            // faturaDetaylarıToolStripMenuItem
            // 
            this.faturaDetaylarıToolStripMenuItem.Name = "faturaDetaylarıToolStripMenuItem";
            this.faturaDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.faturaDetaylarıToolStripMenuItem.Text = "Detaylar";
            this.faturaDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.faturaDetaylarıToolStripMenuItem_Click);
            // 
            // iLETİŞİMToolStripMenuItem
            // 
            this.iLETİŞİMToolStripMenuItem.Image = global::oyuncak2.Properties.Resources.icons8_hotline_503;
            this.iLETİŞİMToolStripMenuItem.Name = "iLETİŞİMToolStripMenuItem";
            this.iLETİŞİMToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.iLETİŞİMToolStripMenuItem.Text = "İLETİŞİM";
            this.iLETİŞİMToolStripMenuItem.Click += new System.EventHandler(this.iLETİŞİMToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dövizKuruToolStripMenuItem
            // 
            this.dövizKuruToolStripMenuItem.Name = "dövizKuruToolStripMenuItem";
            this.dövizKuruToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.dövizKuruToolStripMenuItem.Text = "Döviz Kuru";
            this.dövizKuruToolStripMenuItem.Click += new System.EventHandler(this.dövizKuruToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oyuncak2.Properties.Resources.ahp;
            this.ClientSize = new System.Drawing.Size(962, 488);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNASAYFAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNLERToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MÜŞTERİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fATURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaDetaylarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLETİŞİMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dövizKuruToolStripMenuItem;
    }
}

