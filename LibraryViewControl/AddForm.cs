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
            bool valid = _libraryCardControl.Check();
            if (valid)
            {
                Card = _libraryCardControl.Card;
                DialogResult = DialogResult.OK;
            }
            
		}

		/// <summary>
		/// Реакция на нажатие кнопки "Random"
		/// </summary>
		/// <param name="sender">Ссылка на кнопку</param>
		/// <param name="e">Ссылка на аргументы события</param>
		private void RandomButtonClick(object sender, EventArgs e)
		{

            _libraryCardControl.Random();
        }
	}
}
