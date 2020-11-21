using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_del_dado
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int numLanci;
            int facciaEstratta;
            int uno = 0, due = 0, tre = 0, quattro = 0, cinque = 0, sei = 0;
            int valore, facciaMin, facciaMag;
            List<string> estrazioni = new List<string>();

            do
            {
                Console.Write("Inserisci il numero di lanci da effettuare: ");
                numLanci = int.Parse(Console.ReadLine());
            } while (numLanci < 0);

            for(int i = 0; i < numLanci; i++)
            {
                facciaEstratta = rnd.Next(1, 7);
                estrazioni.Add(facciaEstratta.ToString());
                switch (facciaEstratta)
                {
                    case 1:
                        uno++;
                        break;
                    case 2:
                        due++;
                        break;
                    case 3:
                        tre++;
                        break;
                    case 4:
                        quattro++;
                        break;
                    case 5:
                        cinque++;
                        break;
                    case 6:
                        sei++;
                        break;

                }
            }

            Console.Write("\n\nLa faccia 1 è stata estratta " + uno + " volte");
            Console.Write($" - Rispetto alle {numLanci/6} volte attese la differenza è {uno/numLanci}");

            Console.Write("\n\nLa faccia 2 è stata estratta " + due + " volte");
            Console.Write("\n\nLa faccia 3 è stata estratta " + tre + " volte");
            Console.Write("\n\nLa faccia 4 è stata estratta " + quattro + " volte");
            Console.Write("\n\nLa faccia 5 è stata estratta " + cinque + " volte");
            Console.Write("\n\nLa faccia 6 è stata estratta " + sei + " volte");


            valore = uno;
            facciaMag = 1;
            if (due > valore) { facciaMag = 2; valore = due; }
            if (tre > valore) { facciaMag = 3; valore = tre; }
            if (quattro > valore) { facciaMag = 4; valore = quattro; }
            if (cinque > valore) { facciaMag = 5; valore = cinque; }
            if (sei > valore) facciaMag = 6;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLa faccia che è stata estratta con maggior frequenza è la faccia " + facciaMag);

            valore = uno;
            facciaMin = 1;
            if (due < valore) { facciaMin = 2; valore = due; }
            if (tre < valore) { facciaMin = 3; valore = tre; }
            if (quattro < valore) { facciaMin = 4; valore = quattro; }
            if (cinque < valore) { facciaMin = 5; valore = cinque; }
            if (sei < valore) facciaMin = 6;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("La faccia che è stata estratta con minor frequenza è la faccia " + facciaMin);

            Console.WriteLine($"Sono state fatte {estrazioni.Count} estrazioni");
            foreach(string es in estrazioni)
            {
                Console.Write($"{es}, ");
            }

            Console.ReadKey();
        }
    }
}
