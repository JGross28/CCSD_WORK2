using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magazine
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            DateTime birth;
            int month;
            int zipCode;
            Console.WriteLine("Please enter your First Name");
            fName = Convert.ToString(Console.Read());
            Console.WriteLine("Please enter your Last Name");
            lName = Convert.ToString(Console.Read());
            Console.WriteLine("Please enter your birth date:");
            birth = Convert.ToDateTime(Console.Read());
            Console.ReadKey();
    
        }
    }
}
