using System;

public class GradesValidator 
{
  public static void Main() 
  {
    Console.Write("Digite o nome do aluno: ");
    string name = Console.ReadLine();
    
    Console.Write("Digite a nota do aluno: ");
    
    if (!int.TryParse(Console.ReadLine(), out int grade)) 
    {
      Console.WriteLine("Digite um número inteiro válido. Tente novamente.");
      return;
    }
    
    if (grade >= 5) 
    {
      Console.WriteLine($"O aluno {name} PASSOU!");
      return;
    }
    
    Console.WriteLine($"O aluno {name} REPROVOU!");
  }
}