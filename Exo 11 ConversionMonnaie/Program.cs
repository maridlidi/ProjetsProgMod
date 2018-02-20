using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_11_ConversionMonnaie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(convertir(1.41, 40, true));
        }
        public static double convertir(double taux, double montant, bool inverse)
        {
            if (inverse)
            {
                return montant / taux;
            }
            else
            {
                return taux * montant;
            }
        }
    }
}
