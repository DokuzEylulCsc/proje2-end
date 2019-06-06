using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    abstract class Otel
    {
        string otelIsmi;
        string sehirBilgisi;
        int yildizSayisi;
        string otelTuru;

        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string SehirBilgisi { get => sehirBilgisi; set => sehirBilgisi = value; }
        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }
        public string OtelTuru { get => otelTuru; set => otelTuru = value; }
    }
}
