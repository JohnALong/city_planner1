using System;

namespace Planner
{
    public class Building
    {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // constructor for building - when created forces an address to be added
        public Building(string address)
        {
            _address = address;
        }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            // hidden method set by other code
            _owner = name;
        }
        public void Design(string designer)
        {
            _designer = designer;
        }
        public void Print()
        {
            Console.WriteLine(this._address);
            Console.WriteLine($"-------------");
            Console.WriteLine($"Designed by {this._designer}");
            Console.WriteLine($"Built on {this._dateConstructed}");
            Console.WriteLine($"Owned by {this._owner}");
            Console.WriteLine($"{this.Volume} cubic meters of space");
            Console.WriteLine("");
        }
    }
}