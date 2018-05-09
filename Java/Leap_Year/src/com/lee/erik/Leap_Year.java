/*
 * Project name: Leap Year Calculator
 * Project purpose: tells user if year entered is a leap year
 * Created/revised by: Erik Lee on Feb 28, 2017
 */
package com.lee.erik;

import java.util.Scanner;

public class Leap_Year {

    public static void main(String[] args) {
        // TODO code application logic here
        String choice = "y";
        while (choice.equalsIgnoreCase ("y")) {
            //retreive user input
            Scanner sc = new Scanner(System.in);
            int year = 0000;
            String isLeapYear;
            int length = String.valueOf(year).length();
            
            System.out.println("Enter year (YYYY): ");
            if(sc.hasNextInt()){
                year = sc.nextInt();            
            }else{
                System.out.println("Invalid entry, please try again.");
                sc.nextLine();
                continue;
            }
            
            System.out.println();
            if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)){
              isLeapYear = "Yaaasss";  
            } else{
                isLeapYear = "Na Bruh";
            }
            
            System.out.println("Is " + year + "  a leap year? " + isLeapYear);
            
            //end loop
            System.out.println();
            System.out.print("Continue (y/n)? ");
            choice = sc.next();
            System.out.println();
        }
    }
    
}
