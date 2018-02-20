using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo21ProcedureRecursive
{
    //RÉALISER UNE PROCÉDURE RÉCURSIVE QUI, A PARTIR D'UN ENTIER n, VA DIRE n FOIS <<HELLO!>>.
    class Program
    {
        public static void RecursiveHello(int nb)
        {
            if (nb <= 1)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Hello");
                RecursiveHello(nb - 1);
            }
        }

        static void Main(string[] args)
        {
            RecursiveHello(5);
        }
    }
}
