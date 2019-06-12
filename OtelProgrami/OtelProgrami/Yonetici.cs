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
         public Yonetici()
        {
            
        }

        // Otel eklendiginde Json olarak JSONVeri\Oteller klasorune Otel eklenecek
        public void OtelEkle(Otel otel)
        {
            OtelRezervasyon otelRez = new OtelRezervasyon();
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Oteller\";

            // ...\JSONVeri\TumOtellereAitOdalar\OtelIsim-uniqueID.json
            // Guid.NewGuid().ToString("N") her bir json dosyasina unique isim vermek icin kullanildi.
            File.WriteAllText(filePath + otel.OtelIsmi + "-" + Guid.NewGuid().ToString("N") + ".json", this.Serialize(otel));
        }

        // JSONVeri\TumOtellereAitOdalar klasorune otel bilgisi
        // belirli olan yeni bir oda eklenecek
        public void OdaEkle(Oda oda)
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\TumOtellereAitOdalar\";

            // ...\JSONVeri\TumOtellereAitOdalar\OtelIsim-OdaTuru-uniqueID.json
            // Guid.NewGuid().ToString("N") her bir json dosyasina unique isim vermek icin kullanildi.
            File.WriteAllText(filePath + oda.OtelIsmi + "-" + oda.GetType().Name + "-" + Guid.NewGuid().ToString("N") + ".json", this.Serialize(oda));
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

        internal List<Uye> Listele()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Uyeler\";

            string[] fileEntries = Directory.GetFiles(filePath);

            List<Uye> uyeler = new List<Uye>();

            foreach (var temp in fileEntries)
            {
                // string olarak json okundu, objeye cevrildi
                Uye uye = JsonConvert.DeserializeObject<Uye>(File.ReadAllText(temp));

                uyeler.Add(uye);
            }

            return uyeler;
        }
    }
}
