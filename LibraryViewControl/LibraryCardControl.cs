using System;
using System.ComponentModel;
using System.Windows.Forms;
using LibraryModel;

namespace LibraryViewControl
{
    public partial class LibraryCardControl : UserControl
    {
        /// <summary>
        /// Флаг ошибки
        /// </summary>
        private bool _error;

        /// <summary>
        /// Ссылка на редактируемое издание
        /// </summary>
        private LibraryCard _card;

        /// <summary>
        /// Флаг доступа только на чтение
        /// </summary>
        private bool _readOnly;

        /// <summary>
        /// Флаг доступа к переключателю типа издания
        /// </summary>
        private bool _canToggle;

        public LibraryCard Card
        {
            get
            {
                return _card;
            }
            set
            {
                if (value != null)
                {
                    _card = value;
                    if (value is Book) SetValue((Book)value);
                    if (value is Magazine) SetValue((Magazine)value);
                }
                else {
                    _titleTextBox.Text = "";
                    _yearTextBox.Text = "";
                    _pagesTextBox.Text = "";
                    _numberTextBox.Text = "";
                    _authorsTextBox.Text = "";
                    _publishingTextBox.Text = "";
                }
                
            }
        }

        public LibraryCardControl()
        {
            InitializeComponent();
            _bookRadioButton.Checked = true;

            Card = new Book();
            BookRadioButtonCheckedChanged(null, EventArgs.Empty);
            ReadOnly = true;
            CanToggle = true;
        }


        /// <summary>
        /// Заполнение полей книги
        /// </summary>
        private void SetValue(Book book)
        {
            _bookRadioButton.Enabled = true;
            _bookRadioButton.Checked = true;
            if (_readOnly || !_canToggle) _magazineRadioButton.Enabled = false;

            _titleTextBox.Text = book.Title;
            _yearTextBox.Text = book.Year.ToString();
            _pagesTextBox.Text = book.Pages.ToString();
            if (book.Authors != null)
                _authorsTextBox.Text = book.Authors.ToString();
            if (book.Publisher != null)
                _publishingTextBox.Text = book.Publisher.ToString();
        }

        /// <summary>
        /// Заполнение полей журнала
        /// </summary>
        private void SetValue(Magazine magazine)
        {
            _magazineRadioButton.Enabled = true;
            _magazineRadioButton.Checked = true;
            if (_readOnly || !_canToggle) _bookRadioButton.Enabled = false;

            _titleTextBox.Text = magazine.Title;
            _yearTextBox.Text = magazine.Year.ToString();
            _pagesTextBox.Text = magazine.Pages.ToString();
            _numberTextBox.Text = magazine.Number.ToString();

        }

        /// <summary>
        /// Свойство, определяющее, можно ли изменить тип издания
        /// </summary>
        public bool CanToggle
        {
            get
            {
                return _canToggle;
            }
            set
            {
                _canToggle = value;
                _bookRadioButton.Enabled = _bookRadioButton.Checked || value;
                _magazineRadioButton.Enabled = _magazineRadioButton.Checked || value;
            }
        }

        /// <summary>
        /// Свойство, определяющее, доступна ли карточка только для чтения
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                _bookRadioButton.Enabled = _bookRadioButton.Checked || !value;
                _magazineRadioButton.Enabled = _magazineRadioButton.Checked || !value;
                _authorsTextBox.Enabled = !value;
                _titleTextBox.Enabled = !value;
                _authorsTextBox.Enabled = !value;
                _publishingTextBox.Enabled = !value;
                _yearTextBox.Enabled = !value;
                _numberTextBox.Enabled = !value;
                _pagesTextBox.Enabled = !value;
            }
        }


        /// <summary>
        /// Реакция на отображение формы
        /// </summary>
        /// <param name="sender">Ссылка на форму</param>
        /// <param name="e">Ссылка на аргументы события</param>
        private void LibraryCardFormShown(object sender, EventArgs e)
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
            if (_bookRadioButton.Checked)
            {
                Card = new Book();
                _numberPanel.Hide();
                _authorsPanel.Show();
                _publishingPanel.Show();

            }
              
        }

        /// <summary>
        /// Реакция на выбор селектора "Журнал"
        /// </summary>
        /// <param name="sender">Ссылка на селектор</param>
        /// <param name="e">Ссылка на аргументы события</param>
        private void MagazineRadioButtonCheckedChanged(object sender, EventArgs e)
        {

            if (_magazineRadioButton.Checked)
            {
                Card = new Magazine();
                _numberPanel.Show();
                _authorsPanel.Hide();
                _publishingPanel.Hide();
            }
                
        }

        private void ShowErrorAndCancelEvent(string message, CancelEventArgs e)
        {
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
                if (Card is Book)
                    ((Book)Card).Authors = _authorsTextBox.Text;
            }
            catch (NullReferenceException ex)
            {
                _error = true;
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
                Card.Title = _titleTextBox.Text;
            }
            catch (NullReferenceException ex)
            {
                _error = true;
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
                if (Card is Book)
                    ((Book)Card).Publisher = _publishingTextBox.Text;
            }
            catch (NullReferenceException ex)
            {
                _error = true;
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
                Card.Year = int.Parse(_yearTextBox.Text);
            }
            catch (FormatException)
            {
                _error = true;
                ShowErrorAndCancelEvent("Год издания должен быть целым числом", e);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _error = true;
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
                if (Card is Magazine)
                    ((Magazine)Card).Number = int.Parse(_numberTextBox.Text);
            }
            catch (FormatException)
            {
                _error = true;
                ShowErrorAndCancelEvent("Номер издания должен быть целым числом", e);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _error = true;
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
                Card.Pages = int.Parse(_pagesTextBox.Text);
            }
            catch (FormatException)
            {
                _error = true;
                ShowErrorAndCancelEvent("Количество страниц должно быть целым числом", e);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _error = true;
                ShowErrorAndCancelEvent(ex.Message, e);
            }
        }

        /// <summary>
        /// Случайная генерация данных издания
        /// </summary>
        public void Random()
        {
            string[] families = { "Иванов", "Петров", "Сидоров", "Кнут", "Пушкин", "Лермонтов", "Симпсон", "Бальзак", "Шекспир", "Гюго", "Достоевский", "Маршак" };
            string[] ios = { "А", "Б", "В", "Г", "Д", "Дж", "Е", "И", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "Ф", "Э", "Ю", "Я" };
            string[] books = { "Мастер и Маргарита", "Война и мир", "Преступление и наказание", "Братья Карамазовы", "Анна Каренина", "Идиот", "Мёртвые души", "Отверженные", "Евгений Онегин", "Собачье сердце", "Герой нашего времени", "Бесы", "Три товарища", "Отцы и дети", "Граф Монте-Кристо", "Двенадцать стульев", "Тарас Бульба", "Воскресение", "Рассказы", "Капитанская дочка", "Горе от ума", "Приключения Шерлока Холмса", "Старик и море", "451 градус по Фаренгейту", "Игрок", "По ком звонит колокол", "Триумфальная арка", "Палата №6", "Обломов", "Маленький принц", "Ревизор", "Вечера на хуторе близ Диканьки", "Униженные и оскорблённые", "Ромео и Джульетта", "Белая гвардия", "Собор Парижской Богоматери", "Тихий Дон", "Бедные люди", "Дубровский", "Сто лет одиночества", "Фауст", "Золотой телёнок", "Хаджи-Мурат", "Солярис", "Детство. Отрочество. Юность", "На западном фронте без перемен", "Петербургские повести", "Записки охотника", "Гамлет", "Пикник на обочине", "Пётр Первый", "Робинзон Крузо", "А зори здесь тихие", "Человек-амфибия", "Остров сокровищ", "Два капитана", "Белый Клык", "Три мушкетера", "Похождения бравого солдата Швейка во время мировой войны", "Американская трагедия", "Село Степанчиково и его обитатели", "Подросток", "Трудно быть богом", "Собака Баскервилей", "Записки из подполья", "Пролетая над гнездом кукушки", "Шинель", "Казаки", "Приключения Тома Сойера", "Хитроумный идальго Дон Кихот Ламанчский", "Великий Гэтсби", "Принц и нищий", "Отец Сергий", "Записки из Мёртвого дома", "Черный обелиск", "Прощай, оружие!", "Мартин Иден", "Унесённые ветром", "Севастопольские рассказы", "Дворянское гнездо", "Алые паруса", "Кавказский пленник", "Таинственный остров", "Драма на охоте", "О дивный новый мир", "Приключения Оливера Твиста", "Дети капитана Гранта", "Вишневый сад", "Бесприданница", "Судьба человека", "Белые ночи", "Левша", "Джейн Эйр", "Нос", "Руслан и Людмила", "Приключения Гекльберри Финна", "Портрет Дориана Грея" };
            string[] magazines = { "Информатика и образование", "Известия ТУСУР", "Вокруг света", "Авторевю", "Вестник полей", "Химия и жизнь", "Физика атома", "Мода" };
            string[] publishes = { "Мир", "Высшая школа", "Наука", "Питер", "Радио и связь", "Академия", "ТУСУР", "Известия", "Вильямс", "Наука и техника", "Просвещение", "Олимп", "ЭКСМО" };

            var random = new Random();
            if (random.Next(2) == 1)
            {
                var book = new Book();
                var a = String.Format("{0} {1}.", families[random.Next(families.Length)], ios[random.Next(ios.Length)]);
                if (random.Next(2) == 1) a += ios[random.Next(ios.Length)] + ".";
                if (random.Next(5) == 1)
                {
                    a += String.Format(", {0} {1}.", families[random.Next(families.Length)], ios[random.Next(ios.Length)]);
                    if (random.Next(2) == 1) a += ios[random.Next(ios.Length)] + ".";
                }
                book.Authors = a;
                book.Title = books[random.Next(books.Length)];
                book.Publisher = publishes[random.Next(publishes.Length)];
                book.Year = random.Next(1990, DateTime.Now.Year + 1);
                book.Pages = random.Next(100, 501);
                Card = book;
            }
            else
            {
                var magazine = new Magazine
                {
                    Title = magazines[random.Next(magazines.Length)],
                    Number = random.Next(1, 13),
                    Year = random.Next(1990, DateTime.Now.Year + 1),
                    Pages = random.Next(100, 501)
                };
                Card = magazine;
            }
        }

        /// <summary>
        /// Проверка корректности введенных данных
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            _error = false;
            if (_bookRadioButton.Checked) AuthorsTextBoxValidating(_authorsTextBox, null);
            if (!_error) TitleTextBoxValidating(_titleTextBox, null);
            if (_bookRadioButton.Checked && !_error) PublishingTextBoxValidating(_publishingTextBox, null);
            if (!_error) YearTextBoxValidating(_yearTextBox, null);
            if (_magazineRadioButton.Checked && !_error) NumberTextBoxValidating(_numberTextBox, null);
            if (!_error) PagesTextBoxValidating(_pagesTextBox, null);
            return !_error;
        }
    }
}
