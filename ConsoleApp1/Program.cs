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
            List<LibraryCard> cards = new List<LibraryCard>()
            {
                new Magazine("Прогнило чёто в", 1800, 20, 4),
                new Book("В датском королевстве", 1992, 400, "Е. Розцекранц, И. Гильденстерн", "Дача inc")
            };

            foreach (LibraryCard pub in cards) {
                System.Console.WriteLine(pub);
            }
            System.Console.ReadLine();

        }
    }
}
