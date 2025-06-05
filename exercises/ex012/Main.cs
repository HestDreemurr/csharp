using System;

public class NumberValidator
{
  public static void Main()
  {
    Console.Write("Digite um número: ");
    
    while (!int.TryParse(Console.ReadLine(), out int number)) {
      Console.Write("Número inválido. Digite novamente: ");
    }
    
    Console.WriteLine("Número válido.");
  }
}