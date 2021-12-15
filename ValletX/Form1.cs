using MySql.Data.MySqlClient;
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
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=walletx;Uid=ankoss;Pwd='asd123!!';");


        private void Form1_Load(object sender, EventArgs e)
        {
            site = "http://www.tcmb.gov.tr/kurlar/today.xml";
            xml_create();

            usd_price.Text = usd;
            eur_price.Text = eur;
            gbp_price.Text = gbp;
            baglantı();
            kur_guncelle(1, usd);
            kur_guncelle(2, eur);
            kur_guncelle(3, gbp);
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

        private void xml_create()
        {
            var xmldoc = new XmlDocument();
            xmldoc.Load(site);
            usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            eur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            gbp = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
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
                MessageBox.Show("bağlantı başarılı.");
                kullanici_giris_panel.Dock = DockStyle.None;
                kullanici_giris_panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }
            mysqlbaglan.Close();
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
    }
}



