using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OtelProgrami
{
    class Uye
    {
<<<<<<< HEAD
        Database db = new Database();
        OtelRezervasyon rez = new OtelRezervasyon();
        YoneticiForm frm = new YoneticiForm();
        public string kullaniciAdi_tut { get; set; }
        public string kullaniciSifre_tut { get; set; }
        public string girisDurumu { get; set; }

    /*    Uye(string adsoyad)
        {
            Adsoyad = adsoyad;
        }*/
        public void giris(string kullaniciAdi, string kullaniciSifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            //girişteki kullanici veya sifre girme hatası log kaydı için
            try
            {
                db.baglanti.Open();
                SqlCommand loginName = new SqlCommand("select kullaniciAdi from Musteriler where kullaniciAd=@kulAdi", db.baglanti);
                loginName.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                SqlDataReader kulAdi_oku = loginName.ExecuteReader();
                if (kulAdi_oku.Read())
                {
                    kullaniciAdi_tut = kulAdi_oku["kullaniciAdi"].ToString();
                    SqlCommand loginpasword = new SqlCommand("select kullaniciSifre from Musteriler where kullaniciSifre = @kulSifre", db.baglanti);
                    loginName.Parameters.AddWithValue("kulSifre", kullaniciSifre);
                    SqlDataReader kulSifre_oku = loginpasword.ExecuteReader();
                    if (kulSifre_oku.Read())
                    {
                        kullaniciSifre_tut = kulSifre_oku["kullaniciSifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + kullaniciSifre_tut;
                        //Yönetici formuna yonlendirme
                        if (kullaniciAdi_tut == "Admin" && kullaniciSifre_tut == "Admin")
                        {
                            frm.ShowDialog();
                        }
                        else
                        {
                            rez.ShowDialog();
                        }
                        // dateUpdate.Parameters
                    }
                    else
                    {
                        MessageBox.Show("Kullanici Şifresini Yanlış Girdiniz.", "Hata|AnaGiris", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    loginpasword.Dispose();
                    kulSifre_oku.Close();
                }
                else
                {
                    MessageBox.Show("Kullanici Adini Yanlış Girdiniz.", "Hata|AnaGiris", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loginName.Dispose();
                kulAdi_oku.Close();
                db.baglanti.Close();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void kayit(string ad, string soyad, string e_mail, string kullanici_Adi, string tel, string sifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kayit_al = new SqlCommand("insert into Musteriler values(@ad,@soyad,@tel,@eMail,@kullaniciAdi,@kullaniciSifre)", db.baglanti);
                kayit_al.Parameters.AddWithValue("ad", ad);
                kayit_al.Parameters.AddWithValue("soyad", soyad);
                kayit_al.Parameters.AddWithValue("tel", tel);
                kayit_al.Parameters.AddWithValue("eMail", e_mail);
                kayit_al.Parameters.AddWithValue("kullaniciAdi", kullanici_Adi);
                kayit_al.Parameters.AddWithValue("kullaniciSifre", sifre);
                kayit_al.ExecuteNonQuery();
                MessageBox.Show("Merhaba " + ad + " kaydınız başarı ile oluşturulmuştur.");
                kayit_al.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        public override void BilgileriniGuncelle()
=======
        string adSoyad;
        string tcNo;
        int yas;

        // Rezervasyon classının gerekip gerekmemesine gore silinecek
        //LinkedList<Rezervasyon> rezervasyonlarim = new LinkedList<Rezervasyon>();

        Uye(string adsoyad, int yas, string tcno)
        {
            AdSoyad = adSoyad;
            TcNo = tcno;
            Yas = yas;
        }

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string TcNo { get => tcNo; set => tcNo = value; }
        public int Yas { get => yas; set => yas = value; }

        public void BilgileriniGuncelle(string yeniAdsoyad, string yeniTc, int yeniYas)
        {
            AdSoyad = yeniAdsoyad;
            TcNo = yeniTc;
            Yas = yeniYas;
        }

        public void RezervasyonIptalEt()
>>>>>>> 357a3b84ba9a9eac3c7878e2981bf9ee97df3246
        {

        }

        // Sistem'e rezervasyon talebi gider, sistem uyenin talebine uygun sonuclari
        // uyeye bildirir.
        public void RezervasyonTalepEt()
        {

        }

        // Uye, sistemin sundugu uygun otel sonuclarindan birini secer,
        // ve rezervasyonu tamamlar.
        public void RezervasyonTamamla()
        {

        }
    }
}
