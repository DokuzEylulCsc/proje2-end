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

        public string OtelIsmi { get => otelIsmi; set => otelIsmi = value; }
        public string SehirBilgisi { get => sehirBilgisi; set => sehirBilgisi = value; }
        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }
        internal LinkedList<Oda> OdaListesi { get => odaListesi; set => odaListesi = value; }

        //Yonetici erisebilir
        public abstract void OdalariGoster();
        public abstract void MusterileriGoster();
    }
}
