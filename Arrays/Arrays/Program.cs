using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1. Ber användaren mata in 10 namn som därefter skrivs ut
            string[] strArray = new string[10];
            Console.WriteLine("Hej, vill du vara vänlig och mata in 10 namn med Enter efter varje namn");

            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            //Övning2. Ber användaren mata in 10 tal som därefter skrivs ut
            int[] intArray = new int[10];
            Console.WriteLine("Hej, vill du vara vänlig och mata in 10 tal med Enter efter varje tal");

            for (int i = 0; i < 10; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            //Övning3. En osorterad array med heltal sorteras och skrivs ut
            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            int tempInt;

            for (int i = 0; i < numbArray.Length; i++)
            {
                for (int j = i; j < numbArray.Length; j++)
                {
                    if (numbArray[j] < numbArray[i])
                    {
                        tempInt = numbArray[i];
                        numbArray[i] = numbArray[j];
                        numbArray[j] = tempInt;
                    }
                }
            }

            for (int i = 0; i < numbArray.Length; i++)
            {
                Console.WriteLine(numbArray[i]);
            }

            //Övning4. En osorterad array med frukter sorteras och skrivs ut
            string[] names = new string[] { "Citron", "Apple", "Cocos", "Banan", "Andre", "Dadel", "Aprikos" };
            string temp;

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i; j < names.Length; j++)
                {
                    if (names[j].CompareTo(names[i]) < 0)
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Övning5. En osorterad array med frukter sorteras i fallande ordning och skrivs ut mha en foreach-loop
            string[] names2 = new string[] { "Citron", "Apple", "Cocos", "Banan", "Andre", "Dadel", "Aprikos" };
            string tempName;

            for (int i = 0; i < names2.Length; i++)
            {
                for (int j = i; j < names2.Length; j++)
                {
                    if (names2[j].CompareTo(names2[i]) > 0)
                    {
                        tempName = names2[i];
                        names2[i] = names2[j];
                        names2[j] = tempName;
                    }
                }
            }

            foreach (string str in names2)
            {
                Console.WriteLine(str);
            }

        }
    }
}
