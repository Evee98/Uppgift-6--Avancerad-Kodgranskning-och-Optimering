namespace Uppgift_6__Avancerad_Kodgranskning_och_Optimering
{
    using System;
    using System.Collections.Generic;

    namespace NameSorter
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> names = new List<string> { "Anna", "John", "Alice", "Bob", "Charlie" }; 

                Console.WriteLine("Original list:");
                foreach (var name in names) // Går att ta bort denna loopen och skapa en funktion istället som vi kan kalla på.
                {
                    Console.WriteLine(name);
                }

                names.Sort(); // Sort the names alphabetically
                Console.WriteLine("\nSorted list:");
                foreach (var name in names) // Går att ta bort denna loopen och skapa en funktion istället som vi kan kalla på.
                {
                    Console.WriteLine(name);
                }

                // Programmet kontrollerar inte om användaren skriver in ogiltiga värden eller om inmatningen är tom. Går att lägga in felhantering här för förbättrad användarinmatning.
                Console.WriteLine("\nEnter name to search:");
                string searchName = Console.ReadLine(); 
                if (names.Contains(searchName))
                {
                    Console.WriteLine($"{searchName} is in the list.");
                }
                else
                {
                    Console.WriteLine($"{searchName} is not in the list.");
                }

                Console.ReadKey();
            }
        }
    }
    
}
