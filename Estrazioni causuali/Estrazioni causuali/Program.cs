using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrazioni_causuali
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; //tentativi per le difficolta intermedio e difficile
            var rnd = new Random(); //istanza dell'oggetto Random
            int casuale = rnd.Next(1, 101); //estrazione del numero casuale compreso tra 1 e 100
            Console.WriteLine("Scegli la difficoltà");
            Console.WriteLine("1) facile (infiniti tentativi con informazione) \n2) intermedio (10 tentativi con informazione) \n3) difficile (20 tentativi senza informazione)");
            var scelta = Char.Parse(Console.ReadLine()); //lettura del carattere scelto

            switch (scelta)
            {
                case '1':
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nFacile");
                    break;

                case '2':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nHai scelto la modalità di gioco intermedia");
                    n = 0;
                    int num; //numero inserito dall'utente
                    do
                    {
                        n++; //incrementa il numero di tentativi
                        Console.Write("\nInserisci il tuo {0}° tentativo:",n);
                        num = int.Parse(Console.ReadLine());
                        if (num < casuale)
                        {
                            Console.Write("\nIl numero che hai inserito è più piccolo di quello da indovinare");
                        }
                        if(num> casuale)
                        {
                            Console.Write("\nIl numero che hai inserito è più grande di quello da indovinare");
                        }
                        //n = n++; //sbagliata
                    } while (n <= 10 && num!=casuale);
                    
                    if (num == casuale)
                    {
                        Console.WriteLine("\nCOMPLIMENTI!!! Hai vinto in {0} tentativi",n);
                    }
                    else
                    {
                        Console.WriteLine("\nHAI PERSO!!!");
                    }

                    break;
                case '3':
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDifficile");
                    do
                    {
                        n = Convert.ToInt32(Console.Read());
                        n++;

                    } while (n <= 20);
                    break;
                default:
                    Console.WriteLine("Hai inserito un opzione non valida");
                    break;
            }
            Console.ReadKey();

        }
    }
}
