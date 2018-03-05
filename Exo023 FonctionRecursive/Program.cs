using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo023_FonctionRecursive
{
    class Program
    {
        //RÉALISER UNE FONCTION RÉCURSIVE QUI, A PARTIR D'UN NOMBRE x ET D'UNE PUISSANCE n ,VA CALCULER Xn ET LE RETOURNER.
        public static int puissance(int nombre, int pow)
        {
            if (pow <= 1)
            {
                return nombre;
            }
            else
            {
                return nombre * puissance(nombre, pow - 1);
            }
        }
        static void Main(string[] args)
        {
            int nombre = 5;
            int pow = 3;
            int resultat = puissance(nombre, pow); // store la puissance dans resultats
            Console.WriteLine(resultat);
        }
    }
}
