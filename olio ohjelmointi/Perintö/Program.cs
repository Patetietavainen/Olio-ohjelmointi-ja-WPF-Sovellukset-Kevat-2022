using System;

namespace Perintö
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Matti", 20,109294088124);
            Opiskelija opiskelija = new Opiskelija("Pekka", 15, 12894981, "Careeria");

            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();
        } 
    }
}
