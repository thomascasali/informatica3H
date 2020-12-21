using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringheComeVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            string testo;
            int i;
            char carattereDaCercare;

            Console.WriteLine("Inserisci la frase di partenza");
            testo = Console.ReadLine();
            Console.WriteLine("Inserisci il carattere da ricercare nella frase");
            carattereDaCercare = char.Parse(Console.ReadLine());

            //soluzione alternativa:
            //string aux = Console.ReadLine();
            //carattereDaCercare = aux[0];

            //prima soluzione esito della ricerca con variabile booleana
            bool trovato = false;
            for (i = 0; i < testo.Length; i++)
            {
                //Console.WriteLine(Char.ToUpper(testo[i]));
                if (testo[i] == carattereDaCercare)
                {
                    Console.WriteLine($"Il carattere è stato trovato nella posizione {i}");
                    trovato = true;
                }
            }
            if (!trovato) {
                Console.WriteLine($"Il carattere NON è stato trovato!");
            }

            //seconda soluzione utlizzando il contatore i con la condizione di uscita dal ciclo nel momento in cui il carattere viene trovato all'interno della frase           
            for (i = 0; i < testo.Length; i++)
            {
                //Console.WriteLine(Char.ToUpper(testo[i]));
                if (testo[i] == carattereDaCercare)
                {
                    Console.WriteLine($"Il carattere è stato trovato nella posizione {i}");
                    break;
                }
            }

            if (i==testo.Length)
            {
                Console.WriteLine($"Il carattere NON è stato trovato!");
            }

            Console.ReadKey();
        }
    }
}
