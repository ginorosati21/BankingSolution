using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class BankAccountWithdraw
    {

        private decimal _openingBalance;
        private BankAccount _account;

        public BankAccountWithdraw()
        {
            _account = new BankAccount(new DummyBonusCalculator());
            _openingBalance = _account.GetBalance();
        }


        [Fact]
        public void WithdrawingMoneyDecreasesTheBalance()
        {
            //Given
            
            var amountToWithdraw = 500M;

            //When
            _account.Withdraw(amountToWithdraw);

            //Then
            var expectedBalance = _openingBalance - amountToWithdraw;
            Assert.Equal(expectedBalance, _account.GetBalance());
        }

        [Fact]
        public void YouCanTakeAllYourMoney()
        {
            

            _account.Withdraw(_openingBalance);

            Assert.Equal(0, _account.GetBalance());
        }
    }
}
