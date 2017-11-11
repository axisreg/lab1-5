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
        //[TestCase("", ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Title при присваивании \"\".")]
        //[TestCase("   ", ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Title при присваивании \"   \".")]
        //[TestCase(null, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Title при присваивании null.")]
        public void TitleTest(string title)
        {
            var pub = new Book();
            pub.Title = title;
            pub.Title = "Мастер и маргарита";
            Assert.That(pub.Title, Is.EqualTo("Мастер и маргарита"));
            Assert.Throws<NullReferenceException>(() => pub.Title = "");
            Assert.Throws<NullReferenceException>(() => pub.Title = "   ");
            Assert.Throws<NullReferenceException>(() => pub.Title = null);
        }

        /// <summary>
        /// Метод для тестирования года издания книги
        /// </summary>
        /// <param name="year">Год издания книги</param>
        [Test]
        //[TestCase(2018, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании 2017.")]
        [TestCase(2016, TestName = "Тестирование Year при присваивании 2016.")]
        [TestCase(1800, TestName = "Тестирование Year при присваивании 1800.")]
        //[TestCase(1799, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании 1799.")]
        //[TestCase(Int32.MaxValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании Int32.MaxValue.")]
       // [TestCase(Int32.MinValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Year при присваивании Int32.MinValue.")]
        public void YearTest(int year)
        {
            var pub = new Book();
            pub.Year = year;
        }

        /// <summary>
        /// Метод для тестирования количества страниц книги
        /// </summary>
        /// <param name="pages">Количество страниц книги</param>
        [Test]
        [TestCase(100, TestName = "Тестирование Pages при присваивании 100.")]
        [TestCase(1000, TestName = "Тестирование Pages при присваивании 1000.")]
        [TestCase(Int32.MaxValue, TestName = "Тестирование Pages при присваивании Int32.MaxValue.")]
        //[TestCase(Int32.MinValue, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Pages при присваивании Int32.MinValue.")]
        //[TestCase(0, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Pages при присваивании 0.")]
        //[TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование Pages при присваивании -1.")]
        public void PagesTest(int pages)
        {
            var pub = new Book();
            pub.Pages = pages;
        }

        /// <summary>
        /// Метод для тестирования списка авторов
        /// </summary>
        /// <param name="authors">Список авторов, разделенных запятыми</param>
        [Test]
        [TestCase("Михаил Булгаков", TestName = "Тестирование Authors при присваивании \"Михаил Булгаков\".")]
        [TestCase("", TestName = "Тестирование Authors при присваивании \"\".")]
        //[TestCase(null, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Authors при присваивании null.")]
        public void AuthorsTest(string authors)
        {
            var pub = new Book();
            pub.Authors = authors;
        }

        /// <summary>
        /// Метод для тестирования издательства, выпустившего книгу
        /// </summary>
        /// <param name="publishing">Наименование издательства</param>
        [Test]
        [TestCase("Художественная литература", TestName = "Тестирование Publishing при присваивании \"Художественная литература\".")]
        //[TestCase("", ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Publishing при присваивании \"\".")]
        //[TestCase("   ", ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Publishing при присваивании \"   \".")]
       // [TestCase(null, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование Publishing при присваивании null.")]
        public void PublisherTest(string publishing)
        {
            var pub = new Book();
            pub.Publisher = publishing;
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
        //[TestCase(null, "Мастер и Маргарита", "Художественная литература", 2016, 500, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование ToString, когда не заполнено поле Authors.")]
        //[TestCase("Михаил Булгаков", null, "Художественная литература", 2016, 500, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование ToString, когда не заполнено поле Title.")]
        //[TestCase("Михаил Булгаков", "Мастер и Маргарита", null, 2016, 500, ExpectedException = typeof(NullReferenceException), TestName = "Тестирование ToString, когда не заполнено поле Publishing.")]
        //[TestCase("Михаил Булгаков", "Мастер и Маргарита", "Художественная литература", 0, 500, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование ToString, когда не заполнено поле Year.")]
       // [TestCase("Михаил Булгаков", "Мастер и Маргарита", "Художественная литература", 2016, 0, ExpectedException = typeof(ArgumentOutOfRangeException), TestName = "Тестирование ToString, когда не заполнено поле Pages.")]
        public string ToStringTest(string authors, string title, string publishing, int year, int pages)
        {
            var pub = new Book();
            pub.Authors = authors;
            pub.Publisher = publishing;
            pub.Title = title;
            pub.Year = year;
            pub.Pages = pages;
            return pub.ToString();
        }
    }
}
