using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class NewAccountTests
    {
        [Fact]
        public void NewAccountsHaveCorrectBlance()
        {
            // "WTCYWYH" "Write the code you wish you hd
            //given I have a brand new bank account 
            var account = new BankAccount(new DummyBonusCalculator());
            //When I retrive the balance
            decimal balance = account.GetBalance();
            //it has a balance of $5,000

            Assert.Equal(5000M, balance);
        }
    }
}


// "Test Per Type" - BankAccount -> BankAccountTests, Customer -> CustomerTests