using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//scrivere un algoritmo che calcola il costo delle fotocopie sulla base dei seguenti parametri:
//costo delle fotocopie in bianco e nero = 0.10€
//costo delle fotocopie a colori = 0.80€
//costo della rilegatura = 1.30€
//chiedere in input il numero di fotocopie in bianco/nero e a colori, quindi stampare il totale del costo

namespace CalcoloCostoFotocopie
{
    class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione delle variabili
            double bn = 0.1;
            double col = 0.8;
            double ril = 1.3;
            int numBn, numCol;
            double tot = 0;

            //lettura controllata del numero di fotocopie in bianco e nero
            do
            {
                Console.Write("\nInserisci il numero di fotocopie in bianco e nero: ");
                numBn = Convert.ToInt32(Console.ReadLine());
            } while (numBn < 0);

            do
            {
                Console.Write("\nInserisci il numero di fotocopie a colori: ");
                numCol = Convert.ToInt32(Console.ReadLine());
            } while (numCol < 0);

            tot = numBn * bn + numCol * col + ril;

            Console.Write("\nIl totale della spesa è: " + tot);
            Console.ReadKey();
        }
    }
}
