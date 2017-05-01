using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testproj
{
    class Program
    {
        static int temperatur = 3;
        int? i = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in grader Celcius:");
            string värme = Console.ReadLine();
            return (String.IsNullOrEmpty(s)) ? "is null or empty" : String.Format("(\"{0}\") is not null or empty", s);
            double kyla = double.Parse(värme);
            Console.WriteLine("Det blir " + (kyla - 273.15) + " grader i Kelvin.");

            double[] celsi = new double[temperatur];
            double[] kelvi = new double[temperatur];
            double totalcelsi = 0;
            double totalK = totalcelsi - 273.15;
            for (int i = 0; i < kelvi.Length; i++)
            {
                totalK = totalK + kelvi[i];

            }
            for (int i = 0; i < celsi.Length; i++)
            {
                Console.WriteLine("Mata in grader i Celsius");
                string grader = Console.ReadLine();
            }
            double medelkelvi = totalK / temperatur;
            Console.WriteLine("Medeltemperaturen för Kelvin under programmerings festivalen 2016 blev:" + medelkelvi);
            Console.WriteLine(" ");
            //-91,05 Kelvin --> Celsius
            double ktoc = -91.05 + 273.15;
            Console.WriteLine("-91.05 Kelvin är i celsius: " + ktoc);
        }
    }
}
