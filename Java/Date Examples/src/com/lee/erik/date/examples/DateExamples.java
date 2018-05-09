
package com.lee.erik.date.examples;

import java.time.LocalDate;
import java.util.Scanner;

public class DateExamples {

    public static void main(String[] args) {
        // TODO code application logic here
        LocalDate birthDay = LocalDate.of(1986, 12, 15);
        LocalDate guess;
        Scanner sc = new Scanner(System.in);
        int year;
        int month;
        int day;
        
        System.out.println("Can you guess my birthday?");
        System.out.println("Enter year: ");
        year = sc.nextInt();
        System.out.println("Enter month: ");
        month = sc.nextInt();
        System.out.println("Enter day: ");
        day = sc.nextInt();
        
        guess = LocalDate.of(year, month, day);
        
        if(guess.compareTo(birthDay) < 0){
            System.out.println("A little before my time!");
        }else if(guess.compareTo(birthDay) > 0){
            System.out.println("A little after my time!");
        }else if(guess.compareTo(birthDay) == 0){
            System.out.println("Bingo!");
        }
    }
    
}
