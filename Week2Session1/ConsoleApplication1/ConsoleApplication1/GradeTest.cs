using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7GradeList
{
    public class GradeTest
    {
        static int numberGradesEntered = 0;
        public static void ShowAverageHighestLowest(double averageGrade, int[] dataArray)
        {
            int lowest = FindSmallestGrade(dataArray);
            Console.WriteLine("Your lowest grade was: " + lowest);
            int highest = FindLargestGrade(dataArray);
            Console.WriteLine("Your highest grade was: " + highest);
        }
        public static double CalculateScoreAverage(int[] dataArray)
        {
            double result = 0;
            for (int i = 0; i < numberGradesEntered; i++)
            {
                Console.WriteLine("Adding " + dataArray[i] + " to result");
                result += dataArray[i];
            }
            int maxGrade = FindLargestGrade(dataArray);
            result -= maxGrade;
            int minGrade = FindSmallestGrade(dataArray);

            result -= minGrade;
            Console.WriteLine("Running result = " + result);
            return result / ( numberGradesEntered - 2 );
        }

        public static int FindLargestGrade(int[] dataArray)
        {
            int maxValue = dataArray[0];
            for (int i = 0; i < numberGradesEntered; i++)
            {
                if (dataArray[i] > maxValue)
                {
                    maxValue = dataArray[i];
                }
            }
            return maxValue;
        }//Find Largest Grade

        public static int FindSmallestGrade(int[] dataArray)
        {
            int minValue = dataArray[0];
            for (int i = 0; i < numberGradesEntered; i++)
            {
                if (dataArray[i] < minValue)
                {
                    minValue = dataArray[i];
                }
            }
            return minValue;
        }//Find Smallest Grade
        public static int[] GetData()
        {
            int[] dataArray = new int[100];
            int n = 0;
            int intValue = 0;
            while (true)
            {
                Console.WriteLine("Enter a Score 0-10 [Q to end]");
                string lineValue = Console.ReadLine();
                if (lineValue.ToLower().Trim().Equals("q"))
                {
                    break;
                }
                if (!int.TryParse(lineValue, out intValue))
                {
                    Console.WriteLine("INVALID SCORE - try again");
                    continue;
                }
                if (intValue < 0 || intValue > 10)
                {
                    Console.WriteLine("NUMERIC DATA OUT OF RANGE - try again");
                    continue;
                }
                dataArray[n] = intValue;
                n++;
                numberGradesEntered++;
                //dataArray[0] = n;
            }
            Console.WriteLine("you've entered " + numberGradesEntered + " scores");
            for (int i = 0; i < numberGradesEntered; i++) Console.WriteLine(dataArray[i]);
            return dataArray;
        }
    }
}
