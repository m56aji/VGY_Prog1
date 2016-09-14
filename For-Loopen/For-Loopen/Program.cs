using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loopen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1, skriver ut talen 0 - 99
            for (int counter = 0; counter < 100; counter++)
                Console.WriteLine(counter);
            Console.WriteLine();

            //Övning 2, skriver ut talen 20 - 0
            for (int counter = 20; counter > 0; counter--)
                Console.WriteLine(counter);
            Console.WriteLine();

            //Övning 3, skriver ut alla jämna tal mellan 0 - 50
            for (int counter = 0; counter <= 50; counter = counter + 2)
                Console.WriteLine(counter);

            ////Övning 4, ber användaren om indata för en for-loop och implementerar indata i utdata
            //Console.WriteLine("For-loopens startvärde");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("For-loopens stopvärde");
            //int stop = int.Parse(Console.ReadLine());

            //Console.WriteLine("For-loopens steg");
            //int steg = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            
            //for (int counter = start; counter < stop; counter  = counter + steg)
            //    Console.WriteLine(counter);
            Console.WriteLine();

            //Forms fråga 1
            for (int i = 0; i < 20; i++)
            {
                if (i == 10)
                    break;

                if (i % 2 == 0)
                    continue;

                Console.Write(i);
            }
            Console.WriteLine();

            //Froms fråga 2
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++) //Nested for loop
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
