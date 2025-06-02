using System;

public class Program {
  public static void Main() {
    Console.Write("Quantos anos voce tem?: ");
    
    if (int.TryParse(Console.ReadLine(), out int age)) {
      Console.WriteLine($"Voce tem {age} anos.");
    } else {
      Console.WriteLine("Deixa de ser burro e digita um numero valido");
    }
  }
}