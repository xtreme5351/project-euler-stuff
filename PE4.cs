using System;

class MainClass {
  public static void Main (string[] args) {
    int n1 = 0;
    int n2 = 0;
    for (int i = 800; i < 1000; i ++){
      for (int j = 800; j < 1000; j++){
        bool check = checkPalindrome(i * j);
        Console.WriteLine(i + " " + j);
        if (check){
          n1 = i;
          n2 = j;
        }
      }
    }
    Console.WriteLine("RESULT = " + n1 + ", " + n2 + " LARGEST PALINDROME = " + (n1 * n2));
  }

  public static bool checkPalindrome(int num){
    string str = num.ToString();
    int numLength = str.Length;
    string s = str.Slice(0, numLength/2);
    string f = Extension.Reverse(str.Slice(numLength/2, numLength));
    if(s == f){
      return true;
    }
    return false;
  }
}

public static class Extension {
    public static string Slice(this string source, int start, int end) {
        if (end < 0) {
            end = source.Length + end;
        }
        int len = end - start;              
        return source.Substring(start, len);
    }
    
    public static string Reverse(string s){
      char[] charArr = s.ToCharArray();
      Array.Reverse(charArr);
      return new string(charArr);
    }
}
