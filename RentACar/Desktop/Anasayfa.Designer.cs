namespace Desktop
{
    partial class Anasayfa
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
            this.AracListeleme = new System.Windows.Forms.ToolStripMenuItem();
            this.araçTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AracKiralama = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriIstekleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AracKiralama,
            this.MusteriIstekleri,
            this.AracListeleme,
            this.araçTakipToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(17, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // AracListeleme
            // 
            this.AracListeleme.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AracListeleme.Name = "AracListeleme";
            this.AracListeleme.Size = new System.Drawing.Size(69, 20);
            this.AracListeleme.Text = "Listeleme";
            this.AracListeleme.Click += new System.EventHandler(this.AracListeleme_Click);
            // 
            // araçTakipToolStripMenuItem
            // 
            this.araçTakipToolStripMenuItem.Name = "araçTakipToolStripMenuItem";
            this.araçTakipToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.araçTakipToolStripMenuItem.Text = "Araç Takip";
            this.araçTakipToolStripMenuItem.Click += new System.EventHandler(this.araçTakipToolStripMenuItem_Click);
            // 
            // AracKiralama
            // 
            this.AracKiralama.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AracKiralama.Name = "AracKiralama";
            this.AracKiralama.Size = new System.Drawing.Size(92, 20);
            this.AracKiralama.Text = "Araç Kiralama";
            this.AracKiralama.Click += new System.EventHandler(this.AracKiralama_Click);
            // 
            // MusteriIstekleri
            // 
            this.MusteriIstekleri.Name = "MusteriIstekleri";
            this.MusteriIstekleri.Size = new System.Drawing.Size(102, 20);
            this.MusteriIstekleri.Text = "Müsteri İstekleri";
            this.MusteriIstekleri.Click += new System.EventHandler(this.MusteriIstekleri_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(907, 658);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anasayfa";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 19);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Araç Kiralama Sistemi";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AracKiralama;
        private System.Windows.Forms.ToolStripMenuItem MusteriIstekleri;
        private System.Windows.Forms.ToolStripMenuItem AracListeleme;
        private System.Windows.Forms.ToolStripMenuItem araçTakipToolStripMenuItem;
    }
}

