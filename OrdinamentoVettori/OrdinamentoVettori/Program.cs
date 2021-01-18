using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim =10; //dimensione del vettore
            Random rnd = new Random(); //variabile randomica
            var vettore = new int[dim]; //creiamo un vettore di interi di dimensione dim

            Console.WriteLine("Vettore casuale:\n");
            for(int i = 0; i < dim; i++)
            {
                //inserisco nel vettore dei valori casuali
                vettore[i] = rnd.Next(1, 100);
                Console.Write(vettore[i] + "\t");
            }

            int indiceMinore = 0;
            int valoreMinore;
            int scambio;
            for (int i = 0; i < dim; i++)
            {
               valoreMinore = vettore[i];
               indiceMinore = i;
               for (int k = i+1; k < dim; k++)
                {
                    if (vettore[k] < valoreMinore)
                    {
                        valoreMinore = vettore[k];
                        indiceMinore = k;
                    }
                }
                //ho trovato il valore più piccolo e lo metto al posto della posizione i-esima
                scambio = vettore[i];
                vettore[i] = vettore[indiceMinore];
                vettore[indiceMinore] = scambio;
                Console.WriteLine("\n");
                for (int j = 0; j < dim; j++)
                {
                    Console.Write(vettore[j] + "\t");
                }
                //ho invertito il valore contenuto nella posizione i del vettore con quello in posizione indiceMinore
            }

            Console.WriteLine("\nVettore ordinato:\n");
            for (int i = 0; i < dim; i++)
            {
                Console.Write(vettore[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
