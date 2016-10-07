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
            ////C = Currency (Valuta) enhet
            //decimal decValue = 123.456m;        //suffixet "m" (money?) för att få ett 128 bitars tal
            //Console.WriteLine(decValue);        //123,46 (OBS Avrundning)
            //Console.WriteLine(decValue.ToString("C2")); //123,46 kr (OBS Avrundning)
            //Console.WriteLine("{0:C1}", decValue);      //123,5 kr (OBS Avrundning)
            //Console.WriteLine();

            //Console.WriteLine(decValue.ToString("E"));  //1,234560E+002 (Grundpotensform)
            //Console.WriteLine();

            ////D = minimum antal siffror i det Decimala (basen 10) talet
            //int iValue = 123456;
            //Console.WriteLine(iValue.ToString("D3"));   //123456
            //Console.WriteLine(iValue.ToString("D8"));   //00123456
            //Console.WriteLine();

            ////E = exponent i basen 10
            //Console.WriteLine(iValue.ToString("E5"));   //1,23456E005
            //Console.WriteLine();

            ////F = Fixed number of decimals
            //Console.WriteLine(iValue.ToString("F"));    //123456,00
            //Console.WriteLine(iValue.ToString("F0"));   //123456
            //Console.WriteLine(iValue.ToString("F3"));   //123456,000
            //Console.WriteLine();

            ////G = General number format
            //double piNumber = Math.PI;
            //Console.WriteLine(piNumber.ToString("F"));    //3,14
            //Console.WriteLine(piNumber.ToString("F0"));   //3
            //Console.WriteLine(piNumber.ToString("F8"));   //3,14159265
            //Console.WriteLine();

            ////P = Percentage
            //double dblNumber = .123456;
            //Console.WriteLine(dblNumber.ToString("P"));      //12,35 %
            //Console.WriteLine(dblNumber.ToString("P0"));     //12 %
            //Console.WriteLine(dblNumber.ToString("P8"));     //12,34560000 %
            //Console.WriteLine();

            ////X = Hexadecimal
            //int xNumber = 123456789;
            //Console.WriteLine(xNumber.ToString("X"));     //75BCD15
            //Console.WriteLine(xNumber.ToString("X0"));    //75BCD15
            //Console.WriteLine(xNumber.ToString("X12"));   //0000075BCD15
            //Console.WriteLine();

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
            int value = 123;
            Console.WriteLine(value.ToString("\\#\\#\\# ##0 kronor och \\0\\0 öre \\#\\#\\#"));
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
