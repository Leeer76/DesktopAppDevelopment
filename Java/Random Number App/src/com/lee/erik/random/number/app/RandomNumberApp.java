package com.lee.erik.random.number.app;

public class RandomNumberApp {

    public static void main(String[] args) {
        // TODO code application logic here
        double rand[] = new double[99];
        double sum = 0;
        double avg = 0;
        
        for(int i = 0; i < rand.length; i++){
            rand[i] = Math.random()*100;
        }
        
        for(double ran: rand){
            sum += ran;
        }
        avg = sum/rand.length;
        
        System.out.print("Sum: " + sum + "\n" + "Average: " + avg + "\n");
    }
    
}
