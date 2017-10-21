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
        [TestCase("Открытое образование", TestName = "Тестирование Title при присваивании \"Открытое образование\".")]
        [TestCase("", ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Title при присваивании \"\".")]
        [TestCase("   ", ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Title при присваивании \"   \".")]
        [TestCase(null, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Title при присваивании null.")]
        public void TitleTest(string title)
        {
            var pub = new Magazine();
            pub.Title = title;
        }

        /// <summary>
        /// Метод для тестирования года издания номера журнала
        /// </summary>
        /// <param name="year">Год издания номера журнала</param>
        [Test]
        [TestCase(2018, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании 2017.")]
        [TestCase(2016, TestName = "Тестирование Year при присваивании 2016.")]
        [TestCase(1956, TestName = "Тестирование Year при присваивании 1956.")]
        [TestCase(1800, TestName = "Тестирование Year при присваивании 1800.")]
        [TestCase(1799, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании 1799.")]
        [TestCase(Int32.MaxValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании Int32.MaxValue.")]
        [TestCase(Int32.MinValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании Int32.MinValue.")]
        public void YearTest(int year)
        {
            var pub = new Magazine();
            pub.Year = year;
        }

        /// <summary>
        /// Метод для тестирования количества страниц номера журнала
        /// </summary>
        /// <param name="pages">Количество страниц номера журнала</param>
        [Test]
        [TestCase(100, TestName = "Тестирование Pages при присваивании 100.")]
        [TestCase(1000, TestName = "Тестирование Pages при присваивании 1000.")]
        [TestCase(Int32.MaxValue, TestName = "Тестирование Pages при присваивании Int32.MaxValue.")]
        [TestCase(Int32.MinValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Pages при присваивании Int32.MinValue.")]
        [TestCase(0, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Pages при присваивании 0.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Pages при присваивании -1.")]
        public void PagesTest(int pages)
        {
            var pub = new Magazine();
            pub.Pages = pages;
        }

        /// <summary>
        /// Метод для тестирования номера выпуска журнала
        /// </summary>
        /// <param name="number">Номер выпуска журнала</param>
        [Test]
        [TestCase(13, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Number при присваивании 13.")]
        [TestCase(12, TestName = "Тестирование Number при присваивании 12.")]
        [TestCase(6, TestName = "Тестирование Number при присваивании 6.")]
        [TestCase(1, TestName = "Тестирование Number при присваивании 1.")]
        [TestCase(0, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Number при присваивании 0.")]
        [TestCase(Int32.MaxValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Number при присваивании Int32.MaxValue.")]
        [TestCase(Int32.MinValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Number при присваивании Int32.MinValue.")]
        public void NumberTest(int number)
        {
            var pub = new Magazine();
            pub.Number = number;
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
        [TestCase(null, 2016, 6, 100, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование ToString, когда не заполнено поле Title.")]
        [TestCase("Открытое образование", 0, 6, 100, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование ToString, когда не заполнено поле Year.")]
        [TestCase("Открытое образование", 2016, 0, 100, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование ToString, когда не заполнено поле Number.")]
        [TestCase("Открытое образование", 2016, 6, 0, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование ToString, когда не заполнено поле Pages.")]
        public string ToStringTest(string title, int year, int number, int pages)
        {
            var pub = new Magazine();
            pub.Title = title;
            pub.Year = year;
            pub.Number = number;
            pub.Pages = pages;
            return pub.ToString();
        }
    }
}