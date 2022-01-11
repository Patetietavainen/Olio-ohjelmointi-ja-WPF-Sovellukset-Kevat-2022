using System;

namespace Harjoitus_7
{
    class Program
    {
        private static string syöte;

        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);
            string syöte;
            while (true)
            {
                Console.WriteLine("Olet kerroksessa" + hissi.Nykyinenkerros);
                Console.WriteLine("Mihin kerrokseen haluat siirtyä?");
                syöte = Console.ReadLine();

                if (syöte == "poistu")
                {
                    Console.WriteLine("poistuit hissistä");
                    break;



                }
                else
                {
                    hissi.Nykyinenkerros = int.Parse(syöte);
                }

            }
        }
    }
}
