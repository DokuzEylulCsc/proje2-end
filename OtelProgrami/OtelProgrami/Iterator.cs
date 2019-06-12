using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    public interface Iterator
    {
        Boolean hasNext();
        Object now();
        Object next();
    }
}
