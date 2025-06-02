using System;

public class AgeValidator {
  public static void Main() {
    Console.Write("Digite o nome do aluno: ");
    string name = Console.ReadLine();
    
    Console.Write("Digite a nota do aluno: ");
    
    if (int.TryParse(Console.ReadLine(), out int grade)) {
      if (grade >= 5) {
        Console.WriteLine($"O aluno {name} PASSOU!");
      } else {
        Console.WriteLine($"O aluno {name} REPROVOU!");
      }
    }
  }
}