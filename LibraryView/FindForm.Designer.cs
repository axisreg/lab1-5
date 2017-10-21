namespace LibraryView
{
	partial class FindForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._titleRadioButton = new System.Windows.Forms.RadioButton();
			this._yearRadioButton = new System.Windows.Forms.RadioButton();
			this._findTextBox = new System.Windows.Forms.TextBox();
			this._regexCheckBox = new System.Windows.Forms.CheckBox();
			this._resultListBox = new System.Windows.Forms.ListBox();
			this._okButton = new System.Windows.Forms.Button();
			this._findButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _titleRadioButton
			// 
			this._titleRadioButton.AutoSize = true;
			this._titleRadioButton.Checked = true;
			this._titleRadioButton.Location = new System.Drawing.Point(125, 12);
			this._titleRadioButton.Name = "_titleRadioButton";
			this._titleRadioButton.Size = new System.Drawing.Size(92, 17);
			this._titleRadioButton.TabIndex = 0;
			this._titleRadioButton.TabStop = true;
			this._titleRadioButton.Text = "По названию";
			this._titleRadioButton.UseVisualStyleBackColor = true;
			// 
			// _yearRadioButton
			// 
			this._yearRadioButton.AutoSize = true;
			this._yearRadioButton.Location = new System.Drawing.Point(223, 12);
			this._yearRadioButton.Name = "_yearRadioButton";
			this._yearRadioButton.Size = new System.Drawing.Size(109, 17);
			this._yearRadioButton.TabIndex = 1;
			this._yearRadioButton.Text = "По году издания";
			this._yearRadioButton.UseVisualStyleBackColor = true;
			// 
			// _findTextBox
			// 
			this._findTextBox.Location = new System.Drawing.Point(12, 40);
			this._findTextBox.Name = "_findTextBox";
			this._findTextBox.Size = new System.Drawing.Size(440, 20);
			this._findTextBox.TabIndex = 2;
			// 
			// _regexCheckBox
			// 
			this._regexCheckBox.AutoSize = true;
			this._regexCheckBox.Location = new System.Drawing.Point(12, 66);
			this._regexCheckBox.Name = "_regexCheckBox";
			this._regexCheckBox.Size = new System.Drawing.Size(223, 17);
			this._regexCheckBox.TabIndex = 3;
			this._regexCheckBox.Text = "Использовать регулярные выражения";
			this._regexCheckBox.UseVisualStyleBackColor = true;
			// 
			// _resultListBox
			// 
			this._resultListBox.FormattingEnabled = true;
			this._resultListBox.IntegralHeight = false;
			this._resultListBox.Location = new System.Drawing.Point(12, 89);
			this._resultListBox.Name = "_resultListBox";
			this._resultListBox.Size = new System.Drawing.Size(440, 216);
			this._resultListBox.TabIndex = 4;
			// 
			// _okButton
			// 
			this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._okButton.Location = new System.Drawing.Point(236, 311);
			this._okButton.Name = "_okButton";
			this._okButton.Size = new System.Drawing.Size(75, 23);
			this._okButton.TabIndex = 6;
			this._okButton.Text = "OK";
			this._okButton.UseVisualStyleBackColor = true;
			// 
			// _findButton
			// 
			this._findButton.Location = new System.Drawing.Point(142, 311);
			this._findButton.Name = "_findButton";
			this._findButton.Size = new System.Drawing.Size(75, 23);
			this._findButton.TabIndex = 5;
			this._findButton.Text = "Искать";
			this._findButton.UseVisualStyleBackColor = true;
			this._findButton.Click += new System.EventHandler(this.FindButtonClick);
			// 
			// FindForm
			// 
			this.AcceptButton = this._findButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 344);
			this.Controls.Add(this._findButton);
			this.Controls.Add(this._okButton);
			this.Controls.Add(this._resultListBox);
			this.Controls.Add(this._regexCheckBox);
			this.Controls.Add(this._findTextBox);
			this.Controls.Add(this._yearRadioButton);
			this.Controls.Add(this._titleRadioButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FindForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Поиск изданий";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton _titleRadioButton;
		private System.Windows.Forms.RadioButton _yearRadioButton;
		private System.Windows.Forms.TextBox _findTextBox;
		private System.Windows.Forms.CheckBox _regexCheckBox;
		private System.Windows.Forms.ListBox _resultListBox;
		private System.Windows.Forms.Button _okButton;
		private System.Windows.Forms.Button _findButton;
	}
}