using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparazione_verifica_23._02._2021
{
    class Program
    {
        //spazio per variabili globali (sono quelle variabili visibili all'interno della class Program)
        static int conta = 0;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //esempio di utilizzo di una variabile globale
            conta++;
            Console.WriteLine(conta);
            IncrementaConta();
            Console.WriteLine(conta);
            //fine utilizzo variabile globale
            int test = 1;
            //esempio di passaggio di paramentro per valore
            IncrementaTestVal(test);
            Console.WriteLine("valore della variabile test passata per valore: " + test);
            //esempio di passaggio di paramentro per riferimento
            IncrementaTestRif(ref test);
            Console.WriteLine("valore della variabile test passata per riferimento: " + test);

            //esempio di chiamata di funzione per valore con ritorno di un dato (in questo caso booleano)
            if (MaggioreDiZero(test))
            {
                Console.WriteLine("Maggiore di zero");
            }
            else
            {
                Console.WriteLine("Minore di zero");
            }

            //stampa per 10 volte di un numero casuale generato da un metodo che ritorna un valore intero
            //dato che il metodo stampa richiede un valore di tipo stringa utilizzo il metodo .ToString() per trasformare in stringa qualunque cosa
            for (int i = 0; i < 10; i++) {
                Stampa(Casuale(1, 7).ToString() + " ");
            }

            //estrazione casuale di una matrice 
            int[,] matrice = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrice[i, j] = Casuale(1, 100);
                }
            }
            //stampo la matrice estratta casualente all'interno del Main
            StampaMatrice(matrice);

            //esempio di riempimento di una matrice tramite una procedura a cui passo la matrice per riferimento
            EstraiMatrice(ref matrice);
            StampaMatrice(matrice);

            Console.ReadKey();
        }

        static void IncrementaConta()
        {
            conta++;
        }

        static void IncrementaTestVal(int pippo)
        {
            pippo++;
        }
        static void IncrementaTestRif(ref int pippo)
        {
            pippo++;
        }
        static bool MaggioreDiZero(int pippo)
        {
            if (pippo > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Casuale(int min, int max)
        {
            return rnd.Next(min, max);
        }

        static void Stampa(string txt)
        {
            Console.Write(txt);
        }

        static void StampaMatrice(int[,] m)
        {
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Stampa(m[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        static void EstraiMatrice(ref int[,] mat) {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = Casuale(1, 100);
                }
            }
        }
    
    }
}
