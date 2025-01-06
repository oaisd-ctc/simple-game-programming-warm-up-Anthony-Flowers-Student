using System;

public class Program
{
    static int playerScore = 0;
    static int rivalScore = 0;
    public static void Main(string[] args)
    {
       Intro();
    }
    public static void Intro()
    {
        Console.Clear();
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Start();
    }
    public static void Start()
    {
        for(int i = 1; i < 11; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Round {i}");
            int rivalRoll = Roll();
            Console.WriteLine($"Rival rolled a {rivalRoll}");
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();
            int playerRoll = Roll();
            Console.WriteLine($"You rolled a {playerRoll}");
            if (playerRoll > rivalRoll)
            {
                Console.WriteLine("You won this round.");
                playerScore++;
            }
            else if (playerRoll < rivalRoll)
            {
                Console.WriteLine("The rival won this round.");
                rivalScore++;
            }
            else 
            {
                Console.WriteLine("This round was a draw.");
            }
            Console.WriteLine($"The score is now - You : {playerScore}. Rival : {rivalScore}.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        End();
        
    }
    public static void End()
    {
        Console.WriteLine();
        Console.WriteLine("Game over.");
        Console.WriteLine($"The score is now - You : {playerScore}. Rival : {rivalScore}.");
        if (playerScore > rivalScore)
        {
            Console.WriteLine("You won!");
        }
        else if (playerScore < rivalScore)
        {
            Console.WriteLine("You lost!");
        }
        else
        {
            Console.WriteLine("This game is a draw.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
    public static int Roll()
    {
        Random dice = new Random();
        int roll = dice.Next(1, 7);
        return roll;
    }
}
