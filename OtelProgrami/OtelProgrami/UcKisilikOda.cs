using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class UcKisilikOda : Oda
    {
        public UcKisilikOda(bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            if (denizManzarasiBilgisi == true)
                Fiyat = 850;
            else if (dagManzarasiBilgisi == true)
                Fiyat = 750;
            else if (ekonomikFiyatBilgisi == true)
                Fiyat = 600;
            else Fiyat = 675;

            KisiKapasitesi = 3;
            KlimaSecenigi = true;
            MiniBarSecenegi = false;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
        }
    }
}
