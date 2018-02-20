using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo71_ListeTriée
{
    class Program
    {   /* RÉALISER UNE METHODE GÉNÉRIQUE NOMMÉE TRIÉLISTE:
        ELLE AURA EN PARAMETE UNE LISTE PASSÉE EN RÉFÉRENCE
        ELLE SERA CAPABLE DE TRIER DES LIST<INT> ET DES LIST<DOUBLE>
        ELLE RETOURNERA UNE LISTE TRIÉ
        INTERDICTION DUTILISER LA METHODE SORT.  */
        public static SortedList<dynamic> TrieListe(ref List<int> nb1, ref List<double> nb2 )
        {
           dynamic SortedList< T> TrieListe = new SortedList<T,T> { nb1, nb2 };
            return TrieListe;

        }

        static void Main(string[] args)
        {
            List<int> nb1 = new List<int>() { 0,1,2,3,4,5,6,7,8,9};

            List<double> nb2 = new List<double>() { 2.2,3.4,4.6,4.1,2.3,8.7,1.1};

        }
    }
}
