using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using LibraryModel;

namespace LibraryViewControl
{
	/// <summary>
	/// Форма для добавления новой карточки издания
	/// </summary>
	public partial class AddForm : Form
	{
		/// <summary>
		/// Ссылка на добавленную карточку
		/// </summary>
		public LibraryCard Card { get; private set; }

		/// <summary>
		/// Конструктор формы
		/// </summary>
		public AddForm()
		{
			InitializeComponent();
            _libraryCardControl.Card = Card;
            _libraryCardControl.ReadOnly = false;
            _libraryCardControl.CanToggle = true;
#if DEBUG
            _randomButton.Show();
#endif
		}

		

		/// <summary>
		/// Реакция на нажатие кнопки "Ok"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void OkButtonClick(object sender, EventArgs e)
		{
            Card = _libraryCardControl.Card;
            DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Random"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void RandomButtonClick(object sender, EventArgs e)
		{
			string[] families = { "Иванов", "Петров", "Сидоров", "Кнут", "Пушкин", "Лермонтов", "Симпсон", "Бальзак", "Шекспир", "Гюго", "Достоевский", "Маршак" };
			string[] initials = { "А", "Б", "В", "Г", "Д", "Дж", "Е", "И", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "Ф", "Э", "Ю", "Я" };
			string[] books = { "Мастер и Маргарита", "Война и мир", "Преступление и наказание", "Братья Карамазовы", "Анна Каренина", "Идиот", "Мёртвые души", "Отверженные", "Евгений Онегин", "Собачье сердце", "Герой нашего времени", "Бесы", "Три товарища", "Отцы и дети", "Граф Монте-Кристо", "Двенадцать стульев", "Тарас Бульба", "Воскресение", "Рассказы", "Капитанская дочка", "Горе от ума", "Приключения Шерлока Холмса", "Старик и море", "451 градус по Фаренгейту", "Игрок", "По ком звонит колокол", "Триумфальная арка", "Палата №6", "Обломов", "Маленький принц", "Ревизор", "Вечера на хуторе близ Диканьки", "Униженные и оскорблённые", "Ромео и Джульетта", "Белая гвардия", "Собор Парижской Богоматери", "Тихий Дон", "Бедные люди", "Дубровский", "Сто лет одиночества", "Фауст", "Золотой телёнок", "Хаджи-Мурат", "Солярис", "Детство. Отрочество. Юность", "На западном фронте без перемен", "Петербургские повести", "Записки охотника", "Гамлет", "Пикник на обочине", "Пётр Первый", "Робинзон Крузо", "А зори здесь тихие", "Человек-амфибия", "Остров сокровищ", "Два капитана", "Белый Клык", "Три мушкетера", "Похождения бравого солдата Швейка во время мировой войны", "Американская трагедия", "Село Степанчиково и его обитатели", "Подросток", "Трудно быть богом", "Собака Баскервилей", "Записки из подполья", "Пролетая над гнездом кукушки", "Шинель", "Казаки", "Приключения Тома Сойера", "Хитроумный идальго Дон Кихот Ламанчский", "Великий Гэтсби", "Принц и нищий", "Отец Сергий", "Записки из Мёртвого дома", "Черный обелиск", "Прощай, оружие!", "Мартин Иден", "Унесённые ветром", "Севастопольские рассказы", "Дворянское гнездо", "Алые паруса", "Кавказский пленник", "Таинственный остров", "Драма на охоте", "О дивный новый мир", "Приключения Оливера Твиста", "Дети капитана Гранта", "Вишневый сад", "Бесприданница", "Судьба человека", "Белые ночи", "Левша", "Джейн Эйр", "Нос", "Руслан и Людмила", "Приключения Гекльберри Финна", "Портрет Дориана Грея" };
			string[] magazines = { "Информатика и образование", "Известия ТУСУР", "Вокруг света", "Авторевю", "Вестник полей", "Химия и жизнь", "Физика атома", "Мода" };
			string[] publishes = { "Мир", "Высшая школа", "Наука", "Питер", "Радио и связь", "Академия", "ТУСУР", "Известия", "Вильямс", "Наука и техника", "Просвещение", "Олимп", "ЭКСМО" };
			Random random = new Random();
			if(random.Next(2) == 1)
			{
				string randomAuthors = String.Format("{0} {1}.", families[random.Next(families.Length)], initials[random.Next(initials.Length)]);
				if (random.Next(2) == 1) randomAuthors += initials[random.Next(initials.Length)] + ".";
				if (random.Next(5) == 1)
				{
                    randomAuthors += String.Format(", {0} {1}.", families[random.Next(families.Length)], initials[random.Next(initials.Length)]);
					if (random.Next(2) == 1) randomAuthors += initials[random.Next(initials.Length)] + ".";
				}
                string randomTitle = books[random.Next(books.Length)];
                string randomPublisher = publishes[random.Next(publishes.Length)];
                int randomYear = random.Next(1990, DateTime.Now.Year + 1);
                int randomPages = random.Next(100, 501);

                _libraryCardControl.Card = new Book(randomTitle, randomYear, randomPages, randomAuthors, randomPublisher );
			}
			else
			{
                string randomTitle = books[random.Next(books.Length)];
                int randomYear = random.Next(1990, DateTime.Now.Year + 1);
                int randomPages = random.Next(100, 501);
				int randomNumber = random.Next(1, 13);

                _libraryCardControl.Card = new Magazine(randomTitle, randomYear, randomPages, randomNumber);

            }
        }
	}
}
