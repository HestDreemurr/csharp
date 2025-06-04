using System;

public class Greetings 
{
  public static void Main()
  {
    Console.Write("Que horas são?: ");
    
    if (!int.TryParse(Console.ReadLine(), out int hours))
    {
      Console.WriteLine("Digite um número válido. Tente novamente.");
      return;
    }
    
    if (hours < 0 || hours > 24) 
    {
      Console.WriteLine("Digite uma hora válida (entre 0 e 24). Tente novamente.");
      return;
    }
    
    string message = (hours >= 18) ? "Boa noite" : "Bom dia";
    
    Console.WriteLine(message);
  }
}