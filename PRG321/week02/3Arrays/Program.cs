using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[5];
            int[] values2 = new int[5];
            int[] values3 = new int[5];
            int i;
            int j;

            Console.WriteLine("Please enter 5 different values: ");
            for (i = 0; i < 5; i++)
                values[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 5 more values: ");
            for (j = 0; j < 5; j++)
                values2[j] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(values[i]);
        }

    }
}
