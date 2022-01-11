using System;

namespace Esimerkki_abstrakt
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Nimi = "Pekka";

            opiskelija.Puhu();

            Henkilö.KuinkaMonta();
        }
    }
}
