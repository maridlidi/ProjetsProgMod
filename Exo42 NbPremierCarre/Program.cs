using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo42_NbPremierCarre
{
   /* ECRIRE UNE MÉTHODE RÉCURSIVE QUI CALCULE LA SOMME DES N PREMIERS CARRÉS. PAR EXEMPLE, 
    SI N VAUT 3, CETTE MÉTHODE CALCULE 3*3+2*2+1*1 . CETTE MÉTHODE N’EST DÉFINI QUE POUR UN N SUPÉRIEUR À 0.*/

    class Program
    {
        public static int NomprePremierCarre(int nombre)
        {
            
            if(nombre>0)
            {
                if(nombre%2==0)
                {
                    return  nombre;
                }
                else
                {
                    return (nombre*nombre)-1 + (nombre*nombre)-2;
                }
            }
            return nombre;
        }
        static void Main(string[] args)
        {
            int nombre = 5;
            int resultat=NomprePremierCarre(nombre);
            Console.WriteLine(nombre);

        }
    }
}
