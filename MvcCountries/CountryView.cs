using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class CountryView
    {
        public CountryView(Country country)
        {
               DisplayCountry = country;
        }
        public Country DisplayCountry { get; set; }

        public void Display()
        {
            Console.Clear();
            string colors = "";
            DisplayCountry.Colors.ForEach(x => colors += x + " ");

            Console.BackgroundColor = DisplayCountry.FlagBackground[0];
            Console.ForegroundColor = DisplayCountry.FlagForeground[0];
            Console.WriteLine("Name: " + DisplayCountry.Name);

            Console.BackgroundColor = DisplayCountry.FlagBackground[1];
            Console.ForegroundColor = DisplayCountry.FlagForeground[1];
            Console.WriteLine("Continent: " + DisplayCountry.Continent);

            Console.BackgroundColor = DisplayCountry.FlagBackground[2];
            Console.ForegroundColor = DisplayCountry.FlagForeground[2];
            Console.WriteLine("Flag Colors: " + colors);

            Console.ResetColor();
        }
    }
}
