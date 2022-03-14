using H2MyBanker.Cards;
using System;

namespace H2MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Card maestro = new Maestro("Rasmus", "Maestro");
            Card visaElectron = new VisaElectron("Daniel", "Visa Electron");
            Card mastercard = new Mastercard("Benjamin", "Master card");
            Card debitcard = new DebitCard("Mikkel", "Debit card");
            Card visaDankort = new VisaDankort("Kris", "Visa Dankort");

            Console.WriteLine(maestro.ToString());
            Console.WriteLine("#############################\n");
            Console.WriteLine(visaElectron.ToString());
            Console.WriteLine("#############################\n");
            Console.WriteLine(mastercard.ToString());
            Console.WriteLine("#############################\n");
            Console.WriteLine(debitcard.ToString());
            Console.WriteLine("#############################\n");
            Console.WriteLine(visaDankort.ToString());
        }
    }
}
