
package com.lee.erik.gridbaglayout_assignment;

import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.event.ActionEvent;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class GridBagLayout_assignment {

    public static void main(String[] args) {
        // TODO code application logic here
        JFrame frame = new JFrame("GridBagLayout");
        frame.setSize(400, 200);
        frame.setLocationByPlatform(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
       
        JPanel panel = new JPanel();
        frame.add(panel);
        panel.setLayout(new GridBagLayout());
        
        GridBagConstraints c = new GridBagConstraints();
        
        c.gridx = 0; c.gridy = 0; c.anchor = GridBagConstraints.LINE_END;
        panel.add(new JLabel("First Name: "), c);
        
        c.gridx = 1; c.gridy = 0; c.anchor = GridBagConstraints.LINE_START;
        JTextField fName = new JTextField(20);
        panel.add(fName,c);
        
        c.gridx = 0; c.gridy = 1; c.anchor = GridBagConstraints.LINE_END;
        panel.add(new JLabel("Middle Name: "), c);
        
        c.gridx = 1; c.gridy = 1; c.anchor = GridBagConstraints.LINE_START;
        JTextField mName = new JTextField(20);
        panel.add(mName, c);
        
        c.gridx = 0; c.gridy = 2; c.anchor = GridBagConstraints.LINE_END;
        panel.add(new JLabel("Last Name: "), c);
        
        c.gridx = 1; c.gridy = 2; c.anchor = GridBagConstraints.LINE_START;
        JTextField lName = new JTextField(20);
        panel.add(lName, c);
        
        c.gridx = 1; c.gridy = 3; c.anchor = GridBagConstraints.LINE_END;
        JButton button1 = new JButton("Enter");
        panel.add(button1,c);
        
        frame.setVisible(true);
        
        button1.addActionListener((ActionEvent e)->{
            String firstN = fName.getText();
            String middleN = mName.getText();
            String lastN = lName.getText();
            
            JOptionPane.showMessageDialog(frame, "Welcome " + firstN + " " + middleN + " " + lastN + "!", "Greetings", JOptionPane.INFORMATION_MESSAGE);
        });
        
    }
    
}
