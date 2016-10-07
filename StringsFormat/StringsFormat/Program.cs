using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1 Skriver ut dagens datum
            DateTime dt = DateTime.Today;
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine();

            //Övning2 Skriver ut cirkelns area
            double areaCirk = Math.PI * 4 * 4;   //pi*r*r
            Console.WriteLine(areaCirk.ToString("F4"));
            Console.WriteLine();

            //Övning3 Skriver ut tal med tusentals-separator
            int tal = 1000000000;
            string sTal = tal.ToString("#,##0");
            Console.WriteLine(sTal);
            Console.WriteLine();
            
            //Övning4 Skriver ut 123 kr med formatering
            double value = 123.00;
            //Console.WriteLine(value.ToString("\\#\\#\\# ##0 kronor och \\0\\0 öre \\#\\#\\#"));
            Console.WriteLine(value.ToString("\\#\\#\\# ##0 kronor och 00 öre \\#\\#\\#"));
            Console.WriteLine();
            
            //Övning5 Skriver ut personnumret formaterad
            Console.WriteLine("Mata in ditt personnummer utan mellanslag eller bindestreck");
            string pnumText = Console.ReadLine();
            decimal pnumTal = decimal.Parse(pnumText);            //Int64 pnumTal = Int64.Parse(pnumText);
            Console.WriteLine("{0:#### ## ##-####}", pnumTal);
            Console.WriteLine();

            //Övning6 Skriver ut veckochemat
            const string format = "{0,-10} | {1,-10} | {2,-10} | {3, -10} | {4, -10}";
            Console.WriteLine("--------------------------Veckoschema-------------------------------");
            Console.WriteLine(String.Format(format, "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag"));
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine(String.Format(format, "Matematik", "Engelska", "Teknik", "Idrott", "Programmering"));
            Console.WriteLine(String.Format(format, "Svenska", "Historia", "Matematik", "Matematik", "Webbprogrammering"));
            Console.ReadLine();
        }
    }
}
