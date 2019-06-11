using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class IkizYatakliOda : Oda
    {
        public IkizYatakliOda(int fiyat,string odaOzeligi)
        {
            Fiyat = fiyat;
            KisiKapasitesi = 2;
            OdaOzelligi = odaOzeligi;
            OdaTuru = "İkiz yataklı oda";
        }
    }
}
