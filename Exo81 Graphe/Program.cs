using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo81_Graphe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Graphe = new Dictionary<string, List<string>>();
            Graphe.Add("A", new List<string>() { "B", "D" });
            Graphe.Add("B", new List<string>() { "A", "C" });
            Graphe.Add("C", new List<string>() { "B", "E", "D" });
            Graphe.Add("D", new List<string>() { "C", "A" });
            Graphe.Add("E", new List<string>() { "C" });
        }
    }
}
