/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.CIS238.examples;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;

/**
 *
 * @author ARMSTROD
 */
public class CustomerList {
    // class variables (global)
    public DefaultListModel model;
    public DefaultComboBoxModel model2;

    // constructor - customer id as parameter
    public CustomerList()
    {
        // call method to get customer info from database
        // and load class variables
        getCustomerInfo();
    }

    private void getCustomerInfo()
    {
        try
        {
            //initialize database driver
            Class.forName("com.mysql.jdbc.Driver");

            //create database connection
            Connection conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/northwind2", "root", "root");
            
            //create statement object
            Statement st = conn.createStatement();

            //create result set (executes SQL)
            ResultSet rs = st.executeQuery("SELECT CustomerID FROM Customers ORDER BY CustomerID");

            //loop to load class variables from result set
            model = new DefaultListModel();
            model2 = new DefaultComboBoxModel();
            while(rs.next())
            {
                model.addElement(rs.getString(1));
                model2.addElement(rs.getString(1));
            }

            //close stuff
            rs.close();
            st.close();
            conn.close();
        }
        catch (Exception e)
        {
            System.out.println(e.toString());
        }

    }

    public DefaultListModel getCustomerList()
    {
        getCustomerInfo();
        return model;
    }

    public DefaultComboBoxModel getCustomerCombo()
    {
        getCustomerInfo();
        return model2;
    }
    
}
