using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public partial class Student
    {
        public int GetID()
        {
            return student_id;
        }
        public static void UnitTest()
        {
            Student s = new Student();
            s.SetId(666);
            int id = s.GetID();
            id = s.ID;
            Console.WriteLine("Our student ID = " + id);
            Console.Read();
        }
    }
}