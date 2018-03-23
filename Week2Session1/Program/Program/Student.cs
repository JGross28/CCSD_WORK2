using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public partial class Student
    {
        private int student_id;
        private int age;
        private string NameF;
        private string NameL;

        public Student()
        {
            student_id = 100;
            age = 18;
            NameF = "Robert";
            NameL = "Paulson";
        }

        void SetID(int id)
        {
            if (id < 0)
            {
                Console.WriteLine("RTFM");
                return;
            }
            student_id = id;
        }

    }
    public class Vehicle
    {
        private int m_numberWheels;
        private string m_engineType;

        public Vehicle()
        {
            m_numberWheels = 4;
            m_engineType = "V6";
        }

        void SetWheels(int Wheels)
        {
            if (Wheels < 4)
            {
                Console.WriteLine("You are a badass and own a bike!!");
            }
        }
        void SetEngine(string engine)
        {
            if (engine != "V6")
            {
                Console.WriteLine("Thats a lot of power you have there!");
            }
        }
    }
}
