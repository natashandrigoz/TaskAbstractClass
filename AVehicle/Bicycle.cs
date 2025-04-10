using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVehicle
{
    /// <summary>
    /// Класс Велосипед
    /// </summary>
    class Bicycle:Vehicle
    {
        /// <summary>
        /// Оригинальное поле для велосипедов
        /// (количество пассажиров)
        /// </summary>
        private int maxPassengers;
        /// <summary>
        /// Свойство для управления полем maxPassengers
        /// </summary>
        public int MaxPassengers { get; set; }
        /// <summary>
        /// Конструктор + конструктор базового класса
        /// </summary>
        /// <param name="prise">цена</param>
        /// <param name="maxspeed">максимальная скорость</param>
        /// <param name="year">год выпуска</param>
        /// <param name="maxPassengers">количество пассажиров</param>
        public Bicycle(int prise, int maxspeed, int year, int maxPassengers) 
            : base(prise, maxspeed, year)
        {
            this.MaxPassengers = maxPassengers;
        }
    }
}
