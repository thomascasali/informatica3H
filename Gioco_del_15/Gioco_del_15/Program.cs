using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gioco_del_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var gioco15 = new int[4, 4]; //definisco la matrice di gioco
            var rnd = new Random();
            int x, y;

            for(int i = 1; i < 16; i++)
            {
                do
                {
                    x = rnd.Next(4); //estrae un numero casuale da 0 a 3 che rappresenta la riga estratta
                    y = rnd.Next(4); //estrae un numero casuale da 0 a 3 che rappresenta la colonna estratta
                } while (gioco15[x, y]!=0);
                gioco15[x, y] = i;
            }

            StampaGioco(gioco15);
            Console.ReadKey();
        }

        static void StampaGioco(int [,] mat)
        {
            Console.WriteLine("\n---------------------");
            for (int i = 0; i < 4; i++)
            {                
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0) Console.Write("| ");
                    if(mat[i,j]<10) Console.Write(" ");
                    Console.Write(mat[i,j]+" | ");
                }
                Console.WriteLine("\n---------------------");
            }
        }
    }
}
