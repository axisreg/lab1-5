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
            List<Publication> pubs = new List<Publication>()
            {
                new Magazine("Прогнило чёто в", 1800, 20, 4),
                new Book("В датском королевстве", 1992, 400, "Е. Розцекранц, И. Гильденстерн", "Дача inc")
            };

            foreach (Publication pub in pubs) {
                System.Console.WriteLine(pub);
            }
            System.Console.ReadLine();

        }
    }
}
