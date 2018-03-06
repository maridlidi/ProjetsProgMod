using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;


namespace ProjetFinalProgMod.Structures
{
    //
    public class Noeuds
    {
        public string Intitule;
        public Combat Combat;
        public Dictionary<int, string> LienReponseNoeud;

        public Noeuds(string intitule, Combat combat, Dictionary<int, string> Reponse)
        {
            Intitule = intitule;
            Combat = combat;
            LienReponseNoeud = Reponse;
        }

        public void Init(ref Personnage Joueur)
        {
            
            if (Combat != null)
                
            {

                Combat.LancerCombat();   
            }
            Console.WriteLine(Intitule);
        }

        public string ChoixReponse()
        {

            string rep = null;
            //AFFICHAGE
            foreach (var choix in LienReponseNoeud)
            {
                Console.WriteLine($"{choix.Key} : {choix.Value}");

            }
            Console.WriteLine("Quelle est votre reponse?");


            {
                int x = int.Parse(Console.ReadLine());
                foreach (var Reponse in LienReponseNoeud)
                {

                    if (x == Reponse.Key)
                    {
                        rep = Reponse.Value;
                        break;
                    }
                }
            }
            return rep;
        }
    }
}
