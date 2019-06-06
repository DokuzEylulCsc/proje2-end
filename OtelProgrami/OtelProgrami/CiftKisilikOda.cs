using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class CiftKisilikOda : Oda
    {
        public CiftKisilikOda(bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            if (denizManzarasiBilgisi == true)
                Fiyat = 900;
            else if (dagManzarasiBilgisi == true)
                Fiyat = 800;
            else if (ekonomikFiyatBilgisi == true)
                Fiyat = 650;
            else Fiyat = 800;

            KisiKapasitesi = 2;
            KlimaSecenigi = true;
            MiniBarSecenegi = true;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
        }
    }
}
