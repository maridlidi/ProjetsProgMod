using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo91a93_StructPersonnage
{
    public struct Personnage
    {
        public string nom;
        public string race;
        public int PointVie;
        public int PointAttaque;
        public int PointDefense;

        public Personnage(string Nom, string Race, int PointDeVie, int PointDattaque, int PointDeDefense)
        {
            nom = Nom;
            race = Race;
            PointVie = PointDeVie;
            PointAttaque = PointDattaque;
            PointDefense = PointDeDefense;
            AfficherPersonage();
        }
        public void PowerUp()
        {
            PointAttaque = PointAttaque * 2;
        }
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
        public void AfficherPersonage()
        {
            Console.WriteLine($" Nom: {nom} ");
            Console.WriteLine($" Race: {race}");
            Console.WriteLine($"Point de Vie: {PointVie}");
            Console.WriteLine($"Point d'attaque: {PointAttaque}");
            Console.WriteLine($"Point de Défense: {PointDefense}");
        }
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
