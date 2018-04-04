using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            int peak;
            int i, j, c, d;
            Console.WriteLine("Enter Peak:");
            peak = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Character:");
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
