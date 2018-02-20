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
        public static TrouverUserAvecLePlusDeChoseAFaire(ref Dictionary<string, List<string>> UserToDoList)
        {
            int max;
            foreach (int max in UserToDoList)
            {
                max++;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> UserToDoList1 = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> UserToDoList2 = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> UserToDoList3 = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> UserToDoList4 = new Dictionary<string, List<string>>();
            UserToDoList1.Add("Marieve", new List<string>() { "faire une ToDo liste", "Envoyer Exo", "Dormir" });
            UserToDoList2.Add("Cric", new List<string>() { "Compter les moutons" });
            UserToDoList3.Add("Crac", new List<string>() { "Jouer a saute moutons" });
            UserToDoList4.Add("Croc", new List<string>() { "Manger les moutons!" });

        }
    }
}
