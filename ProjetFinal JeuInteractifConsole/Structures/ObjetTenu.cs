using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;

namespace ProjetFinalProgMod.Structures
{
    public class ObjetTenu
    {
        public string NomObjetTenu;
        public string TypeObjetTenu;
        public int PuissanceObjetTenu;

        public ObjetTenu(string nomObjetTenu, string typeObjetTenu, int puissanceObjetTenu)
        {
            NomObjetTenu = nomObjetTenu;
            TypeObjetTenu = typeObjetTenu;
            PuissanceObjetTenu = puissanceObjetTenu;
        }

        public ObjetTenu() { }


    }
}
