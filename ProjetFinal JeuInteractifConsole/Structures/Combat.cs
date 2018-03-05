using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;

namespace ProjetFinalProgMod.Structures
{
    public class Combat
    {
        public Personnage PersonnageJoueur;
        public Personnage PersonnageEnnemi;

        public Combat() { }

        public Combat(Personnage Joueur, Personnage Ennemi)
        {
            PersonnageJoueur = Joueur;
            PersonnageEnnemi = Ennemi;
        }
        /* METHODES OBLIGATOIRES DANS COMBATS  
         * CETTE METHODE EST RESPONSABLR DE DEMANDER A LUTILISATEUR SIL VEUT FRAPPER OU LANCER UN SORT. 
         * ELLE EST EGALEMENT RESPONSABLE DE FAIRE JOUER LADVERSAIRE EN LUI FESANT FRAPPER OU LANCER UN SORT. 
         * ELLE RETOURNERA TRUE SI LE PERSONNAGE A GAGNE*/


        public void LancerCombat()
        {

            Random SortFrappe = new Random();
            bool Attaque = AttaquePremier(PersonnageJoueur, PersonnageEnnemi);
            // TANT QUE LE JOUEUR OU L'ENNEMI NEST PAS MORT
            while (!PersonnageEnnemi.AmIDead() & !PersonnageJoueur.AmIDead())
            {
                // ATTAQUE JOUEUR
                if (Attaque)
                {
                    int x = SortFrappe.Next(0, 2);
                    if (x == 1)
                    {
                        PersonnageJoueur.LancerSort(ref PersonnageEnnemi);
                    }
                    else
                    {
                        PersonnageJoueur.FrapperAdversaire(ref PersonnageEnnemi);
                    }
                }
                // ATTAQUE ENNEMI
                if (!Attaque)
                {
                    int x = SortFrappe.Next(0, 2);
                    if (x == 1)
                    {
                        PersonnageEnnemi.LancerSort(ref PersonnageJoueur);
                    }
                    else
                    {
                        PersonnageEnnemi.FrapperAdversaire(ref PersonnageJoueur);
                    }
                }
                if (Attaque) Attaque = false;
                else Attaque = true;
            }
        }

        /*CETTE METHODE DOIT FAIRE 3 CHOSES. SI L'ADVERSAIRE A UN OBJET PLUS PUISSANT, ALORS IL DEVIENT NOTRE OBJET.  
         * SI L'ADVERSAIRE A UN SORT PLUS PUISSANT DANS CA LISTE, ON PEUT LAPRENDRE. LE PLUS IMPORTANT, 
         * POUR FINIR, ELLE FERA GAGNER DES POINTS DEXPERIENCES AU PERSONNAGE A*/
        public Personnage GagnerCombat()
        {
            if (PersonnageJoueur.AmIDead())
            {
                // GAME OVER
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
                return PersonnageJoueur;
            }
            // LE PERSONNAGE ENNEMI EST MOURU
            else
            {
                // METHODE POUR TROUVER MON SORT LE PLUS PUISSANT
                if (PersonnageJoueur.ObjetTenuPers.PuissanceObjetTenu < PersonnageEnnemi.ObjetTenuPers.PuissanceObjetTenu)
                {
                    PersonnageJoueur.ObjetTenuPers = PersonnageEnnemi.ObjetTenuPers;
                }
                int PuissantMax = 0;
                Sorts SortLePlusPuissant = null;
                foreach (Sorts sort in PersonnageEnnemi.SortsPers)
                {
                    if (sort.PuissanceSort > PuissantMax)
                    {
                        PuissantMax = sort.PuissanceSort;
                        SortLePlusPuissant = sort;
                    }
                }
                foreach (var sort in PersonnageEnnemi.SortsPers)
                {
                    if (sort.PuissanceSort > SortLePlusPuissant.PuissanceSort)
                    {
                        // FONCTION QUI DEMANDE SI ON AJOUTE LE NOUVEAU SORT
                        //TECHNIQUEMENT, ICI DEVRAIT VERIFIER SI MA LISTE DE SORT EST PLEINE POUR LE RAJOUTER
                        /*   if(PersonnageJoueur)
                           {*/
                        PersonnageJoueur.SortsPers.Add(sort);
                        /*  }
                          else
                          {
                              Console.WriteLine("Je ne veux pas de ton sort!!!");
                          }*/
                    }

                }
                PersonnageJoueur.PtsExperience += PersonnageEnnemi.ValeurPersoExperience;
                PersonnageJoueur.ExperienceTotale += PersonnageEnnemi.ValeurPersoExperience;
                PersonnageJoueur.GagnerNiveau();
                PersonnageJoueur.GagnerExperience();
                PersonnageJoueur.BoostNiveau();
                return PersonnageJoueur;
            }
        }

        /* ELEMENTS A RESPECTER */
        // LORS DE LAPPEL POUR SAVOIR QUI ATTAQUE LE PREMIER, SI(TRUE) JOUEUR ATTAQUE PREMIER
        public bool AttaquePremier(Personnage persJoueur, Personnage persEnnemi)
        {
            if (persJoueur.PtsVitesse > persEnnemi.PtsVitesse)
            {
                return true;
            }
            return false;
        }

    }
}
