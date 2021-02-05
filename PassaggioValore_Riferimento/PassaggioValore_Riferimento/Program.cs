using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaggioValore_Riferimento
{
    class Program
    {
        static void Main(string[] parametros)
        {
            int parametro;

            // Passing by value.
            // The value of parametro in Main is not changed.
            parametro = 4;
            CalcolaIlQuadratoConPassaggioPerValore(parametro);
            Console.WriteLine(parametro);
            // Output: 4

            // Passing by reference.
            // The value of parametro in Main is changed.
            parametro = 4;
            CalcolaIlQuadratoConPassaggioPerRiferimento(ref parametro);
            Console.WriteLine(parametro);
            // Output: 16
        }

        static void CalcolaIlQuadratoConPassaggioPerValore(int valParameter)
        {
            valParameter *= valParameter;
        }

        // Passing by reference
        static void CalcolaIlQuadratoConPassaggioPerRiferimento(ref int refParameter)
        {
            refParameter *= refParameter;
        }
    }
}
