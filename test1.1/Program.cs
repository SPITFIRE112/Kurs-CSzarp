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
               char[,] tablica = new char[400, 2];
           
            
        
            string klucz = "3+p8eJrEQNb&RQyAN_xsfgm5NBSVXCB#?+?pJtS!!6KkkNcf4C9ZqtYsC&2j=6RecsEDTa-TFyV6G54TE*k%yq8TQB9yD"; // 93 characters to full security



             for (int i = 0; i < klucz.Length; i++)
			{
                    tablica[i, 0] = (char)(i+33);
                tablica[i, 1]= klucz[i];
            }
           
            
      
			
        
            Console.WriteLine("Wpisz tekst");
            string tekst = Console.ReadLine();
         
            for (int i = 0; i < tablica.Length/2; i++)
			{
                Console.WriteLine("Zamieniam" + tablica [ i, 0]);
                Console.WriteLine("na" + tablica[ i, 1]);
                tekst = tekst.Replace(tablica[i, 0], tablica[i, 1]);
            }
           Console.WriteLine("Zaszyfrowany");
            Console.WriteLine(tekst);
            Console.WriteLine("Odszyfrowany");

              for (int i = 0; i < tekst.Length; i++)
			{
                Console.WriteLine("Zamieniam" + tablica [ i, 0]);
                Console.WriteLine("na" + tablica[ i, 1]);
                tekst = tekst.Replace(tablica[i, 0], tablica[i, 1]);
            }
           
                Console.WriteLine(tekst);


            Main(args);
           
        }
    }
}
