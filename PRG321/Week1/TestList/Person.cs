using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestList
{
    public class Person
    {
        protected int age; //protects itself from other object interacting with it
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 35)
                { //only allow if proposed value is 35 or less
                    age = value;
                }
            }
        }
        public string Name;
        public bool IsMale;
        // Constructer. Builds one copy of this person as an object in RAM
        public Person(string name, int age, bool male)
        {
            Name = name;
            Age = age;
            IsMale = male;
        }

        public void Talk(string msg)
        {
            Console.WriteLine("Hello, my name is " 
                + Name + ", and I'm " + Age + " years old." + msg);
        }
    }
}
