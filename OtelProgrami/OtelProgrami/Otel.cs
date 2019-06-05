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
        //List olarak odalarin listesi ..

        public int YildizSayisi { get => yildizSayisi; set => yildizSayisi = value; }

        //Yonetici erisebilir
        public abstract void OdalariGoster();
        public abstract void MusterileriGoster();
    }
}
