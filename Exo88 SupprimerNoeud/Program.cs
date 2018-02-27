using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo88_SupprimerNoeud
{
    /*REALISER UNE METHODE GENERIQUE CAPABLE DE SUPPRIMER UN NOEUD DANS UN GRAPHE*/

    // ELLE SUPPRIMERA LE NOEUD AINSI QUE TOUTES LES VALEURS ASSOCIES.
    class Program
    {
        public static void supprimerNoeud<T>(T noeud, Dictionary<T, List<T>> Graphe)
        {
            //POUR TOUTES LES CLE DANS MON GRAPHE
            foreach (dynamic key in Graphe.ToList())
            {   //JE RECHERCHE PARMIS TOUTES LES VALEURS ASSOCIEES
                for (int i = 0; i < key.Value.Count; i++)
                {   // SI LA CLE(le noeud) CORRESPOND A LA DITES VALEURS
                    if (noeud == key.Value[i])
                    {   //ON SUPPRIME LES VALEURS ASSOCIEES
                        key.Value.Remove(key.Value[i]);
                    }
                }
            }
            // ENSUITERESTE QUA SUPPRIMER LA CLE(LE NOEUD)
            Graphe.Remove(noeud);
            // JE CONFIRME EN FESANS REAFICHER MON GRAPHE
            foreach (dynamic key in Graphe.ToList())
            {
                Console.Write($"Noeud : {key.Key}");
                foreach (dynamic arrete in key.Value)
                {
                    Console.Write($"  Arrete: {arrete}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Graphe = new Dictionary<string, List<string>>();
            Graphe.Add("A", new List<string>() { "E", "D" });
            Graphe.Add("B", new List<string>() { "D", "E" });
            Graphe.Add("C", new List<string>() { "D", "E" });
            Graphe.Add("D", new List<string>() { "A", "B", "C" });
            Graphe.Add("E", new List<string>() { "A", "B", "C" });
            // ICI JAPPEL MA FONCTION, ET JE LUI DEMANDE DE SUPPRIMER LE NOEUD "D" DANS LE GRAPHE
            supprimerNoeud("D",Graphe);
        }
    }
}
