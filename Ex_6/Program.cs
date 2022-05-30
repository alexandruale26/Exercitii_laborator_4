using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti o functie recursiva care va calcula al n-lea element din
            // sirul lui Fibonacci, n fiind citit de la tastatura.


            Console.WriteLine("Introduceti numarul");
            int numar = 0;
            CitireNumar(ref numar);

            Console.WriteLine($"Elementul {numar} din sirul lui Fibonacci este {Fibonacci(numar)}");

            static void CitireNumar(ref int numar)
            {
                numar = int.Parse(Console.ReadLine());

                if (numar <= 0)
                {
                    Console.WriteLine("Numarul trebuie sa fie mai mare decat 0.");
                    System.Environment.Exit(0);
                }    
            }

            static int Fibonacci(int n)
            {
                if (n <= 2)
                    return 1;

                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
