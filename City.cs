using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }

        public string Mayor { get; set; }

        public int dateEstablished { get; set; }

        public List<Building> Buildings = new List<Building>();

        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }

        public City(string name, string mayor, int year)
        {
            Name = name;
            Mayor = mayor;
            dateEstablished = year;
        }
    }
}