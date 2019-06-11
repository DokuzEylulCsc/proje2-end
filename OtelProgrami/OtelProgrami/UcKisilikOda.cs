using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class UcKisilikOda : Oda
    {
        public UcKisilikOda(int fiyat, string odaOzeligi)
        {

            Fiyat = fiyat;
            KisiKapasitesi = 3;
            OdaOzelligi = odaOzeligi;
            OdaTuru = "Üç kişilik oda";
        }

    }
}
