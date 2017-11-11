using LibraryModel;
using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
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
                        System.Console.WriteLine("Создается карточка книги");
                        card = new Book();
                        System.Console.WriteLine("Введите заглавие книги:");
                        card.Title = Console.ReadLine();
                        System.Console.WriteLine("Введите год издания книги:");
                        card.Year = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Введите количество страниц книги:");
                        card.Pages = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Введите список авторов книги (через запятую):");
                        ((Book)card).Authors = Console.ReadLine();
                        System.Console.WriteLine("Введите издательство книги:");
                        ((Book)card).Publisher = Console.ReadLine();
                        break;
                    case 2:
                        System.Console.WriteLine("Создается карточка журнала");
                        card = new Magazine();
                        System.Console.WriteLine("Введите заглавие журнала:");
                        card.Title = Console.ReadLine();
                        System.Console.WriteLine("Введите год издания журнала:");
                        card.Year = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Введите количество страниц журнала:");
                        card.Pages = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Введите номер журнала:");
                        ((Magazine)card).Number = Convert.ToInt32(Console.ReadLine());
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
