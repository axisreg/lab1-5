using System;
using System.ComponentModel;
using System.Windows.Forms;
using LibraryModel;

namespace LibraryView
{
	/// <summary>
	/// Форма для редактирования карточки издания
	/// </summary>
	public partial class ModifyForm : Form
	{
		private bool _error;

		/// <summary>
		/// Ссылка на редактируемую карточку
		/// </summary>
		public LibraryCard Card { get; private set; }

		/// <summary>
		/// Конструктор формы
		/// </summary>
		/// <param name="card">Карточка издания для редактирования</param>
		public ModifyForm(LibraryCard card)
		{
			InitializeComponent();
			Card = card;
			_titleTextBox.Text = card.Title;
			_yearTextBox.Text = card.Year.ToString();
			_pagesTextBox.Text = card.Pages.ToString();
			if (card is Book)
			{
				_bookRadioButton.Checked = true;
				_magazineRadioButton.Enabled = false;
				_authorsTextBox.Text = ((Book)card).Authors;
				_publishingTextBox.Text = ((Book)card).Publisher;
			}
			else
			{
				_magazineRadioButton.Checked = true;
				_bookRadioButton.Enabled = false;
				_numberTextBox.Text = ((Magazine)card).Number.ToString();
			}
		}

		/// <summary>
		/// Реакция на отображение формы
		/// </summary>
		/// <param name="sender">Ссылка на форму</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void ModifyFormShown(object sender, EventArgs e)
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
			_numberPanel.Show();
			_authorsPanel.Hide();
			_publishingPanel.Hide();
		}

        /// <summary>
        /// Реакция на введение ошибочных данных
        /// </summary>
        /// <param name="message">Ссылка на сообщение об ошибке</param>
        /// <param name="e">Ссылка на аргументы события</param>
        private void ShowErrorAndCancelEvent(string message, CancelEventArgs e) {
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
                ((Book)Card).Authors = _authorsTextBox.Text;
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
                Card.Title = _titleTextBox.Text;
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
                ((Book)Card).Publisher = _publishingTextBox.Text;
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
                Card.Year = int.Parse(_yearTextBox.Text);
            }
            catch (FormatException)
            {
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
                ((Magazine)Card).Number = int.Parse(_numberTextBox.Text);
            }
            catch (FormatException)
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
                Card.Pages = int.Parse(_pagesTextBox.Text);
            }
            catch (FormatException) {
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
	}
}
