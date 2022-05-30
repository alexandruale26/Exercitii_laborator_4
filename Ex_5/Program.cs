using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti  o functie recursiva care va calcula suma numerelor de
            // la 1 pana la n, apelati-o si afisati-i rezultatul.


            Console.WriteLine("Introduceti numarul");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Rezultatul este -->  " + SumaNumere(n));


            static int SumaNumere(int n)
            {
                if (n <= 1)
                    return 1;

                return n + SumaNumere(n - 1);
            }

        }
    }
}
