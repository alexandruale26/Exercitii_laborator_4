using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cititi de la tastatura continutul a doua matrici de intregi cu 2 
               dimensiuni avand lungimile n, m, respectiv m ,n. Lungimile celor doua dimensiuni
               ale matricilor, m si n, vor fi citite de la tastura. Scrieti o functie care 
               va calcula produsul celor doua matrici, apelati-o si afisati-i rezultatul.
            */

            int n = CitireDimensiuni();
            int m = CitireDimensiuni();


            Console.WriteLine("\nCreati matricea 1");
            int[,] matrice1 = CitireMatrice(n,m);

            Console.WriteLine("\nCreati matricea 2");
            int[,] matrice2 = CitireMatrice(m,n);

            Console.WriteLine("\nProdusul celor doua matrici este:");
            int[,] matrice3 = ProdusMatrici( matrice1, matrice2);

            //AfisareMatrice(n, m, matrice1);
            //AfisareMatrice(m, n, matrice2);
            AfisareMatrice(matrice1.GetLength(0), matrice2.GetLength(1), matrice3);


            static int CitireDimensiuni()
            {
                Console.WriteLine("Introduceti dimensiunea");
                return int.Parse(Console.ReadLine());
            }


            static int[,] CitireMatrice(int n, int m)
            {
                int[,] matrice = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.WriteLine("Introduceti valoarea");
                        matrice[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                return matrice;
            }


            static void AfisareMatrice(int n, int m, int[,] matrice)
            {
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(matrice[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
            }


            static int[,] ProdusMatrici(int[,] matrice1, int[,] matrice2)
            {
                int m1Linie = matrice1.GetLength(0);
                int m1Coloana = matrice1.GetLength(1);
                //int m2Linie = matrice2.GetLength(0);
                int m2Coloana = matrice2.GetLength(1);

                int aux;

                int[,] produsMatrice = new int[m1Linie, m2Coloana];

                for (int i = 0; i < m1Linie; i++)
                {
                    for (int j = 0; j < m2Coloana; j++)
                    {
                        aux = 0;

                        for (int k = 0; k < m1Coloana; k++)
                        {
                            aux += matrice1[i, k] * matrice2[k, j];
                        }
                        produsMatrice[i, j] = aux;
                    }
                }
                return produsMatrice;
            }

        }
    }
}
