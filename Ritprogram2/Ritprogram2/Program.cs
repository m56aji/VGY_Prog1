//Programmet öppnar nya fönster som numreras
//Numreringen stämmer inte om man stänger ett fönster
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritprogram2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Ritprogram2());

            //Får alla fönster som skapas i applikationen att behandlas lika
            //Annars avslutas programmet när det första fönstret stängs inte
            //när det sista fönstret stängs.
            new Ritprogram2();
            Application.Run();
        }
    }
}
