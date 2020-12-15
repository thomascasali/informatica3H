using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertiVettore
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim,i,k;
            var rnd = new Random();

            Console.Write("Inserisci la dimensione del vettore:");
            dim = int.Parse(Console.ReadLine());
            var vettore = new int[dim];
            var vettoreInverso = new int[dim];

            for (i = 0; i < dim; i++)
            {
                //estrazione casuale
                vettore[i] = rnd.Next(100);
            }

            for (i = 0; i < dim; i++)
            {
                //inverto il vettore
                vettoreInverso[i] = vettore[dim-i-1];
            }

            //stampa dei vettori
            for (i = 0; i < dim; i++)
            {
                Console.Write(vettore[i] + ", "); 
            }
            Console.WriteLine("\n");
            for (i = 0; i < dim; i++)
            {
                Console.Write(vettoreInverso[i] + ", ");
            }
            Console.ReadKey();

        }
    }
}
