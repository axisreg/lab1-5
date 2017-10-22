using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibraryModel;

namespace LibraryView
{
	/// <summary>
	/// Форма для поиска карточек изданий
	/// </summary>
	public partial class FindForm : Form
	{
		/// <summary>
		/// Список изданий
		/// </summary>
		private List<LibraryCard> _libraryCards;

		/// <summary>
		/// Конструктор формы
		/// </summary>
		/// <param name="list">Список карточек изданий, в котором будет осуществляться поиск</param>
		public FindForm(List<LibraryCard> list)
		{
			_libraryCards = list;
			InitializeComponent();
		}

		/// <summary>
		/// Проверка совпадения условий поиска
		/// </summary>
		/// <param name="card">Ссылка на издание</param>
		/// <param name="info">Строка для поиска</param>
		private void Check(LibraryCard card, string info)
		{
			if (_regexCheckBox.Checked)
			{
				Regex regex = new Regex(_findTextBox.Text, RegexOptions.IgnoreCase);
				if (regex.Match(info).Success) _resultListBox.Items.Add(card);
			}
			else
			{
				if (info.ToLower().Contains(_findTextBox.Text.ToLower())) _resultListBox.Items.Add(card);
			}
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Искать"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void FindButtonClick(object sender, EventArgs e)
		{
			_resultListBox.Items.Clear();
			foreach (LibraryCard card in _libraryCards)
			{
				Check(card, _titleRadioButton.Checked ? card.Title : card.Year.ToString());
			}
		}
	}
}
