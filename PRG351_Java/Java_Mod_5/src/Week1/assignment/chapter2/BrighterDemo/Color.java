/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week1.assignment.chapter2.BrighterDemo;

/**
 *
 * @author CCSDuser
 */
public class Color 
{
    private int mR, mG, mB;
    
    public int R()
    {
        return mR;
    }
    public int G()
    {
        return mG;
    }
    public int B()
    {
        return mB;
    }
    public Color(int r, int g, int b)
    {
        mR = r;
        mG = g;
        mB = b;
    }
    
    public String ToString()
    {
        String s;
        s = "R = " + mR + " - G = " + mG + " - B = " + mB;
        return s;
    }
    
    public static void UnitTest()
    {
        Color c = new Color(50, 100, 150);
        System.out.println("Color = " + c.ToString());
    }
    
}
