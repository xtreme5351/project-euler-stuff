using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    var watch = new System.Diagnostics.Stopwatch(); watch.Start();
    List<int> triangularNumbers = new List<int>();
    const int n = 50000;
    for(int i = 1; i < n; i++){
      int a = (i) * (i + 1) / 2;
      triangularNumbers.Add(a);
    }
    //Console.WriteLine(String.Join(" ", triangularNumbers));
    int factorised = factorFinder(triangularNumbers, n);
    watch.Stop();
    Console.WriteLine("First number with over the wanted factor number = " + factorised);
    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
  }

  public static int factorFinder(List<int> nums, int n){
    foreach (int a in nums){
      //Console.WriteLine("a = " + a);
      int factorNumber = 0;
      const int wantedFactorNumber = 500;
      for (int i = 1; i <= a; i++){
        if(a % i == 0){
          factorNumber += 1;
        }
      }
      //Console.WriteLine("Num = " + a + " | Total factor number = " + factorNumber);
      if(factorNumber > wantedFactorNumber){
        return a;
      }
    }
    return -1;
  }
}
