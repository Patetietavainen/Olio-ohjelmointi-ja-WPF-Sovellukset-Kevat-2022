using System;
using System.Collections.Generic;
using System.Text;

namespace Perintö
{
    class Henkilö
    {
        public string Nimi;
        public int Ikä;
        public int Henkilötunnus;

        public Henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;
            Henkilötunnus = henkilötunnus;
        }

        public virtual void TulostaTiedot()
        {
            Console.WriteLine("Henkilö:" + Nimi + ". Ikä:" + Ikä + "Henkilötunnus:" + Henkilötunnus);
        }
    }
}
