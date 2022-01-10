using System;
using System.Collections.Generic;
using System.Text;

namespace testiapp
{
    class koira
    {


        public string nimi;
        public int ikä;
        public string rotu;

        public void TulostaData()
        {

            Console.WriteLine("koiran nimi:" + nimi + ". ikä: " + ikä + ". Rotu" + rotu);
        }






        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }

    }
}
