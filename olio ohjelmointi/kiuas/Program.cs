using System;

namespace kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas harvia = new kiuas( "harvia",  80,  50) ;

            harvia.Näytätiedot();
            harvia.tila = true;
            harvia.Näytätiedot();
            harvia.Säädälämpötila(100);
            harvia.Näytätiedot();
        }
    }
}