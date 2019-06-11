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
        string otelTuru;
        string odaTuru;
        int fiyat;
        int kisiKapasitesi;
        string sehirBilgisi;

        bool denizManzarasiSecenegi;
        bool dagManzarasiSecenegi;

        // false ise fiyat Normal olsun, NormalFiyatSecenegine gerek kalmamis olur!
        bool ekonomikFiyatSecenegi;
        bool rezervBilgisi = false;

        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string OtelTuru { get => otelTuru; set => otelTuru = value; }
        public string OdaTuru { get => odaTuru; set => odaTuru = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int KisiKapasitesi { get => kisiKapasitesi; set => kisiKapasitesi = value; }
        public string SehirBilgisi { get => sehirBilgisi; set => sehirBilgisi = value; }
        public bool DenizManzarasiSecenegi { get => denizManzarasiSecenegi; set => denizManzarasiSecenegi = value; }
        public bool DagManzarasiSecenegi { get => dagManzarasiSecenegi; set => dagManzarasiSecenegi = value; }
        public bool EkonomikFiyatSecenegi { get => ekonomikFiyatSecenegi; set => ekonomikFiyatSecenegi = value; }
        public bool RezervBilgisi { get => rezervBilgisi; set => rezervBilgisi = value; }

        internal Oda()
        {

        }

        internal void OdaBilgiGir(string otelAd, int fiyat, int kisiKap, bool deniz, bool dag, bool eko, bool rezerv)
        {
            OtelIsmi = otelAd;
            Fiyat = fiyat;
            KisiKapasitesi = kisiKap;
            DenizManzarasiSecenegi = deniz;
            DagManzarasiSecenegi = dag;
            EkonomikFiyatSecenegi = eko;
            RezervBilgisi = rezerv;
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
        internal void OdaEkle(int i)
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\TumOtellereAitOdalar\";

            // ...\JSONVeri\TumOtellereAitOdalar\OtelIsim OdaTuru.json
            File.WriteAllText(filePath + OtelIsmi + "-" + this.GetType().Name + "-" + i + ".json", this.Serialize(this));
        }
    }
}
