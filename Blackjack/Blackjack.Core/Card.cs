namespace Blackjack.Core
{
    using System;

    public class Card
    {
        // Kaardi klass: mast, number, punktid, nähtav või mitte
        // Diamonds (♦), Clubs (♣), Hearts (♥) and Spades (♠)

        private string _rank { get; }
        private char _suite { get; }
        private int _points { get; }
        public string Description => _rank + _suite; // it's an expression body
        public Boolean Hidden { get; set; } = true;

        public Card(string rank, char suite, int points)
        {
            this._rank = rank;
            this._suite = suite;
            this._points = points;
        }
    }
}
