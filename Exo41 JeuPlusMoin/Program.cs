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
            int[] DemanderIntervalle = new int[] { 1, (reponse) };
            return DemanderIntervalle;
        }
        public static int DemanderNombreEssais(int NombreEssais)
        {
            Console.WriteLine("Dites en combien d'essais vous pensez trouver le nombre?");
            int DemanderNombreEssais = int.Parse(Console.ReadLine());
            return DemanderNombreEssais;
        }
        public static int GenererAleatoire(int[] intervalle)
        {
            Random aleatoire=new Random();
           int[] intervalle= aleatoire.Next(1, (int[] DemanderIntervalle));
        }
        public static void DemanderNombreADeviner(int NombreEssais)
        {
            int nombreEssais = int.Parse(Console.ReadLine());
        }
        public static void FeleciterOuPas(bool NombreTrouve, int NombreADeviner)
        {
            if(NombreTrouve==true)
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

        }
    }
}
