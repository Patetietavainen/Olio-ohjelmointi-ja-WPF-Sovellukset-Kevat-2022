using System;
using System.Collections.Generic;
using System.Text;

namespace kiuas
{
    class kiuas
    {
        private string merkki;
        private int lämpötila;
        private int kosteus;
        public bool tila = false;


        public kiuas(string _merkki, int _lämpötila, int _kosteus)

        {

            merkki = _merkki;
            lämpötila = _lämpötila;
            kosteus = _kosteus;

        }

        internal void TulostaData()
        {
            throw new NotImplementedException();
        }

        public void Näytätiedot()
        {
            if (tila)
            {
                Console.WriteLine("kiuas" + merkki + "on päällä");
                Console.WriteLine("lämpötila=" + lämpötila);
                Console.WriteLine("kosteus=" + kosteus);
            }
            else
            {
                Console.WriteLine("kiuas" + merkki + "ei ole päällä");
            }

        }

        public void Säädälämpötila(int uusiLämpötila)

        {
            lämpötila = uusiLämpötila;
        }








    }
}
