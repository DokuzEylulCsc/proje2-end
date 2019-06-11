using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class IkizYatakliOda : Oda
    {
        public IkizYatakliOda(int fiyat,string odaOzelligi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 2;
            OdaOzelligi = odaOzelligi;
            OdaTuru = "İkiz Yataklı Oda";
        }
    }
}
