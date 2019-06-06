using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace OtelProgrami
{
    class Uye
    {
        string ad;
        string soyad;
        string telNo;
        string tcNo;
        string sifre;
        LinkedList<Rezervasyon> rezervasyonlarim = new LinkedList<Rezervasyon>();

        public Uye(string ad, string soyad, string telNo, string tcNo, string sifre)
        {
            Ad = ad;
            Soyad = soyad;
            TelNo = telNo;
            TcNo = tcNo;
            Sifre = sifre;
        }

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string TelNo { get => telNo; set => telNo = value; }
        public string TcNo { get => tcNo; set => tcNo = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        internal LinkedList<Rezervasyon> Rezervasyonlarim { get => rezervasyonlarim; set => rezervasyonlarim = value; }

        public void BilgileriniGuncelle(string yeniAd, string yeniSoyad, string yeniTelNo, string yeniTcNo, string yeniSifre)
        {
            Ad = ad;
            Soyad = soyad;
            TelNo = yeniTelNo;
            TcNo = yeniTcNo;
            Sifre = yeniSifre;
        }

        public void RezervasyonIptalEt()
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

        internal string Serialize(Object o)
        {
            //Serilestirip, Json'u guzel bicimde yazdiriyor.
            return JToken.Parse(JsonConvert.SerializeObject(o)).ToString(Formatting.Indented);
        }

        internal Uye Deserialize(string serialized)
        {
            return JsonConvert.DeserializeObject<Uye>(serialized);
        }

        // JSONVeri/Uyeler klasörune yeni uye'nin json olarak bilgilerini yazdir
        internal void KayitOl()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Uyeler\";

            // ...\JSONVeri\Uyeler\Ahmet Mehmet 4534323122.json
            File.WriteAllText(filePath + this.Ad + " " + this.Soyad + " " + this.TcNo + ".json", this.Serialize(this));
        }
    }
}
