using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soloSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nScegli la modalità di gioco:\n1) facile\n2) intermedio\n3) difficile");
            var scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("hai scelto facile");

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("hai scelto intermedio");

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("hai scelto difficile");

                    break;
                default:
                    Console.WriteLine("hai inserito un'opzione non valida");

                    break;
            }
            Console.ReadKey();
        }
    }
}
