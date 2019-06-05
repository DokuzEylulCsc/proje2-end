using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Rezervasyon
    {
        DateTime rezervasyonTarihi;
        Otel otelBilgisi;
        Oda odaBilgisi;
        LinkedList<Uye> rezervasyonSahipleri = new LinkedList<Uye>();

        Rezervasyon(DateTime rezTarihi, Otel otel, Oda oda, LinkedList<Uye> kalacakKisiler)
        {
            RezervasyonTarihi = rezTarihi;
            OtelBilgisi = otel;
            OdaBilgisi = oda;
            RezervasyonSahipleri = kalacakKisiler;
        }

        public DateTime RezervasyonTarihi { get => rezervasyonTarihi; set => rezervasyonTarihi = value; }
        internal Otel OtelBilgisi { get => otelBilgisi; set => otelBilgisi = value; }
        internal Oda OdaBilgisi { get => odaBilgisi; set => odaBilgisi = value; }
        internal LinkedList<Uye> RezervasyonSahipleri { get => rezervasyonSahipleri; set => rezervasyonSahipleri = value; }
    }
}
