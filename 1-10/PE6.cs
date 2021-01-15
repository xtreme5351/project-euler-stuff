using System;
using System.Numerics;

class MainClass {
  public static void Main (string[] args) {
    double SumSResult = SumSquares(100);
    double SquareResult = SquareSums(100);
    double diff = SquareSums(100) - SumSquares(100);
    Console.WriteLine("SUM OF SQUARES = " + SumSResult + " <> SQUARE OF SUMS = " + SquareResult);
    Console.WriteLine("DIFF = " + diff);
  }

  public static double SumSquares(int n){
    double total = 0;
    for (int i = 1; i <= n; i++){
      total += Math.Pow(i, 2);
    }
    return total;
  }

  public static double SquareSums(int n){
    int initTotal = 0;
    double total = 0;
    for (int i = 1; i <= n; i++){
      initTotal += i;
    }
    total = Math.Pow(initTotal, 2);
    return total;
  }
}
