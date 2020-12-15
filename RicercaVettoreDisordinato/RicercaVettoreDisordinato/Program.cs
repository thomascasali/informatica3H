using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicercaVettoreDisordinato
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensione;
            int numDaRicercare, i;
            bool trovato = false;
            var rnd = new Random();
            do
            {
                Console.WriteLine("Inserisci la dimensione del vettore:");
                dimensione = int.Parse(Console.ReadLine());
            } while (dimensione < 10 || dimensione > 100);
            var vettore = new int[dimensione]; //istanzio oggetto vettore

            for (i = 0; i < dimensione; i++)
            {
                vettore[i] = rnd.Next(1, 1001); //riempio il vettore di numeri da 1 a 1000
                Console.Write(vettore[i] + ", ");
            }

            do
            {
                Console.Write("\nInserisci un numero da ricercare all'interno del vettore: ");
                numDaRicercare = int.Parse(Console.ReadLine());

                for (i = 0; i < dimensione; i++)
                {
                    if (vettore[i] == numDaRicercare) break;
                }

                if (i == dimensione)
                {
                    Console.WriteLine("Il numero inserito non è presente nel vettore");
                }
                else
                {
                    Console.WriteLine($"Il numero inserito è presente nel vettore nella posizione {i}");
                    trovato = true;
                }
            } while (trovato == false);
            Console.ReadKey();
        }
    }
}
