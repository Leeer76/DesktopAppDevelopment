
package com.lee.erik;

import java.util.Scanner;

public class LoginCreator {

    public static void main(String[] args) {
        // TODO code application logic here
        String first;
        String middle;
        String last;
        String ss;
        String login;
        int systemCheck = 1;
        Scanner sc = new Scanner(System.in);
        
        System.out.println("What is your first name?");
        first = sc.next();
        System.out.println("What is your middle name?");
        middle = sc.next();
        System.out.println("What is your last name?");
        last = sc.next();
        System.out.println("What is your SS#? (###-##-####)");
        ss = sc.next();
        while(systemCheck == 1){
        if(ss.length() < 11){
            System.out.println();
            System.out.println("Invalid Social Security #, please try again");
            System.out.println();
            System.out.println("What is your SS#? (###-##-####)");
            ss = sc.next();
        }else{
            systemCheck = 2;
        }
        }
             
        login = first.toUpperCase().substring(0,1) + middle.toUpperCase().substring(0,1) + last.toUpperCase().substring(0,1) + ss.substring(7);
        
        System.out.println();
        System.out.println("Your login ID is: " + login);
    }
    
}
