using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_JeuInteractifConsole
{
    /* LES SORTS RESPECTERONTS LES CONDITIONS SUIVANTES*/
    //UN PERSONNAGE NE PAS AVOIR PLUS DE SORTS QUE SON NIVEAU
    //LA PUISSANCE DUN SORT NE PEUT PAS ETRE PLUS FORTE QUE LE NIVEAU DU PERSONNAGEQUI LE POSSEDE
    // PLUS LA PUISSANCE DUN SORT EST GRANDE, PLUS LES DEGATS INFLIGÉS SERONT GRANDS
    public struct Sort
    {
        public string NomSort;
        public string TypeSort;//REPRESENTE L'ELEMENT UTILISÉ(EX:EAU, FEU, GLACE, POISON)
        public int PuissanceSort;//REPRESENTE A QUEL POINT LE SORT EST PUISSANT

        public Sort(string _nomS, string _typeS, int _pS)
        {
            NomSort = _nomS;
            TypeSort = _typeS;
            PuissanceSort = _pS;
            
        }
        public static int ChanceDeLancerSort()
        {
            ChanceDeLancerSort = 1 - ChanceDeFrapper
     }
    }
   
}
