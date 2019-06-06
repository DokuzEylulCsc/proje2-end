using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class TekKisilikOda : Oda
    {
        public TekKisilikOda(bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            if (denizManzarasiBilgisi == true)
                Fiyat = 500;
            else if (dagManzarasiBilgisi == true)
                Fiyat = 400;
            else if (ekonomikFiyatBilgisi == true)
                Fiyat = 250;
            else Fiyat = 350;

            KisiKapasitesi = 1;
            KlimaSecenigi = true;
            MiniBarSecenegi = true;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
        }
    }
}
