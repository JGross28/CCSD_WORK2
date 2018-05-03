/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Week1.assignment.chapter2.BrighterDemo;

import javax.swing.JFrame;

/**
 *
 * @author CCSDuser
 */
public class DarkerDemo 
{
        public static void UnitTest()
    {
        Color c = new Color(50, 100, 150);
        //JFRAME is like a message box
        //Frame creation
        JFrame f = new JFrame();
        //resize the frame
        f.setSize(400, 400);
        java.awt.Color c2 = java.awt.Color.RED;
        java.awt.Color c3 = c2.darker();
        //set color of jframe with our own color type
        //new java.awt.Color(c.R(), c.G(), c.B())
        f.getContentPane().setBackground(c3);
        f.show();
    }
}
