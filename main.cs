using System;
// using System는 namespace
// System 안에 있는 class들을 사용할 것이라는 뜻
// System 안에는 console이라는 기능이 있음


class Program {
  public static void Main (string[] args) {
    bool boolVariable = true;
    int intVariable = 10;
    float floatVariable = 3.4f;
    char charVariable = 'a';
    
    Console.WriteLine (boolVariable);
    Console.WriteLine (intVariable);
    Console.WriteLine (floatVariable);
    Console.WriteLine (charVariable);
  }
}