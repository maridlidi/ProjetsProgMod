using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal_JeuInteractifConsole;


namespace ProjetFinal_JeuInteractifConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage Hero = new Personnage();
            
            List<Sort> hero = new List<Sort>();
          hero.Add("Atchoum", "Rend malade", 2);
            Personnage adversaire = new Personnage();
           
            ObjetTenu ObjetTenuHero = new ObjetTenu("", "", );
            // CHOIX DE L'UTILISATEUR
            Sort Invisibilite = new Sort() { };
           Combat sansCombat =new Combat() { };
        }
    }
}
