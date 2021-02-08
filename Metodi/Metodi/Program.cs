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
                CreaTris(ref tris);
                StampaInteri(tris);
                Stampa(tris);
                Console.WriteLine("\nSono presenti " + ContaGiocate(tris) + " simboli nel campo di gioco");
                if (!Vittoria(tris))
                {
                    Console.WriteLine("\n non ha vinto nessuno premi un tasto per continuare");
                    Console.ReadKey();
                }
            } while (!Vittoria(tris));
            Console.ReadKey();
        }

        static bool Vittoria(int[,] mat)
        {
            if (mat[0, 0] == mat[0, 1] && mat[0, 1] == mat[0, 2]) return true;
            if (mat[1, 0] == mat[1, 1] && mat[1, 1] == mat[1, 2]) return true;
            if (mat[2, 0] == mat[2, 1] && mat[2, 1] == mat[2, 2]) return true;
            if (mat[0, 0] == mat[1, 0] && mat[1, 0] == mat[2, 0]) return true;
            if (mat[0, 1] == mat[1, 1] && mat[1, 1] == mat[2, 1]) return true;
            if (mat[0, 2] == mat[1, 2] && mat[1, 2] == mat[2, 2]) return true;
            if (mat[0, 0] == mat[1, 1] && mat[1, 1] == mat[2, 2]) return true;
            if (mat[0, 2] == mat[1, 1] && mat[1, 1] == mat[2, 0]) return true;
            return false;
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
