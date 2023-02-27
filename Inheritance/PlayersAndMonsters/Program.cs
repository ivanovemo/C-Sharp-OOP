using System;
namespace PlayersAndMonsters;

public class StartUp
{
    public static void Main(string[] args)
    {
        BladeKnight bladeknight = new BladeKnight("BetrayeD", 80);

        Console.WriteLine(bladeknight.ToString());
    }
}