using MyLibrary;
using System;

namespace Les2Ex3
{
    //Ронжин Леонид.
    //3. В классе банковский счет удалить методы заполнения полей.Вместо этих методов создать конструкторы.
    //Переопределить конструктор по умолчанию,
    //создать конструктор для заполнения поля баланс,
    //конструктор для заполнения поля тип банковского счета,
    //конструктор для заполнения баланса и типа банковского счета.
    //Каждый конструктор должен вызывать метод, генерирующий номер счета.
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine(account);
            account = new BankAccount(1000);
            Console.WriteLine(account);
            account = new BankAccount(AccountType.Credit);
            Console.WriteLine(account);
            account = new BankAccount(1000, AccountType.Calculated);
            Console.WriteLine(account);

            Console.ReadKey();
        }
    }
}
