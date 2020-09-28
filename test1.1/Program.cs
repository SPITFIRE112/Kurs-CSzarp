using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst");
            string tekst = Console.ReadLine();
            tekst = tekst.Replace("a","@");
            Console.WriteLine(tekst);
            Console.ReadKey();
        }
    }
}
