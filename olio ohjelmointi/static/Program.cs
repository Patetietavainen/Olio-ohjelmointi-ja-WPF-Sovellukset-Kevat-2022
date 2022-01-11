using System;

namespace static_esimerkki
{
    static class Program
    {
        static void Main(string[] args)
        {
            float km = 45f;
            float mailit = Muuntaja.KMtoMiles(km);

            Console.WriteLine(km + "Kilometriä on yhtä kuin " + mailit + "mailia");
        }
       
    }
}
