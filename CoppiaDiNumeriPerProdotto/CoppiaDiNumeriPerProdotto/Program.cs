using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoppiaDiNumeriPerProdotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            do { 

                Console.WriteLine("Inserisci un numero intero positivo");
                n = Convert.ToInt32(Console.ReadLine());
                if (n<0) Console.WriteLine("Il numero inserito non è corretto!");

            } while (n < 0);

            for (i = 2; i < n; i++)
            {
                for (j = 2; j < n; j++)
                {
                    if (i * j == n)
                    {
                        Console.WriteLine("La coppia di numeri {0} e {1} moltiplicati producono {2}", i, j, n);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
