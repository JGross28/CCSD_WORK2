using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class ShapeTest
    {
        public static void Main(string[] args)
        {
            Shape[] array_of_shapes = new Shape[3];
            array_of_shapes[0] = new Circle(4, 6, 2.0);
            array_of_shapes[1] = new Rectangle(14, 25);
            array_of_shapes[2] = new Cylinder(16, 22);

            Console.WriteLine("For what shape you want to calculate the Area:\n0. Circle\n1. Rectangle\n2. Cylinder");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            if (choice == 0)
            {
                Console.Write("Enter a radius: ");
                int rad = Convert.ToInt16(Console.ReadLine());
                array_of_shapes[choice] = new Circle(0, 0, rad);
            }
            else if (choice == 1)
            {
            }
            else if (choice == 2)
            {
            }
            //for (int i = 0; i < array_of_shapes.Length; i++)
            //{
                Console.WriteLine(" The shape you chose " + choice + " is a " + array_of_shapes[choice].Name + " with volume = "
                 + array_of_shapes[choice].Volume + " and area " + array_of_shapes[choice].Area);
            //}
            Console.Read();
        }
    }
}
