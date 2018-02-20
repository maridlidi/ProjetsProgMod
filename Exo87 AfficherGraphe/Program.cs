using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo87_AfficherGraphe
{
    class Program
    {   /* REPRÉSENTEZ LE GRAPHE SUIVANT A LAIDE DU DICTIONNAIRE. */

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Graphe = new Dictionary<string, List<string>>();
            Graphe.Add("A", new List<string>() { "E", "D" });
            Graphe.Add("B", new List<string>() { "D", "E" });
            Graphe.Add("C", new List<string>() { "D", "E" });
            Graphe.Add("D", new List<string>() { "A", "B", "C" });
            Graphe.Add("E", new List<string>() { "A", "B", "C" });
            foreach (string noeud in Graphe.Keys.ToList())
            {
                Console.Write($"Noeud : {noeud}");
                foreach (string arrete in Graphe[noeud])
                {
                    Console.Write($"  Arrete: {arrete}");
                }
                Console.WriteLine();
            }
        }
    }
}
