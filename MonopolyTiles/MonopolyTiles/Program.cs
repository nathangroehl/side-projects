﻿using MonopolyStatistics.Helper;
using System;


namespace MonopolyTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Monopoly Simulator");
            Console.WriteLine("The key to winning Monopoly is realizing that there are tiles that are significantly more likely to land on");
            Console.WriteLine("This program simulates a player going around the board following all of the rules except for money because it is independent of movement");
            Console.WriteLine("How many turns do you want in your games? Average game is about 30 turns");
            int numberOfTurns = -1;
            while(!int.TryParse(Console.ReadLine(), out numberOfTurns))
            {
                Console.WriteLine("Invalid input. Please enter only a number.");
            }
            Console.WriteLine("How many games do you want to simulate?");
            int numberOfGames = -1;
            while (!int.TryParse(Console.ReadLine(), out numberOfGames))
            {
                Console.WriteLine("Invalid input. Please enter only a number.");
            }
            GameFunctionality game = new GameFunctionality();
            game.RunMonopoly(numberOfTurns, numberOfGames);
        }
    }
}
