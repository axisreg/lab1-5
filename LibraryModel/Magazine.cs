﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    /// <summary>
    /// Класс, описывающий библиотечную карточку журнала
    /// </summary>
    [Serializable]
    public class Magazine : LibraryCard
    {
        private int _number;

        public Magazine() {
        }

        public Magazine(string title, int year, int pages, int number)
        {
            Title = title;
            Pages = pages;
            Year = year;
            Number = number;
        }

        /// <summary>
		/// Номер выпуска
		/// </summary>
		public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Номер журнала должен лежать в диапазоне от 1 до 12!");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Формирование информации о выпуске журнала
        /// </summary>
        /// <returns>Информация о выпуске журнала в соответствии с ОС ТУСУР 01-2013</returns>
        override public string format()
        {
            return String.Format("{0}. - {1}. - № {2}. - {3} с.", _title, _year, _number, _pages);
        }

        public override string ToString() {
            return format();
        }
    }
}
