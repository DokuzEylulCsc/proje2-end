using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class TekKisilikOda : Oda
    {
        public TekKisilikOda(int fiyat, bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 1;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
            OdaTuru = "Tek kişilik oda";
        }

        public TekKisilikOda()
        {
            OdaTuru = "Tek kişilik oda";
        }
    }
}
