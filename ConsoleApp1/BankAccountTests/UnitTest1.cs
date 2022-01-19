using System;
using Xunit;
using Les6Ex1;

namespace BankAccountTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 13123, AccountType.Calculated, 10, 13123, AccountType.Calculated)]
        [InlineData(20, 131534, AccountType.Credit, 20, 131534, AccountType.Credit)]
        [InlineData(30, 223525, AccountType.Current, 30, 223525, AccountType.Current)]
        public void BankAccount_OperatorEqual(int idFirst, decimal balanceFirst, AccountType accountTypeFirst, int IdSecond, int balanceSecond, AccountType accountTypeSecond)
        {
            BankAccount r1 = new BankAccount(idFirst, balanceFirst, accountTypeFirst);
            BankAccount r2 = new BankAccount(IdSecond, balanceSecond, accountTypeSecond);
            Assert.True(r1 == r2);
        }

        [Theory]
        [InlineData(10, 13123, AccountType.Calculated, 11, 13123, AccountType.Calculated)]
        [InlineData(20, 131534, AccountType.Credit, 20, 1315341, AccountType.Credit)]
        [InlineData(30, 223525, AccountType.Current, 30, 223525, AccountType.Deposit)]
        public void BankAccount_OperatorNotEqual(int idFirst, decimal balanceFirst, AccountType accountTypeFirst, int IdSecond, int balanceSecond, AccountType accountTypeSecond)
        {
            BankAccount r1 = new BankAccount(idFirst, balanceFirst, accountTypeFirst);
            BankAccount r2 = new BankAccount(IdSecond, balanceSecond, accountTypeSecond);
            Assert.True(r1 != r2);
        }
        [Theory]
        [InlineData(10, 13123, AccountType.Calculated, 10, 13123, AccountType.Calculated)]
        [InlineData(20, 131534, AccountType.Credit, 20, 131534, AccountType.Credit)]
        [InlineData(30, 223525, AccountType.Current, 30, 223525, AccountType.Current)]
        public void BankAccount_Equal(int idFirst, decimal balanceFirst, AccountType accountTypeFirst, int IdSecond, int balanceSecond, AccountType accountTypeSecond)
        {
            BankAccount r1 = new BankAccount(idFirst, balanceFirst, accountTypeFirst);
            BankAccount r2 = new BankAccount(IdSecond, balanceSecond, accountTypeSecond);
            Assert.Equal(r1, r2);
        }

        [Theory]
        [InlineData(10, 13123, AccountType.Calculated, 11, 13123, AccountType.Calculated)]
        [InlineData(20, 131534, AccountType.Credit, 20, 1315341, AccountType.Credit)]
        [InlineData(30, 223525, AccountType.Current, 30, 223525, AccountType.Deposit)]
        public void BankAccount_NotEqual(int idFirst, decimal balanceFirst, AccountType accountTypeFirst, int IdSecond, int balanceSecond, AccountType accountTypeSecond)
        {
            BankAccount r1 = new BankAccount(idFirst, balanceFirst, accountTypeFirst);
            BankAccount r2 = new BankAccount(IdSecond, balanceSecond, accountTypeSecond);
            Assert.NotEqual(r1, r2);
        }
    }
}
