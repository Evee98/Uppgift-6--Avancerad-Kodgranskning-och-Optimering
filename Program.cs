using System;
using System.Collections.Generic;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialiserar en lista med namn
            List<string> names = new List<string> { "Anna", "John", "Alice", "Bob", "Charlie" };

            // Skriver ut den ursprungliga listan av namn
            Console.WriteLine("Original list:");
            PrintList(names); // Kallar på metoden för att skriva ut listan

            // Sorterar listan alfabetiskt
            names.Sort(); // Använder den inbyggda Sort-metoden för att sortera i stigande ordning (alfabetiskt)
            Console.WriteLine("\nSorted list:"); // Meddelande för att indikera att listan nu är sorterad
            PrintList(names); // Kallar på metoden för att skriva ut den sorterade listan

            // Tar emot användarinmatning för att söka efter ett namn i listan
            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine(); // Läser in användarens input

            // Kontrollerar om användaren har lämnat in ett tomt värde eller enbart mellanslag
            if (string.IsNullOrWhiteSpace(searchName))
            {
                Console.WriteLine("Error: No input provided."); // Felmeddelande om ingen giltig inmatning ges
            }
            // Kontrollerar om det angivna namnet finns i listan
            else if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list."); // Skriver ut meddelande om namnet finns i listan
            }
            // Om namnet inte finns i listan
            else
            {
                Console.WriteLine($"{searchName} is not in the list."); // Skriver ut meddelande om namnet inte finns
            }

            // Väntar på att användaren trycker på en tangent innan programmet avslutas
            Console.ReadKey();
        }

        // Metod för att skriva ut alla namn i listan
        static void PrintList(List<string> list)
        {
            // Går igenom varje namn i listan och skriver ut det
            foreach (var name in list)
            {
                Console.WriteLine(name); // Skriver ut varje namn på en egen rad
            }
        }
    }
}

