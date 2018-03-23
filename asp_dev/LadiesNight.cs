using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale;
            Console.WriteLine("Are you male? (y/n)");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                isMale = true;
            }
            else 
            {
                isMale = false;
            }
            if (isMale == true)
            {
                Console.WriteLine("Ladies Night Only");
            }
            else
            {
                int age = 0;
                Console.WriteLine("Please enter your age:");
                age = Convert.ToInt16(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine("Buzz off. Go to a One Direction Concert");
                }
                else
                {
                    if (age > 40)
                    {
                        Console.WriteLine("This is no Cougar Club!!!");
                    }
                    else
                    {
                        Console.WriteLine("Welcome to the Club!!");
                    }
                }
            }
         


            Console.ReadKey();//pause program so user can see result
        }
    }
}
