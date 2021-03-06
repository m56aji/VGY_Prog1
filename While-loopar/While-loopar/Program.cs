﻿//While-loopar är lösta uppgifter från Csharpskolan.se
//av André Jaoui den 25/9 2016
//Det är fritt att använda sig av lösningarna som inspiration men inte som kopieringsunderlag

using System;

namespace While_loopar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning1
            int nbr = 1;
            while (nbr <= 100)
            {
                Console.WriteLine(nbr);
                nbr++;
            }

            //Övning2
            int count = 0;
            string losen = string.Empty;

            while (losen != "password")
            {
                Console.WriteLine("Mata in korrekt lösenord för att fortsätta");
                losen = Console.ReadLine();
                count++;
            }

            Console.WriteLine("Rätt lösenord, det var ditt: " + count + "(e) försök");

            //Övning2.1. Programmet ska konvertera en for-loop till whileloop 
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();

            //Öving2.2 konverterar en for- till while-loop
            int j = 10;
            while (j >= 1)
            {
                Console.WriteLine(j);
                j--;
            }

            //Övning 2.3 Skapar en oändlig while-loop
            //while (true)
            //{
            //    Console.WriteLine("Tryck CTRL+C för att bryta");
            //}

            //Övning 2.4 Gissa mitt tal-övning
            Random rnd = new Random();
            int tal = rnd.Next(100);
            int guess = -1;
            int nbr = 0;

            Console.WriteLine("Gissa på ett tal mellan 0-100");

            while (guess != tal)
            {
                guess = int.Parse(Console.ReadLine());
                nbr++;
                if (guess < tal)
                    Console.WriteLine("Du gissade på ett för lågt tal, gissa igen");
                else if (guess > tal)
                    Console.WriteLine("Du gissade på ett för högt tal, gissa igen");
                else
                    Console.WriteLine("Du gissade rätt, dvs: " + tal + " på " + nbr + " försök");
            }

            //Övning 2.5 Skriver ut fibonacciserien t.o.m 10^6
            int fib_0 = 0;
            int fib_1 = 1;
            int fib_n = 1;

            while (fib_n < 1E6)
            {
                Console.Write(fib_n + "  ");
                fib_n = fib_0 + fib_1;
                fib_0 = fib_1;
                fib_1 = fib_n;
            }
            Console.WriteLine();
            Console.ReadKey();


            //Övning 2.6 Frågar efter saldo, ränta och slutmål samt beräknar tiden för att nå målet
            Console.WriteLine("Hur mycket pengar har du på ditt konto?");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Vilken ränta får du i %?");
            int ranta = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur mycket pengar har du som mål att få på kontot?");
            int slutSaldo = int.Parse(Console.ReadLine());

            int year = 0;

            while (saldo < slutSaldo)
            {
                saldo = saldo * (1 + ranta / 100.0);
                year++;
            }
            Console.WriteLine("Det tog dig " + year + "år att nå saldot " + saldo);
            Console.ReadKey();


            //Övning 2.7 Skriver ut alla skottår från i år till och med år 2050
            int thisYear = DateTime.Now.Year;
            while (thisYear++ < 2050)
            {
                if (DateTime.IsLeapYear(thisYear))
                    Console.WriteLine(thisYear + " är ett skottår");
            }


            //Övning 2.8 Skriver ut alla måndagar från 1 jan i år. 
            //Använder inte TimeSpan då det går lika bra med .AddDays(days) som .AddDays(TimeSpan)
            //Uppgiften är krävande då vi inte bekantat oss med "Objekt" begreppet ännu.
            //Finns snyggare(?) lösningar än den här. 
            int days = 0;                                               //Antal dagar som ska adderas till 1 jan 2016
            int thisYear = DateTime.Now.Year;                           //Ger aktuellt år
            DateTime startOfThisYear = new DateTime(thisYear, 1, 1);  //(År, månad, dag) == 2016, 01, 01

            //Testutskrifter för att avgöra vilket format som lämpar sig i while-iterationen
            Console.WriteLine(DateTime.Now.DayOfYear);                                      //269
            Console.WriteLine(startOfThisYear.AddDays(2).DayOfYear);                        //3            
            Console.WriteLine(startOfThisYear.AddDays(2).ToShortDateString());              //2016-01-03. Datum i kort format (utan tim:min:sek)
            Console.WriteLine(startOfThisYear.AddDays(2).DayOfWeek.ToString());             //Sunday


            while (startOfThisYear.AddDays(days++).DayOfYear < DateTime.Now.DayOfYear)      //Adderat datum < dagens datum
            {
                if (startOfThisYear.AddDays(days).DayOfWeek.ToString().Equals("Monday"))    //Adderat datum som text == Måndag
                    Console.WriteLine(startOfThisYear.AddDays(days).ToShortDateString() + " är en måndag");
            }

        }
    }
}
