using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;

namespace ProjetFinalProgMod.Structures
{
    public class Noeuds
    {
        public string Intitule;
        public Combat Combat;
        public Dictionary<string, Noeuds> LienReponseEnfant;

        public Noeuds(string intitule, Combat combat, Dictionary<string, Noeuds> lienReponseEnfants1)
        {
            Intitule = intitule;
            Combat = combat;
            LienReponseEnfant = lienReponseEnfants1;
        }

        public void ChoixUtilisateur()
        {
            string MaReponse;
            bool EntreeValide = false;
            {
                // AFFICHER LES REPONSES POSSIBLES
                foreach (string reponse in LienReponseEnfant.Keys.ToList())
                {
                    Console.WriteLine(reponse);
                }
                // PRENDRE REPONSE UTILISATEUR
                MaReponse = Console.ReadLine();
                //  VERIFIE LA REPONSE UTILISATEUR
                foreach (string reponse in LienReponseEnfant.Keys.ToList())
                {
                    if (MaReponse == reponse)
                    {
                        EntreeValide = true;
                    }
                }
                while (!EntreeValide) ;
            }

            LienReponseEnfant[MaReponse].ChoixUtilisateur();

        }

        /* Console.WriteLine(Intitule);
             string reponse1 = Console.ReadLine();

             if (!Combat.Equals(default(Combat)))
             {
                LancerCombat();
                 return true;
             }
             return false;*/
    }
}
