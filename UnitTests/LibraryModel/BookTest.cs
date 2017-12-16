using System;
using NUnit.Framework;
using LibraryModel;

namespace UnitTests.LibraryModel
{
    /// <summary>
	/// Класс для тестирования библиотечных карточек книг
	/// </summary>
	[TestFixture]
    public class BookTest
    {
        /// <summary>
        /// Метод для тестирования названия книги
        /// </summary>
        /// <param name="title">Название книги</param>
        [Test]
        [TestCase("Мастер и Маргарита", TestName = "Тестирование Title при присваивании \"Мастер и Маргарита\".")]
        public void TitleTest(string title)
        {
            var pub = new Book
            {
                Title = title
            };
        }

        /// <summary>
        /// Метод для тестирования ошибок названия книги
        /// </summary>
        [Test]
        public void TitleErrorsTest()
        {
            var pub = new Book();
            Assert.Throws<NullReferenceException>(() => pub.Title = "");
            Assert.Throws<NullReferenceException>(() => pub.Title = "   ");
            Assert.Throws<NullReferenceException>(() => pub.Title = null);
        }

        /// <summary>
        /// Метод для тестирования года издания книги
        /// </summary>
        /// <param name="year">Год издания книги</param>
        [Test]
        [TestCase(2016, TestName = "Тестирование Year при присваивании 2016.")]
        [TestCase(1800, TestName = "Тестирование Year при присваивании 1800.")]
        public void YearTest(int year)
        {
            var pub = new Book
            {
                Year = year
            };
        }

        /// <summary>
        /// Метод для тестирования ошибок при присвоении года издания номера журнала
        /// </summary>
        [Test]
        public void YearErrorsTest()
        {
            var pub = new Book();
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = DateTime.Now.Year + 1);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = 1799);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = Int32.MaxValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Year = Int32.MinValue);
        }

        /// <summary>
        /// Метод для тестирования количества страниц книги
        /// </summary>
        /// <param name="pages">Количество страниц книги</param>
        [Test]
        [TestCase(100, TestName = "Тестирование Pages при присваивании 100.")]
        [TestCase(1000, TestName = "Тестирование Pages при присваивании 1000.")]
        [TestCase(Int32.MaxValue, TestName = "Тестирование Pages при присваивании Int32.MaxValue.")]
        public void PagesTest(int pages)
        {
            var pub = new Book
            {
                Pages = pages
            };
        }

        /// <summary>
        /// Метод для тестирования ошибок при присвоении количества страниц книги
        /// </summary>
        [Test]
        public void PageErrorsErrors()
        {
            var pub = new Book();
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Pages = 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Pages = Int32.MinValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => pub.Pages = -1);
        }

        /// <summary>
        /// Метод для тестирования списка авторов
        /// </summary>
        /// <param name="authors">Список авторов, разделенных запятыми</param>
        [Test]
        [TestCase("Михаил Булгаков", TestName = "Тестирование Authors при присваивании \"Михаил Булгаков\".")]
        [TestCase("", TestName = "Тестирование Authors при присваивании \"\".")]
        public void AuthorsTest(string authors)
        {
            var pub = new Book
            {
                Authors = authors
            };
        }

        /// <summary>
        /// Метод для тестирования ошибок при назначении списка авторов
        /// </summary>
        [Test]
        public void AuthorsErrorsTest()
        {
            var pub = new Book();
            Assert.Throws<NullReferenceException>(() => pub.Authors = null);

        }

        /// <summary>
        /// Метод для тестирования издательства, выпустившего книгу
        /// </summary>
        /// <param name="publisher">Наименование издательства</param>
        [Test]
        [TestCase("Художественная литература", TestName = "Тестирование Publishing при присваивании \"Художественная литература\".")]
        public void PublisherTest(string publisher)
        {
            var pub = new Book
            {
                Publisher = publisher
            };
        }
 

        /// <summary>
        /// Метод для тестирования ошибок назначения издательства, выпустившего книгу
        /// </summary>
        [Test]
        public void PublisherErrorTest()
        {
            var pub = new Book();
            Assert.Throws<NullReferenceException>(() => pub.Publisher = "");
            Assert.Throws<NullReferenceException>(() => pub.Publisher= "   ");
            Assert.Throws<NullReferenceException>(() => pub.Publisher = null);
        }

        /// <summary>
        /// Метод для тестирования формирования информации о книге в соответствии с ОС ТУСУР 01-2013
        /// </summary>
        /// <param name="authors">Список авторов, разделенных запятыми</param>
        /// <param name="title">Название книги</param>
        /// <param name="publishing">Наименование издательства</param>
        /// <param name="year">Год издания книги</param>
        /// <param name="pages">Количество страниц книги</param>
        [Test]
        [TestCase("Михаил Булгаков", "Мастер и Маргарита", "Художественная литература", 2016, 500, TestName = "Тестирование ToString, когда все поля карточки заполнены.", ExpectedResult = "Михаил, Булгаков. Мастер и Маргарита / Булгаков Михаил. - Художественная литература, 2016. - 500 с.")]
        public string FormatTest(string authors, string title, string publishing, int year, int pages)
        {
            var pub = new Book
            {
                Authors = authors,
                Publisher = publishing,
                Title = title,
                Year = year,
                Pages = pages
            };
            return pub.Format();
        }


        private string SetFormatData(string authors, string title, string publishing, int year, int pages) {
            var pub = new Book
            {
                Authors = authors,
                Publisher = publishing,
                Title = title,
                Year = year,
                Pages = pages
            };
            return pub.Format();
        }

        /// <summary>
        /// Метод для тестирования ошибок формирования информации о книге в соответствии с ОС ТУСУР 01-2013
        /// </summary>
        [Test]
        public void FormatErrorsTest()
        {
            Assert.Throws<NullReferenceException>(() => SetFormatData(null, "Мастер и Маргарита", "Художественная литература", 2016, 500));
            Assert.Throws<NullReferenceException>(() => SetFormatData("Михаил Булгаков", null, "Художественная литература", 2016, 500));
            Assert.Throws<NullReferenceException>(() => SetFormatData("Михаил Булгаков", "Мастер и Маргарита", null, 2016, 500));
            Assert.Throws<ArgumentOutOfRangeException>(() => SetFormatData("Михаил Булгаков", "Мастер и Маргарита", "Художественная литература", 0, 500));
            Assert.Throws<ArgumentOutOfRangeException>(() => SetFormatData("Михаил Булгаков", "Мастер и Маргарита", "Художественная литература", 2016, 0));
        }
    }
}
