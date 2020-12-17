using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ESERCIZIO 1
//Scrivere un programma che letti gli elementi di un vettore numerico, 
//ne realizzi un secondo con i numeri nelle posizioni invertite 
//(il primo elemento del vettore1 diventa l'ultimo del vettore2, 
//il secondo diventa il penultimo, etc etc). Stampare i due vettori

//ESERCIZIO 2
//Scrivere un programma che letti gli elementi di due vettori numerici, 
//ne inizializzi un terzo assegnando ad ogni suo elemento il massimo 
//fra i corrispondenti elementi dei primi due vettori. Stampare i tre vettori.

namespace InvertiVettore
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim,i,k;
            var rnd = new Random();
            int esercizio = 2; //scelta dell'esercizio da eseguire

            switch (esercizio) {
                case 1:
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
                    break;
                case 2:
                    Console.Write("Inserisci la dimensione dei vettori:");
                    dim = int.Parse(Console.ReadLine());
                    //istanzio i 2 vettori
                    var vet1 = new int[dim];
                    var vet2 = new int[dim];
                    var vetMax = new int[dim];

                    for (i = 0; i < dim; i++)
                    {
                        //estrazione casuale di numeri all'interno dei vettori
                        vet1[i] = rnd.Next(100);
                        vet2[i] = rnd.Next(100);
                    }

                    for (i = 0; i < dim; i++)
                    {
                        //confronto il valore contenuto nella posizione i-esima dei 2 vettori vet1 e vet2 e metto il maggiore nel vetMax
                        if (vet1[i] > vet2[i])
                        {
                            vetMax[i] = vet1[i];
                        }
                        else
                        {
                            vetMax[i] = vet2[i];
                        }
                    }

                    Console.WriteLine("\nVettore1:\n");
                    for (i = 0; i < dim; i++) Console.Write(vet1[i]+"\t");
                    Console.WriteLine("\nVettore2:\n");
                    for (i = 0; i < dim; i++) Console.Write(vet2[i] + "\t");
                    Console.WriteLine("\nVettore dei Massimi:\n");
                    for (i = 0; i < dim; i++) Console.Write(vetMax[i] + "\t");

                    break;
            }
            Console.ReadKey();

        }
    }
}
