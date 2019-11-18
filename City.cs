using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string cityName { get; set; }
        public string Mayor { get; set; }
        public int YearEstablished { get; set; }
        public List<Building> Buildings { get; set; }

        public List<Building> GetBuildings()
        {
            return this.Buildings;
        }

        public void AddBuilding(Building newBuilding)
        {
            this.Buildings.Add(newBuilding);
        }
    }

}

// Practice: Urban Planner II
// Now you need to create a type to represent your city. Here are the requirements for the class. You determine if/when to use fields, properties, a constructor, and methods.

// Name of the city.
// The mayor of the city.
// Year the city was established.
// A collection of all of the buildings in the city.
// A method to add a building to the city.
// Remember, each class should be in its own file. Create a City.cs file and define the City class in there. Make sure it's in the same namespace as your other classes.

// Once the class is defined to your liking, refactor your code in Main() to create a new city instance and add your buildings to it. Once all buildings are in the city, refactor your code that outputs the building info to the console to be inside a foreach loop that iterate the city's building collection.

// Example
// City megalopolis = new City();

// ...

// foreach (Building building in megalopolis.Buildings) {
//     Console.WriteLine(...);
// }