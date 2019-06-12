using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProgrami
{
    class OtelIterator : Iterator
    {
        List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
        int position = 0;

        internal List<Rezervasyon> Rezervasyonlar { get => rezervasyonlar; set => rezervasyonlar = value; }
        public int Position { get => position; set => position = value; }

        internal OtelIterator(List<Rezervasyon> rez)
        {
            Rezervasyonlar = rez;
        }

        public bool hasNext()
        {
            if (Position >= Rezervasyonlar.Count || Rezervasyonlar.ElementAt(Position) == null)
                return false;
            else
            {
                return true;
            }
        }

        public Object next()
        {
            return Rezervasyonlar.ElementAt(Position++);
        }

        public Object now()
        {
            Object returning = null;
            if (Position < Rezervasyonlar.Count)
            {
                returning = Rezervasyonlar.ElementAt(Position);
            }
            return returning;
        }
    }
}
