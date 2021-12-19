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
            this.components = new System.ComponentModel.Container();
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
            this.saat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kur_panel = new System.Windows.Forms.Panel();
            this.kullanici_giris_panel = new System.Windows.Forms.Panel();
            this.sif_kul = new System.Windows.Forms.TextBox();
            this.ad_kul = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.add_cash = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_ekle = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.have_usd = new System.Windows.Forms.TextBox();
            this.have_eur = new System.Windows.Forms.TextBox();
            this.have_gbp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.kur_panel.SuspendLayout();
            this.kullanici_giris_panel.SuspendLayout();
            this.add_cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "GBP";
            // 
            // usd_price
            // 
            this.usd_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_price.Location = new System.Drawing.Point(157, 218);
            this.usd_price.Multiline = true;
            this.usd_price.Name = "usd_price";
            this.usd_price.ReadOnly = true;
            this.usd_price.Size = new System.Drawing.Size(125, 40);
            this.usd_price.TabIndex = 5;
            this.usd_price.Text = "1";
            this.usd_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eur_price
            // 
            this.eur_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.eur_price.Location = new System.Drawing.Point(157, 273);
            this.eur_price.Multiline = true;
            this.eur_price.Name = "eur_price";
            this.eur_price.ReadOnly = true;
            this.eur_price.Size = new System.Drawing.Size(125, 40);
            this.eur_price.TabIndex = 6;
            this.eur_price.Text = "1";
            this.eur_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_price
            // 
            this.gbp_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.gbp_price.Location = new System.Drawing.Point(157, 327);
            this.gbp_price.Multiline = true;
            this.gbp_price.Name = "gbp_price";
            this.gbp_price.ReadOnly = true;
            this.gbp_price.Size = new System.Drawing.Size(125, 40);
            this.gbp_price.TabIndex = 7;
            this.gbp_price.Text = "1";
            this.gbp_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_price_all
            // 
            this.gbp_price_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.gbp_price_all.Location = new System.Drawing.Point(288, 327);
            this.gbp_price_all.Multiline = true;
            this.gbp_price_all.Name = "gbp_price_all";
            this.gbp_price_all.ReadOnly = true;
            this.gbp_price_all.Size = new System.Drawing.Size(125, 40);
            this.gbp_price_all.TabIndex = 10;
            this.gbp_price_all.Text = "-";
            this.gbp_price_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eur_price_all
            // 
            this.eur_price_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.eur_price_all.Location = new System.Drawing.Point(288, 273);
            this.eur_price_all.Multiline = true;
            this.eur_price_all.Name = "eur_price_all";
            this.eur_price_all.ReadOnly = true;
            this.eur_price_all.Size = new System.Drawing.Size(125, 40);
            this.eur_price_all.TabIndex = 9;
            this.eur_price_all.Text = "-";
            this.eur_price_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usd_price_all
            // 
            this.usd_price_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_price_all.Location = new System.Drawing.Point(288, 218);
            this.usd_price_all.Multiline = true;
            this.usd_price_all.Name = "usd_price_all";
            this.usd_price_all.ReadOnly = true;
            this.usd_price_all.Size = new System.Drawing.Size(125, 40);
            this.usd_price_all.TabIndex = 8;
            this.usd_price_all.Text = "-";
            this.usd_price_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saat);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 46);
            this.panel1.TabIndex = 11;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saat.Location = new System.Drawing.Point(531, 12);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(60, 22);
            this.saat.TabIndex = 12;
            this.saat.Text = "19:45";
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
            this.button2.Text = "Para ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.kur_panel.Controls.Add(this.have_gbp);
            this.kur_panel.Controls.Add(this.have_eur);
            this.kur_panel.Controls.Add(this.have_usd);
            this.kur_panel.Controls.Add(this.gbp_price_all);
            this.kur_panel.Controls.Add(this.label1);
            this.kur_panel.Controls.Add(this.label2);
            this.kur_panel.Controls.Add(this.eur_price_all);
            this.kur_panel.Controls.Add(this.label3);
            this.kur_panel.Controls.Add(this.usd_price_all);
            this.kur_panel.Controls.Add(this.usd_price);
            this.kur_panel.Controls.Add(this.gbp_price);
            this.kur_panel.Controls.Add(this.eur_price);
            this.kur_panel.Location = new System.Drawing.Point(710, 114);
            this.kur_panel.Name = "kur_panel";
            this.kur_panel.Size = new System.Drawing.Size(579, 435);
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
            this.sif_kul.Location = new System.Drawing.Point(252, 225);
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
            this.ad_kul.Location = new System.Drawing.Point(252, 183);
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
            this.button5.Location = new System.Drawing.Point(283, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "Bağlan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // add_cash
            // 
            this.add_cash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_cash.Controls.Add(this.button4);
            this.add_cash.Controls.Add(this.button3);
            this.add_cash.Controls.Add(this.tb_ekle);
            this.add_cash.Controls.Add(this.comboBox1);
            this.add_cash.Location = new System.Drawing.Point(125, 176);
            this.add_cash.Name = "add_cash";
            this.add_cash.Size = new System.Drawing.Size(466, 269);
            this.add_cash.TabIndex = 15;
            this.add_cash.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(421, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tb_ekle
            // 
            this.tb_ekle.Location = new System.Drawing.Point(145, 88);
            this.tb_ekle.Name = "tb_ekle";
            this.tb_ekle.Size = new System.Drawing.Size(165, 22);
            this.tb_ekle.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // have_usd
            // 
            this.have_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.have_usd.Location = new System.Drawing.Point(419, 218);
            this.have_usd.Multiline = true;
            this.have_usd.Name = "have_usd";
            this.have_usd.ReadOnly = true;
            this.have_usd.Size = new System.Drawing.Size(125, 40);
            this.have_usd.TabIndex = 11;
            this.have_usd.Text = "-";
            this.have_usd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // have_eur
            // 
            this.have_eur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.have_eur.Location = new System.Drawing.Point(419, 273);
            this.have_eur.Multiline = true;
            this.have_eur.Name = "have_eur";
            this.have_eur.ReadOnly = true;
            this.have_eur.Size = new System.Drawing.Size(125, 40);
            this.have_eur.TabIndex = 12;
            this.have_eur.Text = "-";
            this.have_eur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // have_gbp
            // 
            this.have_gbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.have_gbp.Location = new System.Drawing.Point(419, 327);
            this.have_gbp.Multiline = true;
            this.have_gbp.Name = "have_gbp";
            this.have_gbp.ReadOnly = true;
            this.have_gbp.Size = new System.Drawing.Size(125, 40);
            this.have_gbp.TabIndex = 13;
            this.have_gbp.Text = "-";
            this.have_gbp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 727);
            this.Controls.Add(this.add_cash);
            this.Controls.Add(this.kullanici_giris_panel);
            this.Controls.Add(this.kur_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.kur_panel.ResumeLayout(false);
            this.kur_panel.PerformLayout();
            this.kullanici_giris_panel.ResumeLayout(false);
            this.kullanici_giris_panel.PerformLayout();
            this.add_cash.ResumeLayout(false);
            this.add_cash.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kur_panel;
        private System.Windows.Forms.Panel kullanici_giris_panel;
        private System.Windows.Forms.TextBox sif_kul;
        private System.Windows.Forms.TextBox ad_kul;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel add_cash;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_ekle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox have_gbp;
        private System.Windows.Forms.TextBox have_eur;
        private System.Windows.Forms.TextBox have_usd;
    }
}

