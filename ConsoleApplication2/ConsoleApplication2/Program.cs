using System;

namespace ConsoleApplication2
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            // ... Returnerar index för det första funna udda elementet
            int oddIndex = elements.FindIndex(x => x % 2 != 0); //returnerar true om x är udda
            Console.WriteLine(oddIndex);                        //Utskrift: 2
        }
    }

}
