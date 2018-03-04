using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal_JeuInteractifConsole;

namespace ProjetFinal_JeuInteractifConsole
{
    
    public struct Personnage
    {
      /*1*/   public int Niveau; /*REPRESENTE LA PROGRESSION GLOBALE DU PERSONNAGE*/
      /*2*/   public string Race;/*REPRESENTE LA RACE DUN PERSONNAGE*/
      /*3*/   public string Nom;/*REPRESENTE LE NOM DUN PERSONNAGE*/
      /*4*/   public int PointVieActuel;/*POINTS DE VIE RESTANTS DU PERSONNAGE*/
      /*5*/   public int PointVieMaximum;/*POINTS DE VIE MAXIMUM QUN PERSONNAGE PEUT AVOIR(100 SI ON A 40/100POINTS DE VIE)
      /*6*/   public int PointAttaque;/*DETERMINE A QUEL POINT VOTRE PERSONNAGE FRAPPE FORT*/
      /*7*/   public int PointMagie;/*DETERMINE A QUEL POINT LES SORTS DE VOTER PERSONNAGE SONT PUISSANT*/
      /*8*/   public int PointDefense;/*DETERMINE A QUEL POINT VOTER PERSONNAGE RESISTE AUX ATTAQUES QU'ON LUI INFLIGE*/
      /*9*/   public int PointVitesse;/*DANS LE CADRE D'UN DEBUT DE COMBAT, VA DETERMINER QUEL PERSONNAGE VA COMMENCER*/
      /*10*/  public int PointExperience;/*REPRESENTE LE NOMBRE DE POINTS DEXPERIENCES OBTENUS POUR PASSER D'UN NIVEAU A L'AUTRE*/
      /*11*/  public int SeuilExperience;/*REPRESENTE LE NOMBRE DE POINT D'EXPERIENCE A AVOIR POUR GAGNER UN NIVEAU*/
      /*12*/  public List<string> Sort;/*REPRESENTE L'ENSEMBLE DES SORTS QUE POSSEDE UN PERSONNAGE*/
      /*13*/  public string ObjetTenu;/*REPRESENTE L'OBJET TENU PAR LE PERSONNAGE*/
      /*14*/  public int PointExperienceFournis;/*REPRESENET LES POINTS D'EXPERIENCE QU'UN AUTRE PERSONNAGE VA GAGNER EN TUANT CE PERSONNAGE*/

        public Personnage(int _niv, string _R, string NomP, int _pva, int _pvm, int _pa, int _pm, int _pd, int _pv, int _pe, int _sExp, List<string> _s, string _ob, int _pef)
        {
           /*1*/  Niveau = _niv;
           /*2*/  Race=_R;
           /*3*/  Nom=NomP;
           /*4*/  PointVieActuel=_pva;
           /*5*/  PointVieMaximum=_pvm;
           /*6*/  PointAttaque=_pa;
           /*7*/  PointMagie=_pm;
           /*8*/  PointDefense=_pd;
           /*9*/  PointVitesse=_pv;
          /*10*/  PointExperience=_pe;
          /*11*/  SeuilExperience=_sExp;
          /*12*/  Sort = _s;
          /*13*/  ObjetTenu=_ob;
          /*14*/  PointExperienceFournis=_pef;
           
        }

        public static Random random = new Random();
        public int GagnerNiveau(Personnage Principale)
        {
        if(PointExperience>SeuilExperience)
            {
                Niveau++;
            }
            return Niveau;
        }

        public int GagnerExperience(int pointsGagnes)
        {
            if(Po)
        }

        public bool FrapperAdversaire(ref Personnage adversaire)
        {
            int PointsDegat = 0;
            int NiveauAttaque = random.Next(-5, 5);

            if(ObjetTenu.Equals(default(ObjetTenu)))
            {
                PointsDegat = PointAttaque + ObjetTenuHero.PuissanceObTenu + NiveauAttaque - adversaire.PointDefense;
            }
            else
            {
                PointsDegat = PointAttaque + NiveauAttaque - adversaire.PointDefense;
            }
            if(PointsDegat<=0)
            {
                adversaire.PointVieActuel = adversaire.PointVieActuel -1;
            }
            else
            {
                adversaire.PointVieActuel = adversaire.PointVieActuel - PointsDegat;
            }
        }

       public void LancerSorts(string nomSort, Personnage adversaire)
        {

        }

        public bool Dead()
        {
            if (PointVieActuel <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SeuilExperiencePersonnage()
        {
         SeuilExperience = Niveau;
        }
    }
    
}
