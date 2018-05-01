using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    public partial class Student
    {
        public int ID
        {
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    student_id = value;
                }
            }
            get
            {
                return student_id;
            }
        }
    }
}