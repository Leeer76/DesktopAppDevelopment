/*
 * Project name: FactorialAssignment
 * Project purpose: calculate the factorial based on the users input
 * Created/revised by: Erik Lee on Feb 7, 2017
 */
package com.lee.erik;

import java.util.Scanner;


public class FactorialAssignment {

    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        while (choice.equalsIgnoreCase("y")) {
            System.out.println("Enter value (1 to 10): ");
            //declare variables
            int value = sc.nextInt();
            int factor = 1;
            //calculate and display results
            if (value >= 1 && value <=10){
            for (int i = 1; i <= value; i+=1){
                factor*=i;
            }
            System.out.println("Factorial: " + factor);
            }
            else{
                System.out.println("Invalid entry");
                }
            //end loop
            System.out.print("Continue (y/n)? ");
            choice = sc.next();
            System.out.println();
        }
    }
 }
