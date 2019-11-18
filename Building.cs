using System;

namespace Planner
{
    public class Building
    {
        // private properties
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // public properties
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

        // constructor 
        public Building(string address)
        {
            _address = address;
        }

        // Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
        public void Construct(string designer)
        {
            _designer = designer;
            _dateConstructed = DateTime.Now;
        }
        // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void PrintDetails()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(_address);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine();
        }
    }

}