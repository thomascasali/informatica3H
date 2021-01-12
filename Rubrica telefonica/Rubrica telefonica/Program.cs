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
                        Console.WriteLine("Inserisci il numero di cellulare");
                        cell[numContatti] = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Inserisci l'età (compresa tra 6 e 120 anni)");
                            eta[numContatti] = int.Parse(Console.ReadLine());
                            if (eta[numContatti] < 6 || eta[numContatti] > 120) Errore("");
                        } while (eta[numContatti] < 6 || eta[numContatti] > 120);
                        do
                        {
                            Console.WriteLine("Inserisci l'altezza (compresa tra 100 e 220 cm)");
                            altezza[numContatti] = int.Parse(Console.ReadLine());
                            if (altezza[numContatti] < 100 || altezza[numContatti] > 220) Errore("Attenzione, è stato inserita un'altezza non corretta");
                        } while (altezza[numContatti] < 100 || altezza[numContatti] > 220);
                        Console.WriteLine("Inserisci l'email");
                        email[numContatti] = Console.ReadLine();
                        //incremento il numero di contatti in rubrica
                        numContatti++;
                        break;
                    
                    case 2: //ricerca anagrafica
                        int sceltaTipoRicerca;
                        int altezzaDaCercare;
                        Console.WriteLine("Per quale campo vuoi effettuare la ricerca?");
                        Console.WriteLine("1) Nome");
                        Console.WriteLine("2) Email");
                        Console.WriteLine("3) Numero di telefono");
                        Console.WriteLine("4) Età");
                        Console.WriteLine("5) Altezza");
                        do
                        {
                            sceltaTipoRicerca = int.Parse(Console.ReadLine());
                        } while (sceltaTipoRicerca < 1 || sceltaTipoRicerca > 5);
                        switch (sceltaTipoRicerca)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                do
                                {
                                    Console.WriteLine("Inserisci l'altezza da ricercare (compresa tra 100 e 220 cm)");
                                    altezzaDaCercare= int.Parse(Console.ReadLine());
                                    if (altezzaDaCercare < 100 || altezzaDaCercare > 220) Errore("");
                                } while (altezzaDaCercare < 100 || altezzaDaCercare > 220);
                                for (int i = 0; i < numContatti; i++)
                                {
                                    if (altezza[i]== altezzaDaCercare) { 
                                        Console.WriteLine($"{i + 1}) {nomi[i]} \t {cell[i]} \t {email[i]} \t {eta[i]} \t {altezza[i]}");
                                    }
                                }
                                break;
                        }

                        break;
                    
                    case 4: //stampa numero contatti
                        Console.WriteLine("In rubrica sono memorizzate " + numContatti + " anagrafiche ");
                        break;

                    case 5: //stampa di tutti i contatti
                        for(int i = 0; i < numContatti; i++)
                        {
                            Console.WriteLine($"{i+1}) {nomi[i]} \t {cell[i]} \t {email[i]} \t {eta[i]} \t {altezza[i]}") ;
                        }
                        break;

                }
                if (finito == false) { 
                    Console.WriteLine("\n\noperazione completata. PREMI UN TASTO PER PROSEGUIRE");
                    Console.ReadKey();
                }
            } while (finito == false);

        }

        static void Errore(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (msg == "") {
                Console.WriteLine("Attenzione, è stato inserito un dato non corretto!");
            }
            else
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
