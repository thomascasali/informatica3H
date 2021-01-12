using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica_telefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomi = new string[250]; //vettore contenente i nomi
            var eta = new int[250];     //vettore contenente le età
            var altezza = new int[250]; //vettore contenente le altezze
            var cell = new string[250]; //vettore contenente i numeri di cellulare
            var email = new string[250];//vettore contenente le email
            int scelta;
            bool finito = false;
            int numContatti = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Quale operazione vuoi eseguire?");
                Console.WriteLine("1) Inserimento di una anagrafica in rubrica");
                Console.WriteLine("2) Ricerca di una anagrafica in rubrica");
                Console.WriteLine("3) Cancellazione di una anagrafica in rubrica");
                Console.WriteLine("4) Conteggio delle anagrafica in rubrica");
                Console.WriteLine("5) Stampa di tutte le anagrafica in rubrica");
                Console.WriteLine("0) Esci dal programma\n");
                do
                {
                    scelta = int.Parse(Console.ReadLine());
                } while (scelta < 0 || scelta > 5);

                switch (scelta)
                {
                    case 0:
                        finito = true;
                        break;
                    case 1:
                        Console.WriteLine("Inserisci cognome e nome del contatto");
                        nomi[numContatti] = Console.ReadLine();
                        numContatti++;
                        break;
                    case 4:
                        Console.WriteLine("In rubrica sono memorizzate " + numContatti + " anagrafiche ");
                        break;
                    case 5:
                        for(int i = 0; i < numContatti; i++)
                        {
                            Console.WriteLine((i+1) + ") " + nomi[i]);
                        }
                        break;

                }
                if (finito == false) { 
                    Console.WriteLine("\n\noperazione completata. PREMI UN TASTO PER PROSEGUIRE");
                    Console.ReadKey();
                }
            } while (finito == false);

        }
    }
}
