using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo41_JeuPlusMoin
{   /* LE JEU DU PLUS OU MOIN. CREER UNPROGRAMME DONT LE BUT EST DE FAIRE DEVINER A L'UTILISATEUR UN NOMBRE DANS UN INTERVALLE DONNÉ. */
    // LE PROGRAMME COMMENCERA PAR DEMANDER UN NOMBRE QUI DÉFINIT LINTERVALLE DE CHOIX DU NOMBRE ALEATOIRE
    // LE PROGRAMME DEMANDERA ENSUITE, EN COMBIEN DESSAIS LENOMBRE DEVRA ETRE DEVINE
    // LE PROGRAMME DEMANDERA ENSUITE PLUSIEURS FOIS A LUTILISATEUR DE RENTRER UN NOMBRE, ET DIRA PLUS OU MOIN A CHAQUE FOIS.
    // tERMINE EN DISANT BRAVO SI TROUVE, SINON DIT DESOLE CETAIS....
    class Program
    {
        public static int[] DemanderIntervalle()
        {
            Console.WriteLine("Donner un nombre.");
            int reponse = int.Parse(Console.ReadLine());
            int[] DemanderIntervalle = new int[] { 1, reponse };
            return DemanderIntervalle;
        }
        public static int DemanderNombreEssais()
        {
            Console.WriteLine("Dites en combien d'essais vous pensez trouver le nombre ? ");
            int DemanderNombreEssais = int.Parse(Console.ReadLine());
            return DemanderNombreEssais;
        }
        public static int GenererAleatoire(int[] DemanderIntervalle)
        {
            Random aleatoire = new Random();
            int genererAleatoire = aleatoire.Next(DemanderIntervalle[0], DemanderIntervalle[1]);
            return genererAleatoire;
        }
        public static void DemanderNombreADeviner(int NombreEssais)
        {
            int[] intervalle = DemanderIntervalle();
            int NombreADeviner=GenererAleatoire(intervalle);
            bool trouve=false;
            while(NombreEssais != 0 & !trouve)
            {
                NombreEssais--;
                Console.WriteLine("Dite un nombre");
                int reponse = int.Parse(Console.ReadLine());
                if (NombreADeviner<reponse)
                {
                    Console.WriteLine("C'est moin!");
                }
                else if(NombreADeviner>reponse)
                {
                    Console.WriteLine("C'est plus!");
                }
                else
                {
                    trouve = true;
                }
            }

            FeleciterOuPas(trouve, NombreADeviner);
        }
        public static void FeleciterOuPas(bool NombreTrouve, int NombreADeviner)
        {
            if(NombreTrouve)
            {
                Console.WriteLine("Felicitation, tu as trouve!");
            }
            else
            {
                Console.WriteLine($"Dommage, Cetais {NombreADeviner} le bon numero...");
            }
        }
        static void Main(string[] args)
        {
            
            int nombreEssais=DemanderNombreEssais();
            DemanderNombreADeviner(nombreEssais);
        }
    }
}
