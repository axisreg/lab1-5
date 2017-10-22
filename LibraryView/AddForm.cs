using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using LibraryModel;

namespace LibraryView
{
	/// <summary>
	/// Форма для добавления новой карточки издания
	/// </summary>
	public partial class AddForm : Form
	{
		/// <summary>
		/// Флаг ошибки
		/// </summary>
		private bool _error;

		/// <summary>
		/// Ссылка на добавленную карточку
		/// </summary>
		public Publication Publication { get; private set; }

		/// <summary>
		/// Конструктор формы
		/// </summary>
		public AddForm()
		{
			InitializeComponent();
#if DEBUG
			_randomButton.Show();
#endif
		}

		/// <summary>
		/// Реакция на отображение формы
		/// </summary>
		/// <param name="sender">Ссылка на форму</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void AddFormShown(object sender, EventArgs e)
		{
			_bookRadioButton.Checked = true;
		}

		/// <summary>
		/// Реакция на выбор селектора "Книга"
		/// </summary>
		/// <param name="sender">Ссылка на селектор</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void BookRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			Publication = new Book();
			_numberPanel.Hide();
			_authorsPanel.Show();
			_publishingPanel.Show();
		}

		/// <summary>
		/// Реакция на выбор селектора "Журнал"
		/// </summary>
		/// <param name="sender">Ссылка на селектор</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void MagazineRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			Publication = new Magazine();
			_numberPanel.Show();
			_authorsPanel.Hide();
			_publishingPanel.Hide();
		}

        private void ShowErrorAndCancelEvent(string message, CancelEventArgs e)
        {
            _error = true;
            MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (e != null) e.Cancel = true;
        }

		/// <summary>
		/// Реакция изменение текста в поле "Авторы"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void AuthorsTextBoxValidating(object sender, CancelEventArgs e)
		{
            try
            {
                ((Book)Publication).Authors = _authorsTextBox.Text;
            }
            catch (NullReferenceException ex)
            {
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

		/// <summary>
		/// Реакция изменение текста в поле "Название"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void TitleTextBoxValidating(object sender, CancelEventArgs e)
		{
            try
            {
                Publication.Title = _titleTextBox.Text;
            }
            catch (NullReferenceException ex)
            {
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

		/// <summary>
		/// Реакция изменение текста в поле "Издательство"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void PublishingTextBoxValidating(object sender, CancelEventArgs e)
		{
            try
            {
                ((Book)Publication).Publisher = _publishingTextBox.Text;
            }
            catch (NullReferenceException ex)
            {
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

		/// <summary>
		/// Реакция изменение текста в поле "Год издания"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void YearTextBoxValidating(object sender, CancelEventArgs e)
		{
            try
            {
                Publication.Year = int.Parse(_yearTextBox.Text);
            }
            catch (FormatException ex) {
                ShowErrorAndCancelEvent("Год издания должен быть целым числом", e);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

		/// <summary>
		/// Реакция изменение текста в поле "Номер"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void NumberTextBoxValidating(object sender, CancelEventArgs e)
		{
            try
            {
                ((Magazine)Publication).Number = int.Parse(_numberTextBox.Text);
            }
            catch (FormatException ex)
            {
                ShowErrorAndCancelEvent("Номер издания должен быть целым числом", e);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

		/// <summary>
		/// Реакция изменение текста в поле "Страниц"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void PagesTextBoxValidating(object sender, CancelEventArgs e)
		{
            try
            {
                Publication.Pages = int.Parse(_pagesTextBox.Text);
            }
            catch (FormatException ex)
            {
                ShowErrorAndCancelEvent("Количество страниц должно быть целым числом", e);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

		/// <summary>
		/// Реакция на нажатие кнопки "Ok"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void OkButtonClick(object sender, EventArgs e)
		{
			_error = false;
			if (_bookRadioButton.Checked) AuthorsTextBoxValidating(_authorsTextBox, null);
			if (!_error) TitleTextBoxValidating(_titleTextBox, null);
			if (_bookRadioButton.Checked && !_error) PublishingTextBoxValidating(_publishingTextBox, null);
			if (!_error) YearTextBoxValidating(_yearTextBox, null);
			if (_magazineRadioButton.Checked && !_error) NumberTextBoxValidating(_numberTextBox, null);
			if (!_error) PagesTextBoxValidating(_pagesTextBox, null);
			if (!_error) DialogResult = DialogResult.OK;
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
				string authors = String.Format("{0} {1}.", families[random.Next(families.Length)], initials[random.Next(initials.Length)]);
				if (random.Next(2) == 1) authors += initials[random.Next(initials.Length)] + ".";
				if (random.Next(5) == 1)
				{
					authors += String.Format(", {0} {1}.", families[random.Next(families.Length)], initials[random.Next(initials.Length)]);
					if (random.Next(2) == 1) authors += initials[random.Next(initials.Length)] + ".";
				}
				_authorsTextBox.Text = authors;
				_titleTextBox.Text = books[random.Next(books.Length)];
				_publishingTextBox.Text = publishes[random.Next(publishes.Length)];
				_bookRadioButton.Checked = true;
			}
			else
			{
				_titleTextBox.Text = magazines[random.Next(magazines.Length)];
				_numberTextBox.Text = random.Next(1, 13).ToString();
				_magazineRadioButton.Checked = true;
			}
			_yearTextBox.Text = random.Next(1990, DateTime.Now.Year + 1).ToString();
			_pagesTextBox.Text = random.Next(100, 501).ToString();
		}
	}
}
