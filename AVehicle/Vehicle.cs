using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVehicle
{
    /// <summary>
    /// Абстрактный класс Транспортное средство
    /// </summary>
    abstract class Vehicle
    {
        /// <summary>
        /// Исключения для классов наследников
        /// </summary>
        protected Exception OutOfMaxBorder = new Exception("Исключение, превышена максимальна граница");
        protected Exception NonBellowZero = new Exception("Исключение, введенное значение не может быть отрицательным!");
        /// <summary>
        /// Защищенные поля цены, максимальной скорости, год выпуска,
        /// которые управляются соответствующими свойствами
        /// </summary>
        protected int price, maxspeed, year;
        /// <summary>
        /// Свойство Цена, которое управляет полем price
        /// </summary>
        public int Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        /// <summary>
        /// Свойство Максимальная скорость, 
        /// которое управляет полем maxspeed
        /// </summary>
        public int Maxspeed
        {
            get { return maxspeed; }
            set { if (value > 0) maxspeed = value; }
        }
        /// <summary>
        /// Свойство Год выпуска, которое 
        /// управляет полем year
        /// </summary>
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }
        /// <summary>
        /// Конструктор 1 без параметров для инициализации полей
        /// экземпляра класса значениями по умолчанию
        /// </summary>
        public Vehicle() { }
        /// <summary>
        /// Конструктор 2 с параметрами для инициализации
        /// полей экземпляра класса 
        /// </summary>
        /// <param name="price">цена</param>
        /// <param name="maxspeed">максимальная скорость</param>
        /// <param name="year">год выпуска</param>
        public Vehicle(int price, int maxspeed, int year)
        {
            this.Price = price;
            this.Maxspeed = maxspeed;
            this.Year = year;
        }
    }
}
