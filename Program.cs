using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Brentwood = new City("Brentwood", "Lee Majors", 1897);

            Building ThirtyTwoFiftySeven = new Building("3257 Tenth St")
            {
                Width = 250,
                Depth = 105,
                Stories = 4
            };

            Building NineteenTwentyTwo = new Building("1922 Concord Rd")
            {
                Width = 307,
                Depth = 89,
                Stories = 2
            };

            Building NinetySevenThirtyOne = new Building("9731 Retreat Ln")
            {
                Width = 147,
                Depth = 89,
                Stories = 2
            };

            ThirtyTwoFiftySeven.Design("John Long");
            ThirtyTwoFiftySeven.Purchase("Guy Cherkesky");
            ThirtyTwoFiftySeven.Construct();

            NineteenTwentyTwo.Design("Ryan Bishop");
            NineteenTwentyTwo.Purchase("Joe Shepherd");
            NineteenTwentyTwo.Construct();

            NinetySevenThirtyOne.Design("Random Builder");
            NinetySevenThirtyOne.Purchase("Brenda Long");
            NinetySevenThirtyOne.Construct();

            Brentwood.AddBuilding(ThirtyTwoFiftySeven);
            Brentwood.AddBuilding(NineteenTwentyTwo);
            Brentwood.AddBuilding(NinetySevenThirtyOne);

            foreach (Building building in Brentwood.Buildings)
            {
                building.Print();
            }
        }
    }
}
