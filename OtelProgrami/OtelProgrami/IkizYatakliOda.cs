using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class IkizYatakliOda : Oda
    {
        public IkizYatakliOda(int fiyat, bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 2;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
            OdaTuru = "İkiz yataklı oda";
        }

        public IkizYatakliOda()
        {
            OdaTuru = "İkiz yataklı oda";
        }
    }
}
