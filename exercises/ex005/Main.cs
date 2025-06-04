using System;

public class Operators
{
  public static void Main()
  {
    Console.Write("Insira um número: ");
    int.TryParse(Console.ReadLine(), out int num01);
    
    Console.Write("Insira outro número: ");
    int.TryParse(Console.ReadLine(), out int num02);
    
    int sum = num01 + num02;
    int sub = num01 - num02;
    int times = num01 * num02;
    int division = num01 / num02;
    int modulus = num01 % num02;
    
    Console.WriteLine($"A soma entre {num01} e {num02} é {sum}.");
    Console.WriteLine($"A subtração entre {num01} e {num02} é {sub}.");
    Console.WriteLine($"A multiplicação entre {num01} e {num02} é {times}.");
    Console.WriteLine($"A divisão entre {num01} e {num02} é {division}.");
    Console.WriteLine($"O resto da divisão entre {num01} e {num02} é {modulus}.");
  }
}