using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class VisaElectron : Card, IExpiryDate, IInternational, IPayableOnline, IMonthlyLimit
    {
        public DateTime ExprityDate { get; set; }
        public bool IsInternational { get; set; }
        public bool IsPayableOnline { get; set; }
        public int MonthlyLimit { get; set; }
        Random random = new Random();

        public VisaElectron(string cardOwner, string cardName) : base(cardOwner, cardName)
        {
            Prefix = new string[]
            {
                "4026",
                "417500",
                "4508",
                "4844",
                "4913",
                "4917",
            };
            ExprityDate = DateTime.Now.AddYears(random.Next(1, 6));
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Exprity date:" + ExprityDate;
        }
    }
}
