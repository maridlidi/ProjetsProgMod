using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo67_DePipe
{      /* ECRIRE UNE FONCTION NOMÉE DEPIPE.
         * ELLE AURA EN PARAMETRE UNE LISTE DENTIER DE 1 A 6 SIMULANT DES LANCER DE DÉS
         * RETOURNERA SI LE DE EST PIPÉ OU NON AVEC LE BOOLÉEN
         * UN DÉ SERA CONSIDÉRÉ PIPÉ SI, LE NOMBRE DE LANCERS EST SUPÉRIEUR A 30
         * ET QU'AU MOIN UNE FACE AIT UNE PROPORTION D'APPARITION INFÉRIEUR A 10% OU SUPÉRIEUR A 20%
         * (ENTE 10% ET 20%, LA FACE SEMBLE NORMALE) */
    class program
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
        public static bool DePipe(List<int> ListeLancer)
        {
            if (ListeLancer.Count >= 30)
            {
                int un = 0, deux = 0, trois = 0, quatre = 0, cinq = 0, six = 0;
                foreach (int i in ListeLancer)
                {
                    switch (i)
                    {
                        case 1:
                            un += 1;
                            continue;
                        case 2:
                            deux += 1;
                            continue;
                        case 3:
                            trois += 1;
                            continue;
                        case 4:
                            quatre += 1;
                            continue;
                        case 5:
                            cinq += 1;
                            continue;
                        case 6:
                            six += 1;
                            continue;
                    }
                }
                un = (un / ListeLancer.Count / 100);
                deux = (deux / ListeLancer.Count) * 100;
                trois = (trois / ListeLancer.Count) * 100;
                quatre = (quatre / ListeLancer.Count) * 100;
                cinq = (cinq / ListeLancer.Count) * 100;
                six = (six / ListeLancer.Count) * 100;
                if ((un < 10 | un > 20) | (deux < 10 | deux > 20) | (trois < 10 | trois > 20)
                    | (quatre < 10 | quatre > 20) | (cinq < 10 | cinq > 20) | (six < 10 | six > 20))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            List<int> ToutLancer = SimulerXLancers(300);
            bool PipeOuNon = DePipe(ToutLancer);
            Console.WriteLine(PipeOuNon);
        }
    }
}

