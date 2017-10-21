namespace LibraryView
{
	partial class MainForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this._dataGroupBox = new System.Windows.Forms.GroupBox();
			this._dataListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._addButton = new System.Windows.Forms.Button();
			this._delButton = new System.Windows.Forms.Button();
			this._findButton = new System.Windows.Forms.Button();
			this._loadButton = new System.Windows.Forms.Button();
			this._saveButton = new System.Windows.Forms.Button();
			this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this._modifyButton = new System.Windows.Forms.Button();
			this._dataGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// _dataGroupBox
			// 
			this._dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._dataGroupBox.Controls.Add(this._dataListView);
			this._dataGroupBox.Location = new System.Drawing.Point(12, 12);
			this._dataGroupBox.Name = "_dataGroupBox";
			this._dataGroupBox.Size = new System.Drawing.Size(687, 282);
			this._dataGroupBox.TabIndex = 0;
			this._dataGroupBox.TabStop = false;
			this._dataGroupBox.Text = "Список изданий";
			// 
			// _dataListView
			// 
			this._dataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this._dataListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._dataListView.FullRowSelect = true;
			this._dataListView.GridLines = true;
			this._dataListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this._dataListView.Location = new System.Drawing.Point(3, 16);
			this._dataListView.MultiSelect = false;
			this._dataListView.Name = "_dataListView";
			this._dataListView.Size = new System.Drawing.Size(681, 263);
			this._dataListView.TabIndex = 0;
			this._dataListView.UseCompatibleStateImageBehavior = false;
			this._dataListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Название";
			this.columnHeader1.Width = 234;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Год издания";
			this.columnHeader2.Width = 77;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Страницы";
			this.columnHeader3.Width = 67;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Полная информация";
			this.columnHeader4.Width = 277;
			// 
			// _addButton
			// 
			this._addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._addButton.Location = new System.Drawing.Point(115, 300);
			this._addButton.Name = "_addButton";
			this._addButton.Size = new System.Drawing.Size(75, 23);
			this._addButton.TabIndex = 1;
			this._addButton.Text = "Добавить";
			this._addButton.UseVisualStyleBackColor = true;
			this._addButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// _delButton
			// 
			this._delButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._delButton.Location = new System.Drawing.Point(196, 300);
			this._delButton.Name = "_delButton";
			this._delButton.Size = new System.Drawing.Size(75, 23);
			this._delButton.TabIndex = 2;
			this._delButton.Text = "Удалить";
			this._delButton.UseVisualStyleBackColor = true;
			this._delButton.Click += new System.EventHandler(this.DelButtonClick);
			// 
			// _findButton
			// 
			this._findButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._findButton.Location = new System.Drawing.Point(358, 300);
			this._findButton.Name = "_findButton";
			this._findButton.Size = new System.Drawing.Size(75, 23);
			this._findButton.TabIndex = 4;
			this._findButton.Text = "Найти";
			this._findButton.UseVisualStyleBackColor = true;
			this._findButton.Click += new System.EventHandler(this.FindButtonClick);
			// 
			// _loadButton
			// 
			this._loadButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._loadButton.Location = new System.Drawing.Point(439, 300);
			this._loadButton.Name = "_loadButton";
			this._loadButton.Size = new System.Drawing.Size(75, 23);
			this._loadButton.TabIndex = 5;
			this._loadButton.Text = "Загрузить";
			this._loadButton.UseVisualStyleBackColor = true;
			this._loadButton.Click += new System.EventHandler(this.LoadButtonClick);
			// 
			// _saveButton
			// 
			this._saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._saveButton.Location = new System.Drawing.Point(520, 300);
			this._saveButton.Name = "_saveButton";
			this._saveButton.Size = new System.Drawing.Size(75, 23);
			this._saveButton.TabIndex = 6;
			this._saveButton.Text = "Сохранить";
			this._saveButton.UseVisualStyleBackColor = true;
			this._saveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// _openFileDialog
			// 
			this._openFileDialog.DefaultExt = "libs";
			this._openFileDialog.Filter = "Library Files|*.libs";
			this._openFileDialog.Title = "Выберите файл для загрузки";
			// 
			// _saveFileDialog
			// 
			this._saveFileDialog.DefaultExt = "libs";
			this._saveFileDialog.Filter = "Library Files|*.libs";
			this._saveFileDialog.Title = "Укажите имя файла";
			// 
			// _modifyButton
			// 
			this._modifyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._modifyButton.Location = new System.Drawing.Point(277, 300);
			this._modifyButton.Name = "_modifyButton";
			this._modifyButton.Size = new System.Drawing.Size(75, 23);
			this._modifyButton.TabIndex = 3;
			this._modifyButton.Text = "Изменить";
			this._modifyButton.UseVisualStyleBackColor = true;
			this._modifyButton.Click += new System.EventHandler(this.ModifyButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(711, 332);
			this.Controls.Add(this._modifyButton);
			this.Controls.Add(this._saveButton);
			this.Controls.Add(this._loadButton);
			this.Controls.Add(this._findButton);
			this.Controls.Add(this._delButton);
			this.Controls.Add(this._addButton);
			this.Controls.Add(this._dataGroupBox);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(727, 370);
			this.Name = "MainForm";
			this.Text = "Система библиотечных карточек";
			this._dataGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _dataGroupBox;
		private System.Windows.Forms.ListView _dataListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button _addButton;
		private System.Windows.Forms.Button _delButton;
		private System.Windows.Forms.Button _findButton;
		private System.Windows.Forms.Button _loadButton;
		private System.Windows.Forms.Button _saveButton;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.SaveFileDialog _saveFileDialog;
		private System.Windows.Forms.Button _modifyButton;
	}
}

