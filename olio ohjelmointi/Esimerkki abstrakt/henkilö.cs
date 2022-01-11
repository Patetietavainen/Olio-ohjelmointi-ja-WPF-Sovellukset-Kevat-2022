using System;
using System.Collections.Generic;
using System.Text;

namespace Esimerkki_abstrakt
{
    abstract class henkilö
    {
        public abstract string Nimi { get; set; }

        public abstract void Puhu();

        public static int instanssit = 0;

        public henkilöt ()
        {
          instanssit++;
        }

    public static void KuinkaMonta()
    {
            Console.WriteLine("Henkilöitä elossa:" + instanssit);
    }

}
}
