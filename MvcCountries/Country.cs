using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class Country
    {
        //constructor
        public Country(string name, string continent, List<string> colors, List<ConsoleColor> flagBackground, List<ConsoleColor> flagForeground)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
            FlagBackground = flagBackground;
            FlagForeground = flagForeground;
        }

        //properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }
        public List<ConsoleColor> FlagBackground { get; set; }
        public List<ConsoleColor> FlagForeground { get; set; }


    }
}
