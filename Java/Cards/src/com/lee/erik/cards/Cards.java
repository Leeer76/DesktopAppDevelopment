
package com.lee.erik.cards;

public class Cards {

    public static void main(String[] args) {
        // create deck
        
        deck myDeck = new deck();
        //five hands four card each
        String[][] hands = new String[5][4];
        int index = 1;
        //print cards
        //myDeck.printCardArray();
        
        //shuffle cards
        myDeck.shuffleCards();
        
        //deals out cards
        int i = 0;
        for(int k = 0; k < 5; k++){ // how many hands
            for(int j = 0; j < 4; j++){//how many cards
               hands[k][j] = myDeck.dealCard(i);
               i++;
            }            
        }
        // print the five hands on seperate lines
                
        for(int l = 0; l < 5; l++){
            System.out.print("Hand " + index + ": ");
            index++;
            for(int m = 0; m < 4; m++){
                System.out.print(hands[l][m]);
            } 
            System.out.println();
        }
    }    
}
