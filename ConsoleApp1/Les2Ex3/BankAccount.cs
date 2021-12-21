using MyLibrary;

namespace Les2Ex3
{
    public class BankAccount
    {
        private static int _id = 0;
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
            ++_id;
        }

        public override string ToString()
        {
            return $"Номер счета: {_id}; Тип счета: {_accountType}; Остаток на текущий момент, руб.: {_balance}.";
        }
    }
}
