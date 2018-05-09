/*
 * Project name: Right Triangle
 * Project purpose: calculate the hypotenuse based on the users input
 * Created/revised by: Erik Lee on Jan 31, 2017
 */
package com.lee.erik.right_triangle;

import java.util.Scanner;
import java.lang.Math;
import java.math.RoundingMode;
import java.math.BigDecimal;

public class Right_triangle {

    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        while (choice.equalsIgnoreCase ("y")) {
            //retreive user input
            System.out.println("Length of side A: ");
            double sideA = sc.nextDouble();
            System.out.println();
            
            System.out.println("Length of side B: ");
            double sideB = sc.nextDouble();
            System.out.println();
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
