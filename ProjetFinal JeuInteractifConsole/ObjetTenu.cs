using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_JeuInteractifConsole
{
   public struct ObjetTenu
    {
        public string NomObjetTenu;//REPRESENTE LE NOM DE L'OBJETEX.EPÉE
        public string TypeObTenu;//REPRESENTE L'ELEMENT UTILISÉ(EX:EAU, FEU, GLACE, POISON)
        public int PuissanceObTenu;// REPRESENTE A QUEL POINT L'OBJET TENU EST PUISSANT

       public  ObjetTenu(string _nomObT, string _typeObT, int _puisanceObT)
        {
            NomObjetTenu = _nomObT;
            TypeObTenu = _typeObT;
            PuissanceObTenu = _puisanceObT;
        }
        //  UN PERSONNAGE POSSEDE UN SEUL OBJET
        //  LA PUISSANCE DUN OBJET TENU NE PEU PAS ETRE PLUS FORTE QUE LE NIVEAU DU PERSONNAGE
        //  PLUS LA PUISSANCE DUN OBJET TENU EST GRANDE PLUS LES DEGATS INFLIGÉS SERONT GRANDS
        //  L'OBJET TENU AUGMENTE LES DEGATS DE.FRAPPERADVERSAIRE(....)PAR RAPPORT A SI LE PERSONNAGE FRAPPAIS A MAIN NU
       
    }
   
}
