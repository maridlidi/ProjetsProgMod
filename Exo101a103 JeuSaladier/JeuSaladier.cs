using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo101a103_JeuSaladier
{
    public struct JeuSaladier
    {
        public Equipe Equipe_A;
        public Equipe Equipe_B;
        public int mancheactuelle;
        public List<string> saladier;
        public List<string> motsrestants;
        public int NbJoueurEquipe_A;
        public int NbJoueurEquipe_B;


        public void init()
        {
            saladier = new List<string>();
            motsrestants = new List<string>();

            Console.WriteLine("Quel est le nom de la premiere equipe.");
            Equipe_A.nom = Console.ReadLine();
            Console.WriteLine("Combien de joueurs dans vote équipe?");
            int NbJoueurEquipe_A = int.Parse(Console.ReadLine());
            for (int x = 0; x <= NbJoueurEquipe_A; x++)
            {
                Equipe_A.joueurs.Add(new Joueur(Console.ReadLine()));
            }
            foreach (Joueur J in Equipe_A.joueurs)
            {
                Console.WriteLine($"Joueur: {J.nom}, donnez vos 6 personnalités.");

                for (int j = 0; j < 6; j++)
                {
                    saladier.Add(Console.ReadLine());
                }
            }
            Console.WriteLine("Quel est le nom de la deuxieme équipe?");
            Equipe_B.nom = Console.ReadLine();
            Console.WriteLine("Combien de joueurs dans la deuxieme équipe?");
            int NbJoueurEquipe_B = int.Parse(Console.ReadLine());
            for (int x = 0; x <= NbJoueurEquipe_B; x++)
            {
                Equipe_B.joueurs.Add(new Joueur(Console.ReadLine()));
            }
            foreach (Joueur J in Equipe_B.joueurs)
            {
                Console.WriteLine($"Joueur: {J.nom}, donnez vos 6 personnalités.");

                for (int j = 0; j < 6; j++)
                {
                    saladier.Add(Console.ReadLine());
                }
            }
        }
        public void SimuletInit()
        {
            Joueur E1Un = new Joueur("Cric");
            Joueur E1Deux = new Joueur("Crac");
            Joueur E1Trois = new Joueur("Croc");
            List<Joueur> Un = new List<Joueur> { E1Un, E1Deux, E1Trois };
            Equipe Equipe_A = new Equipe("Un", Un, 10);
            saladier.Add("pet", "repet", "Fido Dido", "Humpty Dumpty");

            Joueur E2Un = new Joueur("Pierre");
            Joueur E2Deux = new Joueur("Jean");
            Joueur E2Trois = new Joueur("Jacques");
            List<Joueur> Deux = new List<Joueur> { E2Un, E2Deux, E2Trois };
            Equipe Equipe_B = new Equipe("Deux", Deux, 8);
        }

        public struct Jouer()
        {

        Console.WriteLine($"Bonjour, Nous sommes a la manche : {}, et {} , C'est a ton tour!");

        }
    }
}
