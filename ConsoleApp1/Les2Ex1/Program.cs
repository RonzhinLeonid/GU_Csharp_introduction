using MyLibrary;
using System;

namespace Les2Ex1
{
    //Ронжин Леонид.
    //1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
    //Предусмотреть методы для доступа к данным – заполнения и чтения.
    //Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount
            {
                Id = 1,
                Balance = 1000,
                AccountType = AccountType.Current
            };
            Console.WriteLine(account);
            Console.ReadKey();
        }
    }
}
