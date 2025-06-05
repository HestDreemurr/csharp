using System;

public class WhileLoops 
{
  public static void Main()
  {
    Console.Write("Insira o limite de números: ");
    
    int index = 1;
    int limit = int.Parse(Console.ReadLine());
    
    while (index < limit)
    {
      Console.WriteLine($"Número {index}");
      index++;
    }
  }
}