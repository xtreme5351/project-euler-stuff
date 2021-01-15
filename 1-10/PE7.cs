using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 1; int primes = 1;
    while (counter < 10001){
      primes += 2;
      if (IsPrime(primes)){
        counter += 1;
      }
    }
    Console.WriteLine("The iteration is " + counter + " With a prime value of " + primes);
  }

  public static bool IsPrime(int n){
    int boundary = (int)Math.Floor(Math.Sqrt(n));
    if (n <= 1) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;
    for (int i = 3; i <= boundary; i+=2){
      if (n % i == 0){
        return false;
      }
    }
    return true;
  }
}
