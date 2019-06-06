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
        LinkedList<Oda> odaListesi = new LinkedList<Oda>();
        string otelTuru;

        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string SehirBilgisi { get => sehirBilgisi; set => sehirBilgisi = value; }
        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }
        internal LinkedList<Oda> OdaListesi { get => odaListesi; set => odaListesi = value; }
        public string OtelTuru { get => otelTuru; set => otelTuru = value; }

        //Yonetici erisebilir
        public abstract void OdalariGoster();
        public abstract void MusterileriGoster();
    }
}
