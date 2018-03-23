using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Student s = new Student();
                Console.Write("Enter your name: ");
                s.Name = Console.ReadLine();
                Console.Write("Enter your age: ");
                s.Age = Convert.ToInt16(Console.ReadLine());
                s.Talk();

                Console.ReadKey();
            }
        }
    }
}
