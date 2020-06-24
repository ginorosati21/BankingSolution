using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class BankAccountWithdraw
    {
        [Fact]
        public void WithdrawingMoneyDecreasesTheBalance()
        {
            //Given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 500M;

            //When
            account.Withdraw(amountToWithdraw);

            //Then
            var expectedBalance = openingBalance - amountToWithdraw;
            Assert.Equal(expectedBalance, account.GetBalance());
        }

        [Fact]
        public void YouCanTakeAllYourMoney()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            account.Withdraw(openingBalance);

            Assert.Equal(0, account.GetBalance());
        }
    }
}
