using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioUtilizzoPassaggioParametri
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int dim = 10;
            var vettore = new int[dim];
            vettore
            InizializzaVettore(ref vettore);
            StampaVettore(vettore);
            Console.ReadKey();
        }

        static void InizializzaVettore(ref int[] vet)
        {
            for(int i=0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 100);
            }
        }
        static void StampaVettore(int[] vet)
        {
            Console.WriteLine();
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i]+", "); 
            }
        }
    }
}
