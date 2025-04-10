using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVehicle
{
    /// <summary>
    /// Класс Автомобиль
    /// </summary>
    class Car:Vehicle
    {
        /// <summary>
        /// Оригинальное поле для авто
        /// (мощность автомобиля)
        /// </summary>
        private int power;
        /// <summary>
        /// Свойство для управления полем power
        /// </summary>
        public int Power { get; set; }
        /// <summary>
        /// Конструктор + унаследованный конструктор
        /// </summary>
        /// <param name="prise">цена</param>
        /// <param name="maxspeed">максимальная скорость</param>
        /// <param name="year">год выпуска</param>
        /// <param name="power">мощность</param>
        public Car(int prise, int maxspeed, int year, int power)
            : base(prise, maxspeed, year)
        {
            this.Power = power;
        }
    }
}
