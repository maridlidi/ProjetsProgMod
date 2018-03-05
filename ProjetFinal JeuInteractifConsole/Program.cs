using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;

namespace ProjetFinalProgMod
{
    class Program
    {
        static void Main(string[] args)
        {
            // DETERMINE LA VALEUR DE LA PUISSANCE PAR RAPPORT AU NIVEAU, 10 PAR NIVEAU
            /*1*/
            Sorts BouleDeFeu = new Sorts("Boule de feu", "Feu", 6);
            /*2*/
            Sorts Tornade = new Sorts("Tornade", "Air", 15);
            /*3*/
            Sorts TempeteDeSable = new Sorts("Tempête de sable", "Terre", 27);
            /*4*/
            Sorts ChuteDEau = new Sorts("Chute d'eau", "Eau", 35);

            /*1*/
            ObjetTenu Marteau = new ObjetTenu("Marteau", "Arme destruction", 4);
            /*2*/
            ObjetTenu Couteau = new ObjetTenu("Couteau", "Arme légère", 2);
            /*3*/
            ObjetTenu Lance = new ObjetTenu("Lance", "Arme longue", 3);
            /*4*/
            ObjetTenu Hache = new ObjetTenu("Hache", "Arme lourde", 5);

            /*1*/
            Personnage Hully = new Personnage("Orc des bois", "Hully", 100, 10, 4, 7, 10, Couteau);
            Hully.SortsPers.Add(BouleDeFeu);
            /*2*/
            Personnage Chantalou = new Personnage("Fée du foyer", "Chantalou", 100, 3, 7, 4, 11, Lance);
            Chantalou.SortsPers.Add(ChuteDEau);

            Combat CombatPrincipal = new Combat(Hully, Chantalou);
            Combat SansCombat = new Combat();

            Noeuds Noeud5 = new Noeuds("Après des heures de danse, ils vécurent heureux et eurent beaucoup d'enfants!",
                SansCombat, new Dictionary<string, Noeuds>());
            Noeuds Noeud6 = new Noeuds("Allez vient on va se battre", CombatPrincipal,
                new Dictionary<string, Noeuds>());
            Dictionary<string, Noeuds> Lien456 = new Dictionary<string, Noeuds>();
            Lien456.Add("Oui", Noeud5);
            Lien456.Add("Non", Noeud6);
            Noeuds Noeud4 = new Noeuds("C'était trop bon! On va danser?", SansCombat, Lien456);
            Dictionary<string, Noeuds> Lien346 = new Dictionary<string, Noeuds>();
            Lien346.Add("Oui", Noeud4);
            Lien346.Add("Non", Noeud6);
            Noeuds Noeud3 = new Noeuds("Super! On arrête manger quelquepart?", SansCombat, Lien346);
            Dictionary<string, Noeuds> Lien236 = new Dictionary<string, Noeuds>();
            Lien236.Add("Oui", Noeud3);
            Lien236.Add("Non", Noeud6);
            Noeuds Noeud2 = new Noeuds("Tu veux qu'on voyage ensemble?", SansCombat, Lien236);
            Dictionary<string, Noeuds> Lien126 = new Dictionary<string, Noeuds>();
            Lien126.Add("Oui", Noeud2);
            Lien126.Add("Non", Noeud6);
            Noeuds Noeud1 = new Noeuds("Bonjour! Comment allez vous?", SansCombat, Lien126);




            /*Console.Clear();
            Chantalou.AfficherPersonnage();
            Hully.FrapperAdversaire(ref Chantalou);
            Chantalou.AfficherPersonnage();

            Console.WriteLine();
            Hully.AfficherPersonnage();
            Chantalou.FrapperAdversaire(ref Hully);
            Hully.AfficherPersonnage();*/


        }
    }
}