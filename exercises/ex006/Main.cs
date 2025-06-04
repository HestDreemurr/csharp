using System;

public class Strings
{
  public static void Main()
  {
    Console.Write("Insira um texto: ");
    string text = Console.ReadLine();
    
    int length = text.Length;
    string lowerText = text.ToLower();
    string upperText = text.ToUpper();
    char firstLetter = text[0];
    
    Console.WriteLine($"O tamanho do texto é de {length} caracteres.");
    Console.WriteLine($"O texto em minúsculas é {lowerText}.");
    Console.WriteLine($"O texto em maiúsculas é {upperText}.");
    Console.WriteLine($"A primeira letra do texto é {firstLetter}.");
  }
}