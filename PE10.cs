using System;

class MainClass {
  public static void Main (string[] args) {
    long total = 0; const int n = 2000000;
    for (int i = 0; i < n; i++){
      if (IsPrime(i)){
        total += i;
      }
    }
    Console.WriteLine(total);
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
