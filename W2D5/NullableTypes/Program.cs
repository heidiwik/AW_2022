using System;
using System.Collections.Generic;
using System.Linq;

namespace NullableTypes
{
    class NullableTypes
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>()
            {
                new City("Kuopio", 20),
                new City("Toijala", 22),
                new City("Utsjoki", 13),
                new City("Kemi", null),
                new City("Kerava", 32),
                new City("Lappeenranta", 12)
            };


            Console.WriteLine("Give a first letter of the city: ");
            string firstLetter = Console.ReadLine();

            var foundCities = cities.Where(n => n.Name.StartsWith(firstLetter.ToUpper()));

            foreach (var city in foundCities)
            {
                if (city.Weather == null)
                {
                    continue;
                }
                Console.Write(city.Name + " lämpötila on tänään " + city.Weather + "C. ");
                Console.WriteLine("Fahrenheit: " + city.GetFahrenheit(city.Weather));
            }


            City newCity = null;

            try
            {
                Console.WriteLine(newCity.Weather);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: city not found");
            }




        }
    }



    public class City
    {
        public string Name;
        public int? Weather;

        public City(string name, int? weather)
        {
            this.Weather = weather;
            this.Name = name;
        }

        public double? GetFahrenheit(int? celcius)
        {
            return celcius * 1.8;
        }
    }

}
