using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class Mastercard : Card, IExpiryDate, IDailyLimit, IMonthlyLimit, IMaxCredit
    {
        public DateTime ExpireDate { get; set; }
        public int DailyLimit { get; set; }
        public int MonthlyLimit { get; set; }
        public int MaxCredit { get; set; }

        Random random = new Random();
        public Mastercard(string cardOwner, string cardName) : base(cardOwner, cardName)
        {
            Prefix = new string[]
            {
                "51",
                "52",
                "53",
                "54",
                "55",

            };
            MonthlyLimit = 30000;
            DailyLimit = 5000;
            MaxCredit = 40000;
            ExpireDate = DateTime.Now.AddYears(random.Next(1, 6));
        }
        public override string ToString()
        {
            return base.ToString() + $"\nMonthly limit: {MonthlyLimit}\nDaily Limit: {DailyLimit}\nMax credit: {MaxCredit}\nExprity date: {ExpireDate}";
        }
    }
}
