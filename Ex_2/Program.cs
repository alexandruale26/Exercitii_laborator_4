using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni 
               avand lungimile n, m, k. Lungimile celor trei dimensiuni ale matricii, 
               n, m si k, vor fi citite de la tastura. 
               
               - Scrieti o functie care va calcula suma elementelor unei astfel de matrici, 
               apelati-o si afisati-i rezultatul.                
               - Scrieti o functie care va determina elementul cu valoare maxima, apelati-o
               si afisati-i rezultatul .
            */

            int n = CitireNumere();
            int m = CitireNumere();
            int k = CitireNumere();

            int[,,] matrice3D = CitireMatrice(n, m, k);

            int suma = SumaElementeMatrice(n, m, k, matrice3D);
            int max = MaxElementMatrice(n,m,k,matrice3D);

            AfisareMatrice(matrice3D);

            Console.WriteLine($"Suma elementelor matricei este --> {suma}");
            Console.WriteLine($"Cel mai mare element al matricei este --> {max}");

          
            static int CitireNumere()
            {
                Console.WriteLine("Introduceti dimensiunea");
                return int.Parse(Console.ReadLine());
            }


            static int[,,] CitireMatrice(int n, int m, int k)
            {
                int[,,] matriceTemp = new int[n, m, k];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int y = 0; y < k; y++)
                        {
                            Console.WriteLine("Introduceti elementul");
                            matriceTemp[i, j, y] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                return matriceTemp;
            }


            static void AfisareMatrice(int[,,] matrice3D)
            {
                Console.WriteLine("\nMatricea este:");

                for (int i = 0; i < matrice3D.GetLength(0); i++)
                {
                    for (int j = 0; j < matrice3D.GetLength(1); j++)
                    {
                        for (int y = 0; y < matrice3D.GetLength(2); y++)
                        {
                            Console.Write(matrice3D[i, j, y] + "  ");
                        }
                        Console.Write("   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            static int SumaElementeMatrice(int n, int m, int k, int[,,] matrice3D)
            {
                int suma = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int y = 0; y < k; y++)
                        {
                            suma += matrice3D[i, j, y];
                        }
                    }
                }
                return suma;
            }


            static int MaxElementMatrice(int n, int m, int k, int[,,] matrice3D)
            {
                int max = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        for (int y = 0; y < k; y++)
                        {
                            max = Math.Max(max, matrice3D[i, j, y]);
                        }
                    }
                }
                return max;
            }

        }
    }
}
