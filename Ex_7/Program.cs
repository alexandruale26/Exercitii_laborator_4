using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti o functie recursiva care pentru un numar “n” 
               primit ca parametru, va afisa urmatoarea piramida a numerelor
                1
                2 2
                3 3 3
                4 4 4 4
                …
                n n n ….. n
            */



            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());


            Console.WriteLine();
            PiramidaNumerelor(numar, 1);



            static void Afisare(int numar, int index)
            {
                if (index <= 0)
                {
                    return;
                }

                Afisare(numar, index - 1);
                Console.Write(numar);
            }

            static void PiramidaNumerelor(int numar, int index)
            {
                if (numar <= 0)
                    return;

                Afisare(index, index);

                Console.WriteLine();

                PiramidaNumerelor(numar - 1, index + 1);
            }

        }
    }
}
