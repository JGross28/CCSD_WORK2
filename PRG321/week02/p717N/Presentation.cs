using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p717N10
{
    class Presentation
    {
        static void Main(string[] args)
        {
            Housing house = new Housing();
            MultiUnit multi_room = new MultiUnit();
            SingleFamily houseFamily = new SingleFamily();
            houseFamily.SquareFootage = 2500;
            houseFamily.GarageAvailable = true;

            Console.WriteLine("Printing \"Housing house\" = " + house);
            Console.WriteLine("Printing \"MultiUnit House\" = " + multi_room);
            Console.WriteLine("Printing \"SingleFamily houseFamily\" = " + houseFamily);
            Console.ReadLine();
        }
    }
}
