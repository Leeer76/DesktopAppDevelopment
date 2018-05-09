
package com.lee.erik.world_war_2;

import java.time.LocalDate;
import java.time.Month;
import java.util.Scanner;

public class World_War_2 {

    public static void main(String[] args) {
        // TODO code application logic here
        
        LocalDate start = LocalDate.of(1939, Month.SEPTEMBER, 01);
        LocalDate end = LocalDate.of(1945, Month.SEPTEMBER, 02);
        LocalDate guess;
        int year;
        int month;
        int day;
        Scanner sc = new Scanner(System.in);
        String choice = "y";
        while (choice.equalsIgnoreCase ("y")){
            
        
        System.out.println("Did this date take place during WWII");
        System.out.println("Enter year: (0000)");
        year = sc.nextInt();
        System.out.println("Enter month: (00)");
        month = sc.nextInt();
        System.out.println("Enter day: (00)");
        day = sc.nextInt();
        System.out.println();        
        guess = LocalDate.of(year, month, day);
        
        if(guess.isAfter(end) || guess.isBefore(start)){
            System.out.println("That day was not during World War 2");
        }else{
            System.out.println("That day was not during World War 2");
        }
        System.out.print("Continue (y/n)? ");
        choice = sc.next();
        System.out.println();
        }
    }
    
}
