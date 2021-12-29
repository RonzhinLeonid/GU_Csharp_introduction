using System;
using Data;

namespace Les4Ex1
{
    //Ронжин Леонид
    //Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).
    //Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
    //Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
    //Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
    //Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
    //и предусмотреть метод, который увеличивал бы значение этого поля.
    internal class Program
    {
        static void Main(string[] args)
        {
            var creator = new Creator();
            var building = creator.CreateBuild(30, 10, 1500, 10);

            Console.WriteLine(building);
            Console.WriteLine();
            Console.WriteLine("Количество квартир на этаже: " + building.GetApartmentCountInFloor());
            Console.WriteLine("Количество квартир в подъезде: " + building.GetApartmentCountInEntrance());
            Console.WriteLine("Высота этажа: " + building.GetFloorHeight() + "м\n");

            var building2 = creator.CreateBuild(30, 10, 1500, 10);

            var building3 = creator.CreateBuild(1, 10, 1500, 10);
            // убедимся, что id увеличивается

            for (int i = 0; i < 100; i++)
            {
                var building4 = creator.CreateBuild(30, 10, 1500, 10);
                Console.WriteLine(building4.ID);
            }
        }
    }
}
