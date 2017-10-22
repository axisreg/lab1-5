namespace LibraryViewControl
{
    partial class LibraryCardControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._typePanel = new System.Windows.Forms.Panel();
            this._magazineRadioButton = new System.Windows.Forms.RadioButton();
            this._bookRadioButton = new System.Windows.Forms.RadioButton();
            this._pagesPanel = new System.Windows.Forms.Panel();
            this._pagesTextBox = new System.Windows.Forms.TextBox();
            this._pagesLabel = new System.Windows.Forms.Label();
            this._numberPanel = new System.Windows.Forms.Panel();
            this._numberTextBox = new System.Windows.Forms.TextBox();
            this._numberLabel = new System.Windows.Forms.Label();
            this._yearPanel = new System.Windows.Forms.Panel();
            this._yearTextBox = new System.Windows.Forms.TextBox();
            this._yearLabel = new System.Windows.Forms.Label();
            this._publishingPanel = new System.Windows.Forms.Panel();
            this._publishingTextBox = new System.Windows.Forms.TextBox();
            this._publishingLabel = new System.Windows.Forms.Label();
            this._titlePanel = new System.Windows.Forms.Panel();
            this._titleTextBox = new System.Windows.Forms.TextBox();
            this._titleLabel = new System.Windows.Forms.Label();
            this._authorsPanel = new System.Windows.Forms.Panel();
            this._authorsTextBox = new System.Windows.Forms.TextBox();
            this._authorsLabel = new System.Windows.Forms.Label();
            this._typePanel.SuspendLayout();
            this._pagesPanel.SuspendLayout();
            this._numberPanel.SuspendLayout();
            this._yearPanel.SuspendLayout();
            this._publishingPanel.SuspendLayout();
            this._titlePanel.SuspendLayout();
            this._authorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _typePanel
            // 
            this._typePanel.Controls.Add(this._magazineRadioButton);
            this._typePanel.Controls.Add(this._bookRadioButton);
            this._typePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._typePanel.Location = new System.Drawing.Point(0, 0);
            this._typePanel.Name = "_typePanel";
            this._typePanel.Size = new System.Drawing.Size(450, 41);
            this._typePanel.TabIndex = 8;
            // 
            // _magazineRadioButton
            // 
            this._magazineRadioButton.AutoSize = true;
            this._magazineRadioButton.Location = new System.Drawing.Point(253, 12);
            this._magazineRadioButton.Name = "_magazineRadioButton";
            this._magazineRadioButton.Size = new System.Drawing.Size(65, 17);
            this._magazineRadioButton.TabIndex = 1;
            this._magazineRadioButton.Text = "Журнал";
            this._magazineRadioButton.UseVisualStyleBackColor = true;
            this._magazineRadioButton.CheckedChanged += new System.EventHandler(this.MagazineRadioButtonCheckedChanged);
            // 
            // _bookRadioButton
            // 
            this._bookRadioButton.AutoSize = true;
            this._bookRadioButton.Checked = true;
            this._bookRadioButton.Location = new System.Drawing.Point(128, 12);
            this._bookRadioButton.Name = "_bookRadioButton";
            this._bookRadioButton.Size = new System.Drawing.Size(55, 17);
            this._bookRadioButton.TabIndex = 0;
            this._bookRadioButton.TabStop = true;
            this._bookRadioButton.Text = "Книга";
            this._bookRadioButton.UseVisualStyleBackColor = true;
            this._bookRadioButton.CheckedChanged += new System.EventHandler(this.BookRadioButtonCheckedChanged);
            // 
            // _pagesPanel
            // 
            this._pagesPanel.Controls.Add(this._pagesTextBox);
            this._pagesPanel.Controls.Add(this._pagesLabel);
            this._pagesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._pagesPanel.Location = new System.Drawing.Point(0, 211);
            this._pagesPanel.Name = "_pagesPanel";
            this._pagesPanel.Size = new System.Drawing.Size(450, 34);
            this._pagesPanel.TabIndex = 19;
            // 
            // _pagesTextBox
            // 
            this._pagesTextBox.Location = new System.Drawing.Point(97, 6);
            this._pagesTextBox.Name = "_pagesTextBox";
            this._pagesTextBox.Size = new System.Drawing.Size(56, 20);
            this._pagesTextBox.TabIndex = 1;
            this._pagesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PagesTextBoxValidating);
            // 
            // _pagesLabel
            // 
            this._pagesLabel.AutoSize = true;
            this._pagesLabel.Location = new System.Drawing.Point(12, 9);
            this._pagesLabel.Name = "_pagesLabel";
            this._pagesLabel.Size = new System.Drawing.Size(49, 13);
            this._pagesLabel.TabIndex = 0;
            this._pagesLabel.Text = "Страниц";
            // 
            // _numberPanel
            // 
            this._numberPanel.Controls.Add(this._numberTextBox);
            this._numberPanel.Controls.Add(this._numberLabel);
            this._numberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._numberPanel.Location = new System.Drawing.Point(0, 177);
            this._numberPanel.Name = "_numberPanel";
            this._numberPanel.Size = new System.Drawing.Size(450, 34);
            this._numberPanel.TabIndex = 18;
            this._numberPanel.Visible = false;
            // 
            // _numberTextBox
            // 
            this._numberTextBox.Location = new System.Drawing.Point(97, 6);
            this._numberTextBox.Name = "_numberTextBox";
            this._numberTextBox.Size = new System.Drawing.Size(56, 20);
            this._numberTextBox.TabIndex = 1;
            this._numberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NumberTextBoxValidating);
            // 
            // _numberLabel
            // 
            this._numberLabel.AutoSize = true;
            this._numberLabel.Location = new System.Drawing.Point(12, 9);
            this._numberLabel.Name = "_numberLabel";
            this._numberLabel.Size = new System.Drawing.Size(41, 13);
            this._numberLabel.TabIndex = 0;
            this._numberLabel.Text = "Номер";
            // 
            // _yearPanel
            // 
            this._yearPanel.Controls.Add(this._yearTextBox);
            this._yearPanel.Controls.Add(this._yearLabel);
            this._yearPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._yearPanel.Location = new System.Drawing.Point(0, 143);
            this._yearPanel.Name = "_yearPanel";
            this._yearPanel.Size = new System.Drawing.Size(450, 34);
            this._yearPanel.TabIndex = 17;
            // 
            // _yearTextBox
            // 
            this._yearTextBox.Location = new System.Drawing.Point(97, 6);
            this._yearTextBox.Name = "_yearTextBox";
            this._yearTextBox.Size = new System.Drawing.Size(56, 20);
            this._yearTextBox.TabIndex = 1;
            this._yearTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.YearTextBoxValidating);
            // 
            // _yearLabel
            // 
            this._yearLabel.AutoSize = true;
            this._yearLabel.Location = new System.Drawing.Point(12, 9);
            this._yearLabel.Name = "_yearLabel";
            this._yearLabel.Size = new System.Drawing.Size(70, 13);
            this._yearLabel.TabIndex = 0;
            this._yearLabel.Text = "Год издания";
            // 
            // _publishingPanel
            // 
            this._publishingPanel.Controls.Add(this._publishingTextBox);
            this._publishingPanel.Controls.Add(this._publishingLabel);
            this._publishingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._publishingPanel.Location = new System.Drawing.Point(0, 109);
            this._publishingPanel.Name = "_publishingPanel";
            this._publishingPanel.Size = new System.Drawing.Size(450, 34);
            this._publishingPanel.TabIndex = 16;
            this._publishingPanel.Visible = false;
            // 
            // _publishingTextBox
            // 
            this._publishingTextBox.Location = new System.Drawing.Point(97, 6);
            this._publishingTextBox.Name = "_publishingTextBox";
            this._publishingTextBox.Size = new System.Drawing.Size(340, 20);
            this._publishingTextBox.TabIndex = 1;
            this._publishingTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PublishingTextBoxValidating);
            // 
            // _publishingLabel
            // 
            this._publishingLabel.AutoSize = true;
            this._publishingLabel.Location = new System.Drawing.Point(12, 9);
            this._publishingLabel.Name = "_publishingLabel";
            this._publishingLabel.Size = new System.Drawing.Size(79, 13);
            this._publishingLabel.TabIndex = 0;
            this._publishingLabel.Text = "Издательство";
            // 
            // _titlePanel
            // 
            this._titlePanel.Controls.Add(this._titleTextBox);
            this._titlePanel.Controls.Add(this._titleLabel);
            this._titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._titlePanel.Location = new System.Drawing.Point(0, 75);
            this._titlePanel.Name = "_titlePanel";
            this._titlePanel.Size = new System.Drawing.Size(450, 34);
            this._titlePanel.TabIndex = 15;
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Location = new System.Drawing.Point(97, 6);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.Size = new System.Drawing.Size(340, 20);
            this._titleTextBox.TabIndex = 1;
            this._titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TitleTextBoxValidating);
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Location = new System.Drawing.Point(12, 9);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(57, 13);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = "Название";
            // 
            // _authorsPanel
            // 
            this._authorsPanel.Controls.Add(this._authorsTextBox);
            this._authorsPanel.Controls.Add(this._authorsLabel);
            this._authorsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._authorsPanel.Location = new System.Drawing.Point(0, 41);
            this._authorsPanel.Name = "_authorsPanel";
            this._authorsPanel.Size = new System.Drawing.Size(450, 34);
            this._authorsPanel.TabIndex = 14;
            this._authorsPanel.Visible = false;
            // 
            // _authorsTextBox
            // 
            this._authorsTextBox.Location = new System.Drawing.Point(97, 6);
            this._authorsTextBox.Name = "_authorsTextBox";
            this._authorsTextBox.Size = new System.Drawing.Size(340, 20);
            this._authorsTextBox.TabIndex = 1;
            this._authorsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AuthorsTextBoxValidating);
            // 
            // _authorsLabel
            // 
            this._authorsLabel.AutoSize = true;
            this._authorsLabel.Location = new System.Drawing.Point(12, 9);
            this._authorsLabel.Name = "_authorsLabel";
            this._authorsLabel.Size = new System.Drawing.Size(45, 13);
            this._authorsLabel.TabIndex = 0;
            this._authorsLabel.Text = "Авторы";
            // 
            // LibraryCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pagesPanel);
            this.Controls.Add(this._numberPanel);
            this.Controls.Add(this._yearPanel);
            this.Controls.Add(this._publishingPanel);
            this.Controls.Add(this._titlePanel);
            this.Controls.Add(this._authorsPanel);
            this.Controls.Add(this._typePanel);
            this.Name = "LibraryCardControl";
            this.Size = new System.Drawing.Size(450, 248);
            this._typePanel.ResumeLayout(false);
            this._typePanel.PerformLayout();
            this._pagesPanel.ResumeLayout(false);
            this._pagesPanel.PerformLayout();
            this._numberPanel.ResumeLayout(false);
            this._numberPanel.PerformLayout();
            this._yearPanel.ResumeLayout(false);
            this._yearPanel.PerformLayout();
            this._publishingPanel.ResumeLayout(false);
            this._publishingPanel.PerformLayout();
            this._titlePanel.ResumeLayout(false);
            this._titlePanel.PerformLayout();
            this._authorsPanel.ResumeLayout(false);
            this._authorsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _typePanel;
        private System.Windows.Forms.RadioButton _magazineRadioButton;
        private System.Windows.Forms.RadioButton _bookRadioButton;
        private System.Windows.Forms.Panel _pagesPanel;
        private System.Windows.Forms.TextBox _pagesTextBox;
        private System.Windows.Forms.Label _pagesLabel;
        private System.Windows.Forms.Panel _numberPanel;
        private System.Windows.Forms.TextBox _numberTextBox;
        private System.Windows.Forms.Label _numberLabel;
        private System.Windows.Forms.Panel _yearPanel;
        private System.Windows.Forms.TextBox _yearTextBox;
        private System.Windows.Forms.Label _yearLabel;
        private System.Windows.Forms.Panel _publishingPanel;
        private System.Windows.Forms.TextBox _publishingTextBox;
        private System.Windows.Forms.Label _publishingLabel;
        private System.Windows.Forms.Panel _titlePanel;
        private System.Windows.Forms.TextBox _titleTextBox;
        private System.Windows.Forms.Label _titleLabel;
        private System.Windows.Forms.Panel _authorsPanel;
        private System.Windows.Forms.TextBox _authorsTextBox;
        private System.Windows.Forms.Label _authorsLabel;
    }
}
