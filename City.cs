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