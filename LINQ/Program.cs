using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> videoGames = new List<string>
        {
            "The Legend of Zelda: Breath of the Wild",
            "Red Dead Redemption 2",
            "The Witcher 3: Wild Hunt",
            "Counter-Strike: Global Offensive",
            "Minecraft",
            "Fortnite",
            "Call of Duty: Warzone",
            "Persona 5",
            "Dark Souls III",
            "Super Mario Odyssey"
        };
       
        var orderedGames = videoGames.OrderBy(game => game.Length);

        Console.WriteLine("List of video games ordered by name length:");
        foreach (var game in orderedGames)
        {
            Console.WriteLine(game);
        }

        string longestGameName = videoGames.OrderByDescending(game => game.Length).First();
        Console.WriteLine($"Longest game name: {longestGameName}");

        var shortNames = videoGames.Where(game => game.Length < 20);
        Console.WriteLine("Games with names shorter than 20 characters:");
        foreach (var game in shortNames)
        {
            Console.WriteLine(game);
        }

        int gamesWithThe = videoGames.Count(game => game.Contains("The"));
        Console.WriteLine($"Number of games with 'The' in their name: {gamesWithThe}");

        bool hasMinecraft = videoGames.Any(game => game.Contains("Minecraft"));
        Console.WriteLine("Contains 'Minecraft': " + hasMinecraft);
    }
}
