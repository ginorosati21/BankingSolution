﻿using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _currentBalance = 5000;
        private ICalculateBonuses _bonusCalculator;

        public BankAccount(ICalculateBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }

        public decimal GetBalance()
        {
            return _currentBalance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            decimal amountOfBonus = _bonusCalculator.GetDepostitBonusFor(amountToDeposit, _currentBalance);
            _currentBalance += amountToDeposit + amountOfBonus;

        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw <= _currentBalance)
            {
                _currentBalance -= amountToWithdraw;
            } else
            {
                throw new OverdraftException();
            }
            
        }
    }
}