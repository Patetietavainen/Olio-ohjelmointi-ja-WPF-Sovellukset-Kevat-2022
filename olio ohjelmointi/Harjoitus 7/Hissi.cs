using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_7
{
    class Hissi
    {
        private int minKerros;
        private int maxKerros;
        private int nykyinenKerros;

        public Hissi(int minKerros, int maxKerros)
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;

        }

        public int Nykyinenkerros
        {
            get => nykyinenKerros;
            set
            {
                if (value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("virheellinen Kerros");
                }
                else
                {
                    nykyinenKerros = value;
                }

            }
        }
    }
}