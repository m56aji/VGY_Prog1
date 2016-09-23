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
            /*
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

            //Övning 4, ber användaren om indata för en for-loop och implementerar indata i utdata
            Console.WriteLine("For-loopens startvärde");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("For-loopens stopvärde");
            int stop = int.Parse(Console.ReadLine());

            Console.WriteLine("For-loopens steg");
            int steg = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int counter = start; counter < stop; counter = counter + steg)
                Console.WriteLine(counter);
            Console.WriteLine();

            //Övning 5
            Console.WriteLine("Ange startvärdet för n!");
            int startvalue = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startvalue; i > 0; i--)
                sum += i;

            Console.WriteLine(sum);
            Console.WriteLine();
            

            //Övning6
            Console.WriteLine("Ange ett heltal. Undersöker om 3 och 7 är delare");
            int value = int.Parse(Console.ReadLine());
            bool delare = false;

            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i + "Har har delarna både 3 och 7");
                    delare = true;
                }
            }
            if(!delare)
                Console.WriteLine("Hittade inga tal....");

            Console.ReadKey();
            
            //Övning7 beräknar finonaccital
            Console.WriteLine("Ange ett heltal så skrivs fibonacci-serien ut t.o.m ditt angivna tal");
            int fib = int.Parse(Console.ReadLine());
            int fib_0 = 0;
            int fib_1 = 1;
            int fib_n;

            if (fib == 0)
                Console.WriteLine("Fibonaccitalen blir: 0");
            else {
                Console.Write("Fibonaccitalen blir: 1  ");
                for (int i = 1; i < fib; i++)
                {
                    fib_n = fib_0 + fib_1;
                    fib_0 = fib_1;
                    fib_1 = fib_n;
                    Console.Write(fib_n + "  ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();

            //Övning8 Beräknar kubikroten genom mha en for-loop
            Console.WriteLine("Ange ett heltal så beräknar datorn kubikroten ur talet");
            int kub = int.Parse(Console.ReadLine());

            for (double i = 0; i < kub; i += 0.1) {
                if ((kub - i * i * i) < 0.1) {
                    Console.WriteLine("kubikroten är: " + i );
                    break;
                }
            }

            Console.ReadKey();
            
            //Övning9 Kontrollerar om ett givet tal är ett primtal
            Console.WriteLine("Ange ett heltal så avgör programmet om det är ett primtal");
            int prim = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int i = 3; i < prim; i++)
            {
                if(prim%i == 0)     //Om resten vid heltalsdivison blir noll är det inte ett primtal
                {
                    Console.WriteLine(prim + " är INTE ett primtal");
                    flag = true;
                    break;
                }
            }

            if(!flag)
                Console.WriteLine(prim + " är ett primtal");

            Console.ReadKey();
            */

            //Övning9 Kontrollerar om ett givet tal är ett primtal och primtalsfaktoriserar det i så fall
            //Buggar == Inte klart == !Klart
            Console.WriteLine("Ange ett heltal så avgör programmet om det är ett primtal och i så fall primtalsfaktoriserar det");
            int prim = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int i = 2; i <= prim; i++)
            {
                if (prim % i == 0)     //Om resten vid heltalsdivison blir noll är det inte ett primtal
                {
                    Console.WriteLine(i + " är en primtalsfaktor");
                    flag = true;
                    prim = prim/i;
                    i = 2;
                }
            }

            if (!flag)
                Console.WriteLine(prim + " är ett primtal");

            Console.ReadKey();
            
        }
    }
}
