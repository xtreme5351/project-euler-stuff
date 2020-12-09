using System;

class MainClass {
  public static void Main (string[] args) {
    int[] seq = fibonacci(100);
    Console.WriteLine("The sequence is [{0}]", string.Join(", ", seq));
    int total = 0;
    foreach(int i in seq){
      if (i%2 == 0){
        total += i;
      }
    }
    Console.WriteLine("SUM OF EVEN = " + total);
  }
  public static int[] fibonacci(int lim){
    int[] sequence = new int[lim + 1];
    sequence[0] = 1; 
    sequence[1] = 2;
    for (int i = 2; i < (lim+1); i++){
      sequence[i] = sequence[i - 2] + sequence[i - 1];
      if (sequence[i] > 3000000){
        Console.WriteLine("EXCEEDED");
        break;
      }
    }
    return sequence;
  }
}
