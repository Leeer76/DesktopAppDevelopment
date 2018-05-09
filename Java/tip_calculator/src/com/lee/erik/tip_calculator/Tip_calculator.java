/*
 * Project name: Tip Calculator
 * Project purpose: calculate the tip based on the users input
 * Created/revised by: Erik Lee on Jan 31, 2017
 */
package com.lee.erik.tip_calculator;

import java.util.Scanner;
import java.text.NumberFormat;

public class Tip_calculator {

    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        while(choice.equalsIgnoreCase ("y")){
        
        //retreive user input
        System.out.println("Enter bill amount: ");
        double bill = sc.nextDouble();
        System.out.println();
        
        System.out.println("Enter tip percentage: ");
        double tipIn = sc.nextDouble();
        System.out.println();
        
        //calculate results
        double tipOut;
        double grandTotal;
        tipIn = tipIn/100;
        tipOut = bill * tipIn;
        grandTotal = bill + tipOut;
        
        //display results
       NumberFormat currency = NumberFormat.getCurrencyInstance();
       String outPut = 
               "Tip amount: " + currency.format(tipOut) + "\n"
               + "Grand total: " + currency.format(grandTotal);
       System.out.println(outPut);
       System.out.println();
       
       //close loop
       System.out.println("Continue (y/n)?");
       choice = sc.next();
       System.out.println();
        }  
    }
    
}
