using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica_vettori_21._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var vet = new int[100]; //dichiarazione vettore int[] vet = new int [100];
            var vetMin = new int[100];
            var vetMax = new int[100];
            int numMin=0, numMax=0;
            int totMin=0, totMax=0;

            int num,n,m,x;
            var rnd = new Random();
            Console.WriteLine("Inserisci il numero di elementi da inserire nel vettore");
            do
            {
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 100);
            
            Console.WriteLine("Inserisci il limite inferiore dei numeri da estrarre casualmente: ");
            n = int.Parse(Console.ReadLine()); //input del limite inferiore

            do
            {
                Console.WriteLine("\nInserisci il limite superiore dei numeri da estrarre casualmente (deve essere maggiore del numero inserito precedentemente): ");
                m = int.Parse(Console.ReadLine());
                if (m <= n)
                {
                    Console.WriteLine($"In numero inserito non può essere minore di {n}");
                }
            } while (m <= n);

            //a questo punto so quanti numeri deve estrarre e so l'intervallo dei numeri da estrarre

            for (int i=0; i < num; i++)
            {
                vet[i] = rnd.Next(n, m + 1); //estrazione casuale del vettore
                Console.Write($"{vet[i]} | ");
            }

            do
            {
                Console.WriteLine($"\nInserisci il valore da utilizzare come separatore dei dati compreso tra {n} e {m}");
                x = int.Parse(Console.ReadLine());
                if (x < n || x > m)
                {
                    Console.WriteLine("Il valore inserito non è corretto");
                }
            } while (x < n || x > m);

            for (int i = 0; i < num; i++)
            {
                if (vet[i] < x)
                {
                    //riempio il vettore dei numeri minori di x
                    vetMin[numMin] = vet[i];
                    numMin++;
                    //potevo anche ridurre ad una unica istruzione vetMin[numMin++] = vet[i];
                }
                else
                {
                    //riempio il vettore dei numeri maggiori o uguali ad x
                    vetMax[numMax] = vet[i];
                    numMax++;
                    //potevo anche ridurre ad una unica istruzione vetMin[numMin++] = vet[i];
                }
            }

            Console.WriteLine($"\nVettore con numeri minori di {x}:\n");
            for (int i = 0; i < numMin; i++)
            {
                Console.Write($"{vetMin[i]} | ");
                totMin += vetMin[i];
            }
            Console.WriteLine($"\nLa media dei valori del vettore vetMin è {totMin/numMin}\n");

            Console.WriteLine($"\nVettore con numeri maggiori o uguali ad {x}:\n");
            for (int i = 0; i < numMax; i++)
            {
                Console.Write($"{vetMax[i]} | ");
                totMax += vetMax[i];
            }
            Console.WriteLine($"\nLa media dei valori del vettore vetMin è {totMax / numMax}\n");


            Console.ReadKey();

        }
    }
}
