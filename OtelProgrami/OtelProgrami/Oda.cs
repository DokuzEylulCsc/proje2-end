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
    class Oda
    {
        string otelIsmi;
        string odaTuru;
        int fiyat;
        int kisiKapasitesi;
        string sehirBilgisi;
        string odaOzelligi;
        bool rezervBilgisi = false;

        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string OdaTuru { get => odaTuru; set => odaTuru = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int KisiKapasitesi { get => kisiKapasitesi; set => kisiKapasitesi = value; }
        public string SehirBilgisi { get => sehirBilgisi; set => sehirBilgisi = value; }
        public string OdaOzelligi { get => odaOzelligi; set => odaOzelligi = value; }
        public bool RezervBilgisi { get => rezervBilgisi; set => rezervBilgisi = value; }

        internal void OdaBilgiGir(string otelAd, string sehir, string ozellik)
        {
            OtelIsmi = otelAd;
            SehirBilgisi = sehir;
            OdaOzelligi = ozellik;
        }

        internal string Serialize(Object o)
        {
            //Serilestirip, Json'u guzel bicimde yazdiriyor.
            return JToken.Parse(JsonConvert.SerializeObject(o)).ToString(Formatting.Indented);
        }

        internal Oda Deserialize(string serialized)
        {
            return JsonConvert.DeserializeObject<Oda>(serialized);
        }

        // JSONVeri/Odalar klasörune yeni oda'nin json olarak bilgilerini yazdir
        internal void OdaEkle()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\TumOtellereAitOdalar\";

            // ...\JSONVeri\TumOtellereAitOdalar\OtelIsim-OdaTuru-uniqueID.json
            // Guid.NewGuid().ToString("N") her bir json dosyasina unique isim vermek icin kullanildi.
            File.WriteAllText(filePath + OtelIsmi + "-" + this.GetType().Name + "-" + Guid.NewGuid().ToString("N") + ".json", this.Serialize(this));
        }
    }
}
