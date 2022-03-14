using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public abstract class Card
    {
        private int RegNumber = 3520;
        readonly int Age;
        Random Random = new Random();
        public string CardOwner { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string[] Prefix { get; set; }
        public string AccountNumber { get; set; }
        public int Minimum { get; set; }
        public int CardNumberLenght { get; set; } = 16;

        public Card(string cardOwner, string cardName)
        {
            CardOwner = cardOwner;
            CardName = cardName;
        }
        private void GenerateCardNumber()
        {
            CardNumber = Prefix[Random.Next(0, Prefix.Length)];
            Console.WriteLine($"{CardNumber} Prefix");
            int lenghtOfCardNumber = CardNumberLenght - CardNumber.Length;
            for (int i = 0; i < lenghtOfCardNumber; i++)
            {
                CardNumber += Random.Next(0, 9);
            }
            Console.WriteLine($"{CardNumber} has been generated");
        }
        private void GenerateAccountNumber()
        {
            AccountNumber += RegNumber;
            for (int i = 0; i < 10; i++)
            {
                AccountNumber += Random.Next(0, 9);
            }
            Console.WriteLine($"AccountNumber has been generated");
        }

        public override string ToString()
        {
            GenerateCardNumber();
            GenerateAccountNumber();
            Console.WriteLine();
            return $"CardOwner: {CardOwner}\nCard name: {CardName}\nCardnumber: {CardNumber}\nAccountNumber: {AccountNumber}\nCardNumberLenght: {CardNumberLenght}";
        }
    }
}
