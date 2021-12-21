using MyLibrary;
using System;

namespace Les2Ex2
{
    //Ронжин Леонид.
    //2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
    //Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var account = new BankAccount
                {
                    Balance = 1000,
                    AccountType = AccountType.Current
                };
                Console.WriteLine(account);
            }
            Console.ReadKey();
        }
    }
}
