using System;

public class SumNumbers
{
  public static void Main()
  {
    int sum = 0;
    int index = 0;
    
    while (true)
    {
      Console.Write("Digite um número (999 para encerrar): ");
      int number = int.Parse(Console.ReadLine());
      
      if (number == 999)
      {
        break;
      }
      
      sum += number;
      index++;
    }
    
    Console.WriteLine($"A soma dos {index} números é: {sum}");
  }
}