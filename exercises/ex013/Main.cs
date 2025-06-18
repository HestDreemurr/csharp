using System;

public class Arrays 
{
  public static void Main()
  {
    string[] foods = {"Arroz", "Feijão", "Carne", "Frango", "Batata"};
    
    foreach (string food in foods)
    {
      Console.WriteLine(food);
    }
    
    Console.WriteLine("O primeiro item da lista é: " + foods[0]);
    Console.WriteLine("O tamanho da lista é de " + foods.Length + " itens");
  }
}