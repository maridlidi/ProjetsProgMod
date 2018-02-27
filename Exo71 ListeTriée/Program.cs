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
       public static List<T> listeTrie<T> (List<T> aTrier )
        {
            
            foreach (T entre in aTrier.ToList())
            {
                for (dynamic i = 0; i < aTrier.Count-1; i++)
                {
                    if (aTrier[i] > aTrier[i+1])
                    {
                        
                        dynamic temporaire=aTrier[i + 1];
                        aTrier[i+1] = aTrier[i];
                        aTrier[i]=temporaire;
                    }
                }
            }
            return aTrier;
        }


        static void Main(string[] args)
        {
            List<int> nb1 = new List<int>() { 2,6,7,8,5,5,4,54,5,7,8,9};

            List<double> nb2 = new List<double>() { 2.2,3.4,4.6,4.1,2.3,8.7,1.1};
            var nouvelleListe = listeTrie(nb1);
           foreach(var n in nouvelleListe.ToList())
            {
                Console.WriteLine(n);
            }
        }
    }
}
