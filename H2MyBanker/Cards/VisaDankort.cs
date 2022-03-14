using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class VisaDankort : Card, IExpiryDate, IMonthlyLimit
    {
        public DateTime ExprityDate { get; set; }
        public int MonthlyLimit { get; set; }
        Random random = new Random();
        public VisaDankort(string cardOwner, string cardName) : base(cardOwner, cardName)
        {
            Prefix = new string[]
            {
                "4"
            };
            ExprityDate = DateTime.Now.AddYears(random.Next(1, 6));
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Exprity date: " + ExprityDate;
        }
    }
}
