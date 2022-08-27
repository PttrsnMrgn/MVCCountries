using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public List<Country> Countries { get; set; }

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine(String.Format("{0,-30} {1, -10}", $"{i+1}. {Countries[i].Name}", $"List Index {i}"));
            }
            Console.WriteLine("\n0. To Exit");
        }
    }
}
