using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSatser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1, skriver ut siffran som sträng om det är mindre än 5
            Console.WriteLine("Ange ett heltal så skriver programmet ut talet som en sträng");
            string str = Console.ReadLine();
            int i = int.Parse(str);

            switch (i)
            {
                case 1:   Console.WriteLine("Ett\n");                   break;
                case 2:   Console.WriteLine("Två\n");                   break;
                case 3:   Console.WriteLine("Tre\n");                   break;
                case 4:   Console.WriteLine("Fyra\n");                  break;
                default:  Console.WriteLine("Ogiltigt alternativ\n");   break;
            }

            //Övning 2, skriver ut inmatad bokstav som ett väderstreck på engelska
            Console.WriteLine("Ange ett väderstreck, N (North), S (South), E, W");
            string str1 = Console.ReadLine();
            char c = char.Parse(str1);

            switch (c)
            {
                case 'n':
                case 'N': Console.WriteLine("You travel North\n");    break;
                case 's':
                case 'S': Console.WriteLine("You travel South\n");    break;
                case 'e':
                case 'E': Console.WriteLine("You travel East\n");     break;
                case 'w':
                case 'W': Console.WriteLine("You travel West\n");     break;
                default:  Console.WriteLine("I don´t understand\n");  break;
            }

            //Övning3, tar emot två tal och avgör vilken operator som ska användas för beräkningen
            Console.WriteLine("Ange vilken operator du vill använda för en beräkning av två heltal");
            string strOp = Console.ReadLine();
            char op = char.Parse(strOp);

            Console.WriteLine("Ange det första heltalet");
            string tal1 = Console.ReadLine();
            int i1 = int.Parse(tal1);

            Console.WriteLine("Ange det andra heltalet");
            string tal2 = Console.ReadLine();
            int i2 = int.Parse(tal2);

            switch (op)
            {
                case '+': Console.WriteLine("Summan: " + (i1 + i2));     break;
                case '-': Console.WriteLine("Differensen: {0}", i1-i2);  break;
                case '*': Console.WriteLine("Produkten: {0}", i1*i2);    break;
                case '/': Console.WriteLine("Kvoten: {0}", i1/(i2*1.0)); break;
                default: Console.WriteLine("I can´t calculate");         break;
            }
        }
    }
}
