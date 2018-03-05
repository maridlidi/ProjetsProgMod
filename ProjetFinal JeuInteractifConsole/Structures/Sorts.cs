using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinalProgMod;
using ProjetFinalProgMod.Structures;

namespace ProjetFinalProgMod.Structures
{
    public class Sorts
    {
        public string NomSort;
        public string TypeSort;
        public int PuissanceSort;

        public Sorts(string nomSort, string typeSort, int puissanceSort)
        {
            NomSort = nomSort;
            TypeSort = typeSort;
            PuissanceSort = puissanceSort;
        }

        public Sorts() { }


    }
}
