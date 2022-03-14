using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class VisaDankort : Card, IExpiryDate, IMonthlyLimit
    {
        public DateTime ExpireDate { get; set; }
        public int MonthlyLimit { get; set; }
        Random random = new Random();
        public VisaDankort(string cardOwner, string cardName) : base(cardOwner, cardName)
        {
            Prefix = new string[]
            {
                "4"
            };
            ExpireDate = DateTime.Now.AddYears(random.Next(1, 6));
            MonthlyLimit = 25000;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMonthly limit: {MonthlyLimit}\nExprity date: {ExpireDate}";
        }
    }
}
