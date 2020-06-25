using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingTests
{
    public class DummyBonusCalculator : ICalculateBonuses
    {
        public decimal GetDepostitBonusFor(decimal amountToDeposit, decimal currentBalance)
        {
            return 0;
        }
    }
}
