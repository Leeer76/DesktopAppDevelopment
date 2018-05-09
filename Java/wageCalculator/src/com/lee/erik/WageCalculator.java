/*
 * Project name: Wage Calculator
 * Project purpose: calculate the the wages of someone based on input
 * Created/revised by: Erik Lee on Feb 13, 2017
 */
package com.lee.erik;

import java.util.Scanner;
import java.text.NumberFormat;

public class WageCalculator {

    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        
        while (choice.equalsIgnoreCase("y")) {
         
            //declare variables
            final double STHOURS = 40;
            final double OT = 1.5;
            double hours = 0;
            double wage = 0;
            double othours = 0;
            double outPut = 0;
            String outPut2;
            
            //retreive user input
            System.out.println("Enter hourly wage: ");
            wage = sc.nextDouble();
            System.out.println("Enter hours worked this week: ");
            hours = sc.nextDouble();
            
            //calculate results
            if (hours > 40) {
                othours = hours - STHOURS;
                outPut = (STHOURS * wage) + (othours* (wage*OT));
            } else{
                outPut = hours * wage;
            }
            
            NumberFormat currency = NumberFormat.getCurrencyInstance();
            outPut2 = currency.format(outPut);
            System.out.println("Your wages are: " + outPut2);
            
            System.out.println();
            System.out.print("Continue (y/n)? ");
            choice = sc.next();
            System.out.println(); 
                    
        }
    }
    
}
