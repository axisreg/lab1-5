using System;

namespace LibraryModel
{
    /// <summary>
    /// Класс, описывающий библиотечную карточку
    /// </summary>
    [Serializable]
    public abstract class LibraryCard
    {
        private string _title;
        private int _year;
        private int _pages;

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

        public abstract string Format();
    }
}
