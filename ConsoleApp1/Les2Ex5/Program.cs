using MyLibrary;
using System;

namespace Les2Ex5
{
    //Ронжин Леонид.
    //5. * Добавить в класс счет в банке два метода: снять со счета и положить на счет.Метод снять со счета проверяет,
    //возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.

    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(1000, AccountType.Deposit);
            account.PutOnBalance(1000);
            Console.WriteLine(account);
            Console.WriteLine($"Снято со счета: {account.RemoveFromBalance(750)}");
            Console.WriteLine(account);
            Console.WriteLine($"Снято со счета: {account.RemoveFromBalance(750)}");
            Console.WriteLine(account);
            Console.WriteLine($"Снято со счета: {account.RemoveFromBalance(750)}");
            Console.WriteLine(account);
        }
    }
}
