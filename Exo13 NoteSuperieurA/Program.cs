using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo13_NoteSuperieurA
{
    class Program
    {
        public static double[] FoncSupMoy(double[] table)
        {   //ON CALCUL LA MOYENNE DES NOTES DU TABLEAU
            double somme = 0;
            foreach (double i in table)
            {
                somme += i;
            }
            double moyenne = somme / table.Length;
            int compteur = 0;
            double[] newTable = new double[table.Length];

            for (int i = 0; i < table.Length; ++i)
            {
                if (table[i] > moyenne)
                {
                    newTable[compteur] = table[i];
                    ++compteur;
                }
            }
            return newTable;
        }
        static void Main(string[] args)
        {
            double[] notesItitial = new double[] { 11.8, 36.2, 58.3, 28.8, 16.19, 44.1, 89.4 };
            double[] SupMoy;
            SupMoy = FoncSupMoy(notesItitial);
            foreach (double d in SupMoy)
            {
                if (d > 0)
                {
                    Console.Write($"{d},");
                }
            }
        }
    }
}
