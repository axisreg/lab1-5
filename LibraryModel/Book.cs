using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    /// <summary>
    /// Класс, описывающий библиотечную карточку книги
    /// </summary>
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
                if (value == null)
                {
                    throw new NullReferenceException("Список авторов не может быть пустым!");
                }
                _authors = value;
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
        public override string format()
        {
            string mauth = String.Empty;
            string fauth = String.Empty;
            if (!String.IsNullOrWhiteSpace(_authors))
            {
                List<string> all = new List<string>(_authors.Split(','));
                List<string> one = new List<string>(all[0].Trim().Split(' '));
                if (all.Count <= 3)
                {
                    if (one.Count > 1) one[0] += ",";
                    mauth = String.Join(" ", one);
                    if (mauth[mauth.Length - 1] != '.') mauth += ".";
                    mauth += " ";
                    foreach (string s in all)
                    {
                        one.Clear();
                        one.AddRange(s.Trim().Split(' '));
                        if (fauth != String.Empty) fauth += ", ";
                        else fauth = " / ";
                        one.Add(one[0]);
                        one.RemoveAt(0);
                        fauth += String.Join(" ", one);
                    }
                    if (fauth[fauth.Length - 1] != '.') fauth += ".";
                }
                else
                {
                    one.Add(one[0]);
                    one.RemoveAt(0);
                    fauth = " / " + String.Join(" ", one) + "и др.";
                }
            }
            else
            {
                fauth = ".";
            }
            return String.Format("{0}{1}{2} - {3}, {4}. - {5} с.", mauth, _title, fauth, _publisher, _year, _pages);
        }

        public override string ToString()
        {
            return format();
        }
    }
}
