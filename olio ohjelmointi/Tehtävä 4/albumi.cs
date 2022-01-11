using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtävä_4
{
    class Albumi
    {
        private List<kappale> kappaleet = new List<kappale>();

        public void LisääKappale(kappale uusiKappale) => kappaleet.Add(uusiKappale);

    {
         public void TulostaKappaleet()
        {
            foreach (kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.nimi + "," + kappale.pituus);
            }

           


        }



        }

    }

