package com.lee.erik.cards;

public class deck {
    String[] suites = {"H","D","C","S"};
    String[] cards = new String[52];
    
    public deck(){
        //create a deck of cards
        int index = 0;
        //loop through the suites
        for(String suite: suites){
            //generate ace through king
           for(int i = 1; i < 14; i++){
               cards[index] = suite + i + " ";
               index++;
           } 
        }
    }
    public void printCardArray(){
        int index = 0;
        for(String suite:suites){
            for(int i = 1; i < 14; i++){
                System.out.print(cards[index]);
                index++;
            }
        }
        System.out.println();
    }
    
    public void shuffleCards(){
        //excute random number 100 times
        for(int i = 0; i <100; i++){
            String savedCard = "";
            int variant = ((int)(Math.random()*50)) + 1;
            
            for(int j = 0; j < cards.length; j++){
                if(j+variant < cards.length){
                    savedCard = cards[j];
                    cards[j] = cards[j+variant];
                    cards[j+variant] = savedCard;
                }
            }
        }
    }
    public String dealCard(int index){
        return cards[index];
    }
}
