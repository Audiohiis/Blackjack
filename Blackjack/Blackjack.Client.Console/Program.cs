namespace Blackjack.Client.Console
{
    using System;
    using Blackjack.Core;

    class Program
    {
        static void Main(string[] args)
        {
            // All aces are 11 points
            // When user draws a card, house draws a card aswell

            Console.WriteLine("Welcome to the game of Blackjack");

            var c4 = new Card("4", 'C', 4);
            c4.Hidden = false;
            var h6 = new Card("6", 'H', 6);
            h6.Hidden = false;
            var s8 = new Card("8", 'S', 8);
            s8.Hidden = false;
            var dJ = new Card("J", 'D', 10);
            dJ.Hidden = false;

            Console.WriteLine($"You have been dealt: { GetCardDescription(c4) }, { GetCardDescription(h6) }");
            Console.WriteLine($"House have been dealt: { GetCardDescription(s8) }, { GetCardDescription(dJ) }");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - Take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine("I choose: 1");

            var s4 = new Card("4", 'S', 4);
            s4.Hidden = false;
            var hI = new Card("I", 'H', 10);
            hI.Hidden = false;

            Console.WriteLine($"You have been dealt: { GetCardDescription(s4) }");
            Console.WriteLine($"House have been dealt: { GetCardDescription(hI) }");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - Take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine("I choose: 2");

            Console.WriteLine("Your sum: 14");
            Console.WriteLine("House sum: 17");
            Console.WriteLine("House won!");
        }

        public static string GetCardDescription(Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }
    }
}
