using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo22_ProcedureMsgRecursif
{
    //RÉALISER UNE PROCÉDURE RÉCURSIVE QUI, A PARTIR D'UN ENTIER n ET D'UNE CHAINE DE CARACTERES message,
    //VA DIRE n FOIS LE message DANS LA CONSOLE.
    class Program
    {
        public static void MessageRecursif(int n, string mes)
        {
            if (n <= 1)
            {
                Console.WriteLine(mes);
            }
            else
            {
                Console.WriteLine(mes);
                MessageRecursif(n - 1, mes);
            }
        }

        static void Main(string[] args)
        {
            int nb = 6;
            string message = "Hello";
            MessageRecursif(nb, message);

        }
    }
}
