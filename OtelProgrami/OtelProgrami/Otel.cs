﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    public abstract class Otel
    {
        int yildizSayisi;

       //Yonetici erisebilir
        public abstract void OdalariGoster();
        public abstract void MusterileriGoster();
    }
}
