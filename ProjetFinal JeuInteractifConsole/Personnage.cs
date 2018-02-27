using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_JeuInteractifConsole
{
    public class Personnage
    {
      /*1*/   public int Niveau;
      /*2*/   public string Race;
      /*3*/   public string Nom;
      /*4*/   public int PointVieActuels;
      /*5*/   public int PointVieMaximum;
      /*6*/   public int PointAttaque;
      /*7*/   public int PointMagie;
      /*8*/   public int PointDefense;
      /*9*/   public int PointVitesse;
      /*10*/  public int PointExperience;
      /*11*/  public int SeuilExperience;
      /*12*/  public List<string> Sort;
      /*13*/  public string ObjetTenu;
      /*14*/  public int PointExperienceFournis;
        public Personnage(int niv, string R, string NomP, int pva, int pvm, int pa, int pm, int pd, int pv, int pe, int SeuilE, List<string> s, string ob, int pef)
        {
           /*1*/  Niveau = niv;
           /*2*/  Race=R;
           /*3*/  Nom=NomP;
           /*4*/  PointVieActuels=pva;
           /*5*/  PointVieMaximum=pvm;
           /*6*/  PointAttaque=pa;
           /*7*/  PointMagie=pm;
           /*8*/  PointDefense=pd;
           /*9*/  PointVitesse=pv;
          /*10*/  PointExperience=pe;
          /*11*/  SeuilExperience=SeuilE;
          /*12*/  Sort = s;
          /*13*/  ObjetTenu=ob;
          /*14*/  PointExperienceFournis=pef;
        }

    }
}
