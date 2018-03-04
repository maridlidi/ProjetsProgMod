using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo91a93_StructPersonnage
{
    // EX91**: RÉALISEZ VOTRE PROPRE STRUCTURE NOMMÉE PERSONNAGE  
    public struct Personnage
    {
        public string nom;
        public string race;
        public int PointVie;
        public int PointAttaque;
        public int PointDefense;
        //	UN CONSTRUCTEUR PRENANT EN PARAMÈTRE TOUS LES ATTRIBUTS PRÉCÉDENTS
        public Personnage(string Nom, string Race, int PointDeVie, int PointDattaque, int PointDeDefense)
        {
            nom = Nom;
            race = Race;
            PointVie = PointDeVie;
            PointAttaque = PointDattaque;
            PointDefense = PointDeDefense;
            AfficherPersonage();
        }
        // UNE MÉTHODE NOMMÉE POWERUP(): CETTE MÉTHODE MULTIPLIERA PAR 2 LES POINTS D’ATTAQUE
        public void PowerUp()
        {
            PointAttaque = PointAttaque * 2;
        }
        // UNE MÉTHODE NOMMÉE AMLDEAD(): CETTE MÉTHODE RETOURNE TRUE SI LES POINTS DE VIE ONT UNE VALEUR INFÉRIEURE OU ÉGALE À 0
        public bool AmlDead()
        {
            if (PointVie <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // UNE MÉTHODE NOMMÉE AFFICHERPERSONNAGE(): CETTE MÉTHODE AFFICHERA TOUS LES ATTRIBUTS DE LA STRUCTURE SOUS LA FORME:
        public void AfficherPersonage()
        {
            Console.WriteLine($" Nom: {nom} ");
            Console.WriteLine($" Race: {race}");
            Console.WriteLine($"Point de Vie: {PointVie}");
            Console.WriteLine($"Point d'attaque: {PointAttaque}");
            Console.WriteLine($"Point de Défense: {PointDefense}");
        }
       // EX92**:  A PARTIR DE LA STRUCTURE DE L’EXERCICE 91, AJOUTER UNE MÉTHODE POUR FRAPPER UN ENNEMI:
        public bool FrapperEnnemi(ref Personnage Ennemi)
        {
            if (PointAttaque > Ennemi.PointDefense)
            {
                Ennemi.PointVie -= PointAttaque - Ennemi.PointDefense;
            }
            if (Ennemi.PointDefense > PointAttaque)
            {
                Ennemi.PointVie -= 1;
            }
            if (Ennemi.AmlDead())
            {
                Console.WriteLine($"{Ennemi.nom}  EST MORT!!!!!!");
                return true;
            }
            return false;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            /*EX93**: DANS LA MÉTHODE MAIN DE VOTRE PROGRAMME, CRÉER 2 PERSONNAGES ET SIMULER UN COMBAT
        ENTRE CES DEUX PERSONNAGES DONT L’ISSUE SERA LA MORT D’UN DES PERSONNAGE!*/
            Personnage P1 = new Personnage("Pet", "humain", 65, 8, 2);
            Personnage P2 = new Personnage("Repet", "Elfe", 80, 7, 5);
            Personnage P3 = new Personnage("Prhoot", "Orc", 95, 10, 10);

            while (P1.AmlDead() == false && P2.AmlDead() == false)
            {
                P1.FrapperEnnemi(ref P2);
                P2.FrapperEnnemi(ref P1);
            }

        }
    }
}
