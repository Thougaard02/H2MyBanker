using System;
using System.Collections.Generic;
using System.Text;

namespace H2MyBanker.Cards
{
    public class DebitCard : Card
    {
        public DebitCard(string cardOwner) : base(cardOwner)
        {
            CardName = "Debit card";
            Prefix = new string[]
            {
                "2400",
            };
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
