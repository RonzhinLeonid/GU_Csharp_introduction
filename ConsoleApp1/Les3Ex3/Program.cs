﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Les3Ex3
{
    //Ронжин Леонид
    //(*) Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес.
    //Разделителем между ФИО и адресом электронной почты является символ &:
    //  Кучма Андрей Витальевич & Kuchma@mail.ru
    //  Мизинцев Павел Николаевич & Pasha@mail.ru
    //Сформировать новый файл, содержащий список адресов электронной почты.
    //Предусмотреть метод, выделяющий из строки адрес почты.
    //Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s:
    //  public void SearchMail (ref string s).
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new ReaderEmail("Data.txt", "eMails.txt");
            reader.GetFileEmail();
        }
    }
}