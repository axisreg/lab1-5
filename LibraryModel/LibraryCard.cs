using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    /// <summary>
    /// Класс, описывающий библиотечную карточку
    /// </summary>
    [Serializable] abstract public class LibraryCard
    {
        protected string _title;
        protected int _year;
        protected int _pages;

        /// <summary>
		/// Название издания
		/// </summary>
		public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Название издания не может быть пустым!");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Год выпуска издания
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1800 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Неверно указан год издания!");
                }
                _year = value;
            }
        }

        /// <summary>
        /// Количество страниц
        /// </summary>
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Количество страниц издания должно быть положительным числом!");
                }
                _pages = value;
            }
        }

        abstract public string Format();
    }



    //dissertation
    //collection

}
