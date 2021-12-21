using MyLibrary;

namespace Les2Ex2
{
    public class BankAccount
    {
        private static int _id = 0;
        private decimal _balance;
        private AccountType _accountType;

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
            set
            {
                _balance = value;
            }
        }

        public AccountType AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                GetNextId();
                _accountType = AccountType;
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
