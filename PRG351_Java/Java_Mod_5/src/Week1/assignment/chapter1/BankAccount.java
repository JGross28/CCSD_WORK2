
package Week1.assignment.chapter1;

/**
 *
 * @author CCSDuser
 */
public class BankAccount 
{
    double balance;
    double iRate;
    
    public BankAccount(double bal, double rate)
    {
        balance = bal;
        iRate = rate;
    }
    
    public String ToString()
    {
        String s = "Balance = " + balance + " - interest rate = " + iRate;
        return s;
    }
    
    public double ComputeBalanceAfter(int numYears)
    {
        double amount = balance;
        for(int i = 0; i < numYears; i++)
        {
            amount = amount * (1.0 + iRate);
        }
        return amount;
    }
    
    public double ComputeBalanceAfter2(int numYears)
    {
        double amount = balance;
        return amount * Math.pow((1 + iRate), numYears);
    }
    
    public static void UnitTest()
    {
        BankAccount ba = new BankAccount( 1000, 0.05 );
        System.out.println( ba.ToString());
        double finalBalance = ba.ComputeBalanceAfter(3);
        System.out.println("Balance after 3 years = " + finalBalance);
    }
}
