using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Kullanici
    {
        string adsoyad;
        LinkedList<Rezervasyon> rezervasyonlarim = new LinkedList<Rezervasyon>();

        public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        internal LinkedList<Rezervasyon> Rezervasyonlarim { get => rezervasyonlarim; set => rezervasyonlarim = value; }

        public abstract void BilgileriniGuncelle();
        public abstract void RezervasyonYap();
        public abstract void RezervasyonIptalEt();
    }
}
