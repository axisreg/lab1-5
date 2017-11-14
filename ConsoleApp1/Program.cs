using LibraryModel;
using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        private static Book CreateBook() {
            Book book = new Book();
            Console.WriteLine("Введите заглавие книги:");
            book.Title = Console.ReadLine();
            Console.WriteLine("Введите год издания книги:");
            book.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество страниц книги:");
            book.Pages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите список авторов книги (через запятую):");
            book.Authors = Console.ReadLine();
            Console.WriteLine("Введите издательство книги:");
            book.Publisher = Console.ReadLine();
            return book;
        }


        private static Magazine CreateMagazine() {
            Magazine magazine = new Magazine();
            Console.WriteLine("Введите заглавие журнала:");
            magazine.Title = Console.ReadLine();
            Console.WriteLine("Введите год издания журнала:");
            magazine.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество страниц журнала:");
            magazine.Pages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер журнала:");
            magazine.Number = Convert.ToInt32(Console.ReadLine());
            return magazine;
        }

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
                System.Console.WriteLine("Во время выполнения программы возникла ошибка: " + ex.Message);
            }

            System.Console.WriteLine("Нажмите 'Ввод' для выхода.");
            System.Console.ReadLine();

        }
    }
}
