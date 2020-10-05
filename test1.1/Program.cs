using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._1
{
   
        
    class Program
    {
        public static char[,] tablica = new char[,]
            {
            { 'a', '@' },
            { 'i', '&' },
            { 'h', '#' },
            { 's', '$' }
            };
            


        static void Main(string[] args)
        {
            
      
			
        
            Console.WriteLine("Wpisz tekst");
            string tekst = Console.ReadLine();
         
            for (int i = 0; i < tablica.Length/2; i++)
			{
                Console.WriteLine("Zamieniam" + tablica [ i, 0]);
                Console.WriteLine("na" + tablica[ i, 1]);
                tekst = tekst.Replace("a","@");
            }
           
            Console.WriteLine(tekst);
            Main(args);
           
        }
    }
}
