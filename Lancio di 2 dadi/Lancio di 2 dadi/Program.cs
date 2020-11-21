using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_di_2_dadi
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione e inizializzazione delle variabili
            int dado1, dado2;
            var rnd = new Random();
            int lanci, contaDoppi = 0;

            //richiesta del numero di lanci da effettuare
            do
            {
                Console.Write("Quanti lanci vuoi effettuare? ");
                lanci = int.Parse(Console.ReadLine());
            } while (lanci <= 0);

            //eseguo i lanci scelti dall'utente
            for(int i = 0; i < lanci; i++)
            {
                dado1 = rnd.Next(1, 7); 
                dado2 = rnd.Next(1, 7);
                //verifica della condizione dei 2 dadi uguali
                if (dado1 == dado2) contaDoppi++;
            }

            //stampa dei risultati
            Console.WriteLine($"\nSu {lanci} lanci il numero di volte che sono uscite le stesse facce è {contaDoppi}");
            double perc = (double)contaDoppi / (double)lanci * 100;
            Console.WriteLine($"\nLa percentuale di uscita di facce doppie è {perc}%");
            Console.ReadKey();
        }
    }
}
