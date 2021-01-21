using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introMatrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int righe,colonne;
            var rnd = new Random();
            Console.WriteLine("Inserisci il numero di righe della matrice");
            righe = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il numero di colonne della matrice");
            colonne = int.Parse(Console.ReadLine());
            var matrice = new int[righe, colonne]; //creo una matrice di dimensione righe*colonne

            //riempio casualmente la matrice
            for (i = 0; i < righe; i++)
            {
                for (j = 0; j < colonne; j++)
                {
                    matrice[i, j] = rnd.Next(10, 100);
                } 
            }

            //stampo la matrice
            for (i = 0; i < righe; i++)
            {
                for (j = 0; j < colonne; j++)
                {
                    Console.Write(matrice[i, j] + "  |");  
                }
                Console.WriteLine();
            }

            //stampo l'indice della cella della matrice
            Console.WriteLine("\nIndici della matrice:\n");
            for (i = 0; i < righe; i++)
            {
                for (j = 0; j < colonne; j++)
                {
                    Console.Write($" {i},{j} |");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
