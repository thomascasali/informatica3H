using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//progetto di THOMAS CASALI
//scrivere un algoritmo che chiede in ingresso 2 numeri interi positivi e ne esegue la somma

namespace SommaDiNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, tot;
            do
            {
                Console.WriteLine("Inserisci il primo numero");
                num1 = Convert.ToInt32(Console.ReadLine());
            } while (num1 <= 0);

            do
            {
                Console.WriteLine("Inserisci il secondo numero");
                num2 = Convert.ToInt32(Console.ReadLine());
            } while (num2 <= 0);

            tot = num1 + num2;
            Console.WriteLine("La somma di " + num1 + " e " + num2 + " è " + tot);
            Console.ReadKey();
        }
    }
}
