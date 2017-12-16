using System;
using System.Collections.Generic;

namespace LibraryModel
{
    /// <summary>
    /// Класс, описывающий библиотечную карточку книги
    /// </summary>
    /// <inheritdoc cref="LibraryCard"/>
    [Serializable]
    public class Book : LibraryCard
    {
        private string _authors;
        private string _publisher;

        public Book() {
        }

        public Book(string title, int year, int pages, string authors, string publisher)
        {
            Title = title;
            Year = year;
            Pages = pages;
            Authors = authors;
            Publisher = publisher;
        }

        /// <summary>
        /// Список авторов книги
        /// </summary>
        public string Authors
        {
            get
            {
                return _authors;
            }
            set
            {
                _authors = value ?? throw new NullReferenceException("Список авторов не может быть пустым!");
            }
        }

        /// <summary>
        /// Издательство, выпустившее книгу
        /// </summary>
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Издательство книги не может быть пустым!");
                }
                _publisher = value;
            }
        }

        /// <summary>
        /// Формирование информации о книге
        /// </summary>
        /// <returns>Информация о книге в соответствии с ОС ТУСУР 01-2013</returns>
        public override string Format()
        {
            var mauth = String.Empty;
            var fauth = String.Empty;
            if (!String.IsNullOrWhiteSpace(_authors))
            {
                var allAuthors = new List<string>(_authors.Split(','));
                var oneAuthor = new List<string>(allAuthors[0].Trim().Split(' '));
                if (allAuthors.Count <= 3)
                {
                    if (oneAuthor.Count > 1) oneAuthor[0] += ",";
                    mauth = String.Join(" ", oneAuthor);
                    if (mauth[mauth.Length - 1] != '.') mauth += ".";
                    mauth += " ";
                    foreach (var s in allAuthors)
                    {
                        oneAuthor.Clear();
                        oneAuthor.AddRange(s.Trim().Split(' '));
                        if (fauth != String.Empty) fauth += ", ";
                        else fauth = " / ";
                        oneAuthor.Add(oneAuthor[0]);
                        oneAuthor.RemoveAt(0);
                        fauth += String.Join(" ", oneAuthor);
                    }
                    if (fauth[fauth.Length - 1] != '.') fauth += ".";
                }
                else
                {
                    oneAuthor.Add(oneAuthor[0]);
                    oneAuthor.RemoveAt(0);
                    fauth = " / " + String.Join(" ", oneAuthor) + "и др.";
                }
            }
            else
            {
                fauth = ".";
            }
            return String.Format("{0}{1}{2} - {3}, {4}. - {5} с.", mauth, Title, fauth, Publisher, Year, Pages);
        }

        public override string ToString()
        {
            return Format();
        }
    }
}
