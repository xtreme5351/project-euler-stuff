using System;

class MainClass {
  public static void Main (string[] args) {
    long x = maxFactor(600851475143);
    Console.WriteLine("Largest prime factor = " + x);
  }
  public static long maxFactor(long num){
    while(num % 2 == 0){
      num = num / 2;
    }
    for (long i = 3; i < Math.Sqrt(num) ; i+=2){
      while(num % i == 0){
        num = num / i;
        Console.WriteLine(num);
      }
    }
    return num;
  }
}
