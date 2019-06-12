using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Rezervasyon
    {
        string ad;
        string tcNo;
        string otelIsmi;
        string sehir;
        string soyad;
        string odaFiyati;
        string odaTuru; // Oda türü: Tek kisilik, iki kisilik vs.
        string odaOzelligi; // Ekonomik, Deniz manzarasi vs.
        string rezervasyonBaslangic;
        string rezervasyonBitis;
        Uye rezerveEden = new Uye();

        // Otel Türü, Oda Türü, Oda Özelliği vs seçilecek,
        // Kriterlere Uygun x Otelinin y Odası bu tarihlerde rezerve olacak.
        public Rezervasyon(string ad, string soyad, string tcNo, string sehir, string otelIsmi, string odaFiyati, string odaTuru, string odaOzelligi, string baslangic, string bitis, Uye uye)
        {
            Ad = ad;
            Soyad = soyad;
            TcNo = tcNo;
            Sehir = sehir;
            OtelIsmi = otelIsmi;
            OdaFiyati = odaFiyati;
            OdaTuru = odaTuru;
            OdaOzelligi = odaOzelligi;
            RezervasyonBaslangic = baslangic;
            RezervasyonBitis = bitis;
          
        }

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string TcNo { get => tcNo; set => tcNo = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string OdaTuru { get => odaTuru; set => odaTuru = value; }
        public string OdaOzelligi { get => odaOzelligi; set => odaOzelligi = value; }
        public string OdaFiyati { get => odaFiyati; set => odaFiyati = value; }
        public string RezervasyonBaslangic { get => rezervasyonBaslangic; set => rezervasyonBaslangic = value; }
        public string RezervasyonBitis { get => rezervasyonBitis; set => rezervasyonBitis = value; }
    }
}
