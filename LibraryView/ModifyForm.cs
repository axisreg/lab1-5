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
		public Publication Publication { get; private set; }

		/// <summary>
		/// Конструктор формы
		/// </summary>
		/// <param name="publication">Карточка издания для редактирования</param>
		public ModifyForm(Publication publication)
		{
			InitializeComponent();
			Publication = publication;
			_titleTextBox.Text = publication.Title;
			_yearTextBox.Text = publication.Year.ToString();
			_pagesTextBox.Text = publication.Pages.ToString();
			if (publication is Book)
			{
				_bookRadioButton.Checked = true;
				_magazineRadioButton.Enabled = false;
				_authorsTextBox.Text = ((Book)publication).Authors;
				_publishingTextBox.Text = ((Book)publication).Publisher;
			}
			else
			{
				_magazineRadioButton.Checked = true;
				_bookRadioButton.Enabled = false;
				_numberTextBox.Text = ((Magazine)publication).Number.ToString();
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
			//SetStrProperty("Authors", _authorsTextBox.Text, e);
		}

		/// <summary>
		/// Реакция изменение текста в поле "Название"
		/// </summary>
		/// <param name="sender">Ссылка на поле</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void TitleTextBoxValidating(object sender, CancelEventArgs e)
		{
            //SetStrProperty("Title", _titleTextBox.Text, e);
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
            //SetStrProperty("Publishing", _publishingTextBox.Text, e);
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
            //SetIntProperty("Year", _yearTextBox.Text, e);
            try
            {
                Publication.Year = int.Parse(_yearTextBox.Text);
            }
            catch (FormatException ex)
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
            //SetIntProperty("Number", _numberTextBox.Text, e);
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
            //SetIntProperty("Pages", _pagesTextBox.Text, e);
            try
            {
                Publication.Pages = int.Parse(_pagesTextBox.Text);
            }
            catch (FormatException ex) {
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
