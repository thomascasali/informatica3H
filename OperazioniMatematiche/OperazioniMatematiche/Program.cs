using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Scrivere un programma che chiede in ingresso 2 numeri interi e stampa a video il risultato di
- somma
- differenza
- prodotto
- divisione
infine stampa tutti i numeri interi compresi tra i 2 numeri inseriti
*/

namespace OperazioniMatematiche
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int somma, prodotto, differenza;
            double divisione;
            Console.Write("Inserisci il primo numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInserisci il secondo numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            somma = a + b;
            //Console.WriteLine("\nIl risultato della somma tra " + a + " e " + b + " è " + somma);
            Console.WriteLine("\nIl risultato della somma tra {0} e {1} è {2}",a,b,somma);
            differenza = a - b;
            Console.WriteLine("\nIl risultato della differenza tra {0} e {1} è {2}", a, b, differenza);
            prodotto = a * b;
            Console.WriteLine("\nIl risultato del prodotto tra {0} e {1} è {2}", a, b, prodotto);
            divisione = a*1.0 / b;
            Console.WriteLine("\nIl risultato della divisione tra {0} e {1} è {2}", a, b, divisione);

            if (b < a)
            {
                int scambio = a;
                a = b;
                b = scambio;
            }

            Console.WriteLine("\nI numeri compresi tra {0} e {1} sono:", a, b);
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
