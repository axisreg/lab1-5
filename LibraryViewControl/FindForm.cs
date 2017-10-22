using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibraryModel;

namespace LibraryViewControl
{
	/// <summary>
	/// Форма для поиска карточек изданий
	/// </summary>
	public partial class FindForm : Form
	{
		/// <summary>
		/// Список изданий
		/// </summary>
		private List<Publication> _publicationList;

		/// <summary>
		/// Конструктор формы
		/// </summary>
		/// <param name="list">Список карточек изданий, в котором будет осуществляться поиск</param>
		public FindForm(List<Publication> list)
		{
			_publicationList = list;
			InitializeComponent();
		}

		/// <summary>
		/// Проверка совпадения условий поиска
		/// </summary>
		/// <param name="publication">Ссылка на издание</param>
		/// <param name="info">Строка для поиска</param>
		private void Check(Publication publication, string info)
		{
			if (_regexCheckBox.Checked)
			{
				Regex regex = new Regex(_findTextBox.Text, RegexOptions.IgnoreCase);
				if (regex.Match(info).Success) _resultListBox.Items.Add(publication);
			}
			else
			{
				if (info.ToLower().Contains(_findTextBox.Text.ToLower())) _resultListBox.Items.Add(publication);
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
			foreach (Publication publication in _publicationList)
			{
				Check(publication, _titleRadioButton.Checked ? publication.Title : publication.Year.ToString());
			}
		}
	}
}
