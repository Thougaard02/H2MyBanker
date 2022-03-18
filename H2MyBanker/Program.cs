using System;
using H2MyBanker.Cards;
using System.Collections.Generic;
using H2MyBanker;
using H2MyBanker.Interfaces;

namespace H2MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            ICardOwner cardOwner = new CardOwner();
            IAccount account = new Account();

            #region CreditCards

            List<CreditCard> creditCards = new List<CreditCard>();
            creditCards.Add(new Mastercard(cardOwner, account));
            creditCards.Add(new VisaDankort(cardOwner, account));

            foreach (CreditCard creditCard in creditCards)
            {
                Console.WriteLine("ACCOUNT");
                Console.WriteLine("Account number: " + account.GetAccountNumber());
                Console.WriteLine("Account registration number: " + account.GetRegistrationNumber());
                Console.WriteLine();
                Console.WriteLine("Credit Card");
                Console.WriteLine("Card Number: " + creditCard.GenerateCardNumber());
                Console.WriteLine("Card name: " + creditCard.GetCardName());
                Console.WriteLine("Card type: " + creditCard.GetCardType());
                Console.WriteLine("Card current saldo: " + creditCard.GetCurrentSaldo());
                Console.WriteLine("Card age limit: " + creditCard.GetAgeLimit());
                Console.WriteLine("Card credit limit: " + creditCard.GetCreditLimit());
                Console.WriteLine("Card daily limit: " + creditCard.GetDailyLimit());
                Console.WriteLine("Card monthly limit: " + creditCard.GetMonthlyLimit());
                Console.WriteLine("Card expiry month: " + creditCard.GetExpiryMonth());
                Console.WriteLine("Card expiry year: " + creditCard.GetExpiryYear());
                Console.WriteLine();
            }
            #endregion

            #region ExtendedDebitCard

            List<ExtendedDebitCard> extendedDebitCards = new List<ExtendedDebitCard>();
            extendedDebitCards.Add(new Maestro(cardOwner, account));
            extendedDebitCards.Add(new VISAElectron(cardOwner, account));

            foreach (ExtendedDebitCard extendedDebitCard in extendedDebitCards)
            {
                Console.WriteLine("ACCOUNT");
                Console.WriteLine("Account number: " + account.GetAccountNumber());
                Console.WriteLine("Account registration number: " + account.GetRegistrationNumber());
                Console.WriteLine();
                Console.WriteLine("Extended DebitCard");
                Console.WriteLine("Card Number: " + extendedDebitCard.GenerateCardNumber());
                Console.WriteLine("Card name: " + extendedDebitCard.GetCardName());
                Console.WriteLine("Card type: " + extendedDebitCard.GetCardType());
                Console.WriteLine("Card current saldo: " + extendedDebitCard.GetCurrentSaldo());
                Console.WriteLine("Card age limit: " + extendedDebitCard.GetAgeLimit());
                Console.WriteLine("Card expiry month: " + extendedDebitCard.GetExpiryMonth());
                Console.WriteLine("Card expiry year: " + extendedDebitCard.GetExpiryYear());
                Console.WriteLine("Card is payable international: " + extendedDebitCard.IsPayableInternational());
                Console.WriteLine("Card is payable online: " + extendedDebitCard.IsPayableOnline());
                Console.WriteLine();
            }

            #endregion

            #region Debit card

            List<Card> cards = new List<Card>();
            cards.Add(new Hævekort(cardOwner, account));

            foreach (Card card in cards)
            {

                Console.WriteLine("ACCOUNT");
                Console.WriteLine("Account number: " + account.GetAccountNumber());
                Console.WriteLine("Account registration number: " + account.GetRegistrationNumber());
                Console.WriteLine();
                Console.WriteLine("Debit Card");
                Console.WriteLine("Card Number: " + card.GenerateCardNumber());
                Console.WriteLine("Card name: " + card.GetCardName());
                Console.WriteLine("Card type: " + card.GetCardType());
                Console.WriteLine("Card current saldo: " + card.GetCurrentSaldo());
                Console.WriteLine("Card age limit: " + card.GetAgeLimit());
            }

            #endregion
        }
    }
}
