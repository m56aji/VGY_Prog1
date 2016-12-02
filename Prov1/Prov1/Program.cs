//Prov1 källkod som facit
//den 19 nov 2016. André Jaoui
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Uppgift1 innehåller 6 fel.
            //Console.Write("Gissa ett tal: ");
            //string inmatat = Console.ReadLine()

            //int tal = int.Parse(inmatat);

            //if (tal = 42)
            //{
            //    Console.WriteLine(Grattis du matade in det hemliga talet!");

            //}
            //else if (Tal < 42)
            //{
            //    Console.Writeline("För lågt tal!");
            //}
            //else
            //{
            //    Console.WriteLine("För högt");
            //}

            //Uppgift 2.    C: Korrekt form och antal *-tecken (21 st). E: Korrekt form men fel antal *-tecken
            for (int i = 0; i < 7; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    if (k - i > 0)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* Uppgift3
             * Ett argument är ett värde som skickas med vid anrop av en metod som matchar metodens parameter.
             * En parameter är en metods krav på att få värden av bestämd typ vid anropet. 
             * 
             * Deklaration innebär att bestämma en variabel en typ. Tex int i;
             * Initiering innebär att tilldela en variable ett startvärde. Tex int i = 4;
             * Tilldelning är att ge en variabel ett värde ovasett om det är initieraat eller ej. Tex i = 25;
             */

            //Uppgift 4 ger utskriften "false"
            int vikt = 0;
            int length = 0;
            int viktsum = 0;
            int lengthsum = 0;
            int[] viktLengthArray = new int[10];

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine("Ange din vikt i kg");
                vikt = int.Parse(Console.ReadLine());
                viktLengthArray[i] = vikt;
                viktsum += vikt;
                            
                Console.WriteLine("Ange din längd i cm");
                length = int.Parse(Console.ReadLine());
                viktLengthArray[i + 1] = length;
                lengthsum += length;
            }

            Console.WriteLine("Viktsum: {0}, Längd: {1}", viktsum, lengthsum);
            Console.WriteLine("Medellvikt: {0}, medellängd: {1}", viktsum/5, lengthsum/5);

            
            //Uppgift 5 inhämtar information för att beräkna en persons BMI
            double lengthD = viktLengthArray[1]/100.0;

            double bmi = viktLengthArray[0] / lengthD / lengthD;
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("Ditt BMI är {0} och klassas som {1}\n\n", bmi, BmiKlass(bmi));

            //Uppgift 6. Ger dubbla utskrifter för vissa summor
            int[] intArray = { 3, -6, 1, -2, -1, -3, 2, 5 };
            Array.Sort(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    for (int k = 0; k < intArray.Length; k++)
                    {
                        if ((intArray[i] == intArray[j] + intArray[k]) && (j != k))
                            Console.WriteLine(intArray[i] + " = " + intArray[j] + " + " + intArray[k] + "\tijk: " + i + "  " + j + " " + k);
                    }
                }
            }
        }

        //Returnerar viktklass utifrån mottaget BMI-värde
        static string BmiKlass(double bmi)
        {
            if (bmi < 18.5)
                return "Undervikt";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normalvikt";
            else if (bmi >= 25 && bmi < 30)
                return "Övervikt";
            else if (bmi >= 30 && bmi < 35)
                return "Fetma grad 1";
            else if (bmi >= 35 && bmi < 40)
                return "Fetma grad 2";
            else return "Fetma grad 1";
        }
    }
}
