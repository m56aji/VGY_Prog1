using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1 standardlösning med nästlad for-loop och if-else sats
            char sign;
            for (int y = 0; y < 10; y++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0)
                        sign = 'o';
                    else
                        sign = '#';
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning1 alternativ lösning med nästlad for-loop och förkortad if-else sats
            //Läs om förkortad if-sats på https://msdn.microsoft.com/en-us/library/ty67wk28.aspx
            char tecken;
            for (int y = 0; y < 10; y++)
            {
                for (int i = 0; i < 10; i++)
                {
                    tecken = (i % 2 == 0) ? 'o' : '#';          //villkor ? sant : falskt
                    Console.Write(tecken);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning1 ytterliggare alternativ lösning. Den mest kompakta koden
            for (int y = 0; y < 10; y++)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write((i % 2 == 0) ? 'o' : '#');
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning2, den nästlade startvärde beror på var den yttre (y) har för värde
            char sign2;
            for (int y = 0; y < 10; y++) 
            {
                for (int i = y; i <= 10+y; i++) //startvärde är varannan gång jämt varannan gång udda eftersom den tar startvärdet från ytterloopen
                {
                    if (i % 2 == 0)
                        sign2 = 'o';
                    else
                        sign2 = '#';
                    Console.Write(sign2);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning3. I denna lösning har den nästlade loopen ingen blockparantes för att det bara är en sats som ska exekveras i den
            for (int y = 0; y < 10; y++)
            {
                for (int i = y; i < 10; i++) //startvärde från ytterloopen vilket gör att det blir färre innerloopar för varje rad
                    Console.Write('#');
                Console.WriteLine();
            }
            Console.WriteLine();
            
            //Övning4, Triangel
            for (int i = 0; i < 7; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    if (k - i < 0)
                        Console.Write(".");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning5, Kryss
            for (int i = 0; i < 7; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    if (k - i == 0 || k + i == 6)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning6, Fjäril
            for (int i = 0; i < 7; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    if (k - i > 0 && k + i < 6 || k - i < 0 && k + i > 6)
                        Console.Write(".");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Övning7, Diamant
            double d;
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    d = Math.Sqrt(i * k);
                    if (i - k < 5 && i + k > 3 && k - i < 5 && d <= 6)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();

                
            }
        }
    }
}
