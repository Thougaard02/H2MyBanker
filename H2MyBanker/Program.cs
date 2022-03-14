using H2MyBanker.Cards;
using System;
using System.Collections.Generic;

namespace H2MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Card> cards = new List<Card>();
            cards.Add(new Maestro("Rasmus"));
            cards.Add(new VisaElectron("Daniel"));
            cards.Add(new Mastercard("Benjamin"));
            cards.Add(new DebitCard("Mikkel"));
            cards.Add(new Visa("Kris"));

            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
                Console.WriteLine("#############################\n");
            }
        }
    }
}
