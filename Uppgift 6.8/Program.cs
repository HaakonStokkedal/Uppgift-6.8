using System.Collections.Generic;
namespace Uppgift_6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int tal = int.Parse(Console.ReadLine());
            int raknare = 0;

            for (int i = tal - 1; i > 0; i--)
            {
                if (Primtal(i) == true)
                {
                    raknare++;
                }
            }
            Console.WriteLine($"Det är {raknare} antal primtal som är mindre än {tal}.");
            Console.ReadKey();
        }
        static bool Primtal(int tal)
        {
            if (tal < 2)
            {
                return true;
            }

            int namnare = 2;

            while (namnare * namnare <= tal)
            {
                if (tal % namnare == 0)
                {
                    return false;
                }
                namnare++;
            }
            return true;
        }
    }

}