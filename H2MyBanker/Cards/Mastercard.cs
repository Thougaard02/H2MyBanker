using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class Mastercard : Card, IExpiryDate, IDailyLimit, IMonthlyLimit
    {
        public DateTime ExprityDate { get; set; }
        public int DailyLimit { get; set; }
        public int MonthlyLimit { get; set; }
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
            ExprityDate = DateTime.Now.AddYears(random.Next(1, 6));
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Exprity date:" + ExprityDate;
        }
    }
}
