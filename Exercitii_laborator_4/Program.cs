using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura.
            // Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-i rezultatul.

            Console.WriteLine("Cate elemente are vectorul?");
            int n = int.Parse(Console.ReadLine());

            int[] vectorIntregi = CreareVector(n);

            InversareAfisareVector(vectorIntregi, n);
        

            static int[] CreareVector(int n)
            {
                int[] vector = new int[n];

                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine("Introduceti elementul");
                    vector[i] = int.Parse(Console.ReadLine());
                }

                return vector;
            }

            static void Afisare(int n)
            {
                Console.Write(n + " ");
            }

            static void InversareAfisareVector (int[] vector, int n)
            {
                Console.WriteLine("Vectorul inversat este:");
                for (int i = n-1; i >=0 ; i--)
                {
                    Afisare(vector[i]);
                }
            }
        }
    }
}
