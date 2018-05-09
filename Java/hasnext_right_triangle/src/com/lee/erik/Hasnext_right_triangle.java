/*
 * Project name: Right Triangle
 * Project purpose: calculate the hypotenuse based on the users input
 * Created/revised by: Erik Lee on Feb 21, 2017
 */
package com.lee.erik;

import java.util.Scanner;
import java.math.RoundingMode;
import java.math.BigDecimal;

public class Hasnext_right_triangle {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        String choice = "y";
        while (choice.equalsIgnoreCase ("y")) {
            //retreive user input
            Scanner sc = new Scanner(System.in);
            double sideA = 0.0;
            double sideB = 0.0;
            
            
            System.out.println("Length of side A: ");
            if(sc.hasNextDouble()){
                sideA = sc.nextDouble();

                System.out.println("Length of side B: ");
                
                if(sc.hasNextDouble()){
                    sideB = sc.nextDouble();
                }else
                {
                   System.out.println("Invalid number, please try again");
                   sc.nextLine();
                   continue;
                }
            }else{
                System.out.println("Invalid number, please try again");
                sc.nextLine();
                continue;
            }
            System.out.println();
            

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