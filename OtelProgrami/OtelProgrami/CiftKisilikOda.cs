using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class CiftKisilikOda : Oda
    {
        public CiftKisilikOda(int fiyat, bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 2;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
            OdaTuru = "Çift kişilik oda";
        }

        public CiftKisilikOda()
        {
            OdaTuru = "Çift kişilik oda";
        }
    }
}
