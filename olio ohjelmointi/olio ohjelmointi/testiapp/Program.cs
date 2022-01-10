using System;

namespace testiapp
{
    class Program 
    {
        static void Main(string[] args)
        {
            koira koira1 = new koira();
            koira1.nimi = "rekku";
            koira1.ikä = 4;
            koira1.rotu = "saksanpaimenkoira";

            koira1.Hauku();
            koira1.TulostaData();

            koira koira2 = new koira();
            koira2.nimi = "asd";
            koira2.ikä = 2;
            koira2.rotu = "mopsi";

            koira2.TulostaData();


        }
    }
}
