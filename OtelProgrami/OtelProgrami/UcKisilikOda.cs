using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class UcKisilikOda : Oda
    {
        public UcKisilikOda(int fiyat, string odaOzelligi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 3;
            OdaOzelligi = odaOzelligi;
            OdaTuru = "Üç Kişilik Oda";
        }

    }
}
