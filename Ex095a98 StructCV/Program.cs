using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex095a98_StructCV
{
    public struct Ecole
    {
        public string nomecole;
        public int anneedebut;
        public int anneefin;
        public int scoreprestige;

        public Ecole(string NomEcole, int AnneeDebut, int AnneeFin, int ScorePrestige)
        {
            nomecole = NomEcole;
            anneedebut = AnneeDebut;
            anneefin = AnneeFin;
            scoreprestige = ScorePrestige;

        }
        public void AfficherEcole()
        {
            Console.WriteLine($"Nom Ecole : {nomecole}, Cote de Prestige : {scoreprestige}");
        }
    }
    public struct ExperienceProfessionnel
    {
        public string nomentreprise;
        public string intituleposte;
        public int anneedebut;
        public int anneefin;

        public ExperienceProfessionnel(string NomEnterprise, string IntitulePoste, int AnneeDebut, int AnneeFin)
        {
            nomentreprise = NomEnterprise;
            intituleposte = IntitulePoste;
            anneedebut = AnneeDebut;
            anneefin = AnneeFin;
        }
        public void AfficherExp()
        {
            Console.WriteLine($"Les Expériences professionnels sont: \n Nom de l'entreprise: {nomentreprise},\n Poste Occupé: {intituleposte}, \n DE: {anneedebut} a {anneefin}");
        }
    }
    public struct CV
    {
        public string titre;
        public string nom;
        public string prenom;
        public List<Ecole> ecoles;
        public List<ExperienceProfessionnel> experiencesprofessionnels;

        public CV(string Titre, string Nom, string Prenom, List<Ecole> Ecoles, List<ExperienceProfessionnel> ExperiencesProfessionnels)
        {
            titre = Titre;
            nom = Nom;
            prenom = Prenom;
            ecoles = Ecoles;
            experiencesprofessionnels = ExperiencesProfessionnels;
        }
        // RÉALISER UNE PROCEDURE DANS LA STRUCTURE CV AFFICHANT LA TOTALITE DES INFORMATIONS DUN CV.
        public void AfficherCV()
        {
            Console.WriteLine($"Titre : {titre}, Nom : {nom}, Prenom : {prenom} ");
            foreach (Ecole ecole in ecoles)
            {
                ecole.AfficherEcole();
            }
            foreach (ExperienceProfessionnel exp in experiencesprofessionnels)
            {
                exp.AfficherExp();
            }
        }
        //  CREER UNE FONCTION DANS LA STRUCTURE CV QUI COMPARERA 2 CV
        public bool EstMeilleurQue(CV Personne2)
        {
            int TotalScoresCV = 0;
            int TotalCVAComparer = 0;

            foreach (Ecole E in Personne2.ecoles)
            {
                TotalCVAComparer += E.scoreprestige;
            }
            TotalCVAComparer += Personne2.experiencesprofessionnels.Count * 5;
            foreach (Ecole E in ecoles)
            {
                TotalScoresCV += E.scoreprestige;
            }
            TotalScoresCV += experiencesprofessionnels.Count * 5;
            if (TotalScoresCV > TotalCVAComparer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
  

    class Program
    {
        public static CV retourMeilleur(List<CV> Employe)
        {
            CV meilleurCV = new CV();
            int maxScore = 0;
            for (int i = 0; i < Employe.Count; i++)
            {
                int scoreCV = 0;

                foreach (Ecole E in Employe[i].ecoles)
                {
                    scoreCV += E.scoreprestige;
                }
                scoreCV += Employe[i].experiencesprofessionnels.Count * 5;


                if (scoreCV > maxScore)
                {
                    maxScore = scoreCV;
                    meilleurCV = Employe[i];
                }
            }
            return meilleurCV;
        }
        static void Main(string[] args)
        {
            Ecole Humanis = new Ecole("Humanis", 2017, 2018, 5);
            Ecole PolyvalenteArvida = new Ecole("PolyvalenteArvida", 1996, 2001, 6);
            Ecole CegepJonquiere = new Ecole("CegepJonquiere", 2002, 2004, 8);
            List<Ecole> E1 = new List<Ecole> { PolyvalenteArvida, CegepJonquiere, Humanis };
            ExperienceProfessionnel Metro = new ExperienceProfessionnel("Metro", "Emballeur", 2005, 2008);
            ExperienceProfessionnel FuturShop = new ExperienceProfessionnel("Futur Shop", "Vendeur Electroniques", 2008, 2014);
            List<ExperienceProfessionnel> Exp1 = new List<ExperienceProfessionnel> { Metro, FuturShop };

            Ecole JuvenatStJean = new Ecole("JuvenatStJean", 1997, 2002, 8);
            Ecole DEP = new Ecole("Dep", 2002, 2004, 7);
            List<Ecole> E2 = new List<Ecole> { JuvenatStJean, DEP };
            ExperienceProfessionnel IGA = new ExperienceProfessionnel("I.G.A.", "Commis fruits et legumes", 2003, 2007);
            List<ExperienceProfessionnel> Exp2 = new List<ExperienceProfessionnel> { IGA };

            CV Personne1 = new CV("Etudiant", "TheCrick", "Crick", E1, Exp1);
            Personne1.AfficherCV();

            CV Personne2 = new CV("Sans Emploi", "TheCrack", "Crack", E2, Exp2);
            Personne2.AfficherCV();
            if(Personne1.EstMeilleurQue(Personne2))
            {
                Console.WriteLine($"Le CV a : {Personne1.prenom} est meilleur que : {Personne2.prenom}");
            }
            else
            {
                Console.WriteLine($"Mange tes croutes {Personne1.prenom}!!!!!!!!!");
            }

        }
    }
}
