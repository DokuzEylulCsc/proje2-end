using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Yonetici
    {
        string ad;
        string soyad;
        string telNo;
        string tcNo;
        string sifre;

        LinkedList<Oda> odaListesi = new LinkedList<Oda>();
        LinkedList<Uye> musteriListesi = new LinkedList<Uye>();

        internal string Ad { get => ad; set => ad = value; }
        internal string Soyad { get => soyad; set => soyad = value; }
        internal string TelNo { get => telNo; set => telNo = value; }
        internal string TcNo { get => tcNo; set => tcNo = value; }
        internal string Sifre { get => sifre; set => sifre = value; }
        internal LinkedList<Oda> OdaListesi { get => odaListesi; set => odaListesi = value; }
        internal LinkedList<Uye> MusteriListesi { get => musteriListesi; set => musteriListesi = value; }

        internal Yonetici(string ad, string soyad, string telNo, string tcNo, string sifre)
        {
            Ad = ad;
            Soyad = soyad;
            TelNo = telNo;
            TcNo = tcNo;
            Sifre = sifre;
        }

        public Yonetici()
        {

        }

        public void BilgileriniGuncelle(string yeniAd, string yeniSoyad, string yeniTelNo, string yeniTcNo, string yeniSifre)
        {
            Ad = yeniAd;
            Soyad = yeniSoyad;
            TelNo = yeniTelNo;
            TcNo = yeniTcNo;
            Sifre = yeniSifre;
        }

        // Otel eklendiginde Json olarak JSONVeri\Oteller klasorune Otel eklenecek
        public void OtelEkle(Otel otel)
        {

        }

        // JSONVeri\TumOtellereAitOdalar klasorune otel bilgisi
        // belirli olan yeni bir oda eklenecek
        public void OteleOdaEkle(Otel otel)
        {

        }

        internal string Serialize(Object o)
        {
            //Serilestirip, Json'u guzel bicimde yazdiriyor.
            return JToken.Parse(JsonConvert.SerializeObject(o)).ToString(Formatting.Indented);
        }

        internal Yonetici Deserialize(string serialized)
        {
            return JsonConvert.DeserializeObject<Yonetici>(serialized);
        }

        // Belirli bir tarih aralığı girildiğinde hangi otelde kaç oda dolu,
        // hangi odalar dolu, kaç kişi ve ne kadara kalıyor bilgileri sunulmalıdır
        // Sadece Yonetici Erisecek
        public void OteleAitOzetBilgiler(DateTime baslangictarih, DateTime bitisTarih)
        {

        }

        internal List<Uye> Listele()
        {

            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Uyeler\";

            string[] fileEntries = Directory.GetFiles(filePath);

            List<Uye> uyeler = new List<Uye>();

            foreach (var a in fileEntries)
            {
                // newton soft json okuma
                // read file into a string and deserialize JSON to a type
                Uye uye = JsonConvert.DeserializeObject<Uye>(File.ReadAllText(a));

                uyeler.Add(uye);
            }

            return uyeler;
        }
    }
}
