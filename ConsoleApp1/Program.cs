using LibraryModel;
using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Выполнять действие до тех пор, пока операция не пройдет успешно
        /// </summary>
        /// <param name="message">Сообщение, предваряющее операцию.</param>
        /// <param name="action">Выполняемое действие.</param>
        private static void RepeatUntilValid(string message, Action action)
        {
            bool invalid = true;
            do
            {
                Console.WriteLine(message);
                try
                {
                    action();
                    invalid = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.WriteLine("Пожалуйста, повторите ввод еще раз");
                }
            } while (invalid);
            
        }

        /// <summary>
        /// Интерактивное создание карточки книги.
        /// </summary>
        private static Book CreateBook() {
            Book book = new Book();
            RepeatUntilValid(
                "Введите заглавие книги:",
                () => 
                {
                    book.Title = Console.ReadLine();
                });
            RepeatUntilValid(
                "Введите год издания книги:",
                () => 
                {
                    book.Year = Convert.ToInt32(Console.ReadLine());
                });
            RepeatUntilValid(
                "Введите количество страниц книги:",
                () => 
                {
                    book.Pages = Convert.ToInt32(Console.ReadLine());
                });
            RepeatUntilValid(
                "Введите список авторов книги:",
                () => 
                {
                    book.Authors = Console.ReadLine();
                });
            RepeatUntilValid(
                 "Введите издательство книги:",
                 () =>
                 {
                     book.Publisher = Console.ReadLine();
                 });            
            return book;
        }

        /// <summary>
        /// Процесс интерактивного создания карточки журнала.
        /// </summary>
        private static Magazine CreateMagazine() {
            Magazine magazine = new Magazine();
            RepeatUntilValid(
                 "Введите заглавие журнала:",
                 () =>
                 {
                     magazine.Title = Console.ReadLine();
                 });
            RepeatUntilValid(
                  "Введите год издания журнала:",
                  () =>
                  {
                      magazine.Year = Convert.ToInt32(Console.ReadLine());
                  });
            RepeatUntilValid(
                  "Введите количество страниц журнала:",
                  () =>
                  {
                      magazine.Pages = Convert.ToInt32(Console.ReadLine());
                  });
            RepeatUntilValid(
                  "Введите номер журнала:",
                  () =>
                  {
                      magazine.Number = Convert.ToInt32(Console.ReadLine());
                  });
            return magazine;
        }


        /// <summary>
        /// Главная точка входа для консольного приложения.
        /// </summary>
        static void Main(string[] args)
        {
            System.Console.WriteLine("Задание библиотечной карточки:");
            System.Console.WriteLine("Введите цифру для создания карточки определенного типа:");
            System.Console.WriteLine("1) Книга");
            System.Console.WriteLine("2) Журнал");
            try
            {
                int cardType = Convert.ToInt32(System.Console.ReadLine());
                LibraryCard card;
                switch (cardType)
                {
                    case 1:
                        Console.WriteLine("Создается карточка книги");
                        card = CreateBook();
                        break;
                    case 2:
                        Console.WriteLine("Создается карточка журнала");
                        card = CreateMagazine();
                        break;
                    default:
                        throw new ArgumentException("Неизвестный тип библиотечной карточки");
               }
                Console.WriteLine("Форматирование карточки по ГОСТ:");
                Console.WriteLine(card.Format());
            }
            catch (Exception ex) {
                System.Console.WriteLine("Во время выполнения программы возникла непредвиденная ошибка: " + ex.Message);
            }

            System.Console.WriteLine("Нажмите 'Ввод' для выхода.");
            System.Console.ReadLine();

        }
    }
}
