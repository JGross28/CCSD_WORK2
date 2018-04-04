using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week4arrays_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];//declare an array
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = 10 * i;//set values for each index
                Console.WriteLine("The value at location " + i + " is " + myArray[i]);
            }

            //first create an array to save all elements of the original array
            int[] temp = new int [ myArray.Length ];
            for (int i = 0; i < myArray.Length; i++)
            {
                //Saving all elements from myArray to temp array
                temp[i] = myArray[i];
            }

            //We now reallocate our original array
            myArray = new int[100];
            for (int i = 0; i < temp[i]; i++)
            {
                myArray[i] = temp[i];
            }
            try //this can be used as a sort of debugging tool without actually using a debugger.
            {
                int value = myArray[10];
                Console.WriteLine("Access to 10th index now possible.");
            }
            catch(Exception ex)//This will catch the error in runtime with out the need to debug
                //If the code gets to the catch block, that means an error has occured. 
            {
                Console.WriteLine("Error while accessing array element - Reason: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
