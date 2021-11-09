using System;

namespace cyklus
{
    class Program
    {
        static void Main(string[] args)
        {

            int cislo = 1;
            while (cislo <= 10)
                {
                Console.WriteLine(cislo);
                cislo++;
                //cislo = cislo = 1;
                //cislo += 1;
            }
            Console.ReadLine();
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
