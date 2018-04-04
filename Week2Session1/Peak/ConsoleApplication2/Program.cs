using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int peak;
            int i, j, c, d;
            char character;
            Console.WriteLine("Enter peak:");
            peak = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter character:");
            character = char.Parse(Console.ReadLine());
            for (i = 1; i <= peak; ++i)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(character);
                Console.Write("\n");
            }


            for (d = peak - 1; d >= 1; d--)
            {
                for (c = 1; c <= d; c++)
                    Console.Write(character);
                Console.Write("\n");

            }
            Console.Read();

        }
    }
}
