
package com.lee.erik.string.example;

public class StringExample {

    public static void main(String[] args) {
        // TODO code application logic here
        String title = "Friday";
        String firstHalf;
        String secondHalf;
        char char1;
        char char2;
        char char3;
        
        char1 = title.charAt(0);
        char2 = title.charAt(1);
        char3 = title.charAt(2);
        
        System.out.println(char1 + " " + char2 + " " + char3);
        
        firstHalf = title.substring(0,3);
        secondHalf = title.substring(3);
        
        System.out.println(firstHalf);
        System.out.println(secondHalf);
        
    }
    
}
