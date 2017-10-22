﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using LibraryModel;

namespace LibraryViewControl
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
            _libraryCardControl.Card = card;
            _libraryCardControl.ReadOnly = false;
            _libraryCardControl.CanToggle = false;
        }


        public void ModifyFormShown(object sender, EventArgs e) {
            

        }

        /// <summary>
        /// Реакция на нажатие кнопки "Ok"
        /// </summary>
        /// <param name="sender">Ссылка на кнопку</param>
        /// <param name="e">Ссылка на аргументы события</param>
        private void OkButtonClick(object sender, EventArgs e)
		{
			if (!_error) DialogResult = DialogResult.OK;
		}
	}
}
