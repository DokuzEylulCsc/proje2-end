using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Rezervasyon
    {
        Otel otelBilgisi;
        string otelTuru; // Otel türü: Butik, Pansiyon vs.
        string odaTuru; // Oda türü: Tek kisilik, iki kisilik vs.
        string odaOzelligi; // Ekonomik, Deniz manzarasi vs.
        DateTime rezervasyonBaslangic;
        DateTime rezervasyonBitis;
        Uye rezerveEden = new Uye();

        // Otel Türü, Oda Türü, Oda Özelliği vs seçilecek,
        // Kriterlere Uygun x Otelinin y Odası bu tarihlerde rezerve olacak.
        Rezervasyon(string otelTuru, string odaTuru, string odaOzelligi, DateTime baslangic, DateTime bitis, Uye uye)
        {
            OtelTuru = otelTuru;
            OdaTuru = odaTuru;
            OdaOzelligi = odaOzelligi;
            RezervasyonBaslangic = baslangic;
            RezervasyonBitis = bitis;
            RezerveEden = uye;
        }

        public string OtelTuru { get => otelTuru; set => otelTuru = value; }
        public string OdaTuru { get => odaTuru; set => odaTuru = value; }
        public string OdaOzelligi { get => odaOzelligi; set => odaOzelligi = value; }
        public DateTime RezervasyonBaslangic { get => rezervasyonBaslangic; set => rezervasyonBaslangic = value; }
        public DateTime RezervasyonBitis { get => rezervasyonBitis; set => rezervasyonBitis = value; }
        internal Otel OtelBilgisi { get => otelBilgisi; set => otelBilgisi = value; }
        internal Uye RezerveEden { get => rezerveEden; set => rezerveEden = value; }
    }
}
