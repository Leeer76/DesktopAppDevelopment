
package com.lee.erik.swing_example;

import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;

public class Swing_example {

    public static void main(String[] args) {
        // TODO code application logic here
        JFrame frame = new JFrame("Product Manager");
        frame.setSize(600, 400);
        frame.setLocationByPlatform(true);
        
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                
        frame.setVisible(true);
        
        JPanel panel = new JPanel();
        frame.add(panel);
        
        JButton button1 = new JButton("Add Product");
        JButton button2 = new JButton("Remove Product");
        panel.add(button1);
        panel.add(button2);
        
        
        button1.addActionListener((ActionEvent e)->{
            JOptionPane.showMessageDialog(frame, "You added a product!", "Add",INFORMATION_MESSAGE);
        });
        button2.addActionListener((ActionEvent e)->{
            JOptionPane.showMessageDialog(frame, "You removed a product!", "Remove",INFORMATION_MESSAGE);
        });
    }
    
}
