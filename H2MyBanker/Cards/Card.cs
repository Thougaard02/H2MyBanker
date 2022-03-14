using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public abstract class Card
    {
        private const int REG_NUMBER = 3520;
        private const int ACCOUNT_NUMBER_LENGHT = 14;

        private Random random = new Random();
        public string HolderName { get; protected set; }
        public string CardName { get; protected set; }
        public string CardNumber { get; protected set; }
        public string[] Prefix { get; protected set; }
        public string AccountNumber { get; protected set; }
        public int CardNumberLenght { get; protected set; } = 16;

        public Card(string cardOwner)
        {
            HolderName = cardOwner;
        }
        private void GenerateCardNumber()
        {
            CardNumber = Prefix[random.Next(0, Prefix.Length)];
            Console.WriteLine($"{CardNumber} Prefix");
            int lenghtOfCardNumber = CardNumberLenght - CardNumber.Length;
            for (int i = 0; i < lenghtOfCardNumber; i++)
            {
                CardNumber += random.Next(0, 9);
            }
            Console.WriteLine($"{CardNumber} has been generated");
        }
        private void GenerateAccountNumber()
        {
            AccountNumber += REG_NUMBER;
            int lenght = ACCOUNT_NUMBER_LENGHT - AccountNumber.Length;
            for (int i = 0; i < lenght; i++)
            {
                AccountNumber += random.Next(0, 9);
            }
            Console.WriteLine($"AccountNumber has been generated");
        }

        public override string ToString()
        {
            GenerateCardNumber();
            GenerateAccountNumber();
            Console.WriteLine();
            return $"CardOwner: {HolderName}\nCard name: {CardName}\nCardnumber: {CardNumber}\nAccountNumber: {AccountNumber}\nCardNumberLenght: {CardNumberLenght}";
        }
    }
}
