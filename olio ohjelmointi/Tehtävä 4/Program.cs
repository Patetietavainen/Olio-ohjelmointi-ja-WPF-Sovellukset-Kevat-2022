using System;

namespace Tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            albumi.LisääKappale(new kappale("Kappale 1", "06:25"));
            albumi.LisääKappale(new kappale("Kappale 1", "06:25"));
            albumi.LisääKappale(new kappale("Kappale 1", "06:25"));
        
        }
    }
}
