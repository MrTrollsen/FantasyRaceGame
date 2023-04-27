using System;
using System.Collections.Generic;

namespace FantasyRaceGame;
public class TheGame
{
    int currentRound;
    public static Random generator = new Random();
    public static List<Animal> animals = new List<Animal>();
    public void GameCreation()
    {
        Console.WriteLine("How many animals do you want to spawn?");
        string textNumber = Console.ReadLine();
        int animalAmount;
        Int32.TryParse(textNumber, out animalAmount);
        for (int i = 0; i < animalAmount; i++)
        {
            if (generator.Next(2) == 1)
            {
                Console.WriteLine("Teddy Bear has been constructed");
                TeddyBear a = new TeddyBear();
                a.Printstats();
                animals.Add(a);
            }
            else
            {
                Console.WriteLine("Unicorn has been constructed");
                Unicorn b = new Unicorn();
                b.Printstats();
                animals.Add(b);
            }
        }
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();
        TheRace();
    }
    public void TheRace()
    {
        Random generator = new();
        int randomAnimal = generator.Next(animals.Count);
        Animal a = animals[randomAnimal];
        
        while (a.position < 20)
        {
         Console.Clear();
         Console.WriteLine("Round:" + currentRound);
         a.Printstats();
         Console.WriteLine();
         Console.WriteLine("1.Rest animal");
         Console.WriteLine("2.Move animal");

         string choiceText = Console.ReadLine();
         if (choiceText == "1" || choiceText == "one")
         {
         a.Rest();
         }
         else if (choiceText == "2" || choiceText == "two")
         {
         a.Move();
         }
         currentRound += 1;
        }
        Console.WriteLine("Race is finished! press the enter button to quit this lovely game");
        Console.ReadLine();
    }
}