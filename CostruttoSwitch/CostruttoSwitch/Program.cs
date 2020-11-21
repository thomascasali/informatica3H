using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostruttoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserisci il valore di N: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("\nInserisci il valore di M: ");
            var m = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nQuale operazione vuoi svolgere?\n1) divisione\n2) moltiplicazione\n3) elevamento a potenza");
            var scelta = char.Parse(Console.ReadLine());
            switch (scelta)
            {
                case '1':
                    Console.WriteLine("hai scelto di dividere n ed m");

                    break;
                case '2':
                    Console.WriteLine("hai scelto di moltiplicare n ed m");

                    break;
                case '3':
                    Console.WriteLine("hai scelto di elevare n alla m");
                    int eleva = n;
                    for(int i=1; i < m; i++)
                    {
                        eleva=eleva*n;
                    }
                    Console.WriteLine("\nil risultato dell'operazione è {0}", eleva);

                    break;

                default:
                    Console.WriteLine("la scelta inserita non è valida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
