using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    const int n = 500;
    for(int i = 1; i < n; i++){
      for (int j = 1; j < n; j++){
        tripletFinder(i, j);
      }
    }
  }
  
  public static void tripletFinder(int a, int b){
    List<(int, int, double)> triplet = new List<(int, int, double)>();
    double aS = Math.Pow(a, 2); double bS = Math.Pow(b, 2);
    double cS = aS + bS;
    if (Math.Sqrt(cS) % 1 == 0){
      triplet.Add((a, b, Math.Sqrt(cS)));
      Console.WriteLine(String.Join("Triplet = ", triplet));
      //Console.WriteLine( "Proof => " + aS + " + " + bS + " = " + cS );
      double sumThree = a + b + Math.Sqrt(cS);
      Console.WriteLine("SUM OF ABC = " + sumThree);
      if(sumThree == 1000.0){
        Console.WriteLine("PRODUCT = " + (a * b * Math.Sqrt(cS)));
        System.Environment.Exit(0);
      }
    }
  }
}
