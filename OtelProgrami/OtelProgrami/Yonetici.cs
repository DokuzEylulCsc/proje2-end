using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Yonetici
    {
        string adSoyad;
        string tcNo;
        int yas;

        LinkedList<Oda> odaListesi = new LinkedList<Oda>();
        LinkedList<Uye> musteriListesi = new LinkedList<Uye>();

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string TcNo { get => tcNo; set => tcNo = value; }
        public int Yas { get => yas; set => yas = value; }
        internal LinkedList<Oda> OdaListesi { get => odaListesi; set => odaListesi = value; }
        internal LinkedList<Uye> MusteriListesi { get => musteriListesi; set => musteriListesi = value; }

        Yonetici(string adsoyad, int yas, string tcno)
        {
            AdSoyad = adSoyad;
            TcNo = tcno;
            Yas = yas;
        }

        public void BilgileriniGuncelle(string yeniAdsoyad, string yeniTc, int yeniYas)
        {
            AdSoyad = yeniAdsoyad;
            TcNo = yeniTc;
            Yas = yeniYas;
        }

        public void OtelEkle(Otel otel)
        {

        }

        public void OteleOdaEkle(Otel otel)
        {

        }

        // Belirli bir tarih aralığı girildiğinde hangi otelde kaç oda dolu,
        // hangi odalar dolu, kaç kişi ve ne kadara kalıyor bilgileri sunulmalıdır
        // Sadece Yonetici Erisecek
        public void OteleAitOzetBilgiler(DateTime secilecekTarih)
        {

        }
    }
}
