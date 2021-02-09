using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tris = new int[3, 3];
            do
            {
                CreaTris(ref tris); //passo la matrice per riferimento perché verrà modificata
                StampaInteri(tris); //passo la matrice per valore perché NON verrà modificata
                Stampa(tris); //stampo il tris con X e O in base al valore intero contenuto nella matrice
                Console.WriteLine("\nSono presenti " + ContaGiocate(tris) + " simboli nel campo di gioco");
                if (!Vittoria(tris)) //controlla se qualcuno ha vinto
                {
                    Console.WriteLine("\n non ha vinto nessuno premi un tasto per continuare");
                    Console.ReadKey();
                }
            } while (!Vittoria(tris));
            Console.WriteLine("Ha vinto il giocatore " + VittoriaPlayer(tris));
            Console.ReadKey();
        }

        static bool Vittoria(int[,] mat)
        {
            //restituisce true se qualcuno ha vinto, altrimento false
            if (mat[0, 0] == mat[0, 1] && mat[0, 1] == mat[0, 2] && mat[0, 0] != 0) return true;
            if (mat[1, 0] == mat[1, 1] && mat[1, 1] == mat[1, 2] && mat[1, 0] != 0) return true;
            if (mat[2, 0] == mat[2, 1] && mat[2, 1] == mat[2, 2] && mat[2, 0] != 0) return true;
            if (mat[0, 0] == mat[1, 0] && mat[1, 0] == mat[2, 0] && mat[0, 0] != 0) return true;
            if (mat[0, 1] == mat[1, 1] && mat[1, 1] == mat[2, 1] && mat[0, 1] != 0) return true;
            if (mat[0, 2] == mat[1, 2] && mat[1, 2] == mat[2, 2] && mat[0, 2] != 0) return true;
            if (mat[0, 0] == mat[1, 1] && mat[1, 1] == mat[2, 2] && mat[0, 0] != 0) return true;
            if (mat[0, 2] == mat[1, 1] && mat[1, 1] == mat[2, 0] && mat[0, 2] != 0) return true;
            return false;
        }

        static int VittoriaPlayer(int[,] mat)
        {
            //restituisce (se c'è) il giocatore che ha vinto
            if (mat[0, 0] == mat[0, 1] && mat[0, 1] == mat[0, 2] && mat[0, 0] != 0) return mat[0, 0];
            if (mat[1, 0] == mat[1, 1] && mat[1, 1] == mat[1, 2] && mat[0, 0] != 0) return mat[1, 0];
            if (mat[2, 0] == mat[2, 1] && mat[2, 1] == mat[2, 2] && mat[0, 0] != 0) return mat[2, 0];
            if (mat[0, 0] == mat[1, 0] && mat[1, 0] == mat[2, 0] && mat[0, 0] != 0) return mat[0, 0];
            if (mat[0, 1] == mat[1, 1] && mat[1, 1] == mat[2, 1] && mat[0, 0] != 0) return mat[0, 1];
            if (mat[0, 2] == mat[1, 2] && mat[1, 2] == mat[2, 2] && mat[0, 0] != 0) return mat[0, 2];
            if (mat[0, 0] == mat[1, 1] && mat[1, 1] == mat[2, 2] && mat[0, 0] != 0) return mat[0, 0];
            if (mat[0, 2] == mat[1, 1] && mat[1, 1] == mat[2, 0] && mat[0, 0] != 0) return mat[0, 2];
            return 0;
        }
        static void CreaTris(ref int[,] mat)
        {
            var rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] =rnd.Next(3); //estrazione casuale di un numero da 0 a 2
                }
            }
        }

        static void StampaInteri(int[,] mat)
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i,j] +" | ");
                }
                Console.WriteLine();
            }
        }

        static int ContaGiocate(int[,] mat)
        {
            int conta = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mat[i, j] != 0) conta++;
                }
            }
            return conta;
        }

        static void Stampa(int[,] mat)
        {
            Console.WriteLine();
            Console.WriteLine("\n-----------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (mat[i, j]) {
                        case 0:
                            Console.Write("  | ");
                            break;
                        case 1:
                            Console.Write("X | ");
                            break;
                        case 2:
                            Console.Write("O | ");
                            break;
                    }

                }

                Console.WriteLine("\n-----------");
            }
        }
    }
}
