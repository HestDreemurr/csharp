using System;

public class Program 
{
  public static void Main() 
  {
    Console.Write("Quantos anos você tem?: ");
    
    if (int.TryParse(Console.ReadLine(), out int age)) 
    {
      Console.WriteLine($"Você tem {age} anos.");
      return;
    }
    
    Console.WriteLine("Deixa de ser burro e digita um número válido.");
  }
}