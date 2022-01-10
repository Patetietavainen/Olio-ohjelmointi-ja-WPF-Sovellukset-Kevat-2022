using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo ajoneuvo1 = new ajoneuvo();
            ajoneuvo1.nimi = "Audi";
            ajoneuvo1.nopeus = 100;
            ajoneuvo1.renkaat = "michelin";

            ajoneuvo1.nopeus();
            ajoneuvo1.TulostaData();

           
        }
}
