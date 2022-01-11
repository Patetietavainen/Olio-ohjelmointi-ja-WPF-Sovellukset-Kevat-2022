using System;

namespace Laskin
{
    static class Program
    {
        static void Main(string[] args)
        {
            float a = 15;
            float b = 30;

            Console.WriteLine(Laskin.Summa(a, b));
            Console.WriteLine(Laskin.Erotus(a, b));
            Console.WriteLine(Laskin.Kerto(a, b));
            Console.WriteLine(Laskin.Jakolasku(a, b));

        }
    }
}
