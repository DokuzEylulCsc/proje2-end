using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class IkizYatakliOda : Oda
    {
        public IkizYatakliOda(bool denizManzarasiBilgisi, bool dagManzarasiBilgisi, bool ekonomikFiyatBilgisi)
        {
            if (denizManzarasiBilgisi == true)
                Fiyat = 900;
            else if (dagManzarasiBilgisi == true)
                Fiyat = 800;
            else if (ekonomikFiyatBilgisi == true)
                Fiyat = 500;
            else Fiyat = 650;

            KisiKapasitesi = 2;
            KlimaSecenigi = true;
            MiniBarSecenegi = false;
            DenizManzarasiSecenegi = denizManzarasiBilgisi;
            DagManzarasiSecenegi = dagManzarasiBilgisi;
            EkonomikFiyatSecenegi = ekonomikFiyatBilgisi;
        }
    }
}
