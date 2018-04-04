using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter7GradeList
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeTest JG = new GradeTest();
            int[] dataArray = GradeTest.GetData();
            int pos = GradeTest.FindLargestGrade(dataArray);
            int pos2 = GradeTest.FindSmallestGrade(dataArray);
            //calculate average grade
            double averageGrade = GradeTest.CalculateScoreAverage(dataArray);
            Console.WriteLine("Your average grade is " + averageGrade);
            GradeTest.ShowAverageHighestLowest(averageGrade, dataArray);
            Console.Read();
        }
    }
}
