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
            int dim = 10; //dimensione del vettore
            int scambio; //variabile per scambio
            int i, j, k; //indici
            bool finito;
            Random rnd = new Random(); //variabile randomica
            var vettore = new int[dim]; //creiamo un vettore di interi di dimensione dim

            Console.WriteLine("Vettore casuale:\n");
            for(i = 0; i < dim; i++)
            {
                //inserisco nel vettore dei valori casuali
                vettore[i] = rnd.Next(1, 100);
                Console.Write(vettore[i] + "\t");
            }
            Console.WriteLine("\nProcedura di ordinamento:");
            int algoritmo = 1;

            switch (algoritmo)
            {
                case 0: //selection sort
                    int indiceMinore = 0;
                    int valoreMinore;
                    for (i = 0; i < dim; i++)
                    {
                        valoreMinore = vettore[i];
                        indiceMinore = i;
                        for (k = i + 1; k < dim; k++)
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
                        for (j = 0; j < dim; j++)
                        {
                            Console.Write(vettore[j] + "\t");
                        }
                        //ho invertito il valore contenuto nella posizione i del vettore con quello in posizione indiceMinore
                    }
                    break;
                case 1:
                    for (i = 0; i < dim-1; i++)
                    {
                        finito=true;
                        for (j = 0; j < dim-1-i; j++)
                        {
                            if (vettore[j] > vettore[j+1])
                            {
                                scambio = vettore[j];
                                vettore[j] = vettore[j+1];
                                vettore[j+1] = scambio;
                                finito = false; //se ho fatto uno scambio allora non ho ancora finito
                            }
                        }
                        if (finito) break; //se non ha fatto nessuno scambio allora ho finito di ordinare
                        Console.WriteLine("\n");
                        for (k = 0; k < dim; k++)
                        {
                            Console.Write(vettore[k] + "\t");
                        }
                    }
                    break;
            }

            Console.WriteLine("\nVettore ordinato:\n");
            for (i = 0; i < dim; i++)
            {
                Console.Write(vettore[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
