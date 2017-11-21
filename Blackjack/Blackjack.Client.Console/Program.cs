namespace Blackjack.Client.Console
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // All aces are 11 points
            // When user draws a card, house draws a card aswell

            Console.WriteLine("Welcome to the game of Blackjack");

            Console.WriteLine("You have been dealt: 4C, 6H");
            Console.WriteLine("House have been dealt: 8S, [?]");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - Take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine("I choose: 1");

            Console.WriteLine("You have been dealt: 4S");
            Console.WriteLine("House have been dealt: [?]");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - Take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine("I choose: 2");

            Console.WriteLine("Your sum: ");
            Console.WriteLine("House sum: ");
            Console.WriteLine("House won!");
        }
    }
}
