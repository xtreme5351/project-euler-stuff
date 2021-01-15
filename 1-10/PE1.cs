using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Calculate(1000);
  }
  public static void Calculate(int lim){
    int[] multiples = new int[lim];
    for (int i = 0; i < lim; i++){
      int x = i % 3;
      int y = i % 5;
      if (x == 0 || y == 0){
        multiples[i] = i;
      }
    }
    Console.WriteLine("Multiples = [{0}]", string.Join(", ", multiples));
    Console.WriteLine("The total is = " + multiples.Sum());
  }
}
