using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilitaVariabili_ProgrammazioneProcedurale
{
    class Program
    {
        //variabili globali
        //devono essere definite con la parola chiave static seguita dal tipo e dal nome
        //obbligatoria tipo nome
        static int variabileGobale;
        static int[] vetGlobale = new int[10];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //variabili locali (interne al metodo)
            int variabileLocale; //variabili visibile solo dentro all'if

            variabileGobale = 1;
            IncrementaVariabileGlobale();
            variabileGobale++;
            quadratoVariabileGlobale();
            DecrementaVariabileGlobale();
            Stampa(variabileGobale.ToString());

            RiempiVettore();
            StampaVettore();
            RiempiVettore();
            StampaVettore();
            variabileGobale = 0;
            if (true)
            {
                int variabileInterna; //variabili visibile solo dentro all'if
            }

            do
            {
                int variabileWhile; //variabili visibile solo dentro al do...while
            } while (false);
            
            variabileLocale = 0;
            Console.ReadKey();
        }

        static void RiempiVettore()
        {
            for(int i = 0; i < 10; i++)
            {
                vetGlobale[i] = rnd.Next(1, 99);
            }
        }

        static void StampaVettore()
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetGlobale[i] +", ");
            }
            Console.WriteLine();
        }

        static void Stampa(string txt)
        {        
            Console.WriteLine(txt);
        }

        static void IncrementaVariabileGlobale()
        {
            variabileGobale++;
        }

        static void DecrementaVariabileGlobale()
        {
            variabileGobale--;
        }
        static void quadratoVariabileGlobale()
        {
            variabileGobale*= variabileGobale;
        }
    }
}
