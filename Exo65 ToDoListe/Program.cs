using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo65_ToDoListe
{/* SOIT UN SITE WEB CAPABLE DE STOCKER LES TODO LIST, L'ENSEMBLE DES UTILISATEURS EST STOCKÉS 
     DANS UN DICTIONNAIRE DONT LA CLÉ EST LE NOM DE L'UTILISATEUR(STRING) ET LA VALEUR,
     UNE LISTE DE CHOSE A FAIRE(LIST<STRING>). */

    //RÉALISER UNE FONCTION NOMMÉE TROUVERUSERAVECLEPLUSDECHOSESAFAIRE
    //ELLE AURA EN PARAMETE LE DICTIONNAIRE DEFINI CI-DESSUS
    //ELLE RETOURNERA LE NOM DU CLIENT QUI A LA TODO-LIST LA PLUS GRANDE(AVEC LE + D'ÉLÉMENTS)
    class Program
    {
        public static dynamic TrouverUserAvecLePlusDeChoseAFaire(Dictionary<string, List<string>> UserToDoList)
        {
            string userMax=null;
            int max = 0;
            // POUR TOUTES LES KEYVALUEPAIRS DANS MA LISTE
            foreach(var ligne in UserToDoList)
            {   // SI LA VALEUR EST PLUS GRANDE QUE CELLE DEFINI
                if(ligne.Value.Count>max)
                {
                    //ALORS LA VALEUR MAX DEVIENT CETTE VALEUR.VALEUR
                    max = ligne.Value.Count;
                    // L'UTILISATEUR ASSOCIÉ A CETTE LISTE
                    userMax = ligne.Key;
                }
            }
            return userMax;
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> UserToDoList = new Dictionary<string, List<string>>();
            UserToDoList.Add("Marieve", new List<string>() { "faire une ToDo liste", "Envoyer Exo", "Dormir" });
            UserToDoList.Add("Cric", new List<string>() { "Compter les moutons" });
            UserToDoList.Add("Crac", new List<string>() { "Jouer a saute moutons" });
            UserToDoList.Add("Croc", new List<string>() { "Manger les moutons!" });
            // AFFICHE TOUS LES USER DU DICTIONARY
           foreach (string key in UserToDoList.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Le user avec leplus de choses a faire est : ");
            // AFFICHE CELUI QUI AS LE PLUS DE CHOSES A FAIRE
           Console.WriteLine(TrouverUserAvecLePlusDeChoseAFaire(UserToDoList));
        }
    }
}
