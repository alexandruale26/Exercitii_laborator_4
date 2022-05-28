using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti o functie recursiva care va afisa in ordine
            // elementele unui vector de intregi.


            Console.WriteLine("Cate elemente are vectorul?");
            int n = int.Parse(Console.ReadLine());

            int[] vector = CitireVector(n);

            Console.WriteLine("Elementele vectorului sunt");
            AfisareVector(n, vector);


            static int[] CitireVector(int n)
            {
                int[] vector = new int[n];

                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("Introduceti elementul");
                    vector[i] = int.Parse(Console.ReadLine());
                }
                return vector;
            }

            static void AfisareVector(int n, int[] vector)
            {
                if (n-1 < 0)
                {
                    return;
                }
                    
                AfisareVector(n-1, vector);
                Console.Write(vector[n-1] + " ");
            }

        }
    }
}
