using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo42_NbPremierCarre
{
    class Program
    {
        public static int NomprePremierCarre(int nombre)
        {
            
            if(nombre<0)
            {
                if(nombre%2==0)
                {
                    return  nombre;
                }
                else
                {
                    return nombre * 2 + (nombre - 1)*2;
                }
            }
            
        }
        static void Main(string[] args)
        {
            int nombre = 4;
            int resultat=NomprePremierCarre(nombre);

        }
    }
}
