using System;
using System.Collections.Generic;

namespace FantasyRaceGame;
public class Animal
{
    public int speed = 2;
    public int position = 0;
    public int energyMax = 4;
    public int energyCurrent = 4;
    public static Random randomiser = new Random();
    public void Move()
    {
        if (energyCurrent > 0)
        {
            int number = randomiser.Next(1, speed);
            energyCurrent -= 1;
            position += number;
        }
    }
    public void Rest()
    {
        energyCurrent = energyMax;
    }
    public void Printstats()
    {
        Console.WriteLine("speed:" + speed);
        Console.WriteLine("position:" + position);
        Console.WriteLine("Energy:" + energyCurrent + "/" + energyMax);
    }
}

