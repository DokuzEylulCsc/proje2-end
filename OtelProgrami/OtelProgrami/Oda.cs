using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class Oda
    {
        int fiyat;
        int kisiKapasitesi;

        // klima, minibar, deniz manzarasi var/yok vs.
        bool klimaSecenigi;
        bool miniBarSecenegi;
        bool denizManzarasiSecenegi;
        bool dagManzarasiSecenegi;

        // false ise fiyat Normal olsun, NormalFiyatSecenegine gerek kalmamis olur!
        bool ekonomikFiyatSecenegi;

        public int Fiyat { get => fiyat; set => fiyat = value; }
        public int KisiKapasitesi { get => kisiKapasitesi; set => kisiKapasitesi = value; }
        public bool KlimaSecenigi { get => klimaSecenigi; set => klimaSecenigi = value; }
        public bool MiniBarSecenegi { get => miniBarSecenegi; set => miniBarSecenegi = value; }
        public bool DenizManzarasiSecenegi { get => denizManzarasiSecenegi; set => denizManzarasiSecenegi = value; }
        public bool DagManzarasiSecenegi { get => dagManzarasiSecenegi; set => dagManzarasiSecenegi = value; }
        public bool EkonomikFiyatSecenegi { get => ekonomikFiyatSecenegi; set => ekonomikFiyatSecenegi = value; }
    }
}
