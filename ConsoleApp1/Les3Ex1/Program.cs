using System;

namespace Les3Ex1
{
    //Ронжин Леонид
    //В класс банковский счет, созданный в упражнениях добавить метод, который переводит деньги с одного счета на другой.
    //У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstAccount = new BankAccount(1000, AccountType.Deposit);
            Console.WriteLine(firstAccount);
            var secondAccount = new BankAccount(1000, AccountType.Deposit);
            Console.WriteLine(secondAccount);
            firstAccount.TransferFrom(secondAccount, 500);
            Console.WriteLine(firstAccount);
            Console.WriteLine(secondAccount);
            firstAccount.TransferFrom(secondAccount, 500);
            Console.WriteLine(firstAccount);
            Console.WriteLine(secondAccount);
            firstAccount.TransferFrom(secondAccount, 500);
            Console.WriteLine(firstAccount);
            Console.WriteLine(secondAccount);

            firstAccount.TransferFrom(firstAccount, 500);
            Console.WriteLine(firstAccount);
            //Console.WriteLine($"Снято со счета: {account.RemoveFromBalance(750)}");
            //Console.WriteLine(account);
            //Console.WriteLine($"Снято со счета: {account.RemoveFromBalance(750)}");
            //Console.WriteLine(account);
            //Console.WriteLine($"Снято со счета: {account.RemoveFromBalance(750)}");
            //Console.WriteLine(account);
        }
    }
}
