using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class CiftKisilikOda : Oda
    {
        public CiftKisilikOda(int fiyat, string odaOzeligi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 2;
            OdaOzelligi = odaOzeligi;
            OdaTuru = "Çift kişilik oda";
        }

    }
}
