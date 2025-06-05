using System;

public class ForLoops 
{
  public static void Main()
  {
    Console.Write("Quantos \"Olá, mundo!\" voce quer?: ");
    
    int limit = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= limit; i++)
    {
      Console.WriteLine($"{i}° \"Olá, mundo!\"");
    }
  }
}