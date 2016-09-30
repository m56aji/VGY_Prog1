using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1
            Console.WriteLine("\u0056\xE4\u0157\u006D\u0064\u00f6\xA0\u0047\x79\x6D\x6E\x61\x73\x69\x75\x6D");  //Värmdö Gymnasium

            //Övning2, 3a), 3b), 4
            string hw = "Hello World";
            Console.WriteLine("\"Hello World\"");
            Console.WriteLine(hw.ToUpper());
            Console.WriteLine(hw.ToLower());
            Console.WriteLine(hw.Length);           //Mellanslag är oxå ett tecken

            //Övning5
            Console.Write("Mata in en text: ");
            string inmatat = Console.ReadLine();

            for (int i = inmatat.Length-1; i >= 0; i--)
            {
                Console.Write(inmatat[i]);
            }
            Console.WriteLine();

            //Övnning6
            string textMedParam = "{0} elefant{1} balanserade på en liten liten spindeltråååd.\n"
                                    + "Det tyckte {2} var så intressant,\n"
                                    + "så {2} gick och hämtade en annan elefant.\n";

            string finalText = string.Format(textMedParam, "En", "", "han");
            Console.WriteLine(finalText);

            for (int i = 1; i < 10; i++)
            {
                finalText = string.Format(textMedParam, ++i, "er", "de");
                Console.WriteLine(finalText);
            }

            //Fattas sista versen

            //Övning7
            Console.WriteLine("\nDecimaler:\t3\t2\t1");         //Decimaler: TAB 1 TAB 2 TAB 3

            string format = "\t\t{0:0.000}\t{0:0.00}\t{0:0.0}"; //TAB TAB {0} TAB {0} TAB {0}

            string text = string.Format(format, Math.E);        //.Format(utskrift-sträng, placeholder[0])

            Console.WriteLine(text + "\n");                     //Utskrift

            //Övning8
            Console.WriteLine("Skriv ett ord som programmet ska avgöra om det är ett palidrom eller ej");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    Console.WriteLine("{0} är inte ett palidrom", str);
                    break;
                }
                else
                    Console.WriteLine("{0} är ett palidrom", str);
            }
        }
    }
}
