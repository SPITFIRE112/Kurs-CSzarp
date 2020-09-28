using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int numer = Int32.Parse(Console.ReadLine());


            if (numer <= 50)
            {
                Console.WriteLine("Tak! Liczba jest mniejsza lub równa 50");
            }
            else
            {
                Console.WriteLine("Nie! Liczba jest większa od 50");
            }

            Console.ReadLine();
            Main(args);
        }
    }
}
