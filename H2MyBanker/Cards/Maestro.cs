using H2MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class Maestro : Card, IExpiryDate
    {
        public DateTime ExprityDate { get; set; }

        public Maestro(string cardOwner, string cardName) : base(cardOwner, cardName)
        {
            Prefix = new string[]
            {
                "5018",
                "5020",
                "5038",
                "5893",
                "6304",
                "6759",
                "6761",
                "6762",
                "6763",
            };
            CardNumberLenght = 19;
            ExprityDate = DateTime.Now.AddYears(5).AddMonths(8);
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Exprity date:" + ExprityDate;
        }
    }
}
