using System;
using System.Collections.Generic;
using System.Text;

namespace Esimerkki_abstrakt
{
    class Opiskelija : Henkilö
    {
        public override string Nimi { get; set; }

        public override void Puhu()
        {
            Console.WriteLine(Nimi + " puhuu opiskelija luokassa");
        }
    }
}
