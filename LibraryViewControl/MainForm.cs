using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.IO;
using LibraryModel;

namespace LibraryViewControl
{
	/// <summary>
	/// Главная форма приложения
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Список публикаций
		/// </summary>
		private List<LibraryCard> _libraryCards;
		
		/// <summary>
		/// Конструктор формы
		/// </summary>
		public MainForm()
		{
			_libraryCards = new List<LibraryCard>();
			InitializeComponent();
            _libraryCardControl.ReadOnly = true;
            _openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
			_saveFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
		}

		/// <summary>
		/// Обновление списка публикаций
		/// </summary>
		private void UpdateList()
		{
			_dataListView.BeginUpdate();
			_dataListView.Items.Clear();
			foreach (LibraryCard card in _libraryCards)
			{
				_dataListView.Items.Add(new ListViewItem(new string[] { card.Title, card.Year.ToString(), card.Pages.ToString(), card.ToString() }));
			}
			_dataListView.EndUpdate();
            UpdateCardControl();
        }

		/// <summary>
		/// Реакция на нажатие кнопки "Добавить"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void AddButtonClick(object sender, EventArgs e)
		{
			AddForm form = new AddForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				_libraryCards.Add(form.Card);
				UpdateList();
				_dataListView.EnsureVisible(_libraryCards.Count - 1);
			}
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Удалить"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void DelButtonClick(object sender, EventArgs e)
		{
			int index = _dataListView.SelectedIndices.Count <= 0 ? -1 : _dataListView.SelectedIndices[0];
			if (index >= 0 && MessageBox.Show(this, "Вы действительно хотите удалить эту запись?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				_libraryCards.RemoveAt(index);
                UpdateList();
			}
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Изменить"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void ModifyButtonClick(object sender, EventArgs e)
		{
			int index = _dataListView.SelectedIndices.Count <= 0 ? -1 : _dataListView.SelectedIndices[0];
			if (index >= 0)
			{
				ModifyForm form = new ModifyForm(_libraryCards[index]);
				if (form.ShowDialog() == DialogResult.OK)
				{
					UpdateList();
					_dataListView.EnsureVisible(_libraryCards.Count - 1);
                    _dataListView.Focus();
                    _dataListView.Items[index].Selected = true;
                }
			}
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Найти"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void FindButtonClick(object sender, EventArgs e)
		{
			FindForm form = new FindForm(_libraryCards);
			form.ShowDialog();
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Загрузить"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void LoadButtonClick(object sender, EventArgs e)
		{
			if (_openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (FileStream fs = new FileStream(_openFileDialog.FileName, FileMode.Open))
					{
						BinaryFormatter bf = new BinaryFormatter();
						_libraryCards = (List<LibraryCard>) bf.Deserialize(fs);
						UpdateList();
					}
				}
				catch
				{
					MessageBox.Show(this, "Ошибка чтения данных из файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					UpdateList();
				}
			}
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Сохранить"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void SaveButtonClick(object sender, EventArgs e)
		{
			if(_saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fs = new FileStream(_saveFileDialog.FileName, FileMode.Create))
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(fs, _libraryCards);
				}
			}
		}

        /// <summary>
        /// Обновить данные в контрольной карточке
        /// </summary>
        private void UpdateCardControl()
        {
            var index = _dataListView.SelectedIndices.Count <= 0 ? -1 : _dataListView.SelectedIndices[0];
            if (index >= 0)
            {
                _libraryCardControl.Card = _libraryCards[index];
            }
            else
            {
                _libraryCardControl.Card = null;
            }
        }

        /// <summary>
		/// Реакция на выбор издания в списке
		/// </summary>
		/// <param name="sender">Ссылка на список</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void DataListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCardControl();
        }
    }
}
