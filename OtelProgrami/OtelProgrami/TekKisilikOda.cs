using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class TekKisilikOda : Oda
    {
        public TekKisilikOda(int fiyat, string odaOzelligi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 1;
            OdaOzelligi = odaOzelligi;
            OdaTuru = "Tek Kişilik Oda";
        }

    }
}
