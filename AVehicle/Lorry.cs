using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVehicle
{
     /// <summary>
     /// Класс Грузовик
     /// </summary>
    class Lorry:Vehicle
    {
        /// <summary>
        /// Специфическое поле для грузовика
        /// (максимальная емкость)
        /// </summary>
        private int maxCapacity;
        /// <summary>
        /// Свойство для управления полем maxCapacity
        /// </summary>
        public int MaxCapacity { get; set; }
        /// <summary>
        /// Конструктор + унаследованный конструктор
        /// </summary>
        /// <param name="prise">цена</param>
        /// <param name="maxspeed">максимальная скорость</param>
        /// <param name="year">год выпуска</param>
        /// <param name="maxCapacity">максимальная емкость</param>
        public Lorry(int prise, int maxspeed, int year, int maxCapacity)
            : base(prise, maxspeed, year)
        {
            this.MaxCapacity = maxCapacity;
        }
    }
}
