/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.CIS238.examples;

/**
 *
 * @author ARMSTROD
 */
public class consoleDBlist {
    
    public static void main(String args[])
    {
        // create a new customer list object
        CustomerList myList = new CustomerList();

        // print a heading
        System.out.println("Customer List - " + myList.getCustomerList().getSize());

        // loop to print customer id list
        for(int i=0; i<myList.getCustomerList().getSize(); i++)
        {
            //print a line number
            System.out.print((i+1) + ": ");
            //print the customer id
            System.out.println(myList.getCustomerList().getElementAt(i).toString());
        }
    }    
}
