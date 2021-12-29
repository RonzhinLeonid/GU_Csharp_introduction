using Data.Abstract;
using System;

namespace Data
{
    public class Building : IBuilder
    {
        readonly long _id;
        static long _nextId;
        int _height;
        int _floorCount;
        int _apartmentCount;
        int _entranceCount;

        public long ID => _id;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                ChangeHeight(value);
            }
        }
        public int FloorCount
        {
            get
            {
                return _floorCount;
            }
            set
            {
                ChangeFloorCount(value);
            }
        }
        public int ApartmentCount
        {
            get
            {
                return _apartmentCount;
            }
            set
            {
                ChangeApartmentCount(value);
            }
        }
        public int EntranceCount
        {
            get
            {
                return _entranceCount;
            }
            set
            {
                ChangeEntranceCount(value);
            }
        }

        public Building()
        {
            _id = GetNextId();
        }

        public Building(int height, int floors, int apartments, int entrances) : this()
        {
            if (height <= 0 || floors <= 0 || apartments <= 0 || entrances <= 0)
            {
                throw new Exception("Ни один параметр здания не может быть равен нулю либо быть меньше нуля");
            }

            _height = height;
            _floorCount = floors;
            _apartmentCount = apartments;
            _entranceCount = entrances;
        }

        /// <summary>
        /// Изменение высоты дома
        /// </summary>
        /// <param name="newHeight">Новое значение высоты</param>
        public void ChangeHeight(int newHeight)
        {
            if (newHeight <= 0)
            {
                throw new Exception("Высота здания должна быть больше нуля");
            }
            _height = newHeight;
        }

        /// <summary>
        /// Изменение числа этажей
        /// </summary>
        /// <param name="newCount">Новое количество этажей</param>
        public void ChangeFloorCount(int newCount)
        {
            if (newCount <= 0)
            {
                throw new Exception("Количество этажей здания должно быть больше нуля");
            }
            _floorCount = newCount;
        }

        /// <summary>
        /// Изменение числа квартир
        /// </summary>
        /// <param name="newCount">Новое количество квартир</param>
        public void ChangeApartmentCount(int newCount)
        {
            if (newCount <= 0)
            {
                throw new Exception("Количество квартир в здании должно быть больше нуля");
            }
            _apartmentCount = newCount;
        }

        /// <summary>
        /// Изменение числа подъездов
        /// </summary>
        /// <param name="newCount">Новое количество подъездов</param>
        public void ChangeEntranceCount(int newCount)
        {
            if (newCount <= 0)
            {
                throw new Exception("Количество подъездов в здании должно быть больше нуля");
            }
            _entranceCount = newCount;
        }

        /// <summary>
        /// Вычисление высоты одного этажа
        /// </summary>
        /// <returns>Высота одного этажа</returns>
        public double GetFloorHeight()
        {
            return _height / _floorCount;
        }
        //количества квартир в подъезде, количества квартир на этаже и т.д.

        /// <summary>
        /// Вычисление количества квартир в подъезде
        /// </summary>
        /// <returns>Количество квартир на этаже</returns>
        public int GetApartmentCountInEntrance()
        {
            return _apartmentCount % _entranceCount > 0
                ? _apartmentCount / _entranceCount + 1
                : _apartmentCount / _entranceCount;
        }

        /// <summary>
        /// Вычисление количества квартир на этаже
        /// </summary>
        /// <returns>Количество квартир на этаже</returns>
        public int GetApartmentCountInFloor()
        {
            return _apartmentCount % _floorCount > 0
                ? _apartmentCount / _floorCount + 1
                : _apartmentCount / _floorCount;
        }

        /// <summary>
        /// Получение уникального id дома
        /// </summary>
        /// <returns>iid дома</returns>
        private long GetNextId()
        {
            return ++_nextId;
        }

        public override string ToString()
        {
            return $"id: {_id},\n" +
                   $"Высота здания: {_height} м,\n" +
                   $"Количество квартир: {_apartmentCount},\n" +
                   $"Количество этажей: {_floorCount},\n" +
                   $"Количество подъездов: {_entranceCount}.";
        }
    }
}
