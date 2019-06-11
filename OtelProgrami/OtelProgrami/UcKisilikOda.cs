using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class UcKisilikOda : Oda
    {
        public UcKisilikOda(int fiyat, bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {

            Fiyat = fiyat;
            KisiKapasitesi = 3;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
            OdaTuru = "Üç kişilik oda";
        }

        public UcKisilikOda()
        {
            OdaTuru = "Üç kişilik oda";
        }
    }
}
