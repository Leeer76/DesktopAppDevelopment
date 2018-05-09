
package com.lee.erik.gridbaglayout_example;

import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class GridbagLayout_example {

    public static void main(String[] args) {
        // TODO code application logic here
        JFrame frame = new JFrame("Gridbaglayout Example");
        frame.setSize(600, 400);
        frame.setLocationByPlatform(true);
       
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
                
        JPanel panel = new JPanel();
        
        frame.add(panel);
        panel.setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();
        
        c.gridx = 0; c.gridy = 0; c.anchor = GridBagConstraints.LINE_END;
        panel.add(new JLabel("Number 1: "), c);
       
        c.gridx = 1; c.gridy = 0; c.anchor = GridBagConstraints.LINE_START;
        JTextField numOne = new JTextField(20);
        panel.add(numOne, c);
        
        c.gridx = 0; c.gridy = 1; c.anchor = GridBagConstraints.LINE_END;
        panel.add(new JLabel("Number 2: "), c);
       
        c.gridx = 1; c.gridy = 1; c.anchor = GridBagConstraints.LINE_START;
        JTextField numTwo = new JTextField(20);
        panel.add(numTwo, c);
        
        c.gridx = 1; c.gridy = 3; c.anchor = GridBagConstraints.LINE_END;
        JButton button1 = new JButton("Calculate Sume");
        panel.add(button1,c);
        
        frame.setVisible(true);
        
        button1.addActionListener((ActionEvent e) ->{
        double numberOne = Double.parseDouble(numOne.getText());
        double numberTwo = Double.parseDouble(numTwo.getText());
        double sum = numberOne + numberTwo;
        JOptionPane.showMessageDialog(frame,"The sum of your two numbers is " + sum, "Sum", JOptionPane.INFORMATION_MESSAGE);
        });
    }
    
}
