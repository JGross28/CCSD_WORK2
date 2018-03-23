using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Week2Assignment1;
namespace Week2Assignment2
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Please enter the professor ID: ");
            int professor_id = Convert.ToInt32(Console.ReadLine());

            ProfessorRating PR = new ProfessorRating(professor_id );

            // successfully disabled the default constructor by making it private
            //ProfessorRating PR2 = new ProfessorRating();


            // we first capture user inputs regarding the different ratings and store
            // those into local variables
            Console.Write("Enter helpfullness rating: ");
            double helpfullness = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter easiness rating: ");
            double easiness = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Course Material rating: ");
            double courseMaterial = Convert.ToInt32(Console.ReadLine());

            PR.EasiNess = easiness;
            PR.HelpFullness = helpfullness;
            PR.CourseMaterial = courseMaterial;
            double avg = PR.OverallRating();
            Console.WriteLine("You overall rating for professor " + professor_id + " " + "is: " + avg);
            Console.ReadKey();
        }
    }
}
