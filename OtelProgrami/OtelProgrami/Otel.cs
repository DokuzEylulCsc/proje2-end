using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    abstract class Otel
    {
        int yildizSayisi;
        LinkedList<Oda> odaListesi = new LinkedList<Oda>();

        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }
        internal LinkedList<Oda> OdaListesi { get => odaListesi; set => odaListesi = value; }

        //Yonetici erisebilir
        public abstract void OdalariGoster();
        public abstract void MusterileriGoster();
    }
}
