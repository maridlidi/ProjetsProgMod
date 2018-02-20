using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo61_ProcedureAfficherListe
{
    /* RÉALISER UNE PROCÉDURE NOMMÉE AFFICHER BONS ELEMENTS, PRENANT EN PARAMÈTRE UNE LISTE D’ENTIERS(LIST, LINKEDLIST, ?)
    ET UN BOOLÉEN, QUI VA AFFICHER LES ÉLÉMENTS D’INDICES PAIRS SI LE BOOLÉEN A LA VALEUR TRUE 
    ET LES ÉLÉMENTS D’INDICE IMPAIRS SI LE BOOLÉEN A LA VALEUR FALSE*/
    class Program
    {
        public static void AfficheBonsElements(List<int> nombre, bool element)

        {
            foreach (int x in nombre)
            {
                if (x % 2 == 0)
                {
                    element = true;
                    Console.WriteLine($"{x}, {element}");
                }
                else
                {
                    element = false;
                    Console.WriteLine($"{x}, {element}");
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> maListe = new List<int> { 1, 2, 3, 4, 5, 6, 7, 89, 135465 };
            bool nombrepair = true;
            AfficheBonsElements(maListe, nombrepair);
        }
    }
}

