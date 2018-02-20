using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionMinMaxSumMoy
{
    class Program
    {
        /*REALISER UNE PROCEDURE QUIAFFICHERA LEMINIMUM,LA MOYENNE,LE MAXIMUM ET LASOMME D'UN TABLEAU DE 10 ENTIERS.
        APPELER CETTE MÉTHODE DANS LE MAIN.*/
            public static void minMaxMoy(int[] table)
        {
            int somme = 0;
            foreach (int i in table)
            {
                somme += i;
            }
            int moyenne = somme / table.Length;
            int minimum = table.Min();
            int maximum = table.Max();
            Console.WriteLine($"Le maximum : {maximum}, Minimum : {minimum}, moyenne : {moyenne},somme: {somme} ");
            }
        static void Main(string[] args)
        {
            int[] entiers;
            entiers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            minMaxMoy(entiers);
        }
    }
}

