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
            int[] vectorInversat = InversareVector(vectorIntregi, n);

            Afisare(vectorInversat, n);
        

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

            static void Afisare(int[] vector, int n)
            {
                Console.WriteLine("Vectorul inversat este:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(vector[i] + " ");
                }
            }


            static int[] InversareVector (int[] vector, int n)
            {
                int[] vectorTemporar = new int[n];

                for (int i = 1; i <= n; i++)
                {
                    vectorTemporar[i-1] = vector[n - i];
                }
                return vectorTemporar;
            }

        }
    }
}
