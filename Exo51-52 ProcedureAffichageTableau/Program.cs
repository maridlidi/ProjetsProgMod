using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo51_52_ProcedureAffichageTableau
{
    class Program
    {
        public static void Exo52(string[] Nom, string[] prenom)
        {
            for (int x = 0; x < Nom.Length; ++x)
            {
                Console.WriteLine($"Ex0 52 : {Nom[x]} {prenom[x]}");
            }
        }
        public static void NomUtilisateur(string[] utilisateur)
        {
            for (int x = 0; x < utilisateur.Length; ++x)
            {
                Console.WriteLine($"Ex0 51 : {utilisateur[x]}");
            }
        }
        static void Main(string[] args)
        {
            string[] Nom = new string[] { "pierre", "Jean", "Jacques" };
            string[] NomFamille = new[] { "Crick", "Crack", "Crock" };
            NomUtilisateur(Nom);
            Console.ReadLine();
            Console.Clear();
            Exo52(NomFamille, Nom);
        }
    }
}
