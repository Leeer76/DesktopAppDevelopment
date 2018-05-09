/*
 * Project name: Right Triangle
 * Project purpose: calculate the hypotenuse based on the users input
 * Created/revised by: Erik Lee on Feb 21, 2017
 */
package com.lee.erik;

import java.util.InputMismatchException;
import java.util.Scanner;
import java.math.RoundingMode;
import java.math.BigDecimal;

public class Try_catch_right_triangle {

    public static void main(String[] args) {
        // TODO code application logic here Scanner sc = new Scanner(System.in);
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        while (choice.equalsIgnoreCase ("y")) {
            //retreive user input
            double sideA = 0.0;
            double sideB = 0.0;
            try{
            System.out.println("Length of side A: ");
            sideA = sc.nextDouble();
            System.out.println();
            System.out.println("Length of side B: ");
            sideB = sc.nextDouble();
            System.out.println();
            }catch(InputMismatchException e)
            {
                sc.next();
                System.out.println("Error! Invalid number, try again.");
                        continue;
            }
            //calculate results
            double sideC;
            sideC = Math.sqrt((Math.pow(sideA,2)) + (Math.pow(sideB,2)));
            
            BigDecimal Hypotenuse = new BigDecimal(sideC).setScale(2,RoundingMode.HALF_UP);
            //display results
            System.out.println("The hypotenuse equals: " + Hypotenuse + "\n");
            
            //end loop
            System.out.print("Continue (y/n)? ");
            choice = sc.next();
            System.out.println();
        }
    }
    
}

