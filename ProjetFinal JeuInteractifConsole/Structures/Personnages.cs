using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;

namespace ProjetFinalProgMod.Structures
{
    public class Personnage
    {
        static readonly Random Rand = new Random();

        public int Niveau;
        public string Race;
        public string NomPers;
        public int PtsVieActuels;
        public int PtsVieMax;
        public int PtsAttaque;
        public int PtsMagie;
        public int PtsDefense;
        public int PtsVitesse;
        public int PtsExperience;
        public int SeuilExperience;
        public List<Sorts> SortsPers;
        public ObjetTenu ObjetTenuPers;
        public int ValeurPersoExperience;
        public int ExperienceTotale;

        public Personnage(string race, string nomPers, int ptsVieMax,
        int ptsAttaque, int ptsMagie, int ptsDefense, int ptsVitesse,
        ObjetTenu objetTenuPers)
        {
            // PARAMETRE ATTRIBUÉ PAR DEFAUT, ENLEVER DU CONSTRUCTEUR
            Niveau = 1;
            Race = race;
            NomPers = nomPers;


            // STATS
            PtsVieMax = ptsVieMax;
            PtsVieActuels = PtsVieMax;

            PtsAttaque = ptsAttaque;
            PtsMagie = ptsMagie;
            PtsDefense = ptsDefense;
            PtsVitesse = ptsVitesse;

            // DETERMINE LES POINTS DEXPERIENCE INITIAL, ET LE PROCHAIN NIVEAU
            PtsExperience = 0;
            SeuilExperience = 200;


            // CONSTRUCTEUR POUR EQUIPER MON PERSONNAGE
            SortsPers = new List<Sorts>();
            ObjetTenuPers = objetTenuPers;
        }
        // CRÉATION D'UN PERSONNAGE VIDE
        public Personnage() { }

        public void AfficherPersonnage()
        {
            Console.WriteLine($"\nNiveau:\t\t\t\t{Niveau}");
            Console.WriteLine($"Race:\t\t\t\t{Race}");
            Console.WriteLine($"Nom:\t\t\t\t{NomPers}");
            Console.WriteLine($"Points de vie actuels:\t\t{PtsVieActuels}");
            foreach (Sorts sort in SortsPers)
            {
                Console.WriteLine(sort);
            }
            //Console.WriteLine($"Sorts possédés:{SortsPers}");//ajouter un foreach pour 
            Console.WriteLine($"Objet tenu:{ObjetTenuPers.NomObjetTenu}");

        }

        // VERIFIE SI LES POINTS DE VIE SONT RENDU A 0 SI OUI TRUE
        public bool AmIDead()
        {
            if (PtsVieActuels <= 0)
            {
                Console.WriteLine($"{NomPers} est mort !!!");
                Console.WriteLine();
                return true;
            }
            else
            {
                return false;
            }
        }

        // METHODE DE FRAPPE
        public bool FrapperAdversaire(ref Personnage adversaire)
        {
            int pointsDegats = 0;
            int randomDegat = Rand.Next(-5, 5);
            if (!ObjetTenuPers.Equals(default(ObjetTenu)))
            {
                pointsDegats = PtsAttaque + ObjetTenuPers.PuissanceObjetTenu + randomDegat - adversaire.PtsDefense;
            }
            else
            {
                pointsDegats = PtsAttaque + randomDegat - adversaire.PtsDefense;
            }

            if (pointsDegats <= 0)
            {
                adversaire.PtsVieActuels = adversaire.PtsVieActuels - 1;
            }
            else
            {
                adversaire.PtsVieActuels = adversaire.PtsVieActuels - pointsDegats;
            }
            return adversaire.AmIDead();
        }

        // METHODE POUR LANCER SORTS
        public bool LancerSort(ref Personnage adversaire)
        {
            var rand = new Random();
            int pointsDegats = 0;
            int randomDegat = Rand.Next(-5, 5);
            Sorts LeSortUtilisde = SortsPers[rand.Next(0, SortsPers.Count)];
            pointsDegats = randomDegat + PtsMagie + LeSortUtilisde.PuissanceSort - adversaire.PtsDefense;
            if (pointsDegats <= 0)
            {
                adversaire.PtsVieActuels = adversaire.PtsVieActuels - 1;
            }
            else
            {
                adversaire.PtsVieActuels = adversaire.PtsVieActuels - pointsDegats;
            }
            // VERIFIE SI LE PERSONNAGE EST MORT
            return adversaire.AmIDead();
        }

        // ENLEVE LES POINTS DEXPERIENCE NECESSAIRE POUR ATTEINDRE LE PROCHAIN NIVEAU, ET GARDE LE SURPLUS
        public void GagnerNiveau()
        {
            ValeurExperienceCheck();
            while (PtsExperience > SeuilExperience)
            {
                if (PtsExperience > SeuilExperience)
                {
                    PtsExperience -= SeuilExperience;
                    Niveau++;
                }
                BoostNiveau();
            }
        }

        /* QUAND UN PERSONNAGE GAGNE UN NIVEAU, SES POINTS D'ATTAQUE, DE DEFENSE,
        DE MAGIE ET DE VITESSE SON MULTIPLIER PAR UN FACTEUR CONSTANT. */
        public void BoostNiveau()
        {
            
            {
                PtsAttaque *= 2;
                PtsDefense *= 2;
                PtsVitesse *= 2;
                PtsMagie *= 2;

            }
        }

        // DETERMINE LE NOMBRE DE POINTS DEXPERIENCES FOURNI PAR UN ADVERSAIRE LORSQUIL EST MOURU
        public void ValeurExperienceCheck()
        {
            ValeurPersoExperience = ExperienceTotale / 2;
        }

        // METHODE QUI ATTRIBUE LES POINTS DEXPERIENCE OBTENU LORSQUON GAGNE COMBAT
        public void GagnerExperience( Personnage adversaire)
        {
            int pointsGagne = adversaire.ValeurPersoExperience;
            PtsExperience += pointsGagne;
            ExperienceTotale += pointsGagne;
            ValeurExperienceCheck();
            GagnerNiveau();
        }


    }
}
