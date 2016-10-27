using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en randomerare som jag kan slumpa tal med
            Random randomerare = new Random();

            int rnd, sum = 0;

            //Övning 1. Slumpar fram ett tal mellan 1 och 20 och beräknar medelvärdet
            Console.WriteLine("Programmet slumpar fram 10 tal mellan 1-20 och beräknar medelvärdet");
            for (int i = 0; i < 9; i++)
            {
                rnd = randomerare.Next(20) + 1;
                Console.Write(rnd + " ");
                sum += rnd;
            }
            Console.Write("Medelvärdet blev " + sum / 10);

            Console.WriteLine("\n");

            //Övning 2.Slumpar ett tal mellan 15 och 31 och räknar ut medianen
            Console.WriteLine("Programmet slumpar fram 20 tal mellan 15-30 och beräknar medianvärdet");
            Console.WriteLine("På platsen där medianvärdet beräknas visas ett stolptecken |");
            int[] randArr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                randArr[i] = randomerare.Next(15, 31);
            }

            Console.WriteLine();
            Array.Sort(randArr);

            for (int i = 0; i < 20; i++)
            {
                Console.Write(randArr[i]);
                Console.Write((i == 9) ? " | " : " ");
            }

            Console.Write("Medianen är " + (randArr[9] + randArr[10]) / 2.0);

            Console.WriteLine("\n");

            //Övning 3. 
            Console.WriteLine("Du ska gissa ett tal som slumpas fram mellan 0 och 100.");
            int guess = -1;
            int slumptal = randomerare.Next(101);

            while (guess != slumptal)
            {
                Console.WriteLine("Vilket är ditt tal?");
                guess = int.Parse(Console.ReadLine());

                if (guess < slumptal)
                    Console.WriteLine("För lågt gissa igen");
                if (guess > slumptal)
                    Console.WriteLine("För högt gissa igen");

            }

            Console.WriteLine("Rätt gissat");
            Console.WriteLine();
        }
    }
}
