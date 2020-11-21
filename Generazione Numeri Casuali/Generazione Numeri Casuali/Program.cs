using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generazione_Numeri_Casuali
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Random rnd = new Random(); //dichiarazione e istanziazione della variabile rnd di tipo Random
            
            n = rnd.Next();//numero intero casuale
            Console.WriteLine("Numero estratto = {0}",n);

            n = rnd.Next(50);//numero intero casuale da 0 a 49
            Console.WriteLine("Numero estratto = " + n);

            n = rnd.Next(30,50);//numero intero casuale da 30 a 49
            Console.WriteLine("Numero estratto = " + n);

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(rnd.Next(100));
            }
            Console.ReadKey();
        }
    }
}
