using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo63_ListeDattente
{/* A PARTIR D'UNE STRUCTURE DE DONNÉES CONNUE(TABLEAU, LISTE, PILE, FILE?), MODELISEZ LE PHENOMENE
    DE FILE D'ATTENTE. LE PHENOMENE EST; CHAQUE CLIENT EST MODELISE PAR UN TABLEAU A 1 DIMENSION AVEC 2 ÉLÉMENTS. 
    LE PREMIER ELEMENT EST SON NOM, LE 2IEME ELEMENT EST UNE STRING QUI A LA VALEUR "ARGENT" SI LE CLIENT POSSEDE
    DE QUOI PAYER ET "PASDARGENT" SI LE CLIENT NA PAS DE QUOI PAYER.*/
    class Program
    {
        public static Random random = new Random();

        public static void TraiterProchainClient(Queue<string> Client, Queue<string> Argent)
        {
            int Employe = 20;

            bool Donut = false;
            string ClientActuel = Client.Peek();
            string ArgentClient = Argent.Peek();

            if (ArgentClient == "Argent")
            {
                Donut = true;
            }
            else
            {
                Employe = random.Next() % 10;
                if (Employe != 0)
                {
                    Donut = false;
                }
                else
                {
                    Donut = true;
                }
            }
            if (Donut == true & Employe == 0)
            {
                Console.WriteLine($"Le client {ClientActuel} , donut : {Donut} je congedie mon employe , car il avait {ArgentClient}");
            }
            else if (Employe == 20 & Donut == true)
            {
                Console.WriteLine($" Le client {ClientActuel} , donut recu :{Donut}");
            }
            else
            {
                Console.WriteLine($" Le client {ClientActuel} , donut pas recu :{Donut}");
            }
            Client.Dequeue();
            Argent.Dequeue();
        }
        static void Main(string[] args)
        {
            Queue<string> NomClient = new Queue<string>();
            Queue<string> ArgentClient = new Queue<string>();
            NomClient.Enqueue("Cric");
            NomClient.Enqueue("Crack");
            NomClient.Enqueue("Croc");
            ArgentClient.Enqueue("Argent");
            ArgentClient.Enqueue("Argent");
            ArgentClient.Enqueue("PasArgent");
            TraiterProchainClient(NomClient, ArgentClient);
            TraiterProchainClient(NomClient, ArgentClient);
            TraiterProchainClient(NomClient, ArgentClient);
        }
    }
}
