package array.example;

public class ArrayExample {

    public static void main(String[] args) {
        // TODO code application logic here
        
        double array[] = new double[10];
        double sum = 0;
        
       //array[0] = 1.2;
       // array[1] = 3.9;
       
       for(int i = 0; i < array.length; i++){
           array[i] = i;
          
       }
       
       for(double arr: array){
           sum += arr;
       }
      //System.out.println("Value at index 0 = " + array[0]);
      //System.out.println("Value at index 1 = " + array[1]);
      //System.out.println("Value at index 2 = " + array[2]);
      
      for(int i = 0; i < array.length; i++){
          System.out.println("Value at index " + i + " = " + array[i]);
      }
      System.out.println(sum);
    }
    
}
