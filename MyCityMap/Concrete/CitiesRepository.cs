using System.Collections.Generic;
using MyCityMap.Models;

namespace MyCityMap.Concrete
{
    public class CitiesRepository
    {
        public IEnumerable<City> Cities = new[]
        {
            new City
            {
                Name ="Minsk",
                Description="Minsk capital of Belarus"
            },
            new City
            {
                Name = "Warsaw",
                Description = "Warsaw is the capital of Poland"
            },
            new City
            {
                Name = "Berlin",
                Description = "Berlin is the capital of Germany"
            },
            new City
            {
                Name = "Amsterdam",
                Description = "Amsterdam is the capital of Netherland"
            },
            new City
            {
                Name = "Oslo",
                Description = "Oslo is the capital of Norway"
            },
            new City
            {
                Name = "Lisbon",
                Description = "Lisbon is the capital of Portugal"
            },
            new City
            {
                Name = "Madrid",
                Description = "Madrid is the capital of Spain"
            },
            new City
            {
                Name = "Moskow",
                Description = "Moskow is the capital of Russia"
            },
            new City
            {
                Name = "Kiev",
                Description = "Kiev is the capital of Ukraine"
            },
            new City
            {
                Name = "Stockholm",
                Description = "Stockholm is the capital of Sweden"
            }
        };
    }
}
