using System;

namespace Les6Ex1
{
    public class BankAccount
    {
        private int _id = 0;
        private static int _countAccount = 0;
        private decimal _balance;
        private AccountType _accountType;

        public BankAccount()
        {
            GetNextId();
            _balance = 0;
            _accountType = AccountType.Deposit;
        }

        public BankAccount(decimal balance)
        {
            GetNextId();
            _balance = balance;
            _accountType = AccountType.Deposit;
        }

        public BankAccount(AccountType accountType)
        {
            GetNextId();
            _balance = 0;
            _accountType = accountType;
        }

        public BankAccount(decimal balance, AccountType accountType)
        {
            GetNextId();
            _balance = balance;
            _accountType = accountType;
        }
        public BankAccount(int id, decimal balance, AccountType accountType)
        {
            _id = id;
            _balance = balance;
            _accountType = accountType;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        public AccountType AccountType
        {
            get
            {
                return _accountType;
            }
        }

        private void GetNextId()
        {
            _id = ++_countAccount;
        }

        public decimal RemoveFromBalance(decimal money)
        {
            if (_balance < money) return 0;
            _balance -= money;
            return money;
        }

        public void PutOnBalance(decimal money)
        {
            _balance += money;
        }

        public bool TransferFrom(BankAccount bankAccount, decimal money)
        {
            if (bankAccount == null ||
                _id == bankAccount.Id ||
                bankAccount.RemoveFromBalance(money) == 0) return false;
            PutOnBalance(money);
            return true;
        }

        public static bool operator ==(BankAccount x, BankAccount y)
        {
            return !(x is null) && !(y is null) && x.Id == y.Id && x.AccountType == y.AccountType && x.Balance == y.Balance;
        }

        public static bool operator !=(BankAccount x, BankAccount y)
        {
            return !(x == y);
        }

        public override bool Equals(object? obj)
        {
            return obj is BankAccount bankAccount && bankAccount.Id == _id && bankAccount.AccountType == _accountType && bankAccount.Balance == _balance;
        }

        protected bool Equals(BankAccount other)
        {
            return _id == other.Id && _accountType == other.AccountType && _balance == other.Balance;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, AccountType, Balance);
        }

        public override string ToString()
        {
            return $"Номер счета: {_id}; Тип счета: {_accountType}; Остаток на текущий момент, руб.: {_balance}.";
        }
    }
}
