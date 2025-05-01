using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Optional: you can test your methods here
    }

    public static int AddStarWarsCharacters(string[] characters)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] == "Yoda")
            {
                return i;
            }
        }
        return -1;
    }

    public static string DeathStarCombat(Dictionary<string, int> jedi)
    {
        string strongestJedi = "";
        int highestAttack = int.MinValue;

        foreach (var pair in jedi)
        {
            if (pair.Value > highestAttack)
            {
                highestAttack = pair.Value;
                strongestJedi = pair.Key;
            }
        }

        return strongestJedi;
    }

    public static List<string> ConvertPlanets(string[] planets)
    {
        List<string> planetList = new List<string>(planets);
        planetList.Reverse();
        return planetList;
    }

    public static double AverageDroids(List<int> droids)
    {
        List<int> evenDroids = new List<int>();

        foreach (int droid in droids)
        {
            if (droid % 2 == 0)
            {
                evenDroids.Add(droid);
            }
        }

        if (evenDroids.Count == 0)
        {
            return 0;
        }

        double sum = 0;
        foreach (int even in evenDroids)
        {
            sum += even;
        }

        return sum / evenDroids.Count;
    }

    public static string TryToCatchDarthVader(string input)
    {
        try
        {
            int result = int.Parse(input);
            return "Vader Was Captured!";
        }
        catch (FormatException)
        {
            return "Vader Got Away!";
        }
    }
}