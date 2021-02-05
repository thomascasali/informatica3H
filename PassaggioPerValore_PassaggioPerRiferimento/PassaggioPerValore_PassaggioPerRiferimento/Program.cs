using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaggioPerValore_PassaggioPerRiferimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string messaggio = "passa il dato per valore";
            Stampa(messaggio); //passaggio della variabile messaggio per valore
            Console.WriteLine(messaggio); //stampo lo stesso valore di messaggio
            StampaConPassaggioPerRiferimento(ref messaggio); //passo la variabile messaggio per riferimento
            Console.WriteLine(messaggio); //stampo il valore impostato dentro il metodo
            Console.ReadKey();  
        }

        static void Stampa(string messaggio)
        {
            Console.WriteLine(messaggio);
            messaggio = ""; //istruzione inutile perché non succede più nulla con la variabile messaggio
        }

        static void StampaConPassaggioPerRiferimento(ref string txt)
        {
            Console.WriteLine(txt);
            txt = "il dato è stato passato per riferimento"; //istruzione che modifica la stringa passata al metodo
        }
    }
}
