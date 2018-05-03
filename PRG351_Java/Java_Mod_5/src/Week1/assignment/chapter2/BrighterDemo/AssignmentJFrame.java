package Week1.assignment.chapter2.BrighterDemo;

import javax.swing.JFrame;

/**
 *
 * @author CCSDuser
 */
public class AssignmentJFrame 
{
    public static void UnitTest()
    {
        Color c = new Color(50, 100, 150);
        //JFRAME is like a message box
        //Frame creation
        JFrame f = new JFrame();
        //resize the frame
        f.setSize(400, 400);
        java.awt.Color c2 = new java.awt.Color(50, 100, 150);
        java.awt.Color c3 = c2.brighter();
        int r = c3.getRed();
        int g = c3.getGreen();
        int b = c3.getBlue();
        String s;
        s = "R = " + r + " - G = " + g + " - B = " + b;
        System.out.println(s);
        //set color of jframe with our own color type
        //new java.awt.Color(c.R(), c.G(), c.B())
        f.getContentPane().setBackground(c3);
        f.show();
    }
}
