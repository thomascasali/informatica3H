using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Gestite un noleggio di biciclette, la prima ora di noleggio costa 10€, 
 * dalla seconda ora fino alla fine della terza ogni mezzora costa 4€. 
 * oltre la terza ora il costo è di € 6 all'ora. 
 * chiesto N, il numero dei minuti di noleggio, calcolate e stampate l'importo totale del noleggio.
*/
namespace CalcoloCostoNoleggio
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuti;
            int mezzore;
            int oreeccedenti;
            int costo;
            do
            {
                Console.Write("\nInserisci la durata del noleggio in minuti: ");
                minuti = Convert.ToInt32(Console.ReadLine());
            } while (minuti <= 0);
            costo = 10; //se minuti è maggiore di 0 allora il noleggio minimo è di 10€
            if (minuti>60)
            {
                minuti = minuti - 60; //tolgo i primi 60 minuti di noleggio
                if (minuti < 120)
                {
                    mezzore = (int)Math.Ceiling(1.0 * minuti / 30); //calcolo quante mezzore sono state fatte dopo la prima ora. arrotondo il risultato della divisione all'intero superiore
                    costo = costo + mezzore * 4; //moltiplico le mezzore calcolate per il costo di 4 €
                }
                else
                {
                    costo = 10 + 16; // costo della prima ora + costo delle 4 mezzore successive
                    minuti = minuti - 120; //tolgo al totale dei minuti le successive 2 ore
                    oreeccedenti = (int)Math.Ceiling(1.0*minuti / 60); //calcolo delle ore successive alla terza ora. arrotondo il risultato della divisione all'intero superiore 
                    costo = costo + oreeccedenti * 6; //moltiplico le ore eccedenti per il costo di 6€/ora
                }
            }
            Console.Write("\nIl costo complessivo del noleggio è: " + costo + " euro");
            Console.ReadKey();
        }
    }
}
