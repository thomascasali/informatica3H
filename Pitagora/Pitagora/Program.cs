using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagora
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, ris, n;
            do
            {
                Console.Write("Inserisci il numero n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1);
            Console.WriteLine();
            //quando esco dal ciclo ho un valore in n maggiore di 0
            for (x = 1; x <= n; x++)
            {
                for (y = 1; y <= n; y++)
                {
                    ris = x * y; //calcolo il valore di ris
                    Console.Write(ris + "\t"); //stampo ris seguito da tabulazione
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
