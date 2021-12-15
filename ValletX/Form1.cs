﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ValletX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string site;
        public string usd;
        public string eur;
        public string gbp;
        public int kul_sicil;
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=walletx;Uid=ankoss;Pwd='asd123!!';");


        private void Form1_Load(object sender, EventArgs e)
        {
            site = "http://www.tcmb.gov.tr/kurlar/today.xml";
            xml_create();


            baglantı();
            kur_guncelle(1, usd);
            kur_guncelle(2, eur);
            kur_guncelle(3, gbp);
            kur_goster();

            timer1.Interval = 1000;

            add_combobox();
        }

        bool kur_durum = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (kur_durum)
            {
                kur_panel.Visible = false;
                kur_panel.Dock = DockStyle.None;
                kur_durum = false;
            }
            else
            {
                kur_panel.Visible = true;
                kur_panel.Dock = DockStyle.Fill;
                kur_durum = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string kul_ad = ad_kul.Text.ToString();
            string kul_sif = sif_kul.Text.ToString();
            giris_kontrol(kul_ad, kul_sif);
        }
        public void giris_kontrol(string ad, string sif)
        {

            MySqlCommand cmd = new MySqlCommand();
            mysqlbaglan.Open();
            cmd.Connection = mysqlbaglan;
            cmd.CommandText = "SELECT * FROM kullanici_bilgi where kul_ad='" + ad + "' AND kul_sif='" + sif + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kul_sicil = int.Parse(dr[0].ToString());
                MessageBox.Show("bağlantı başarılı: " + kul_sicil);
                kullanici_giris_panel.Dock = DockStyle.None;
                kullanici_giris_panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            dr.Close();
            mysqlbaglan.Close();
            timer1.Start();
        }
        public void baglantı()
        {
            try
            {
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed) { }
                else
                {
                    MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                }
                mysqlbaglan.Close();
            }
            catch (Exception err)
            {
                mysqlbaglan.Close();
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void kur_guncelle(int id, string kur)
        {
            mysqlbaglan.Open();

            MySqlCommand cmd = new MySqlCommand("update tur_bilgi set tur_kur=@kur where tur_id=@id", mysqlbaglan);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@kur", kur);
            cmd.ExecuteNonQuery();

            mysqlbaglan.Close();

        }
        public void xml_create()
        {
            var xmldoc = new XmlDocument();
            xmldoc.Load(site);
            usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            eur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            gbp = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
        }
        public void kur_goster()
        {
            usd_price.Text = usd;
            eur_price.Text = eur;
            gbp_price.Text = gbp;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % 10 == 0)
            {
                saat.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                kur_guncelle(1, usd);
                kur_guncelle(2, eur);
                kur_guncelle(3, gbp);
                kur_goster();
            }
        }

        public void add_gold(int kul_id, int tur_id, int bak)
        {
            mysqlbaglan.Open();
            MySqlCommand cmd = new MySqlCommand("insert into bakiye_bilgi (kul_id,tur_id,bak_miktar) values (@kul_id,@tur_id,@miktar)", mysqlbaglan);
            cmd.Parameters.AddWithValue("@kul_id", kul_id);
            cmd.Parameters.AddWithValue("@tur_id", tur_id);
            cmd.Parameters.AddWithValue("@miktar", bak);
            cmd.ExecuteNonQuery();
            mysqlbaglan.Close();
            MessageBox.Show("Paranız başarılı bir şekilde eklendi");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            add_cash.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (add_cash.Visible == false) add_cash.Visible = true;
            else add_cash.Visible = false;
        }

        public void add_combobox()
        {
            mysqlbaglan.Open();


            MySqlCommand cmd = new MySqlCommand("Select tur_kisa from tur_bilgi", mysqlbaglan);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }

            mysqlbaglan.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int bak_id = 0;
            mysqlbaglan.Open();

            MySqlCommand cmd = new MySqlCommand("Select tur_id from tur_bilgi where tur_kisa=@kisa", mysqlbaglan);
            cmd.Parameters.AddWithValue("@kisa", comboBox1.Text.ToString());
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bak_id = int.Parse(dr[0].ToString());
            }
            dr.Close();
            mysqlbaglan.Close();
            MessageBox.Show("bilgi alındı" + bak_id.ToString());
            int miktar = int.Parse(tb_ekle.Text.ToString());
            add_gold(kul_sicil, bak_id, miktar);
            
        }
    }
}



