using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRegistration
{
    public class Student
    {
        public string Name;
        public int Age;

        public void Talk()
        {
            Console.WriteLine("My name is " + Name + ",and my age is " + Age);
        }
    }
}
