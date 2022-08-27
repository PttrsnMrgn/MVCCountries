using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class CountryController
    {
        public List<Country> countryDb { get; set; } = new List<Country>()
            {
                 new Country(
                        "United States of America",
                        "North America",
                        new List<string>(){"Red", "White" , "Blue"},
                        new List<ConsoleColor>(){ ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue },
                        new List<ConsoleColor>(){ ConsoleColor.White, ConsoleColor.Black, ConsoleColor.White }
                        ),
                 new Country(
                        "Brazil",
                        "South America",
                        new List<string>(){"Green", "Yellow" , "Blue"},
                        new List<ConsoleColor>(){ ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Blue },
                        new List<ConsoleColor>(){ ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White }
                        ),
                 new Country(
                        "Chad",
                        "Africa",
                        new List<string>(){"Blue", "Yellow" , "Red"},
                        new List<ConsoleColor>(){ ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Red },
                        new List<ConsoleColor>(){ ConsoleColor.White, ConsoleColor.Black, ConsoleColor.White }
                        )
            };
        public void CountryAction(Country country)
        {
            var view = new CountryView(country);
            view.Display();
        }
        public Country GetSelection()
        {
            Waypoint:
            Console.WriteLine($"\nWhich country would you like to view? Enter Selection (0 - {countryDb.Count})");
            try
            {
                int selection = int.Parse(Console.ReadLine());

                if(selection == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                var view = countryDb[selection -1];
                return view;
            }
            catch
            {
                Console.WriteLine("Please enter a valid selection!");
                goto Waypoint;
            }
        }
        public bool Restart()
        {
            bool restart;
            Waypoint1:
            Console.WriteLine("\nWould you like to learn about another country? (Y/N):");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                restart = true;
            }
            else if (input == "n")
            {
                restart = false;
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Please enter valid input.");
                goto Waypoint1;
            }
            return restart;
        }
        public void WelcomeAction()
        {
            do
            {
                Console.Clear();
                var view = new CountryListView(countryDb);
                Console.WriteLine("Hello, welcome to the country app.\nPlease select a country from the following list:\n");
                view.Display();
                var country = GetSelection();
                CountryAction(country);
            } while (Restart());
        }


    }
}
