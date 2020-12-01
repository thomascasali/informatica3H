using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeriEstratti = new int[50];
            var rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                numeriEstratti[i] = rnd.Next(1, 51);
            }

            for (int i = 0; i < 50; i++)
            {
                if (i % 10 == 0 && i > 0) Console.WriteLine(); 
                Console.Write(numeriEstratti[i] + "\t| ");              
            }

            Console.WriteLine("\n");
            var dado = new int[6];
            for (int i = 0; i < 1000000; i++)
            {
                dado[rnd.Next(1, 7)-1]++;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"La faccia {i+1} del dado è stata estratta {dado[i]} volte");
            }
 
            Console.ReadKey();
        }
    }
}
