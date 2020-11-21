using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputControllato
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            //inizio del ciclo post condizionale per la lettura di un numero positivo
            do
            {
                Console.WriteLine("Inserisci un numero maggiore di 0");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero < 0);

            //numero = numero + 1;
            numero++; //calcolo del numero successivo
            Console.Write("\nIl numero successivo a quello inserito è: ");
            Console.WriteLine(numero);
            Console.ReadKey();
        }
    }
}
