using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo62_FonctionRetourneElementPile
{
    /* RÉALISEZ UNE FONCTION QUI PREND UNE PILE EN PARAMETRE ET RETOURNE LE NOMBRE D'ÉLÉMENT QUELLE CONTIENT.*/
    class Program
    {
        static void AfficherMaPile(Stack<string> Pile)
        {
            int compteur = 0;
            foreach (string x in Pile)
            {
                Console.WriteLine(x);
                compteur++;
            }
            Console.WriteLine(compteur);
        }
        // POUR L'INSTANT, NE FAIS QUE AFFICHER LES ÉLÉMENTS DE MA CRISS DE PILE, TROUVER COMMENT FAIRE DECOMPTE.
        static void Main(string[] args)
        {
            Stack<string> Pile = new Stack<string>();
            Pile.Push("Cric");
            Pile.Push("Crac");
            Pile.Push("Croc");
            AfficherMaPile(Pile);
        }
    }
}
