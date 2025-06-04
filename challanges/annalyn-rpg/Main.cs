/// Este desafio pertence à plataforma Exercism: https://exercism.org/tracks/csharp/exercises/annalyns-infiltration

using System;
using Logic;

public class AnnalynRPG 
{
  public static void Main() 
  {
    bool knightIsAwake = false;
    bool archerIsAwake = false;
    bool prisonerIsAwake = false;
    bool petDogIsPresent = false;
    
    // Fast Attack
    bool canFastAttack = QuestLogic.CanFastAttack(knightIsAwake);
    Console.WriteLine($"Can Fast Attack? {canFastAttack}");
    
    // Spy
    bool canSpy = QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
    Console.WriteLine($"Can Spy? {canSpy}");
    
    // Signal Prisoner
    bool canSignalPrisoner = QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
    Console.WriteLine($"Can Signal Prisoner? {canSignalPrisoner}");
    
    // Free Prisoner
    bool canFreePrisoner = QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
    Console.WriteLine($"Can Free Prisoner? {canFreePrisoner}");
  }
}