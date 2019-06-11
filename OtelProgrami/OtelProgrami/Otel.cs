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
    class Otel
    {
        string otelIsmi;
        string sehirBilgisi;
        int yildizSayisi;
        string otelTuru;

        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string SehirBilgisi { get => sehirBilgisi; set => sehirBilgisi = value; }
        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }
        public string OtelTuru { get => otelTuru; set => otelTuru = value; }
    
        internal Otel(string otelIsmi, string sehirBilgisi, int yildizSy, string otelTur)
        {
            OtelIsmi = otelIsmi;
            SehirBilgisi = sehirBilgisi;
            YildizSayisi = yildizSy;
            OtelTuru = otelTur;
        }

        internal string Serialize(Object o)
        {
            //Serilestirip, Json'u guzel bicimde yazdiriyor.
            return JToken.Parse(JsonConvert.SerializeObject(o)).ToString(Formatting.Indented);
        }

        internal Otel Deserialize(string serialized)
        {
            return JsonConvert.DeserializeObject<Otel>(serialized);
        }

        // JSONVeri/Oteller klasörune yeni otel'in json olarak bilgilerini yazdir
        internal void OtelEkle()
        {
            string filePath = System.IO.Directory.GetCurrentDirectory();
            filePath = System.IO.Directory.GetCurrentDirectory().Substring(0, filePath.LastIndexOf("bin")) + @"JSONVeri\Oteller\";

            // ...\JSONVeri\Oteller\Otelismi.json
            File.WriteAllText(filePath + OtelIsmi + ".json", this.Serialize(this));
        }
    }
}
