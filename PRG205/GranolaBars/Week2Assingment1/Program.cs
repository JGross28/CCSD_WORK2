using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GranolaBars
{
    class Program
    {
        static void Main(string[] args)
        {
            int casesSold;
            double pricePerBar;
            double profit;
            double proceeds;
            double finalOutcome;

            casesSold = GetCasesSold();
            pricePerBar = GetPricePerCase();
            profit = GetProfit(casesSold, pricePerBar);
            proceeds = GetProceeds(profit);
            finalOutcome = FinalOutcome(proceeds, profit);

            Console.WriteLine("The amount of cases sold were: " + casesSold);
            Console.WriteLine("The price per bar was: {0:C}", pricePerBar);
            Console.WriteLine("The gross income was: {0:C}",profit);
            Console.WriteLine("The student government fees were: {0:C}",  proceeds);
            Console.WriteLine("Income minus government fees were: {0:C}",  finalOutcome);
            Console.ReadLine();
        }

        public static int GetCasesSold()
        {
            int cSold;
            Console.WriteLine("Enter cases sold: ");
            cSold = Convert.ToInt32(Console.ReadLine());
            return cSold;
        }

        public static double GetPricePerCase()
        {
            double perBar;
            Console.WriteLine("Enter the price per bar: ");
            perBar = double.Parse(Console.ReadLine());
            return perBar;
        }
 
        public static double GetProfit(int casesSold, double pricePerBar)
        {
            const double CASE_PRICE = 5.00;
            double profit;
            profit = ((pricePerBar * 12 - CASE_PRICE) * cSold);
            return profit;
        }

        public static double GetProceeds(double profit)
        {
            const double STU_GOV_FEES = .10;
            return (profit * STU_GOV_FEES);
        }

        public static double FinalOutcome(double proceeds, double profit)
        {
            return (profit - proceeds);
        }

        public static double cSold { get; set; }

    }
}


