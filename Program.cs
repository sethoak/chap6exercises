using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Gotham = new City();
            // Create several buildings in the Main() method of Program.cs.
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building BatmanBuilding = new Building("123 Downtown Avenue");
            Building CatwomanBuilding = new Building("999 Matriarchy Drive");
            Building CarnegieHall = new Building("Practice Practice Practice");
            Building GooGooHaim = new Building("1000 Big Museum Blvd");
            Building NashvilleSoftWareSchool = new Building("??? Good HVAC Street");
            // Give each building a width, height, and number of stories.
            FiveOneTwoEigth.Width = 100;
            FiveOneTwoEigth.Stories = 10;
            FiveOneTwoEigth.Depth = 75;

            BatmanBuilding.Width = 345;
            BatmanBuilding.Stories = 94;
            BatmanBuilding.Depth = 234;

            CatwomanBuilding.Width = 123;
            CatwomanBuilding.Stories = 87;
            CatwomanBuilding.Depth = 400;

            CarnegieHall.Width = 6329;
            CarnegieHall.Stories = 40;
            CarnegieHall.Depth = 25;

            GooGooHaim.Width = 126;
            GooGooHaim.Stories = 60;
            GooGooHaim.Depth = 12;

            NashvilleSoftWareSchool.Width = 30;
            NashvilleSoftWareSchool.Stories = 23;
            NashvilleSoftWareSchool.Depth = 100;
            // Construct each building.
            FiveOneTwoEigth.Construct("Frank LLoyd Wright");
            BatmanBuilding.Construct("Alfred");
            CatwomanBuilding.Construct("Michele Pfeifer");
            NashvilleSoftWareSchool.Construct("John Wark");
            CarnegieHall.Construct("Some Nerd");
            GooGooHaim.Construct("Frank Garhehehe");
            // Have business people in your city purchase each of your buildings.
            FiveOneTwoEigth.Purchase("Blimp");
            BatmanBuilding.Purchase("Brample");
            CatwomanBuilding.Purchase("Repples");
            NashvilleSoftWareSchool.Purchase("Chip");
            CarnegieHall.Purchase("Flap");
            GooGooHaim.Purchase("John");
            // After all of the buildings have been purchased, display the following information to the console for each building.
            List<Building> buildings = new List<Building>()
            {
                FiveOneTwoEigth,
                BatmanBuilding,
                CatwomanBuilding,
                NashvilleSoftWareSchool,
                CarnegieHall,
                GooGooHaim
            };

            Gotham.Buildings = buildings;

            foreach (Building building in buildings)
            {
                building.PrintDetails();
            }

            Building HouseHome = new Building("4001 Anderson Rd");
            Gotham.AddBuilding(HouseHome);

            foreach (Building building in buildings)
            {
                building.PrintDetails();
            }

        }
    }
}