/*
 * Project name: GPA Calculator
 * Project purpose: calculate the GPA based on the users input
 * Created/revised by: Erik Lee on Feb 8, 2017
 */
package com.lee.erik;

import java.util.Scanner;

public class GPA_calc {

    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        while (choice.equalsIgnoreCase("y")){
                       
            final double numGrade = 4;
            final double A = 4;
            final double B = 3;
            final double C = 2;
            final double D = 1;
            final double F = 0;
            double GPA = 0;
            double GPAOut = 0;
            
            for (int i = 1; i <= 4; i++) {
            System.out.println("Enter letter grade: ");
            String grade1 = sc.next();
            switch (grade1.toLowerCase()){
                case "a":
                    GPA = GPA + A;
                     break;
                case "b":
                    GPA = GPA + B;
                    break;
                case "c":
                    GPA = GPA + C;
                    break;
                case "d":
                    GPA = GPA + D;
                    break;
                case "f":
                    GPA = GPA + F;
                    break;               
            }
            }
         
        GPAOut = GPA/numGrade;
        System.out.println("Your GPA is: " + GPAOut);
        
        System.out.print("Continue (y/n)? ");
        choice = sc.next();
        System.out.println();    
        }
        
    }
    
}
