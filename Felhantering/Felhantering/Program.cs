using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exempel_1 med undantagshantering

            bool oneMoreTime = true;
            int inkomst = 0;
            
            //Loop för att försäkra oss om att ett värde skrivs in
            do
            {
                Console.Write("Ange din inkomst: ");
                try
                {
                    inkomst = int.Parse(Console.ReadLine());
                    oneMoreTime = false;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Ooops" + e);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Ooops" + e);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ooops" + e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ooops" + e);
                }
            } while (oneMoreTime);

            Console.WriteLine();

            //Läser in antal timmar via en do-while-loop
            int timmar = 0;
            oneMoreTime = true;
            do { 
                Console.Write("Ange antal timmar: ");
                try
                {
                    timmar = int.Parse(Console.ReadLine());
                    oneMoreTime = false;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Ooops" + e);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Ooops" + e);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ooops" + e);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ooops" + e);
                }
            } while (oneMoreTime);

            Console.WriteLine();

            //Övning2. Lösning på problemet med division med noll
            if ( timmar == 0)
                Console.WriteLine("Division med noll är inte tillåtet");
            else
                Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h \n");

            //Övning3
            //När vi marekerar WriteLine kommer vi till Metoden WriteLine som har 19 överlagrade metoder
            //Den metod vi vanligtvis använder är WriteLine(String) som har ett undandag: IOException - An I/ O error occurred.


            //Övning4
            //finally blocket tillåter mig att stänga filer eller databasen eller vad det nu var jag höll på med innan try-blocket

            //Övning5 med utskrift av egna felmeddelanden
            Console.Write("Ange din ålder ");
            try
            {
                int age = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Du skrev inte in något värde innan du tryckte på Enter");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Det värde du angav hade ett absolutbelopp som översteg ett int32 tal");
            }
            catch (FormatException)
            {
                Console.WriteLine("Du använde tecken vid inmatningen som inte (alla) kan tolkas som siffror.");
            }
            catch (Exception)
            {
                Console.WriteLine("Programmet kan inte tolka din inmatning som ett tal.");
            }

            Console.WriteLine();

            //Övning6. Vi låter en metod sköta inmatningen, loophanteringen och felhantering
            Console.Write("Ange din inkomst igen: ");
            inkomst = heltalInmatning();

            Console.Write("Ange antal timmar igen: ");
            timmar = heltalInmatning();

            if (timmar == 0)
                Console.WriteLine("Division med noll är inte tillåtet");
            else
                Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h \n");

            //Övning7. Frågar efter startvärde, stegvärde och stopvärde på ett feltolerant sätt.
            //Skriver därefter sekvensen startvärde - n x(startvärde + stegvärde) - stopvärde
            int start, steg, stop;

            heltalInmatning("Ange startvärde: ", out start);
            heltalInmatning("Ange stegvärde: " , out steg);
            heltalInmatning("Ange stoppvärde: ", out stop);

            Console.WriteLine();

            for (int i = start; i < stop; i += steg)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }//Main

        //Metod för att hantera heltalsinmatning och felkontroll
        private static int heltalInmatning()
        {
            int tal = 0;
            bool oneMoreTime = false;

            do {
                oneMoreTime = int.TryParse(Console.ReadLine(), out tal);
                if (!oneMoreTime)
                    Console.WriteLine("mata gärna in ett heltal tack!");
            }
            while (!oneMoreTime);

            return tal;
        }//slut på metoden heltalInmatning

        //Metod som är Överlagrad! Hanterar heltalsinmatning och felkontroll men utan returvärde då metoden har "out" som parametermodiferare
        private static void heltalInmatning(string s, out int tal)
        {
            bool oneMoreTime = false;
            Console.Write(s);
            do {
                oneMoreTime = int.TryParse(Console.ReadLine(), out tal);
                if (!oneMoreTime)
                    Console.WriteLine("mata gärna in ett heltal tack!");
            } while (!oneMoreTime);
        }//slut på metoden
    }
}
