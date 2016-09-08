/* Skapad av André den 29 aug 2016
 * Koden är ett lösningsförslag på uppgifterna 1-5 (+ en extra övning) i 
 * CSharpskolans Variabler-övningar
 */

using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1
            Console.WriteLine("Mata in tal 1:");
            string in1 = Console.ReadLine();
            int tal1 = int.Parse(in1);

            Console.WriteLine("Mata in tal 2:");
            string in2 = Console.ReadLine();
            int tal2 = int.Parse(in2);

            Console.WriteLine("Summan: " + (tal1 + tal2));
            Console.WriteLine("Produkten: " + tal1 * tal2);
            Console.WriteLine("Kvoten: " + tal1 / tal2);

            //Övning2
            Console.WriteLine("Mata in ditt förnamn:");
            string fNam = Console.ReadLine();

            Console.WriteLine("Mata in ditt efternamn:");
            string eNam = Console.ReadLine();

            Console.WriteLine("Hej " + fNam + " " + eNam);

            //Övning3
            Console.WriteLine("Mata in grader Celcius:");
            string textDegree = Console.ReadLine();
            double degree = double.Parse(textDegree);
            Console.WriteLine("Det blir " + (1.8 * degree + 32) + " grader Farenheit.");


            //Övning4
            Console.Write("Mata in grader Celcius: ");
            string textGrader = Console.ReadLine();
            double grader = double.Parse(textGrader);
            Console.Write("Det blir " + (1.8 * grader + 32) + " grader Farenheit.\n");


            //Övning5
            Console.Write("Cirkelns radie: ");
            string inRadie = Console.ReadLine();
            double radie = double.Parse(inRadie);
            double pi = Math.PI;
            Console.WriteLine("Area: " + (Math.Round(pi * radie * radie, 2)));
            Console.WriteLine("Omkrets: " + Math.Round(2 * pi * radie, 2));

            Console.ReadKey();


            //Extra Övning6
            Console.Write("Ange ett tresiffrigt tal som jag ska beräkna siffersumman av: ");
            string textTal = Console.ReadLine();
            int tal = int.Parse(textTal);

            int siff1 = tal / 100;
            int siff2 = tal / 10 - siff1 * 10;
            int siff3 = tal - siff1 * 100 - siff2 * 10;
            int sum = siff1 + siff2 + siff3;

            Console.Write("Siffersumman blir " + sum);
            Console.ReadKey();
        }
    }
}
