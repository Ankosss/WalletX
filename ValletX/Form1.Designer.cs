namespace ValletX
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usd_price = new System.Windows.Forms.TextBox();
            this.eur_price = new System.Windows.Forms.TextBox();
            this.gbp_price = new System.Windows.Forms.TextBox();
            this.gbp_price_all = new System.Windows.Forms.TextBox();
            this.eur_price_all = new System.Windows.Forms.TextBox();
            this.usd_price_all = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kur_panel = new System.Windows.Forms.Panel();
            this.kullanici_giris_panel = new System.Windows.Forms.Panel();
            this.sif_kul = new System.Windows.Forms.TextBox();
            this.ad_kul = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.kur_panel.SuspendLayout();
            this.kullanici_giris_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(105, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "GBP";
            // 
            // usd_price
            // 
            this.usd_price.Enabled = false;
            this.usd_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_price.Location = new System.Drawing.Point(229, 276);
            this.usd_price.Multiline = true;
            this.usd_price.Name = "usd_price";
            this.usd_price.Size = new System.Drawing.Size(150, 40);
            this.usd_price.TabIndex = 5;
            this.usd_price.Text = "1";
            this.usd_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eur_price
            // 
            this.eur_price.Enabled = false;
            this.eur_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.eur_price.Location = new System.Drawing.Point(229, 331);
            this.eur_price.Multiline = true;
            this.eur_price.Name = "eur_price";
            this.eur_price.Size = new System.Drawing.Size(150, 40);
            this.eur_price.TabIndex = 6;
            this.eur_price.Text = "1";
            this.eur_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_price
            // 
            this.gbp_price.Enabled = false;
            this.gbp_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.gbp_price.Location = new System.Drawing.Point(229, 385);
            this.gbp_price.Multiline = true;
            this.gbp_price.Name = "gbp_price";
            this.gbp_price.Size = new System.Drawing.Size(150, 40);
            this.gbp_price.TabIndex = 7;
            this.gbp_price.Text = "1";
            this.gbp_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_price_all
            // 
            this.gbp_price_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.gbp_price_all.Location = new System.Drawing.Point(385, 385);
            this.gbp_price_all.Multiline = true;
            this.gbp_price_all.Name = "gbp_price_all";
            this.gbp_price_all.Size = new System.Drawing.Size(150, 40);
            this.gbp_price_all.TabIndex = 10;
            this.gbp_price_all.Text = "1";
            this.gbp_price_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eur_price_all
            // 
            this.eur_price_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.eur_price_all.Location = new System.Drawing.Point(385, 331);
            this.eur_price_all.Multiline = true;
            this.eur_price_all.Name = "eur_price_all";
            this.eur_price_all.Size = new System.Drawing.Size(150, 40);
            this.eur_price_all.TabIndex = 9;
            this.eur_price_all.Text = "1";
            this.eur_price_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usd_price_all
            // 
            this.usd_price_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_price_all.Location = new System.Drawing.Point(385, 276);
            this.usd_price_all.Multiline = true;
            this.usd_price_all.Name = "usd_price_all";
            this.usd_price_all.Size = new System.Drawing.Size(150, 40);
            this.usd_price_all.TabIndex = 8;
            this.usd_price_all.Text = "1";
            this.usd_price_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 46);
            this.panel1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(350, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(175, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cüzdan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kur_panel
            // 
            this.kur_panel.Controls.Add(this.gbp_price_all);
            this.kur_panel.Controls.Add(this.label1);
            this.kur_panel.Controls.Add(this.label2);
            this.kur_panel.Controls.Add(this.eur_price_all);
            this.kur_panel.Controls.Add(this.label3);
            this.kur_panel.Controls.Add(this.usd_price_all);
            this.kur_panel.Controls.Add(this.usd_price);
            this.kur_panel.Controls.Add(this.gbp_price);
            this.kur_panel.Controls.Add(this.eur_price);
            this.kur_panel.Location = new System.Drawing.Point(716, 317);
            this.kur_panel.Name = "kur_panel";
            this.kur_panel.Size = new System.Drawing.Size(539, 363);
            this.kur_panel.TabIndex = 12;
            // 
            // kullanici_giris_panel
            // 
            this.kullanici_giris_panel.Controls.Add(this.sif_kul);
            this.kullanici_giris_panel.Controls.Add(this.ad_kul);
            this.kullanici_giris_panel.Controls.Add(this.button5);
            this.kullanici_giris_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullanici_giris_panel.Location = new System.Drawing.Point(0, 46);
            this.kullanici_giris_panel.Name = "kullanici_giris_panel";
            this.kullanici_giris_panel.Size = new System.Drawing.Size(729, 681);
            this.kullanici_giris_panel.TabIndex = 13;
            // 
            // sif_kul
            // 
            this.sif_kul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sif_kul.Location = new System.Drawing.Point(225, 224);
            this.sif_kul.Multiline = true;
            this.sif_kul.Name = "sif_kul";
            this.sif_kul.Size = new System.Drawing.Size(191, 30);
            this.sif_kul.TabIndex = 2;
            this.sif_kul.Text = "şifre";
            this.sif_kul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ad_kul
            // 
            this.ad_kul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_kul.Location = new System.Drawing.Point(225, 182);
            this.ad_kul.Multiline = true;
            this.ad_kul.Name = "ad_kul";
            this.ad_kul.Size = new System.Drawing.Size(191, 30);
            this.ad_kul.TabIndex = 1;
            this.ad_kul.Text = "kullanıcı adı";
            this.ad_kul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(260, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "Bağlan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 727);
            this.Controls.Add(this.kullanici_giris_panel);
            this.Controls.Add(this.kur_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.kur_panel.ResumeLayout(false);
            this.kur_panel.PerformLayout();
            this.kullanici_giris_panel.ResumeLayout(false);
            this.kullanici_giris_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usd_price;
        private System.Windows.Forms.TextBox eur_price;
        private System.Windows.Forms.TextBox gbp_price;
        private System.Windows.Forms.TextBox gbp_price_all;
        private System.Windows.Forms.TextBox eur_price_all;
        private System.Windows.Forms.TextBox usd_price_all;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kur_panel;
        private System.Windows.Forms.Panel kullanici_giris_panel;
        private System.Windows.Forms.TextBox sif_kul;
        private System.Windows.Forms.TextBox ad_kul;
        private System.Windows.Forms.Button button5;
    }
}

