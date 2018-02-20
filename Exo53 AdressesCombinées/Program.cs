using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo53_AdressesCombinées
{
    class program
    {
        public static string[] AdresseCombines(string Url, string[] ID)
        {
            string[] UrlCombine = new string[ID.Length];
            for (int x = 0; x < ID.Length; ++x)
            {
                UrlCombine[x] = $"{Url}{ID[x]}";
            }
            return UrlCombine;
        }
        static void Main(string[] args)
        {
            string AdresseWeb = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=pubmed&retmode=xml&id=";
            string[] id = new string[] { "29374430", "29374429", "29374424", "29374415", "29374414", "29374413", "29374412", "29374411", "29374410", "29374409", "29374408", "29374407", "29374406", "29374394", "29374392", "29374391", "29374384", "29374370", "29374363", "29374362" };
            string[] mesURL = AdresseCombines(AdresseWeb, id);
            for (int x = 0; x < mesURL.Length; ++x)
            {
                Console.WriteLine(mesURL[x]);
            }
        }
    }
}