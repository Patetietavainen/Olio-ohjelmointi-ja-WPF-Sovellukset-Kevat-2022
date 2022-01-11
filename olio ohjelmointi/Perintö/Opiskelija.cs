using System;
using System.Collections.Generic;
using System.Text;

namespace Perintö
{
    class Opiskelija : Henkilö
    {

        public int opiskelijaID;
        public string koulu;
        private string v;

        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opiskelijaID;
            koulu = _koulu;
        }

        public Opiskelija(string nimi, int ikä, int henkilötunnus, string v) : base(nimi, ikä, henkilötunnus)
        {
            this.v = v;
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija:" + Nimi + ".Ikä:" + ". Koulu" + koulu + ". opiskelijaID:" + opiskelijaID);
        }



    }
}
