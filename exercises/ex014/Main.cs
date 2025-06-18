using System;

public class Methods
{
  public static void SayHello(string name = "Desconhecido")
  {
    Console.WriteLine($"Olá, {name}!");
  }
  
  public static int SumNumbers(int number01 = 0, int number02 = 0)
  {
    Console.WriteLine("Somando números...");
    return number01 + number02;
  }
  
  public static void Main()
  {
    SayHello("Gabriel");
    
    int sum = SumNumbers(5, 5);
    Console.WriteLine($"A soma é: {sum}");
  }
}