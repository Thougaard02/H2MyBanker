using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class VisaElectron : Card, IExpiryDate, IInternational, IPayableOnline, IMonthlyLimit, IMaxCredit
    {
        public DateTime ExpireDate { get; set; }
        public bool IsInternational { get; set; }
        public bool IsPayableOnline { get; set; }
        public int MonthlyLimit { get; set; }
        public int MaxCredit { get; set; }

        Random random = new Random();

        public VisaElectron(string cardOwner) : base(cardOwner)
        {
            CardName = "Visa Electron";
            Prefix = new string[]
            {
                "4026",
                "417500",
                "4508",
                "4844",
                "4913",
                "4917",
            };
            MonthlyLimit = 10000;
            MaxCredit = 20000;
            IsInternational = true;
            IsPayableOnline = true;
            ExpireDate = DateTime.Now.AddYears(random.Next(1, 6));
        }
        public override string ToString()
        {
            return base.ToString() + $"\nMonthly limit: {MonthlyLimit}\nMax credit: {MaxCredit}\nInternational: {IsInternational}\nPayableOnline: {IsPayableOnline}\nExprity date: {ExpireDate}";
        }
    }
}
