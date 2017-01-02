using System;

namespace Klasser
{
    class Namn
    {
        public string Fnam { get; set; }
        public string Enamn { get; set; }

        //Något skall beräknas, så varför inte längden på namnet...(?)
        public int Calc {
            get {
                return Enamn.Length - Fnam.Length;
            }
        }

        //Enligt uppgiften ska metoden returnera en bool och hantera DateTime-Objekt...
        //set-propertien behövs inte då vi inte är intresserad av att ta emot ett bool-värde
        public bool Birthdate
        {
            get {
                bool inBool;
                int year, month, day;
                do
                {
                    Console.Write("Vilket år är du född (ÅÅÅÅ) ");
                    inBool = int.TryParse(Console.ReadLine(), out year);
                } while (!inBool);

                do
                {
                    Console.Write("Vilken månad är du född (MM) ");
                    inBool = int.TryParse(Console.ReadLine(), out month);
                } while (!inBool);

                do
                {
                    Console.Write("Vilken dag är du född (DD) ");
                    inBool = int.TryParse(Console.ReadLine(), out day);
                } while (!inBool);

                DateTime bday = new DateTime(year, month, day);     //DateTime-konstruktorn kräver minst tre argument
                DateTime now = DateTime.Now;                        //Skapar ett DateTimeObjekt med dagens datum

                //Styr formatet på DateTimeObjektet till fyrsiffrigt årtal, tvåsiffig månad, tvåsiffrig dag
                //vilket genererar ett 4+2+2= 8 siffrigt tal. Division med 10^4 ger mig ett 4-siffrigt tal.  
                int age = (int.Parse(now.ToString("yyyyMMdd")) - int.Parse(bday.ToString("yyyyMMdd"))) /10000;

                return (age >= 18);     //true om age är större än eller lika med 18, dvs myndig.
            }
        }
        
        //Övning4
        public int Length { get; set; }
        public int Veight { get; set; }
        public int Bmi {
            get { 
                return (Veight / (Length * Length / 100 / 100));
            }
        }
    }//class
}//namespace
