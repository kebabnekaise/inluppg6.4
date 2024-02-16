using System;

namespace inluppg6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en bas, sedan en exponent");
            double bas = double.Parse(Console.ReadLine());
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine(Exponent(bas, exponent));
        }

        static double Exponent(double x, int y)
        {
            double resultat = x;
            for (int i = 1; i < y; i++)
            {
                resultat = resultat * x;
            }

            return resultat;
        }
    }
}