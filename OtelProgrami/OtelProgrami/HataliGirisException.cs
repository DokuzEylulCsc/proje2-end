using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class HataliGirisException : Exception
    {
        internal HataliGirisException(string message) : base("Üye olunurken tel no veya tc no girilirken harf kullanıldı")
        {

        }
    }
}
