using System;
using System.Windows.Forms;
using LibraryModel;

namespace LibraryViewControl
{
	/// <summary>
	/// Форма для редактирования карточки издания
	/// </summary>
	/// <inheritdoc cref="Form"/>
	public partial class ModifyForm : Form
	{
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
            _libraryCardControl.Card = card;
            _libraryCardControl.ReadOnly = false;
            _libraryCardControl.CanToggle = false;
        }

        /// <summary>
		/// Реакция на отображение формы
		/// </summary>
		/// <param name="sender">Ссылка на форму</param>
		/// <param name="e">Ссылка на аргументы события</param>
        private void ModifyFormShown(object sender, EventArgs e) {
        }

        /// <summary>
        /// Реакция на нажатие кнопки "Ok"
        /// </summary>
        /// <param name="sender">Ссылка на кнопку</param>
        /// <param name="e">Ссылка на аргументы события</param>
        private void OkButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}
