using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo66_LancageDe
{/* ÉCRIRE UNE FONCTION SIMULANT DES LANCERS DE DÉS A 6 FACES.
     * LA FONCTION NOMMÉE SIMULERXLANCERS QUI:
     * AURA EN PARAMETRE DENTREE LE NOMBRE DE LANCER
     * RETOURNERA UNE LISTE DENTIER CONTENANT DES VALEURS DE 1 A 6. */
    class Program
    {
        public static Random random = new Random();
        public static List<int> SimulerXLancers(int nbLancer)
        {
            List<int> MesLancer = new List<int>();
            int resultat;
            for (int x = 0; x < nbLancer; x++)
            {
                resultat = random.Next(1, 7);
                MesLancer.Add(resultat);
            }
            return MesLancer;
        }
        static void Main(string[] args)
        {
            List<int> ToutLancer = SimulerXLancers(30);
        }
    }
}
