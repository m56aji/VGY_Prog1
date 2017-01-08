using System;

namespace Metoder
{
    class Program
    {
        #region Metoder
        static double CelsiusTillFarenheit(double celsius)
        {
            return (celsius / 5.0) * 9 + 32;
        }

        static double Area(double radie)
        {
            return Math.Round(Math.PI*radie*radie, 2);
        }

        static double Omkr(double radie)
        {
            return Math.Round(Math.PI * 2 * radie, 2);
        }

        static int KastaTärning(int nbrKast)
        {
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < nbrKast; i++)
            {
                sum += rnd.Next(6) + 1;
            }
            return sum;
        }

        static int KastaTärning(int nbrKast, int nbrSidor)
        {
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < nbrKast; i++)
            {
                sum += rnd.Next(nbrSidor) + 1;
            }
            return sum;
        }

        static int KastaTärning(string tKastStr)
        {
            string[] delar = tKastStr.Split('T');

            int nbrKast = int.Parse(delar[0]);
            int nbrSidor = int.Parse(delar[1]);

            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < nbrKast; i++)
            {
                sum += rnd.Next(nbrSidor) + 1;
            }
            return sum;
        }
        #endregion

        static void Main(string[] args)
        {
            //Övning1
            Console.WriteLine("Ange ett antal grader Celcius så räknar programmet ut grader Farenheit");
            double farenh = double.Parse(Console.ReadLine());
            Console.WriteLine("Antal grader Farenheit " + CelsiusTillFarenheit(farenh) +"\n");

            //Övning2
            Console.WriteLine("Ange en cirkels radie så räknar programmet ut omkrets och area");
            double radie = double.Parse(Console.ReadLine());
            Console.WriteLine("Area " + Area(radie) + "\nOmkrets " + Omkr(radie) + "\n");

            //Övning3
            Console.WriteLine("Antal tärningskast");
            int kast = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultat " + KastaTärning(kast) + "\n");

            //Övning4
            Console.WriteLine("Antal tärningskast");
            int kast2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Antal sidor på tärningen");
            int sidor = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultat " + KastaTärning(kast2, sidor) + "\n");

            //Övning5
            Console.WriteLine("Ange antal kast och antal sidor. Ex: 5T6 står för 5 kast med en 6-sidig tärningr");
            string tSlag = Console.ReadLine();

            Console.WriteLine("Resultat " + KastaTärning(tSlag) + "\n");

            Console.ReadKey();
        }
    }
}
