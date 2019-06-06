using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class TatilKoyu : Otel
    {
        public TatilKoyu(string otelIsmi, string sehirBilgisi, int yildizSy)
        {
            OtelIsmi = otelIsmi;
            SehirBilgisi = sehirBilgisi;
            YildizSayisi = yildizSy;
        }

        public override void MusterileriGoster()
        {

        }

        public override void OdalariGoster()
        {

        }
    }
}
