using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo104_GestionStock
{
    class Program
    {
        public struct arcticle
        {
            public string nomArcticle;
            public int numeroArcticle;
            public double prixVente;
            public double prixPrecedent;
            public int quantite;
            public string reference;

            public arcticle(string NomArcticle, int NumeroArcticle, double PrixVente, double PrixPrecedent, int Quantite, string Reference)
            {
                nomArcticle = NomArcticle;
                numeroArcticle = NumeroArcticle;
                prixVente = PrixVente;
                prixPrecedent = PrixPrecedent;
                quantite = Quantite;
                reference = Reference;
            }

        }


        static void Main(string[] args)
        {
       
        }

    }
    
}
