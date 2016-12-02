﻿//Lösningar till uppgifter till momentet Samlingsklasser
//André Jaoui den 27/11 2016

using System;
using System.Collections.Generic;
using System.Diagnostics;                                      //Behövs för Stopwatch
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser2
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();            // Skapar ett tidtagarur(?)
            stopwatch.Start();

            //Skapa en dictionary med int som nyckel och int som värde
            Dictionary<int, int> dict = new Dictionary<int, int>();

            //skapa ett Random objekt för att slumpa
            Random random = new Random();
            int key;

            //Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                //Slumpa tal mellan 1 och 6
                key = random.Next(1, 7);

                //Lägg nyckel om denna inte redan finns
                if (!dict.ContainsKey(key))
                    dict.Add(key, 0);

                //Öka förekomsten av tal
                dict[key]++;
            }

            //Visa resultatet
            foreach (KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

            stopwatch.Stop();           // Stoppar tidtagaruret
            Console.WriteLine("Time elapsed (ms): {0}", stopwatch.Elapsed.TotalMilliseconds);

            Console.WriteLine("\n\n");

            /*-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-* *-*/

            //Övning 1
            stopwatch.Reset();         //Nollar tidtagarutet
            stopwatch.Start();

            //Skapa en dictionary med int som nyckel och int som värde
            SortedList<int, int> sList = new SortedList<int, int>();

            //skapa ett Random objekt för att slumpa
            Random rnd = new Random();

            //Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                //Slumpa tal mellan 1 och 6
                key = rnd.Next(1, 7);

                //Lägg nyckel om denna inte redan finns
                if (!sList.ContainsKey(key))
                    sList.Add(key, 0);

                //Öka förekomsten av tal
                sList[key]++;
            }

            //Visa resultatet
            foreach (KeyValuePair<int, int> kvp in sList)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

            stopwatch.Stop();
            Console.WriteLine("Time elapsed (ms): {0}", stopwatch.Elapsed.TotalMilliseconds);


            //Övning2
            List<double> talList = new List<double>();
            double dTal;

            Console.WriteLine("\n\nProgrammet läser in ett valfritt antal decimal/heltal följt av Enter. Medelvärdet skrivs ut löpande. Avsluta med 0");
            do
            {
                Console.WriteLine("Mata in ett nytt värde");
                dTal = double.Parse(Console.ReadLine());
                talList.Add(dTal);
                Console.WriteLine("Medelvärdet på inmatade tal är: " + talList.Average());
            } while (dTal != 0);

            Console.WriteLine();

            //Övning3
            //Skriv sedan ett program som slumpvis drar kort från korleken tills dess att alla 52 kort är dragna. Skriv ut varje kort du "drar".
            List<string> kortNamnList = new List<string>();

            kortNamnList.Add("kE");
            for (int i = 2; i < 11; i++)
                kortNamnList.Add("k" + i.ToString());
            kortNamnList.Add("kKn");
            kortNamnList.Add("kD");
            kortNamnList.Add("kK");

            kortNamnList.Add("hE");
            for (int i = 2; i < 11; i++)
                kortNamnList.Add("h" + i.ToString());
            kortNamnList.Add("hKn");
            kortNamnList.Add("hD");
            kortNamnList.Add("hK");

            kortNamnList.Add("rE");
            for (int i = 2; i < 11; i++)
                kortNamnList.Add("r" + i.ToString());
            kortNamnList.Add("rKn");
            kortNamnList.Add("rD");
            kortNamnList.Add("rK");

            kortNamnList.Add("sE");
            for (int i = 2; i < 11; i++)
                kortNamnList.Add("s" + i.ToString());
            kortNamnList.Add("sKn");
            kortNamnList.Add("sD");
            kortNamnList.Add("sK");


            //Att använda i övning 4
            string[] kortNamnArray = new string[kortNamnList.Count];
            kortNamnList.CopyTo(kortNamnArray);

            int kortNr, drag = 1;

            do
            {
                kortNr = rnd.Next(0, kortNamnList.Count - 1);
                Console.WriteLine(drag++ + " Draget kort: " + kortNamnList[kortNr]);
                kortNamnList.RemoveAt(kortNr);
            } while (kortNamnList.Count > 0);

            Console.WriteLine();


            //Övning4
            Dictionary<string, int> kortlekDic = new Dictionary<string, int>();
            int parNbr = 0;

            //Adderar kortens namn samt ett värde mellan 1 och 13 som motsvarar kortets spelvärde
            for (int i = 0; i < kortNamnArray.Length; i++)
            {
                kortlekDic.Add(kortNamnArray[i], i % 13 + 1);
            }

            List<string> keyList = new List<string>(kortlekDic.Keys);       //Skapar en lista av nycklar/keys
            string kort1, kort2;

            //Drar två kort ur leken/Dictionary/kortlekDic slumpmässigt 1000 ggr
            for (int i = 0; i < 1000; i++)
            {
                kort1 = keyList[rnd.Next(0, 52)];
                kort2 = keyList[rnd.Next(0, 52)];

                //Har jag fått ett par med samma värde slumpmässigt och det inte är samma kort 2 ggr 
                if (kortlekDic[kort1] == kortlekDic[kort2] && !kort1.Equals(kort2))
                {
                    Console.Write(kort1 + "\toch\t" + kort2 + "\tvar ett par");
                    Console.WriteLine("\tPar nummer {0} ", ++parNbr);
                }
            }

            Console.WriteLine("Det blev " + parNbr / 10 + "% av dragen som gav par. Teoretiskt ska det bli 5,9%");
        }
    }
}

