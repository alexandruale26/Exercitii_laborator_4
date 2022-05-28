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

            int suma = 0, max = 0;

            int[,,] matrice3D = new int[n, m, k];



            CalculeMatrice3D(ref suma, ref max, matrice3D);
            AfisareMatrice(matrice3D);

            Console.WriteLine($"Suma elementelor matricei este --> {suma}");
            Console.WriteLine($"Cel mai mare element al matricei este --> {max}");

          

            static int CitireNumere()
            {
                Console.WriteLine("Introduceti dimensiunea");
                return int.Parse(Console.ReadLine());
            }


            static void CitireMatrice(int i, int j, int y, int[,,] matrice3D)
            {
                Console.WriteLine("Introduceti elementul");
                matrice3D[i, j, y] = int.Parse(Console.ReadLine());
            }


            static void SumaElementeMatrice(ref int suma, int i, int j, int y, int[,,] matrice3D)
            {
                suma += matrice3D[i, j, y];
            }


            static void MaxElementMatrice(ref int max, int i, int j, int y, int[,,] matrice3D)
            {
                max = Math.Max(max, matrice3D[i, j, y]);
            }


            static void CalculeMatrice3D(ref int suma, ref int max, int[,,] matrice3D)
            {
                for (int i = 0; i < matrice3D.GetLength(0); i++)
                {
                    for (int j = 0; j < matrice3D.GetLength(1); j++)
                    {
                        for (int y = 0; y < matrice3D.GetLength(2); y++)
                        {
                            CitireMatrice(i, j, y, matrice3D);
                            SumaElementeMatrice(ref suma, i, j, y, matrice3D);
                            MaxElementMatrice(ref max, i, j, y, matrice3D);
                        }
                    }
                }
                Console.WriteLine();
            }


            static void AfisareMatrice(int[,,] matrice3D)
            {
                Console.WriteLine("Matricea este:");

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


        }
    }
}
