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

        public koira()
        {
        }

       public koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Hauku();
        }


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
