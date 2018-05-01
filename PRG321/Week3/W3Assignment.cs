using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    public class W3Assignment
    {
        
        public static int minVal(int[] input)
        {
            int min = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= min)
                {
                    min = input[i];
                }
            }
            return min;
        }
        public static int maxVal(int[] input)
        {
            int max = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= max)
                {
                    max = input[i];
                }
            }
            return max;
        }
            public static List<int> RunAssignments()
            {
                StreamReader inputFile = new StreamReader("numbers.txt");
                String content = "";
                List<int> values = new List<int>();
                while (content != null)
                {
                    content = inputFile.ReadLine();
                    if (content == null)
                    {
                        inputFile.Close();
                        break;
                    }
                    try
                    {
                        int temp = Convert.ToInt32(content);
                        values.Add(temp);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error converting to a number from file. Reason = " + e.Message);
                        break;//break here gets out of while loop
                        //no reason to continue if there is an error
                    }
                }

                inputFile.Close();
                Console.WriteLine("The array contains " + values.Count + " elements");

                foreach (var number in values)
                {
                    Console.WriteLine("The current value is = " + number);
                }
                return values;
            }
        }
    }