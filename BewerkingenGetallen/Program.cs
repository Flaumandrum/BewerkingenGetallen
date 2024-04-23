using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BewerkingenGetallen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startmenu());
        }

        // Velden

        // functies

        /// <summary>
        /// Functie om 2 getallen op te tellen 
        /// </summary>
        /// <param name="getal1"></param>
        /// <param name="getal2"></param>
        /// <returns>returns de oplossing in tekstvorm </returns>
        static public String Optellen(int getal1, int getal2)
        {
            return Convert.ToString(getal1 + getal2);
        }

        /// <summary>
        /// Functie om 2 getallen te verminderen
        /// </summary>
        /// <param name="getal1"></param>
        /// <param name="getal2"></param>
        /// <returns>returns de oplossing in tekstvorm </returns>
        static public String Verminderen(int getal1, int getal2)
        {
            return Convert.ToString(getal1 - getal2);
        }

        /// <summary>
        /// Functie om 2 getallen te vermenigvuldigen
        /// </summary>
        /// <param name="getal1"></param>
        /// <param name="getal2"></param>
        /// <returns>returns de oplossing in tekstvorm </returns>
        static public String Vermenigvuldigen(int getal1, int getal2)
        {
            return Convert.ToString(getal1 * getal2);
        }


    }
}
