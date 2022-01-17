using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_8
{
    abstract class henkilö

    {
        public abstract string Nimi;
        public abstract int Ikä;
        public abstract int Henkilötunnus;

        public Henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;

        }

        public virtual void TulostaTiedot()
        {
            Console.WriteLine("Henkilö:" + Nimi + ". Ikä:" + Ikä);
        }

    }
