using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("2200 Jefferson");
            Building building2 = new Building("1432 State St");
            Building building3 = new Building("9842 Park Place Blvd");
            // building 1 properties
            building1.Construct();
            building1.Design("John Long");
            building1.Stories = 4;
            building1.Purchase("Jeff Bezos");
            building1.Width = 147;
            building1.Depth = 69;
            building1.Print();

            // building 2 properties
            building2.Construct();
            building2.Design("John Long");
            building2.Stories = 9;
            building2.Purchase("Mark Zuckerberg");
            building2.Width = 245;
            building2.Depth = 104;
            building2.Print();

            // building 3 properties
            building3.Construct();
            building3.Design("John Long");
            building3.Stories = 2;
            building3.Purchase("John Long");
            building3.Width = 49;
            building3.Depth = 26;
            building3.Print();

        }
    }
}
