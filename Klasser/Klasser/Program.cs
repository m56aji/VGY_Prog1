using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1, med felhantering eftersom vi lärde oss det förra lektionen....
            Bil car = new Bil();

            bool inBool = false;
            int year, doors;

            //Console.Write("Ange Bilmodell (Nissan/Volvo/Toyota/etc): ");
            //car.Model = Console.ReadLine();

            //Console.Write("Ange Bilens registreingsnummer (123abc): ");
            //car.RegNbr = Console.ReadLine();

            //Console.Write("Ange Bilens färg ");
            //car.Color = Console.ReadLine();

            //do
            //{
            //    Console.Write("Vilken årsmodell har bilen: ");
            //    inBool = int.TryParse(Console.ReadLine(), out year);
            //    car.Year = year;
            //} while (!inBool);


            //do
            //{
            //    Console.Write("Hur många dörrar har bilen?: ");
            //    inBool = int.TryParse(Console.ReadLine(), out doors);
            //    car.NbrDoors = doors;
            //} while (!inBool);

            //Console.Write("Du har köpt en {0} {1} av årsmodell {2} med reg nr {3} som har {4} dörrar", car.Color, car.Model, car.Year, car.RegNbr, car.NbrDoors);

            //Console.ReadKey();

            //Övning2. Returnerar skillnaden i antal bokstäver mellan efternamn och förnamn.
            Namn name = new Namn();
            Console.Write("Ange ditt efternamn: ");
            name.Enamn = Console.ReadLine();

            Console.Write("Ange ditt förnamn: ");
            name.Fnam = Console.ReadLine();

            if (name.Calc > 0)
                Console.WriteLine("{0} har fler bokstäver än {1}", name.Enamn, name.Fnam);
            else if (name.Calc < 0)
                Console.WriteLine("{0} har färre bokstäver än {1}", name.Enamn, name.Fnam);
            else
                Console.WriteLine("{0} har lika många bokstäver som {1}", name.Enamn, name.Fnam);

            //Övning3
            if (name.Birthdate)
                Console.WriteLine("Du är du myndig");
            else
                Console.WriteLine("Du är omyndig");
            Console.ReadKey();

            //Övning4. Frågar efter vikt och längd för att räkna ut BMI
            int vikt, langd;

            do
            {
                Console.Write("Ange din vikt i kg ");
                inBool = int.TryParse(Console.ReadLine(), out vikt);
                name.Veight = vikt;
            } while (!inBool);

            do
            {
                Console.Write("Ange din längd i cm ");
                inBool = int.TryParse(Console.ReadLine(), out langd);
                name.Length = langd;
            } while (!inBool);

            Console.WriteLine("Ditt BMI är: " + name.Bmi);
        }
    }
}
