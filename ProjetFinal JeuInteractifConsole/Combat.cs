using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal_JeuInteractifConsole;

namespace ProjetFinal_JeuInteractifConsole
{
  
    public struct Combat
    {
        public int ChanceDeFrapper;
        public int ChanceDeLancerSort;

    }
    
    /*CETTE METHODE LANCERA UN COMBAT ENTRE 2 PERSONNAGES. 
     * ELLE EST RESPONSABLE DE DEMANDER A LUTILISATEUR S'IL VEUT FRAPPER OU LANCER UN SORT. 
     * ELLE EST EGALEMENT RESPONSABLE DE FAIRE JOUER L'ADVERSAIRE EN LUI FESANT LANCER UN SORT OU EN LE FESANT FRAPPER. 
     * ELLE RETOURNERA TRUE SI SI LE PERSONNAGE "A" A GAGNÉ. QUAND ELLE FERA JOUER VOTRE ADVERSAIRE,
     * POUR SAVOIR S'IL LANCE UN SORT OU S'IL FRAPPE, ELLE UTILISERA LA PROBABILITE SUIVANTE:
     * ChanceDeFrapper = PointAttaque / (PointAttaque + PointsMagie); ET ChanceDeLancerSort = 1 - ChanceDeFrapper*/
    public LancerCombat(ref Personnage adversaire)
    {
    Console.WriteLine("");
       

    }
    // CETTE METHODE FAIT 3 CHOSES
    public bool GagnerCombat(ref Personnage Hero)
    {
     
    if (PointVitesse>adversaire.PointVitesse)
    {
        
    }
     else
        {
        
        }
        return true;
    }

    public static int ChanceDeFrapper(int frappe)
    {
        ChanceDeFrapper = PointAttaque / (PointAttaque + PointMagie);

    }

    
}