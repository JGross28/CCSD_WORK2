using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            Person p = new Person("Jordan", 29, true);
            people.Add(p);
            p = new Person("Tony", 31, true);
            people.Add(p);
            p = new Person("Brendon", 28, true);
            people.Add(p);
            p = new Person("Jennica", 23, false);
            people.Add(p);

            Console.ReadKey(); //pauses program
        }
    }
}
