using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo101a103_JeuSaladier
{
    public struct Equipe
    {
        public string nom;
        public List<Joueur> joueurs;
        public int nbpoints;

        public Equipe (string Nom, List<Joueur> Joueurs, int NbPoints)
        {
            nom = Nom;
            joueurs = Joueurs;
            nbpoints = NbPoints;
        }
    }
}
