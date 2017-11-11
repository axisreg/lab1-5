using System;
using NUnit.Framework;
using LibraryModel;

namespace UnitTests.LibraryModel
{
    /// <summary>
    /// Класс для тестирования библиотечных карточек выпусков журналов
    /// </summary>
    [TestFixture]
    public class MagazineTest
    {
        /// <summary>
        /// Метод для тестирования названия журнала
        /// </summary>
        /// <param name="title">Название журнала</param>
        [Test]
        [TestCase("Открытое образование", TestName = "Тестирование Title при присваивании валидного значения.")]
        public void TitleTest(string title)
        {
            var pub = new Magazine();
            pub.Title = title;
        }

        /// <summary>
        /// Метод для тестирования ошибок в названии журнала
        /// </summary>
        [Test]
        public void TitleTestErrors() {
            var pub = new Magazine();
            Assert.Throws<NullReferenceException>(() => pub.Title = "");
            Assert.Throws<NullReferenceException>(() => pub.Title = "   ");
            Assert.Throws<NullReferenceException>(() => pub.Title = null);
        }

        /// <summary>
        /// Метод для тестирования года издания номера журнала
        /// </summary>
        /// <param name="year">Год издания номера журнала</param>
        [Test]
        [TestCase(1800, TestName = "Тестирование Year при присваивании 1800.")]
        [TestCase(1959, TestName = "Тестирование Year при присваивании 1959.")]
        [TestCase(2017, TestName = "Тестирование Year при присваивании текущего года")]
        public void YearTest(int year)
        {
            var pub = new Magazine();
            pub.Year = year;
        }

        /// <summary>
        /// Метод для тестирования ошибок при присвоении года издания номера журнала
        /// </summary>
        [Test]
        public void YearTestErrors() {
            var pub = new Magazine();
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = DateTime.Now.Year + 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = 1799);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = Int32.MaxValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = Int32.MinValue);
        }

        /// <summary>
        /// Метод для тестирования количества страниц номера журнала
        /// </summary>
        /// <param name="pages">Количество страниц номера журнала</param>
        [Test]
        [TestCase(100, TestName = "Тестирование Pages при присваивании 100.")]
        [TestCase(1000, TestName = "Тестирование Pages при присваивании 1000.")]
        [TestCase(Int32.MaxValue, TestName = "Тестирование Pages при присваивании Int32.MaxValue.")]
        public void PagesTest(int pages)
        {
            var pub = new Magazine();
            pub.Pages = pages;
        }

        /// <summary>
        /// Метод для тестирования ошибок при присвоении количества страниц номера журнала
        /// </summary>
        [Test]
        public void PageTestErrors() {
            var pub = new Magazine();
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Pages = 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Pages = Int32.MinValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Pages = -1);
        }

        /// <summary>
        /// Метод для тестирования номера выпуска журнала
        /// </summary>
        /// <param name="number">Номер выпуска журнала</param>
        [Test]
        [TestCase(12, TestName = "Тестирование Number при присваивании 12.")]
        [TestCase(6, TestName = "Тестирование Number при присваивании 6.")]
        [TestCase(1, TestName = "Тестирование Number при присваивании 1.")]
        public void NumberTest(int number)
        {
            var pub = new Magazine();
            pub.Number = number;
        }

        /// <summary>
        /// Метод для тестирования ошибок номера выпуска журнала
        /// </summary>
        [Test]
        public void NumberTestErrors()
        {
            var pub = new Magazine();
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Number = 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Number = Int32.MinValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Number = Int32.MaxValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Number = 13);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Number = -1);
        }

        /// <summary>
        /// Метод для тестирования формирования информации о номере журнала в соответствии с ОС ТУСУР 01-2013
        /// </summary>
        /// <param name="title">Название журнала</param>
        /// <param name="year">Год издания номера журнала</param>
        /// <param name="number">Номер выпуска журнала</param>
        /// <param name="pages">Количество страниц номера журнала</param>
        [Test]
        [TestCase("Открытое образование", 2016, 6, 100, TestName = "Тестирование ToString, когда все поля карточки заполнены.", ExpectedResult = "Открытое образование. - 2016. - № 6. - 100 с.")]
        public string FormatTest(string title, int year, int number, int pages)
        {
            var pub = new Magazine();
            pub.Title = title;
            pub.Year = year;
            pub.Number = number;
            pub.Pages = pages;
            return pub.format();
        }


        private string setFormatData(string title, int year, int number, int pages) {
            var pub = new Magazine();
            pub.Title = title;
            pub.Year = year;
            pub.Number = number;
            pub.Pages = pages;
            return pub.format();
        }

        /// <summary>
        /// Метод для тестирования ошибок формирования информации о номере журнала в соответствии с ОС ТУСУР 01-2013
        /// </summary>
        [Test]
        public void FormatTestErrors()
        {
            Assert.Throws<NullReferenceException>(() => setFormatData(null, 2016, 6, 100));
            Assert.Throws<ArgumentOutOfRangeException>(() => setFormatData("Открытое образование", 0, 6, 100));
            Assert.Throws<ArgumentOutOfRangeException>(() => setFormatData("Открытое образование", 2016, 0, 100));
            Assert.Throws<ArgumentOutOfRangeException>(() => setFormatData("Открытое образование", 2016, 6, 0));
        }
    }
}