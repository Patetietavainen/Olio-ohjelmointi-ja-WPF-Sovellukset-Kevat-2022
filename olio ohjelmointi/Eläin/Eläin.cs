using System;
using System.Collections.Generic;
using System.Text;

namespace Eläin
{
    abstract class Eläin 
    {
        private static int instanssit = 0; 

        public Eläin()
        {
            instanssit++; 
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä on elossa: " + instanssit);
        }

        public abstract void Ääntele();
    }
}
