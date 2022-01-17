using System;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<kanava> kanavat = new List<kanava>();
            LisääKanavat(kanavat);
            Radio radio = new Radio();

            radio.kytkin = true
            radio.TulostaTiedot();

            radio.Äänenvoimakkuus = 9
            radio.Taajuus =99.5f

            radio.TulostaTiedot();
            radio.kanavaanYhdistetty(kanavat);

            radio.Taajuus = 102.5f

            radio.kanavaanYhdstetty(kanavat);
        }


        static void LisääKanavat(list<kanava> kanavat)

            
    
    }
}
