using System;

public class DayOfWeek 
{
  public static void Main()
  {
    Console.Write("Diga o dia da semana em número (1 à 7): ");
    
    if (!int.TryParse(Console.ReadLine(), out int day))
    {
      Console.WriteLine("Digite um número válido. Tente novamente.");
      return;
    }
    
    switch (day)
    {
      case 1:
        Console.WriteLine("Hoje é segunda!");
        break;
      case 2:
        Console.WriteLine("Hoje é terça!");
        break;
      case 3:
        Console.WriteLine("Hoje é quarta!");
        break;
      case 4:
        Console.WriteLine("Hoje é quinta!");
        break;
      case 5:
        Console.WriteLine("Hoje é sexta!");
        break;
      case 6:
        Console.WriteLine("Hoje é sábado!");
        break;
      case 7:
        Console.WriteLine("Hoje é domingo!");
        break;
      default:
        Console.WriteLine("Dia da semana não encontrado.");
        break;
    }
  }
}