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
        static Personnage Hully;

       
        
        static Dictionary<string, Noeuds> Histoire = new Dictionary<string, Noeuds>();
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
            string d = "Depart!";
           
            SansCombat = null;

            
            /*1er Noeud*/
            Histoire.Add("Depart!",
      new Noeuds("Bonjour! Comment allez vous?",
      null,
      new Dictionary<int, string>()
      {
                    { 1 , "Bien" },
                    { 2, "Bagarre!!!!" }
      }));
            /*2ieme Noeud*/
            Histoire.Add("Bien",
                new Noeuds(
                    "Tu veux qu'on voyage ensemble?",
                    null,
                    new Dictionary<int, string>()
                    {
                           { 1, "oui, voyageons ensemble!" },
                           { 2, "Bagarre!!!!" }
                    }
                    ));
         /*3ieme Noeud*/Histoire.Add("oui, voyageons ensemble!",
                new Noeuds("Super! On arrête manger quelquepart ? ",
                null,
                new Dictionary<int, string>()
                {
                    {1, "oui, allons manger" },
                    {2, "Bagarre!!!!" }
                }
                ));
            /*4ieme Noeud FIN SANS COMBAT*/
            Histoire.Add("oui, allons manger",
                new Noeuds("C'était trop bon! On va danser?",
                null,
                new Dictionary<int, string>()
                {
                { 1,"oui, Après des heures de danse, ils vécurent heureux et eurent beaucoup d'enfants!" },
                
                 }
                ));
         /*COMBAT PRINCIPAL*/Histoire.Add("Bagarre!!!!",
               new Noeuds("Bagarre!!!!",
               CombatPrincipal,
               new Dictionary<int, string>()
               { { 1 , "Game Over" }}
               ));

            RouleNoeud(d);

        }
        public static void HappyEnd()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------                ---------------------");
            Console.WriteLine("------------------- TOUT EST BIEN ----------------------");
            Console.WriteLine("---------------------- QUI FINI ------------------------");
            Console.WriteLine("----------------------- BIEN!! -------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadLine();
            Environment.Exit(1);
        }

        public static void GameOver()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-----------------------           ----------------------");
            Console.WriteLine("----------------------- GAME OVER ----------------------");
            Console.WriteLine("-----------------------           ----------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadLine();
            Environment.Exit(1);
        }
        // COMMENCE PAR LA CASE DEPART 
        public static string RouleNoeud(string x)
        {
            if (x == "oui, Après des heures de danse, ils vécurent heureux et eurent beaucoup d'enfants!")
            {
                HappyEnd();
            }
            if (x == "Game Over")
            {
                GameOver();
            }
            string NouveauNoeud = null;
            foreach (var kv in Histoire)
            {
                
                if (x == kv.Key)
                {
                    kv.Value.Init(ref Hully);
                    NouveauNoeud = kv.Value.ChoixReponse();
                }

            }
            return RouleNoeud(NouveauNoeud);

        }
        
    }
}